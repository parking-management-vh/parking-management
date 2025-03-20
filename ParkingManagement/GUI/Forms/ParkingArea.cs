using ParkingManagement.BLL;
using ParkingManagement.Models;
using ParkingManagement.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ParkingManagement.GUI.Forms
{
    public partial class frmParkingArea : Form
    {
        private parkingAreaBLL parkingAreaBLL = new parkingAreaBLL();

        public frmParkingArea()
        {
            InitializeComponent();
            LoadAllAreas();
            LoadStatusFilter();
        }

        
        private void LoadAllAreas()
        {
            try
            {
                List<parkingAreaModel> areas = parkingAreaBLL.GetAllParkingAreas();

                if (areas == null || areas.Count == 0)
                {
                    MessageBox.Show("Không có khu vực nào trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                kBtnPArea.DataSource = areas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách khu vực: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ParkingArea_Load(object sender, EventArgs e)
        {

        }

        private void kbtnCreate_Click(object sender, EventArgs e)
        {
            string id = Guid.NewGuid().ToString();
            string areaName = kTbParkingArea.Text.Trim();
            string status = kCbbStatus.SelectedItem.ToString();
            string description = kTbDescription.Text.Trim();

            if (string.IsNullOrEmpty(areaName) && string.IsNullOrEmpty(status) && string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            parkingAreaModel newParkingArea = new parkingAreaModel( id, status,areaName , description);
            parkingAreaBLL parkingAreaService = new parkingAreaBLL();
            parkingAreaService.CreateParkingArea(newParkingArea);

            MessageBox.Show("Thêm vai trò thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadAllAreas();
        }

        private string selectedPAId;
        private void kbtnEdit_Click(object sender, EventArgs e)
        {
            if (selectedPAId == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn vai trò để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string areaName = kTbParkingArea.Text.Trim();
            string status = kCbbStatus.SelectedItem.ToString();
            string description = kTbDescription.Text.Trim();

            if (string.IsNullOrEmpty(areaName))
            {
                MessageBox.Show("Role Name không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            parkingAreaModel newPAA = new parkingAreaModel(status,  areaName, description, selectedPAId);
            parkingAreaBLL PAService = new parkingAreaBLL();
            PAService.UpdateParkingArea(newPAA);

            MessageBox.Show("Cập nhật khu vực thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadAllAreas();
        }
        
        private void kBtnPArea_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = kBtnPArea.Rows[e.RowIndex];

                selectedPAId =  row.Cells["id"].Value.ToString();

                if (row.Cells[1].Value != null)
                    kTbParkingArea.Text = row.Cells[1].Value.ToString();

                if (row.Cells[2].Value != null)
                    kCbbStatus.SelectedItem = row.Cells[2].Value.ToString();

                if (row.Cells[3].Value != null)
                    kTbDescription.Text = row.Cells[3].Value.ToString();
            }
        }

        private void kbtnDelete_Click(object sender, EventArgs e)
        {
            if (selectedPAId == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn vai trò để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá vai trò này?", "Xác nhận xoá",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                parkingAreaBLL PAService = new parkingAreaBLL();
                PAService.DeleteParkingArea(selectedPAId);

                MessageBox.Show("Xoá vai trò thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAllAreas();
            }
        }

        private void kbtnRefresh_Click(object sender, EventArgs e)
        {
            kTbParkingArea.Text = "";
            kTbDescription.Text = "";
            kCbbStatus.Text = "";
            LoadAllAreas();
        }
        private void LoadStatusFilter()
        {
            kCbbSStatus.Items.Clear();
            kCbbSStatus.Items.Add("Tất cả");
            kCbbSStatus.Items.Add("Đầy bãi");
            kCbbSStatus.Items.Add("Sửa chữa");
            kCbbSStatus.Items.Add("Còn chỗ");
            kCbbSStatus.SelectedIndex = 0;
        }
        private void kbtnSearch_Click(object sender, EventArgs e)
        {
            string selectedStatus = kCbbSStatus.SelectedItem?.ToString();

            string statusFilter = null;
            if (!string.IsNullOrEmpty(selectedStatus) && selectedStatus != "Tất cả")
            {
                statusFilter = selectedStatus;
            }
            parkingAreaBLL parkingAreaBLL = new parkingAreaBLL();
            List<parkingAreaModel> areas = parkingAreaBLL.GetAllParkingAreas( statusFilter);

            kBtnPArea.DataSource = areas;
        }

        private void kBtnPArea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kryptonGroupBox1_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kCbbStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
