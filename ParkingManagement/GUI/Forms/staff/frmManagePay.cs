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
    public partial class frmManagePay: Form
    {
        private readonly paymentBLL paymentBLL = new paymentBLL();
        private string selectedPaymentId;
        public frmManagePay()
        {
            InitializeComponent();
            LoadAllPayment();
            LoadFilter();
            LoadPayMethodSearch();
            LoadUserSession();
            LoadPaymentmethod();
        }
        private string selectedStaffCode;
        private void LoadUserSession()
        {
            if (SessionManager.CurrentUser == null) return;

            selectedStaffCode = SessionManager.CurrentUser.Code;
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

        private void LoadPaymentmethod()
        {
            kCbPaymentMethod.Items.Clear();
            kCbPaymentMethod.Items.Add("Tất cả");
            kCbPaymentMethod.Items.Add("Tiền mặt");
            kCbPaymentMethod.Items.Add("Thẻ");
            kCbPaymentMethod.Items.Add("Chuyển khoản");
            kCbPaymentMethod.SelectedIndex = 0;
        }

        private void LoadFilter()
        {
            kCbbSFilter.Items.Clear();
            kCbbSFilter.Items.Add("Tất cả");
            kCbbSFilter.Items.Add("Biển số");
            kCbbSFilter.Items.Add("Mã hoá đơn");
            kCbbSFilter.SelectedIndex = 0;
        }
        private void LoadAllPayment()
        {
            try
            {
                string staffCode = SessionManager.CurrentUser.Code;
                string filterType = null;
                string filterValue = null;
                string paymentMethodFilter = null;
                DateTime? paymentDate = null;
                List<paymentModel> payment = paymentBLL.GetAllPaymentsByStaffCode(staffCode, filterType, filterValue, paymentMethodFilter, paymentDate);

                if (payment == null || payment.Count == 0)
                {
                    MessageBox.Show("Không có xe nào trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                kDgvListVehiclePay.DataSource = payment;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách xe: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kDgvListVehiclePay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = kDgvListVehiclePay.Rows[e.RowIndex];

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
    }
}
