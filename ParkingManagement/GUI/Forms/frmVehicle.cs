using MySql.Data.MySqlClient;
using ParkingManagement.BLL;
using ParkingManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingManagement.GUI.Forms
{
    public partial class frmVehicle: Form
    {
        public frmVehicle()
        {
            InitializeComponent();
            LoadAllAreas();
            LoadSlotNumber();
            LoadAllVehicle();
            LoadAllVehicleType();
            kDTPIn.Format = DateTimePickerFormat.Custom;
            kDTPIn.CustomFormat = "yyyy-MM-dd HH:mm:ss";

            kDTPOut.Format = DateTimePickerFormat.Custom;
            kDTPOut.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }

        private parkingAreaBLL parkingAreaBLL = new parkingAreaBLL();
        private vehicleBLL vehicleBLL = new vehicleBLL();
        private parkingSlotBLL parkingSlotBLL = new parkingSlotBLL();

        private string selectedVId;
        private void LoadAllAreas()
        {
            try
            {
                List<parkingAreaModel> areas = parkingAreaBLL.GetAllParkingAreas();

                kCbbArea.DataSource = areas;
                kCbbArea.DisplayMember = "AreaName";
                kCbbArea.ValueMember = "Id";
                kCbbArea.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách khu vực: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAllVehicleType()
        {
            try
            {
                List<VehicleType> vehicleTypes = vehicleBLL.GetAllVehicleType();

                kCbbTypeVehicle.DataSource = vehicleTypes;
                kCbbTypeVehicle.DisplayMember = "VehicleTypeName";
                kCbbTypeVehicle.ValueMember = "Id";
                kCbbTypeVehicle.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách loại xe: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSlotNumber()
        {
            kCbbSlot.Items.Clear();
            kCbbSlot.Items.Add("Số vị trí");
            kCbbSlot.Items.Add("1");
            kCbbSlot.Items.Add("2");
            kCbbSlot.Items.Add("3");
            kCbbSlot.Items.Add("4");
            kCbbSlot.Items.Add("5");
            kCbbSlot.Items.Add("6");
            kCbbSlot.Items.Add("7");
            kCbbSlot.Items.Add("8");
            kCbbSlot.Items.Add("9");
            kCbbSlot.Items.Add("10");
            kCbbSlot.SelectedIndex = 0;
        }

        private void LoadAvailableSlots(Guid areaId)
        {
            try
            {
                List<ParkingSlotModel> slots = parkingSlotBLL.GetSlotByArea(areaId);

                kCbbSlot.DataSource = null;
                kCbbSlot.Items.Clear();

                if (slots.Count == 0)
                {
                    MessageBox.Show("Không có vị trí đỗ nào sẵn sàng trong khu vực này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                kCbbSlot.DataSource = slots;
                kCbbSlot.DisplayMember = "SlotNumber";
                kCbbSlot.ValueMember = "Id"; 

                kCbbSlot.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách vị trí: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshForm()
        {
            selectedVId = null;

            kTbLicense_Plate.Text = "";

            kCbbTypeVehicle.SelectedIndex = -1;
            kCbbSlot.SelectedIndex = -1;
            kCbbArea.SelectedIndex = -1;

            kDTPIn.Value = DateTime.Now;
            kDTPOut.Value = DateTime.Now;
        }

        private void LoadAllVehicle()
        {
            try
            {
                List<allVehicle> vehicles = vehicleBLL.GetAllVehicle();

                if (vehicles == null || vehicles.Count == 0)
                {
                    MessageBox.Show("Không có xe nào trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                kDgvVehicle.DataSource = vehicles;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách xe: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kryptonPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonLabel3_Click(object sender, EventArgs e)
        {

        }

        private void kDgvVehicle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = kDgvVehicle.Rows[e.RowIndex];

                selectedVId = row.Cells["id"].Value?.ToString();

                kTbLicense_Plate.Text = row.Cells[1].Value?.ToString() ?? "";

                string vehicleTypeName = row.Cells[2].Value?.ToString();
                kCbbTypeVehicle.SelectedIndex = kCbbTypeVehicle.FindStringExact(vehicleTypeName);

                string parkingSlotName = row.Cells[3].Value?.ToString();
                kCbbSlot.SelectedIndex = kCbbSlot.FindStringExact(parkingSlotName);

                string areaName = row.Cells[4].Value?.ToString();
                kCbbArea.SelectedIndex = kCbbArea.FindStringExact(areaName);

                if (row.Cells[5].Value != null && row.Cells[5].Value != DBNull.Value)
                {
                    string entryTimeStr = row.Cells[5].Value.ToString().Trim();

                    if (DateTime.TryParse(entryTimeStr, out DateTime entryTime))
                    {
                        kDTPIn.Value = entryTime;
                    }
                    else
                    {
                        MessageBox.Show($"Lỗi chuyển đổi EntryTime: {entryTimeStr}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        kDTPIn.Value = DateTime.Now;
                    }
                }
                else
                {
                    kDTPIn.Value = DateTime.Now;
                }


                // Xử lý ExitTime
                if (row.Cells[6].Value != null && row.Cells[6].Value != DBNull.Value)
                {
                    string entryTimeStr = row.Cells[6].Value.ToString().Trim();

                    if (DateTime.TryParse(entryTimeStr, out DateTime entryTime))
                    {
                        kDTPOut.Value = entryTime;
                    }
                    else
                    {
                        MessageBox.Show($"Lỗi chuyển đổi 6: {entryTimeStr}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        kDTPOut.Value = DateTime.Now;
                    }
                }
                else
                {
                    kDTPOut.Value = DateTime.Now;
                }

            }
        }

        private void kBtnReset_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void kBtnCreateV_Click(object sender, EventArgs e)
        {
            if (!Guid.TryParse(kCbbArea.SelectedValue?.ToString(), out Guid parkingAreaId))
            {
                MessageBox.Show("ID khu vực không hợp lệ! Vui lòng nhập đúng định dạng GUID.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Guid.TryParse(kCbbSlot.SelectedValue?.ToString(), out Guid parkingSlotId))
            {
                MessageBox.Show("ID chỗ đỗ không hợp lệ! Vui lòng nhập đúng định dạng GUID.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Guid.TryParse(kCbbTypeVehicle.SelectedValue?.ToString(), out Guid vehicleTypeId))
            {
                MessageBox.Show("ID loại xe không hợp lệ! Vui lòng nhập đúng định dạng GUID.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string licensePlate = kTbLicense_Plate.Text.Trim();
            if (string.IsNullOrWhiteSpace(licensePlate))
            {
                MessageBox.Show("Biển số xe không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime now = DateTime.Now;

            VehicleModel vehicle = new VehicleModel(
                Guid.NewGuid(),
                licensePlate,
                vehicleTypeId,
                parkingSlotId,
                parkingAreaId,
                now,   
                null, 
                now,   
                now,  
                now   
            );

            try
            {
                vehicleBLL.CreateVehicle(vehicle);
                MessageBox.Show("Thêm phương tiện thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllVehicle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phương tiện: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmVehicle_Load(object sender, EventArgs e)
        {

        }

        private void kBtnFilter_Click(object sender, EventArgs e)
        {
            if (kCbbArea.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khu vực cần lọc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Guid selectedAreaId = Guid.Parse(kCbbArea.SelectedValue.ToString());
            LoadAvailableSlots(selectedAreaId);
        }

        private void kBtnUpdate_Click(object sender, EventArgs e)
        {
            if (!Guid.TryParse(kCbbArea.SelectedValue?.ToString(), out Guid parkingAreaId))
            {
                MessageBox.Show("ID khu vực không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Guid.TryParse(kCbbSlot.SelectedValue?.ToString(), out Guid parkingSlotId))
            {
                MessageBox.Show("ID chỗ đỗ không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Guid.TryParse(kCbbTypeVehicle.SelectedValue?.ToString(), out Guid vehicleTypeId))
            {
                MessageBox.Show("ID loại xe không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(selectedVId))
            {
                MessageBox.Show("Vui lòng chọn chỗ đỗ để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Guid.TryParse(selectedVId, out Guid vehcleId))
            {
                MessageBox.Show("ID chỗ đỗ không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string licensePlate = kTbLicense_Plate.Text.Trim();
            if (string.IsNullOrWhiteSpace(licensePlate))
            {
                MessageBox.Show("Biển số xe không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime now = DateTime.Now;

            VehicleModel vehicle = new VehicleModel(
                vehcleId,
                licensePlate,
                vehicleTypeId,
                parkingSlotId,
                parkingAreaId,
                now,
                null,
                now,
                now,
                now
            );

            try
            {
                vehicleBLL.UpdateVehicle(vehicle);
                LoadAllVehicle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật phương tiện: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kBtnDelete_Click(object sender, EventArgs e)
        {
                if (string.IsNullOrEmpty(selectedVId))
                {
                    MessageBox.Show("Vui lòng chọn chỗ đỗ để xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá chỗ đỗ này?", "Xác nhận xoá",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        vehicleBLL vehicleBLL = new vehicleBLL();
                        vehicleBLL.DeleteVehicle(selectedVId);

                        MessageBox.Show("Xoá chỗ đỗ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadAllVehicle();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xoá chỗ đỗ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        }
    }
}
