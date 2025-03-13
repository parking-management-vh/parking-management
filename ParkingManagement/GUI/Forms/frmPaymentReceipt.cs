using ParkingManagement.BLL;
using ParkingManagement.Models;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ParkingManagement.GUI.Forms
{
    public partial class frmPaymentReceipt : Form
    {
        private readonly paymentBLL paymentBLL = new paymentBLL();
        private string selectedPaymentId;
        public frmPaymentReceipt()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            LoadAllPayment();
            LoadPaymentmethod();
            LoadFilter();
            LoadPayMethodSearch();
        }

        private void LoadAllPayment()
        {
            try
            {
                string filterType = null;
                string filterValue = null;
                string paymentMethodFilter = null;
                DateTime? paymentDate = null;
                List<paymentModel> payment = paymentBLL.GetAllPayments(filterType, filterValue, paymentMethodFilter, paymentDate);

                if (payment == null || payment.Count == 0)
                {
                    MessageBox.Show("Không có xe nào trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                kDgvReceipts.DataSource = payment;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách xe: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kDgvReceipts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = kDgvReceipts.Rows[e.RowIndex];

                selectedPaymentId = row.Cells["id"].Value?.ToString();

                if (row.Cells[1].Value != null && DateTime.TryParse(row.Cells[1].Value.ToString(), out DateTime paymentDate))
                {
                    kDtpPaymentDate.Value = paymentDate;
                }
                else
                {
                    kDtpPaymentDate.Value = DateTime.Now; 
                }

                kTbTotalPrice.Text = row.Cells[2].Value?.ToString();

                kCbPaymentMethod.SelectedItem = row.Cells[3].Value?.ToString();

                kTbTotalTime.Text = row.Cells[4].Value?.ToString() ?? "";
                kTbStaffPay.Text = row.Cells[5].Value?.ToString() ?? "";
                kTbCodeInvoice.Text = row.Cells[6].Value?.ToString() ?? "";
                kTbBks.Text = row.Cells[7].Value?.ToString() ?? "";
            }
        }

        private void LoadPaymentmethod()
        {
            kCbPaymentMethod.Items.Clear();
            kCbPaymentMethod.Items.Add("Tất cả");
            kCbPaymentMethod.Items.Add("Tiền mặt");
            kCbPaymentMethod.Items.Add("Thẻ");
            kCbPaymentMethod.Items.Add("Chuyển khoản");
            kCbPaymentMethod.SelectedIndex = 0;
        }

        private void LoadPayMethodSearch()
        {
            kCbbPayMethod.Items.Clear();
            kCbbPayMethod.Items.Add("Tất cả");
            kCbbPayMethod.Items.Add("Tiền mặt");
            kCbbPayMethod.Items.Add("Thẻ");
            kCbbPayMethod.Items.Add("Chuyển khoản");
            kCbbPayMethod.SelectedIndex = 0;
        }

        private void LoadFilter()
        {
            kCbbSFilter.Items.Clear();
            kCbbSFilter.Items.Add("Tất cả");
            kCbbSFilter.Items.Add("Biển số");
            kCbbSFilter.Items.Add("Mã nhân viên");
            kCbbSFilter.Items.Add("Mã hoá đơn");
            kCbbSFilter.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string licensePlate = null;
            frmCreatePayment createPaymentForm = new frmCreatePayment(licensePlate);
            createPaymentForm.StartPosition = FormStartPosition.CenterParent; 
            createPaymentForm.ShowDialog(); 
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
  
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedPaymentId))
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
                    int paymentId = Convert.ToInt32(selectedPaymentId);

                    bool isDeleted = paymentBLL.DeletePayment(paymentId);

                    if (isDeleted)
                    {
                        MessageBox.Show("Xoá thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllPayment();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xoá chỗ đỗ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void kryptonGroupBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAllPayment();
        }

        private void kBtnSearch_Click(object sender, EventArgs e)
        {
            string filterType = kCbbSFilter.SelectedItem.ToString();
            string filterValue = kTbSearch.Text.Trim();
            string paymentMethodFilter = kCbbPayMethod.SelectedItem.ToString();
            DateTime? paymentDate = kDtpSDate.Value.Date; 

            if (filterType == "Tất cả")
            {
                filterValue = null;
            }

            List<paymentModel> filteredPayments = paymentBLL.GetAllPayments(filterType, filterValue, paymentMethodFilter, paymentDate);

            kDgvReceipts.DataSource = filteredPayments;
        }

        private void kBtnReset_Click(object sender, EventArgs e)
        {
            kDtpPaymentDate.Value = DateTime.Now;
            kTbTotalPrice.Text = "";
            kCbPaymentMethod.SelectedItem = -1;
            kTbTotalTime.Text = "";
            kTbStaffPay.Text = "";
            kTbCodeInvoice.Text = "";
            kTbBks.Text = "";
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}