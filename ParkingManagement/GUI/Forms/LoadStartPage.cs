using ParkingManagement.BLL;
using ParkingManagement.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FontAwesome.Sharp;
using System.IO;

namespace ParkingManagement.GUI.Forms
{
    public partial class LoadStartPage : Form
    {
        private RecentActivityBLL recentActivityBLL;

        public LoadStartPage()
        {
            InitializeComponent();
            recentActivityBLL = new RecentActivityBLL();
            InitializeListView();
            LoadData();
            LoadNotifications();
        }
      
        private void InitializeListView()
        {
            listViewAllData.View = View.Details;
            listViewAllData.Dock = DockStyle.Fill; // ListView full màn hình
            listViewAllData.FullRowSelect = true;
            listViewAllData.GridLines = true;

            listViewAllData.Columns.Clear();
            listViewAllData.Columns.Add("Loại dữ liệu", 150);
            listViewAllData.Columns.Add("Biển số / Mã giao dịch", 200);
            listViewAllData.Columns.Add("Chi tiết", 400); // Cột này chiếm nhiều hơn

            // Đặt chế độ tự điều chỉnh kích thước khi dữ liệu thay đổi
            listViewAllData.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void LoadData()
        {
            // Xóa danh sách cũ và tải dữ liệu mới
            listViewAllData.Items.Clear();
            LoadRecentVehicles();   // Tải danh sách xe mới vào
            LoadRecentTransactions(); // Tải danh sách giao dịch gần đây
            LoadOverdueVehicles();  // Tải danh sách xe quá hạn
        }

        private void LoadRecentVehicles()
        {
            List<VehicleModel> recentVehicles = recentActivityBLL.GetRecentVehicles();
            foreach (var vehicle in recentVehicles)
            {
                ListViewItem item = new ListViewItem("Xe mới vào")
                {
                    ForeColor = Color.Blue,
                    UseItemStyleForSubItems = false
                };
                item.SubItems.Add(vehicle.LicensePlate).ForeColor = Color.Blue;
                item.SubItems.Add($"Thời gian vào: {vehicle.EntryTime:yyyy-MM-dd HH:mm}").ForeColor = Color.Blue;
                listViewAllData.Items.Add(item);
            }
        }

        private void LoadRecentTransactions()
        {
            List<ParkingCard> recentTransactions = recentActivityBLL.GetRecentTransactions();
            foreach (var transaction in recentTransactions)
            {
                ListViewItem item = new ListViewItem("Giao dịch gần đây")
                {
                    ForeColor = Color.DarkGreen,
                    UseItemStyleForSubItems = false
                };
                item.SubItems.Add($"ID: {transaction.Id}").ForeColor = Color.DarkGreen;
                item.SubItems.Add($"Trạng thái: {transaction.Status} | " +
                                  (transaction.EndDate.HasValue ? $"Ngày hết hạn: {transaction.EndDate.Value:yyyy-MM-dd HH:mm}" : "Chưa hết hạn")).ForeColor = Color.DarkGreen;
                listViewAllData.Items.Add(item);
            }
        }

        private void LoadOverdueVehicles()
        {
            List<VehicleModel> overdueVehicles = recentActivityBLL.GetOverdueVehicles();
            foreach (var vehicle in overdueVehicles)
            {
                ListViewItem item = new ListViewItem("Xe quá hạn")
                {
                    ForeColor = Color.Red,
                    UseItemStyleForSubItems = false
                };
                item.SubItems.Add(vehicle.LicensePlate).ForeColor = Color.Red;
                item.SubItems.Add($"Thời gian vào: {vehicle.EntryTime:yyyy-MM-dd HH:mm}").ForeColor = Color.Red;
                listViewAllData.Items.Add(item);
            }
        }

        private void LoadStartPage_Resize(object sender, EventArgs e)
        {
            if (listViewAllData.Columns.Count == 0)
                return; // Đảm bảo có cột trước khi thay đổi kích thước

            int totalWidth = listViewAllData.ClientSize.Width;

            listViewAllData.Columns[0].Width = (int)(totalWidth * 0.2); // 20%
            listViewAllData.Columns[1].Width = (int)(totalWidth * 0.3); // 30%
            listViewAllData.Columns[2].Width = (int)(totalWidth * 0.5); // 50%
        }
      
        private void LoadNotifications()
        {
            panelNotifications.Controls.Clear(); // Xóa thông báo cũ
            RecentActivityBLL bll = new RecentActivityBLL();

            string imgPath = Path.Combine(Application.StartupPath, "Resources\\img\\");           
            (string text, string imageName, Bitmap fallbackImage)[] data = {
                ($"Sức chứa: {bll.GetTotalSlots()} chỗ", "capacity.png", new Bitmap(new MemoryStream(Properties.Resources.capacity))),
                ($"Chỗ trống (Khu 1): {bll.GetAvailableSlots("20b45e92-bfdb-46d7-9314-7a1d8f97e636")}", "available.png", new Bitmap(new MemoryStream(Properties.Resources.available))),
                ($"Chỗ trống (Khu 2): {bll.GetAvailableSlots("a5487c87-0ee1-4861-a597-2d607d33fd43")}", "available.png", new Bitmap(new MemoryStream(Properties.Resources.available))),
                ($"Xe trong bãi: {bll.GetVehiclesInParking()}", "car_in.png", new Bitmap(new MemoryStream(Properties.Resources.car_in))),
                ($"Lượt vào hôm nay: {bll.GetEntriesToday()}", "entry.png", new Bitmap(new MemoryStream(Properties.Resources.entry))),
                ($"Lượt ra hôm nay: {bll.GetExitsToday()}", "exit_car.png", new Bitmap(new MemoryStream(Properties.Resources.exit_car))),
                ($"Doanh thu hôm nay: {bll.GetTodayRevenue():N0} VNĐ", "exit.png", new Bitmap(new MemoryStream(Properties.Resources.exit))),
             
            };

            foreach (var item in data)
            {
                Panel notificationPanel = new Panel
                {
                    Width = panelNotifications.ClientSize.Width - 10, // Tự động full width
                    Height = 50,
                    BackColor = Color.LightGray,  // Mặc định chưa đọc (xám)
                    Cursor = Cursors.Hand,
                    Padding = new Padding(5),
                    Margin = new Padding(3),
                    Tag = false // Chưa đọc (false)
                };

                // PictureBox để hiển thị icon
                PictureBox iconBox = new PictureBox
                {
                    Size = new Size(32, 32),
                    Location = new Point(10, 9),
                    SizeMode = PictureBoxSizeMode.Zoom
                };

                // Kiểm tra file ảnh có tồn tại không, nếu có thì load vào PictureBox
                string iconFilePath = Path.Combine(imgPath, item.imageName);
                if (File.Exists(iconFilePath))
                {
                    iconBox.Image = Image.FromFile(iconFilePath);
                }
                else
                {
                    using (MemoryStream ms = new MemoryStream(Properties.Resources.alert))
                    {
                        iconBox.Image = Image.FromStream(ms); // Nếu không tìm thấy ảnh, dùng ảnh mặc định
                    }
                }

                // Label nội dung thông báo
                Label lblNotification = new Label
                {
                    Text = item.text,
                    AutoSize = false,
                    Width = notificationPanel.Width - 60,
                    Height = notificationPanel.Height,
                    Location = new Point(50, 0), // Đẩy chữ sang phải tránh icon
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    ForeColor = Color.Black,
                    BackColor = Color.Transparent,
                    TextAlign = ContentAlignment.MiddleLeft
                };

                // Hiệu ứng hover
                notificationPanel.MouseEnter += (s, e) =>
                {
                    if (!(bool)notificationPanel.Tag) // Nếu chưa đọc
                        notificationPanel.BackColor = Color.LightYellow;
                };
                notificationPanel.MouseLeave += (s, e) =>
                {
                    if (!(bool)notificationPanel.Tag) // Nếu chưa đọc
                        notificationPanel.BackColor = Color.LightGray;
                };

                // Click vào để đánh dấu đã đọc
                notificationPanel.Click += (s, e) =>
                {
                    notificationPanel.BackColor = Color.White; // Đã đọc
                    notificationPanel.Tag = true;
                };

                // Thêm các control vào panel thông báo
                notificationPanel.Controls.Add(iconBox);
                notificationPanel.Controls.Add(lblNotification);
                panelNotifications.Controls.Add(notificationPanel);
            }
        }

        private void kryptonPanel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
