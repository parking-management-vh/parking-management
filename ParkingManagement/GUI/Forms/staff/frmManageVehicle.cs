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

namespace ParkingManagement.GUI.Forms.staff
{
    public partial class frmManageVehicle : Form
    {
        private parkingAreaBLL parkingAreaBLL = new parkingAreaBLL();
        private vehicleBLL vehicleBLL = new vehicleBLL();
        private parkingSlotBLL parkingSlotBLL = new parkingSlotBLL();
        public frmManageVehicle()
        {
            InitializeComponent();
            loadAllVehicleByArea();
            LoadUserSession();
            LoadAllVehicleType();
            LoadAllVehicleTypeSearch();
            LoadSlotNumber();
            LoadSlotNumberSearch();
            kDTPIn.Format = DateTimePickerFormat.Custom;
            kDTPIn.CustomFormat = "yyyy-MM-dd HH:mm:ss";

            kDTPOut.Format = DateTimePickerFormat.Custom;
            kDTPOut.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }

        private Guid? selectedAreaId;

        private void LoadUserSession()
        {
            if (SessionManager.CurrentUser == null) return;

            selectedAreaId = SessionManager.CurrentUser.AreaId ?? Guid.Empty;
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

        private void LoadAllVehicleTypeSearch()
        {
            try
            {
                List<VehicleType> vehicleTypes = vehicleBLL.GetAllVehicleType();

                kCbbSTypeV.DataSource = vehicleTypes;
                kCbbSTypeV.DisplayMember = "VehicleTypeName";
                kCbbSTypeV.ValueMember = "Id";
                kCbbSTypeV.SelectedIndex = -1;
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

        private void LoadSlotNumberSearch()
        {
            kCbbSSlot.Items.Clear();
            kCbbSSlot.Items.Add("1");
            kCbbSSlot.Items.Add("2");
            kCbbSSlot.Items.Add("3");
            kCbbSSlot.Items.Add("4");
            kCbbSSlot.Items.Add("5");
            kCbbSSlot.Items.Add("6");
            kCbbSSlot.Items.Add("7");
            kCbbSSlot.Items.Add("8");
            kCbbSSlot.Items.Add("9");
            kCbbSSlot.Items.Add("10");
            kCbbSSlot.SelectedIndex = -1;
        }

        private void loadAllVehicleByArea()
        {
            string selectedArea = selectedAreaId?.ToString();
            string selectedSlot = null;
            string selectedVehicleType = null;
            string licensePlate = null;

            List<allVehicle> vehicle = vehicleBLL.GetAllVehicle(selectedArea, selectedSlot, selectedVehicleType, licensePlate);

            kDgvListVehicle.DataSource = null;
            kDgvListVehicle.DataSource = vehicle;
        }

        private void kBtnSearch_Click(object sender, EventArgs e)
        {
            string selectedArea = selectedAreaId?.ToString();
            string selectedSlot = kCbbSSlot.SelectedItem?.ToString();
            string selectedVehicleType = kCbbSTypeV.SelectedValue?.ToString();
            string licensePlate = kTbSBks.Text.Trim();

            List<allVehicle> vehicle = vehicleBLL.GetAllVehicle(selectedArea, selectedSlot, selectedVehicleType, licensePlate);

            kDgvListVehicle.DataSource = null;
            kDgvListVehicle.DataSource = vehicle;
        }

        private void kDgvListVehicle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = kDgvListVehicle.Rows[e.RowIndex];

                kTbLicense_Plate.Text = row.Cells[1].Value?.ToString() ?? "";

                string vehicleTypeName = row.Cells[2].Value?.ToString();
                kCbbTypeVehicle.SelectedIndex = kCbbTypeVehicle.FindStringExact(vehicleTypeName);

                string parkingSlotName = row.Cells[3].Value?.ToString();
                kCbbSlot.SelectedIndex = kCbbSlot.FindStringExact(parkingSlotName);

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

        private void frmManageVehicle_Load(object sender, EventArgs e)
        {

        }
    }
}
