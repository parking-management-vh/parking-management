using Microsoft.Office.Interop.Excel;
using ParkingManagement.BLL;
using ParkingManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingManagement.GUI.Forms
{
    public partial class frmParkingSlot : Form
    {
        private parkingSlotBLL parkingSlotBLL = new parkingSlotBLL();

        public frmParkingSlot()
        {
            InitializeComponent();
            LoadAllAreas();
            LoadAllParkingSlots();
            LoadSearchAreas();
            LoadSlotTypeFilter();
            LoadStatusFilter();
        }

        private void LoadAllAreas()
        {
            try
            {
                parkingAreaBLL parkingAreaBLL = new parkingAreaBLL();
                List<parkingAreaModel> areas = parkingAreaBLL.GetAllParkingAreas();

                kCbbParkingarea.DataSource = areas;
                kCbbParkingarea.DisplayMember = "AreaName";
                kCbbParkingarea.ValueMember = "Id";
                kCbbParkingarea.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách khu vực: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSearchAreas()
        {
            try
            {
                parkingAreaBLL parkingAreaBLL = new parkingAreaBLL();
                List<parkingAreaModel> areas = parkingAreaBLL.GetAllParkingAreas();

                kCbbSArea.DataSource = null;
                kCbbSArea.Items.Clear();
                kCbbSArea.Items.Add("Tất cả");

                foreach (var area in areas)
                {
                    kCbbSArea.Items.Add(area.AreaName);
                }

                kCbbSArea.SelectedIndex = 0; // Mặc định chọn "Tất cả"
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách khu vực: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadAllParkingSlots()
        {
            try
            {
                List<allParkingSlot> areas = parkingSlotBLL.GetAllParkingSlots();

                if (areas == null || areas.Count == 0)
                {
                    MessageBox.Show("Không có khu vực nào trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                kDgvParkingSlot.DataSource = areas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách khu vực: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void kPnSlot_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmParkingSlot_Load(object sender, EventArgs e)
        {

        }

        private void kbtnCreate_Click(object sender, EventArgs e)
        {
            int slotNumber = int.Parse(kTbSlotnumber.Text.Trim());
            string slotType = kCbbSlottype.SelectedItem.ToString();
            string slotStatus = kCbbStatus.SelectedItem.ToString();
            if (!Guid.TryParse(kCbbParkingarea.SelectedValue.ToString(), out Guid parkingAreaId))
            {
                MessageBox.Show("ID khu vực không hợp lệ! Vui lòng nhập đúng định dạng GUID.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(slotType) || string.IsNullOrEmpty(slotStatus) || slotNumber <= 0)
            {
                MessageBox.Show("Không được để trống hoặc giá trị không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ParkingSlotModel newSlot = new ParkingSlotModel(Guid.NewGuid(), slotNumber, slotType, slotStatus, parkingAreaId);
            parkingSlotBLL.InsertParkingSlot(newSlot);

            MessageBox.Show("Thêm chỗ đỗ xe thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadAllParkingSlots();
        }

        private string selectedPLId;
        private void kDgvParkingSlot_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = kDgvParkingSlot.Rows[e.RowIndex];

                // Lấy ID của slot đã chọn
                selectedPLId = row.Cells["id"].Value?.ToString();

                // Đổ dữ liệu vào các trường tương ứng (kiểm tra null)
                kTbSlotnumber.Text = row.Cells[1].Value?.ToString() ?? "";

                kCbbSlottype.SelectedItem = row.Cells[2].Value?.ToString();

                kCbbStatus.SelectedItem = row.Cells[3].Value?.ToString();

                string areaName = row.Cells["AreaName"].Value.ToString();
                kCbbParkingarea.SelectedIndex = kCbbParkingarea.FindStringExact(areaName);
            }
        }

        private void kbtnDelete_Click(object sender, EventArgs e)
        {
                if (string.IsNullOrEmpty(selectedPLId))
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
                        parkingSlotBLL slotService = new parkingSlotBLL();
                        slotService.DeleteParkingSlot(selectedPLId);

                        MessageBox.Show("Xoá chỗ đỗ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadAllParkingSlots(); // Cập nhật danh sách sau khi xoá
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xoá chỗ đỗ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        }

        private void kbtnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedPLId))
            {
                MessageBox.Show("Vui lòng chọn chỗ đỗ để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Guid.TryParse(selectedPLId, out Guid slotId))
            {
                MessageBox.Show("ID chỗ đỗ không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int slotNumber;
            if (!int.TryParse(kTbSlotnumber.Text.Trim(), out slotNumber) || slotNumber <= 0)
            {
                MessageBox.Show("Số chỗ đỗ không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string slotType = kCbbSlottype.SelectedItem?.ToString() ?? "";
            string slotStatus = kCbbStatus.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrEmpty(slotType) || string.IsNullOrEmpty(slotStatus))
            {
                MessageBox.Show("Loại chỗ đỗ và trạng thái không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Guid.TryParse(kCbbParkingarea.SelectedValue?.ToString(), out Guid parkingAreaId))
            {
                MessageBox.Show("ID khu vực không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng cập nhật
            ParkingSlotModel updatedSlot = new ParkingSlotModel(slotId, slotNumber, slotType, slotStatus, parkingAreaId);
            parkingSlotBLL slotService = new parkingSlotBLL();

            try
            {
                slotService.UpdateParkingSlot(updatedSlot);
                MessageBox.Show("Cập nhật chỗ đỗ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllParkingSlots();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật chỗ đỗ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kbtnRefresh_Click(object sender, EventArgs e)
        {
            kTbSlotnumber.Text = "";
            kCbbSlottype.Text = "";
            kCbbStatus.Text = "";
            kCbbParkingarea.Text = "";
        }
        private void LoadSlotTypeFilter()
        {
            kCbbSSlotType.Items.Clear();
            kCbbSSlotType.Items.Add("Tất cả");
            kCbbSSlotType.Items.Add("Lớn");
            kCbbSSlotType.Items.Add("Vừa");
            kCbbSSlotType.Items.Add("Nhỏ");
            kCbbSSlotType.SelectedIndex = 0; 
        }

        private void LoadStatusFilter()
        {
            kCbbSStatus.Items.Clear();
            kCbbSStatus.Items.Add("Tất cả");
            kCbbSStatus.Items.Add("Sẵn sàng");
            kCbbSStatus.Items.Add("Đã có xe");
            kCbbSStatus.Items.Add("Sửa chữa");
            kCbbSStatus.SelectedIndex = 0;
        }

        private void kbtnSearch_Click(object sender, EventArgs e)
        {
            string selectedArea = kCbbSArea.SelectedItem?.ToString();
            string selectedStatus = kCbbSStatus.SelectedItem?.ToString();
            string selectedSlotType = kCbbSSlotType.SelectedItem?.ToString();

            string statusFilter = null;
            if (!string.IsNullOrEmpty(selectedStatus) && selectedStatus != "Tất cả")
            {
                statusFilter = selectedStatus;
            }
            string slotTypeFilter = !string.IsNullOrEmpty(selectedSlotType) && selectedSlotType != "Tất cả" ? selectedSlotType : null;

            parkingSlotBLL parkingSlotBLL = new parkingSlotBLL();
            List<allParkingSlot> slots = parkingSlotBLL.GetAllParkingSlots(selectedArea, statusFilter, slotTypeFilter);

            kDgvParkingSlot.DataSource = null; 
            kDgvParkingSlot.DataSource = slots; 
        }

        private void kCbbSArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
