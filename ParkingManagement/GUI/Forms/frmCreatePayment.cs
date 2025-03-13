using ParkingManagement.BLL;
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
    public partial class frmCreatePayment: Form
    {
        private string licensePlate;
        public frmCreatePayment(string licensePlate)
        {
            InitializeComponent();
            LoadPaymentmethod();
            LoadUserSession();
            this.licensePlate = licensePlate;

            timerClock.Interval = 1000;
            timerClock.Tick += TimerClock_Tick;
            timerClock.Start();
        }

        private void frmCreatePayment_Load(object sender, EventArgs e)
        {
            kTbBks.Text = licensePlate;
        }

        private readonly paymentBLL paymentBLL = new paymentBLL();
        private string selectedStaffCode;
        private void LoadUserSession()
        {
            if (SessionManager.CurrentUser == null) return;

            kLbCodeStaff.Text = $"{SessionManager.CurrentUser.Code}";
            selectedStaffCode = SessionManager.CurrentUser.Code;
        }
        private void TimerClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy HH:mm:ss");
        }
        private void LoadPaymentmethod()
        {
            kCbbPaymentMethod.Items.Clear();
            kCbbPaymentMethod.Items.Add("Tất cả");
            kCbbPaymentMethod.Items.Add("Tiền mặt");
            kCbbPaymentMethod.Items.Add("Thẻ");
            kCbbPaymentMethod.Items.Add("Chuyển khoản");
            kCbbPaymentMethod.SelectedIndex = 0;
        }

        private void kCbbCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void kBtnPaymentNow_Click(object sender, EventArgs e)
        {
            string licensePlate = kTbBks.Text.Trim();
            string staffCode = selectedStaffCode;
            //string staffCode = kLbCodeStaff.Text.ToString();
            string paymentMethod = kCbbPaymentMethod.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(licensePlate))
            {
                MessageBox.Show("Vui lòng nhập biển số xe!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(paymentMethod) || paymentMethod == "Tất cả")
            {
                MessageBox.Show("Vui lòng chọn phương thức thanh toán!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isSuccess = paymentBLL.CreatePayment(licensePlate, staffCode, paymentMethod);

            if (isSuccess)
            {
                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại, vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kTbBks_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
