using ParkingManagement.BLL;
using ParkingManagement.Models;
using System;
using System.Windows.Forms;
using ParkingManagement.DAL;

namespace ParkingManagement.GUI.Forms
{
    public partial class frmPaymentReceipt : Form
    {
        private readonly PaymentReceiptBLL paymentBLL = new PaymentReceiptBLL();

        public frmPaymentReceipt()
        {
            InitializeComponent();
            LoadData();
            txtReceiptID.ReadOnly = true; // Đặt txtReceiptID thành readonly
        }

        private void LoadData()
        {
            dgvReceipts.DataSource = paymentBLL.GetAllReceipts();
            LoadComboBoxData();
            ClearInputs();
        }

        private void LoadComboBoxData()
        {
/*            // Sử dụng ComboBox thay vì TextBox
            cbVehicle.DataSource = VehicleDAL.GetAllVehicles();
            cbVehicle.DisplayMember = "license_plate";
            cbVehicle.ValueMember = "id";

            cbParkingCard.DataSource = ParkingCardDAL.GetAllActiveCards();
            cbParkingCard.DisplayMember = "id";
            cbParkingCard.ValueMember = "id";

            cbStaff.DataSource = UserDAL.GetStaffUsers();
            cbStaff.DisplayMember = "full_name";
            cbStaff.ValueMember = "id";

            cbPaymentMethod.Items.AddRange(new string[] { "Tiền mặt", "Thẻ", "Chuyển khoản" });
            cbPaymentMethod.SelectedIndex = -1; // Không chọn mặc định*/
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
/*            try
            {
                if (!ValidateInputs()) return;

                PaymentReceipt receipt = new PaymentReceipt
                {
                    ParkingCardId = cbParkingCard.SelectedValue?.ToString(),
                    VehicleId = cbVehicle.SelectedValue?.ToString(),
                    StaffCode = cbStaff.SelectedValue?.ToString(),
                    TotalPrice = decimal.Parse(txtTotalPrice.Text),
                    PaymentMethod = cbPaymentMethod.SelectedItem?.ToString(),
                    PaymentDate = dtpPaymentDate.Value
                };

                if (paymentBLL.AddReceipt(receipt))
                {
                    MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thêm hóa đơn thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
  /*          if (dgvReceipts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (!ValidateInputs()) return;

                int id = Convert.ToInt32(dgvReceipts.SelectedRows[0].Cells["id"].Value);
                PaymentReceipt receipt = new PaymentReceipt
                {
                    Id = id.ToString(),
                    ParkingCardId = cbParkingCard.SelectedValue?.ToString(),
                    VehicleId = cbVehicle.SelectedValue?.ToString(),
                    StaffCode = cbStaff.SelectedValue?.ToString(),
                    TotalPrice = decimal.Parse(txtTotalPrice.Text),
                    PaymentMethod = cbPaymentMethod.SelectedItem?.ToString(),
                    PaymentDate = dtpPaymentDate.Value
                };

                if (paymentBLL.UpdateReceipt(receipt))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvReceipts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int id = Convert.ToInt32(dgvReceipts.SelectedRows[0].Cells["id"].Value);
                if (MessageBox.Show("Bạn có chắc muốn xóa hóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (paymentBLL.DeleteReceipt(id))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvReceipts_SelectionChanged(object sender, EventArgs e)
        {
/*            if (dgvReceipts.SelectedRows.Count > 0)
            {
                var row = dgvReceipts.SelectedRows[0];
                txtReceiptID.Text = row.Cells["id"].Value?.ToString();
                cbVehicle.SelectedValue = row.Cells["vehicle_id"].Value;
                cbParkingCard.SelectedValue = row.Cells["parking_card_id"].Value;
                cbStaff.SelectedValue = row.Cells["staff_code"].Value;
                txtTotalPrice.Text = row.Cells["total_price"].Value?.ToString();
                cbPaymentMethod.SelectedItem = row.Cells["payment_method"].Value?.ToString();
                dtpPaymentDate.Value = Convert.ToDateTime(row.Cells["payment_date"].Value);
            }*/
        }

        //private bool ValidateInputs()
        //{
/*            if (cbVehicle.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn xe!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbStaff.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTotalPrice.Text) || !decimal.TryParse(txtTotalPrice.Text, out decimal totalPrice) || totalPrice <= 0)
            {
                MessageBox.Show("Tổng tiền không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbPaymentMethod.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phương thức thanh toán!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;*/
        //}//

        private void ClearInputs()
        {/*
            txtReceiptID.Text = string.Empty;
            cbVehicle.SelectedIndex = -1;
            cbParkingCard.SelectedIndex = -1;
            cbStaff.SelectedIndex = -1;
            txtTotalPrice.Text = string.Empty;
            cbPaymentMethod.SelectedIndex = -1;
            dtpPaymentDate.Value = DateTime.Now;*/
        }
    }
}