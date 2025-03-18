using Org.BouncyCastle.Asn1.Cmp;
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
    public partial class frmParkingCard: Form
    {
        private ParkingCardBLL parkingCardBLL = new ParkingCardBLL();

        public frmParkingCard()
        {
            InitializeComponent();
            LoadAllParkingCards();
            LoadStatusFilter();
            LoadStatusSearch();
            LoadSlotNumber();

            kDtpStartdate.Format = DateTimePickerFormat.Custom;
            kDtpStartdate.CustomFormat = "yyyy-MM-dd HH:mm:ss";

            kDtpEnddate.Format = DateTimePickerFormat.Custom;
            kDtpEnddate.CustomFormat = "yyyy-MM-dd HH:mm:ss";


        }
        private void LoadSlotNumber()
        {
            kCbbStatus.Items.Clear();
            kCbbStatus.Items.Add("Tất cả");
            kCbbStatus.Items.Add("Hết hạn");
            kCbbStatus.Items.Add("Hoạt động");
            kCbbStatus.Items.Add("Không hoạt động");
            kCbbStatus.SelectedIndex = 0;
        }
        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonRadioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kTbContentSearch_TextChanged(object sender, EventArgs e)
        {

        }

        //Load danh sách thẻ giữ xe lên DataGridView
        private void LoadAllParkingCards()
        {
            try
            {
                List<allParkingCard> cards = parkingCardBLL.GetAllParkingCards();

                if (cards == null || cards.Count == 0)
                {
                    MessageBox.Show("Không có thẻ giữ xe nào trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                kDgvParkingCard.DataSource = null;  // Reset trước khi gán
                kDgvParkingCard.DataSource = cards; // Gán danh sách vào DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách thẻ giữ xe: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        


        //Load danh sách trạng thái thẻ giữ xe vào ComboBox
        private void LoadStatusFilter()
        {
            try
            {
                kCbbStatus.Items.Clear();
                kCbbStatus.Items.Add("Tất cả");
                kCbbStatus.Items.Add("Hoạt động");
                kCbbStatus.Items.Add("Hết hạn");
                kCbbStatus.Items.Add("Không hoạt động");

                kCbbStatus.SelectedIndex = 0; // Mặc định chọn "Tất cả"
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách trạng thái: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStatusSearch()
        {
            try
            {
                kCbbSStatus.Items.Clear();
                kCbbSStatus.Items.Add("Tất cả");
                kCbbSStatus.Items.Add("Hoạt động");
                kCbbSStatus.Items.Add("Hết hạn");
                kCbbSStatus.Items.Add("Không hoạt động");

                kCbbSStatus.SelectedIndex = 0; // Mặc định chọn "Tất cả"
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách trạng thái: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Load danh sách thẻ tháng, ngày vào RadioButton
        private void LoadIsMonthFilter()
        {
            try
            {
                // Đặt giá trị mặc định
                kRbtnMonth.Checked = false;
                kRbtnDay.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách loại thẻ: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kTbPrice_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem giá trị của TextBox có phải số không
            //if (!decimal.TryParse(kTbPrice.Text, out decimal price))
            //{
            //    MessageBox.Show("Giá tiền phải là số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    kTbPrice.Text = ""; // Xóa nếu nhập sai
            //    return;
            //}

            //// Nếu người dùng chỉnh sửa trực tiếp, bỏ chọn radio để tránh ghi đè
            //kRbtnMonth.Checked = false;
            //kRbtnDay.Checked = false;
        }

        private void kRbtnMonth_CheckedChanged(object sender, EventArgs e)
        {
            //if (kRbtnMonth.Checked)
            //{
            //    kTbPrice.Text = "500000"; // Giá mẫu cho thẻ tháng
            //}
        }

        private void kRbtnDay_CheckedChanged(object sender, EventArgs e)
        {
            //if (kRbtnDay.Checked)
            //{
            //    kTbPrice.Text = "20000"; // Giá mẫu cho thẻ ngày
            //}
        }

        private void kBtnRefresh_Click(object sender, EventArgs e)
        {
            LoadAllParkingCards();
        }

        private string selectedPCId;
        private void kDgvParkingCard_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = kDgvParkingCard.Rows[e.RowIndex];

                selectedPCId = row.Cells["id"].Value?.ToString();

                if (row.Cells[1].Value != null && row.Cells[1].Value != DBNull.Value)
                {
                    string entryTimeStr = row.Cells[1].Value.ToString().Trim();

                    if (DateTime.TryParse(entryTimeStr, out DateTime entryTime))
                    {
                        kDtpStartdate.Value = entryTime;
                    }
                    else
                    {
                        MessageBox.Show($"Lỗi chuyển đổi EntryTime: {entryTimeStr}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        kDtpStartdate.Value = DateTime.Now;
                    }
                }
                else
                {
                    kDtpStartdate.Value = DateTime.Now;
                }

                if (row.Cells[2].Value != null && row.Cells[2].Value != DBNull.Value)
                {
                    string entryTimeStr = row.Cells[2].Value.ToString().Trim();

                    if (DateTime.TryParse(entryTimeStr, out DateTime entryTime))
                    {
                        kDtpEnddate.Value = entryTime;
                    }
                    else
                    {
                        MessageBox.Show($"Lỗi chuyển đổi : {entryTimeStr}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        kDtpEnddate.Value = DateTime.Now;
                    }
                }
                else
                {
                    kDtpEnddate.Value = DateTime.Now;
                }

                string vehicleTypeName = row.Cells[6].Value?.ToString();
                kCbbStatus.SelectedIndex = kCbbStatus.FindStringExact(vehicleTypeName);

                kTbPrice.Text = row.Cells[5].Value?.ToString() ?? "";
                kTbUserCode.Text = row.Cells[7].Value?.ToString() ?? "";
                kTbBs.Text = row.Cells[6].Value?.ToString() ?? "";

                string status = row.Cells[3].Value?.ToString();
                kCbbStatus.SelectedIndex = kCbbStatus.FindStringExact(status);

                if (row.Cells[4].Value != null && row.Cells[4].Value != DBNull.Value)
                {
                    bool isMonth = Convert.ToBoolean(row.Cells[4].Value);
                    kRbtnMonth.Checked = isMonth;
                    kRbtnDay.Checked = !isMonth;
                }
                else
                {
                    kRbtnMonth.Checked = false;
                    kRbtnDay.Checked = true;
                }

            }
        }

        private void kBtnCreat_Click(object sender, EventArgs e)
        {
            string userCode = kTbUserCode.Text.Trim();
            string vehicleLicensePlate = kTbBs.Text.Trim();
            bool isMonth = kRbtnMonth.Checked;
            parkingCardBLL.CreateParkingCard(vehicleLicensePlate, userCode, isMonth);
        }

        private void kDgvParkingCard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kBtnSearch_Click(object sender, EventArgs e)
        {
            string status = kCbbSStatus.SelectedItem.ToString(); 
            bool? isMonth = null;
            if (kRBtnSAll.Checked)
            {
                status = null;
            }

            if (kBbnCardMonth.Checked)
            {
                isMonth = true;
            }
            else if (kBbnCardDay.Checked)
            {
                isMonth = false;
            }

            List<allParkingCard> parkingCards = parkingCardBLL.GetAllParkingCards(status, isMonth);

            kDgvParkingCard.DataSource = null;
            kDgvParkingCard.DataSource = parkingCards;
        }

        private void kBtnResetFrm_Click(object sender, EventArgs e)
        {
            kDtpStartdate.Value = DateTime.Now;
            kDtpEnddate.Value = DateTime.Now;
            kTbUserCode.Text = "";
            kTbBs.Text = "";
            kTbPrice.Text = "";
            LoadIsMonthFilter();
            kCbbStatus.SelectedIndex = 0;
        }

        private void kryptonGroupBox3_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmParkingCard_Load(object sender, EventArgs e)
        {

        }

        private void kryptonGroupBox1_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
