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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ParkingManagement.GUI.Forms.staff
{
    public partial class frmInOutVehicle: Form
    {
        private vehicleBLL vehicleBLL = new vehicleBLL();
        private ParkingCardBLL parkingCardBLL = new ParkingCardBLL();
        private parkingSlotBLL parkingSlotBLL = new parkingSlotBLL();
        public frmInOutVehicle()
        {
            InitializeComponent();
            LoadAllVehicleType();
            timerClock.Interval = 1000; 
            timerClock.Tick += TimerClock_Tick;
            timerClock.Start();
            kryptonGroupBox4.BackgroundImageLayout = ImageLayout.Stretch;
            kDTPInfoIn.Format = DateTimePickerFormat.Custom;
            kDTPInfoIn.CustomFormat = "yyyy-MM-dd HH:mm:ss";

            kDTPInfoOut.Format = DateTimePickerFormat.Custom;
            kDTPInfoOut.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }
        private Guid? selectedAreaId;

        private void frmInOutVehicle_Load(object sender, EventArgs e)
        {
            LoadUserSession();
        }

        private void LoadUserSession()
        {
            if (SessionManager.CurrentUser == null) return;

            kLbAreaName.Text = $"Khu vực: {SessionManager.CurrentUser.AreaName}";

            selectedAreaId = SessionManager.CurrentUser.AreaId ?? Guid.Empty;

            LoadAvailableSlots(selectedAreaId.Value);
        }

        private void RefreshForm()
        {
            kTbInBks.Text = "";
            LoadAvailableSlots(selectedAreaId ?? Guid.Empty);
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

        private void LoadParkingCardInfo(string licensePlate)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(licensePlate))
                {
                    MessageBox.Show("Biển số xe không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show($"Đang tìm thẻ xe cho biển số: {licensePlate}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                parkingCardDetail cardDetail = parkingCardBLL.GetParkingCardByLicensePlate(licensePlate);

                if (cardDetail == null)
                {
                    MessageBox.Show("Không tìm thấy thẻ xe cho biển số này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadInfoCard();
                    return;
                }

                string license = cardDetail.LicensePlate ?? "N/A";
                string userCode = cardDetail.UserCode ?? "N/A";
                decimal price = cardDetail.Price;
                DateTime startDate = cardDetail.StartDate;
                DateTime endDate = cardDetail.EndDate ?? DateTime.Now;
                bool isMonth = cardDetail.IsMonth;

                MessageBox.Show($@"
                    Dữ liệu lấy được:
                    Biển số: {license}
                    User Code: {userCode}
                    Giá: {price:N0} VNĐ
                    Ngày bắt đầu: {startDate}
                    Ngày kết thúc: {endDate}
                ", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                kTbInfoBs.Text = license;
                kTbInfoUser.Text = userCode;
                kTbInfoPrice.Text = price.ToString("N0") + " VNĐ";
                kDTPInfoIn.Value = startDate;
                kDTPInfoOut.Value = endDate;
                kRbtnInfoMonth.Checked = isMonth;
                kRBtnInfoDay.Checked = !isMonth;

                MessageBox.Show("Dữ liệu đã được hiển thị trên giao diện.", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xảy ra: {ex.Message}\n{ex.StackTrace}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAvailableSlots(Guid areaId)
        {
            try
            {
                List<ParkingSlotModel> slots = parkingSlotBLL.GetSlotByArea(areaId);

                kCbbSlotNum.DataSource = null;
                kCbbSlotNum.Items.Clear();

                if (slots.Count == 0)
                {
                    MessageBox.Show("Không có vị trí đỗ nào sẵn sàng trong khu vực này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                kCbbSlotNum.DataSource = slots;
                kCbbSlotNum.DisplayMember = "SlotNumber";
                kCbbSlotNum.ValueMember = "Id";

                kCbbSlotNum.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách vị trí: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TimerClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy HH:mm:ss");
        }

        private void kTbInBks_TextChanged(object sender, EventArgs e)
        {
            kLbIbBs.Text = kTbInBks.Text;
        }

        private void kryptonLabel7_Click(object sender, EventArgs e)
        {

        }

        private void LoadInfoCard()
        {
            kTbInfoBs.Text = "";
            kTbInfoUser.Text = "";
            kTbInfoPrice.Text = "";
            kDTPInfoIn.Value = DateTime.Now;
            kDTPInfoOut.Value = DateTime.Now;
        }
        private void kBtnSubmitBs_Click(object sender, EventArgs e)
        {
            string licensePlate = kTbInBks.Text.Trim();

            if (string.IsNullOrWhiteSpace(licensePlate))
            {
                MessageBox.Show("Biển số xe không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Guid? vehicleId = vehicleBLL.GetVehicleIdByLicensePlate(licensePlate);
                Guid selectedAreaId = SessionManager.CurrentUser.AreaId ?? Guid.Empty;

                if (vehicleId == null)
                {
                    if (selectedAreaId == Guid.Empty)
                    {
                        MessageBox.Show("Không thể xác định khu vực đỗ xe!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!Guid.TryParse(kCbbSlotNum.SelectedValue?.ToString(), out Guid parkingSlotId))
                    {
                        MessageBox.Show("ID chỗ đỗ không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!Guid.TryParse(kCbbTypeVehicle.SelectedValue?.ToString(), out Guid vehicleTypeId))
                    {
                        MessageBox.Show("ID loại xe không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DateTime now = DateTime.Now;

                    VehicleModel vehicle = new VehicleModel(
                        Guid.NewGuid(),
                        licensePlate,
                        vehicleTypeId,
                        parkingSlotId,
                        selectedAreaId,  
                        now,
                        null,
                        now,
                        now,
                        now
                    );

                    vehicleBLL.CreateVehicle(vehicle);
                    vehicleId = vehicle.Id; 
                }

                parkingCardBLL.CreateParkingCard(licensePlate, "", false);

                LoadParkingCardInfo(licensePlate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phương tiện hoặc thẻ gửi xe: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshForm();
        }

        private void kBtnOutBks_Click(object sender, EventArgs e)
        {
            string licensePlate = kTbOutBks.Text.Trim();

            if (string.IsNullOrWhiteSpace(licensePlate))
            {
                MessageBox.Show("Biển số xe không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            parkingCardBLL.GetParkingCardByLicensePlate(licensePlate);
            LoadParkingCardInfo(licensePlate);
        }

        private void kTbOutBks_TextChanged(object sender, EventArgs e)
        {
            kLbOutTextBs.Text = kTbOutBks.Text;
        }
    }
}
