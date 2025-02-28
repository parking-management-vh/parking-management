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

namespace ParkingManagement.GUI.Forms
{
    public partial class frmUsers: Form
    {
        private userBLL userBLL = new userBLL();
        private roleBLL roleBLL = new roleBLL();
        private parkingAreaBLL parkingAreaBLL = new parkingAreaBLL();
        private int currentPage = 1;
        private int pageSize = 10;
        private int totalPages = 1;

        public frmUsers()
        {
            InitializeComponent();
        }

        private void kLbCode_Click(object sender, EventArgs e)
        {

        }

        private void kTbCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void kLbArea_Click(object sender, EventArgs e)
        {

        }

        private void kTbArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void kTbAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void kLbAddress_Click(object sender, EventArgs e)
        {

        }

        private void kLbSearchArea_Click(object sender, EventArgs e)
        {

        }

        private void kBtnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadAllUsersData();
            }
        }

        private void kBtnLastPage_Click(object sender, EventArgs e)
        {
            currentPage = totalPages;
            LoadAllUsersData();
        }

        private void kPnUserInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            LoadAllUsersData();
            LoadAllRoleData();
            LoadAllAreas();
        }

        private void LoadAllUsersData(
            bool? status = null, 
            string roleName = null, 
            string areaName = null,
            string searchColumn = null, 
            string searchValue = null)
        {
            try
            {
                var (users, total) = userBLL.GetUsersByPage(currentPage, pageSize, status, roleName, areaName, searchColumn, searchValue);
                totalPages = total;
                kGrvUsers.DataSource = users;
                UpdatePaginationButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAllRoleData()
        {
            try
            {
                List<roleModel> roles = roleBLL.GetAllRoleAreas();
                kDgvRoleTable.DataSource = roles;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAllAreas()
        {
            try
            {
                parkingAreaBLL parkingAreaBLL = new parkingAreaBLL();
                List<parkingAreaModel> areas = parkingAreaBLL.GetAllParkingAreas();

                kCbbArea.Items.Clear();
                kCbbArea.Items.Add("Tất cả"); 

                foreach (var area in areas)
                {
                    kCbbArea.Items.Add(area.AreaName);
                }

                kCbbArea.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách khu vực: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UpdatePaginationButtons()
        {
            kBtnFirstPage.Enabled = currentPage > 1;
            kBtnPrevious.Enabled = currentPage > 1;
            kBtnNexPage.Enabled = currentPage < totalPages;
            kBtnLastPage.Enabled = currentPage < totalPages;
            kLbCountPage.Text = $"{currentPage} / {totalPages}";
        }

        private void kBtnFirstPage_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadAllUsersData();
        }

        private void kBtnNexPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadAllUsersData();
            }
        }

        private void kLbCountPage_Click(object sender, EventArgs e)
        {

        }

        private void kGrvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = kGrvUsers.Rows[e.RowIndex];

                kTbCode.Text = row.Cells["Code"].Value.ToString();
                kTbFullName.Text = row.Cells["FullName"].Value.ToString();
                kTbSex.Text = row.Cells["Gender"].Value.ToString();
                kDtpBirthday.Value = row.Cells["DateOfBirth"].Value != DBNull.Value
                                        ? Convert.ToDateTime(row.Cells["DateOfBirth"].Value)
                                        : DateTime.Now;
                kTbArea.Text = row.Cells["AreaName"].Value.ToString();
                kTbEmail.Text = row.Cells["Email"].Value.ToString();
                kTbPhone.Text = row.Cells["PhoneNumber"].Value.ToString();
                kTbAddress.Text = row.Cells["Address"].Value.ToString();
                kTbTypeAcount.Text = row.Cells["RoleName"].Value.ToString();
            }
        }

        private Guid selectedRoleId; 

        private void kDgvRoleTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = kDgvRoleTable.Rows[e.RowIndex];

                selectedRoleId = Guid.Parse(row.Cells["id"].Value.ToString());

                kTbNameRole.Text = row.Cells["RoleName"].Value?.ToString() ?? "";
                kTbDesRole.Text = row.Cells["Description"].Value?.ToString() ?? "";
            }
        }

        private void kPnOption_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kRBtnActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kRBtnInactive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kBtnSearch_Click(object sender, EventArgs e)
        {
            bool? status = null;
            string roleName = null;
            string areaName = kCbbArea.SelectedItem?.ToString();
            string searchValue = kTbContentSearch.Text.Trim();
            string searchColumn = null; 

            if (kRBtnActive.Checked)
            {
                status = true;
            }
            else if (kRBtnInactive.Checked)
            {
                status = false;
            }
            else if (kRbtnAllUser.Checked)
            {
                status = null;
            }

            if (kRbtnManager.Checked)
            {
                roleName = "Admin";
            }
            else if (kRBtnStaff.Checked)
            {
                roleName = "Manager";
            }
            else if (kRBtnCustomer.Checked)
            {
                roleName = "Customer";
            } 
            else if (kRBtnAllAcc.Checked)
            {
                roleName = null;
            }

            if (areaName == "Tất cả")
            {
                areaName = null;
            }
            switch (kCbbOptionSearch.SelectedItem?.ToString())
            {
                case "Họ và tên":
                    searchColumn = "full_name";
                    break;
                case "Mã người dùng":
                    searchColumn = "code";
                    break;
                case "Số điện thoại":
                    searchColumn = "phone_number";
                    break;
                case "Email":
                    searchColumn = "email";
                    break;
            }

            currentPage = 1;
            LoadAllUsersData(status, roleName, areaName, searchColumn, searchValue);
        }

        private void kCbbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            kBtnSearch_Click(sender, e);
        }

        private void kBtnAddRole_Click(object sender, EventArgs e)
        {
            string roleName = kTbNameRole.Text.Trim();
            string description = kTbDesRole.Text.Trim();

            if (string.IsNullOrEmpty(roleName))
            {
                MessageBox.Show("Role Name không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            roleModel newRole = new roleModel(Guid.NewGuid(), roleName, description);
            roleBLL roleService = new roleBLL();
            roleService.CreateRole(newRole);

            MessageBox.Show("Thêm vai trò thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadAllRoleData();
        }

        private void kBtnRoleSave_Click(object sender, EventArgs e)
        {
            if (selectedRoleId == Guid.Empty)
            {
                MessageBox.Show("Vui lòng chọn vai trò để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string roleName = kTbNameRole.Text.Trim();
            string description = kTbDesRole.Text.Trim();

            if (!ValidationUtils.IsValidText(roleName, allowNumbers: true, allowSpaces: true))
            {
                MessageBox.Show("Role Name không hợp lệ! Chỉ được chứa chữ cái, số và không có dấu cách thừa.",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidationUtils.IsValidText(description, allowNumbers: true, allowSpaces: true))
            {
                MessageBox.Show("Description không hợp lệ!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(roleName))
            {
                MessageBox.Show("Role Name không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            roleModel updatedRole = new roleModel(selectedRoleId, roleName, description);
            roleBLL roleService = new roleBLL();
            roleService.UpdateRole(updatedRole);

            MessageBox.Show("Cập nhật vai trò thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadAllRoleData();
        }

        private void kBtnDeleteRole_Click(object sender, EventArgs e)
        {
            if (selectedRoleId == Guid.Empty) 
            {
                MessageBox.Show("Vui lòng chọn vai trò để xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá vai trò này?", "Xác nhận xoá",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                roleBLL roleService = new roleBLL();
                roleService.DeleteRole(selectedRoleId);

                MessageBox.Show("Xoá vai trò thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAllRoleData(); 
                selectedRoleId = Guid.Empty;
            }

        }

        private void kRbtnAllUser_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
