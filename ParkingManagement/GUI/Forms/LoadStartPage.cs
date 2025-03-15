using ParkingManagement.BLL;
using ParkingManagement.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            InitializeCharts();
            LoadData();
            LoadChartData();
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
        private void InitializeCharts()
        {
            chartStatistics.Series.Clear();
            chartStatistics.ChartAreas.Clear();

            chartStatistics.Titles.Clear();
            chartStatistics.Titles.Add("Thống kê bãi đỗ xe");

            ChartArea chartArea = new ChartArea();

            // Kích hoạt trục Y thứ hai để hiển thị doanh thu
            chartArea.AxisY2.Enabled = AxisEnabled.True;

            chartStatistics.ChartAreas.Add(chartArea);

            // Số lượng xe hiện tại (Dạng cột)
            Series seriesVehicleCount = new Series("Xe trong bãi")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };
            chartStatistics.Series.Add(seriesVehicleCount);

            // Doanh thu (Dạng Line hoặc SplineArea để không bị lỗi)
            Series seriesRevenue = new Series("Doanh thu")
            {
                ChartType = SeriesChartType.SplineArea, // Dùng SplineArea thay vì Doughnut
                YAxisType = AxisType.Secondary, // Dùng trục Y thứ hai
                IsValueShownAsLabel = true
            };
            chartStatistics.Series.Add(seriesRevenue);
        }
        private void LoadChartData()
        {
            Random random = new Random();
            int totalVehicles = random.Next(50, 200);
            int vehiclesInToday = random.Next(10, 50);
            int vehiclesOutToday = random.Next(10, 50);
            int revenueToday = random.Next(100000, 500000);
            int totalRevenue = random.Next(5000000, 10000000);

            if (chartStatistics.Series.Count > 0)
            {
                // Cập nhật biểu đồ số lượng xe hiện tại
                chartStatistics.Series["Xe trong bãi"].Points.Clear();
                chartStatistics.Series["Xe trong bãi"].Points.AddXY("Trong bãi", totalVehicles);
                chartStatistics.Series["Xe trong bãi"].Points.AddXY("Vào hôm nay", vehiclesInToday);
                chartStatistics.Series["Xe trong bãi"].Points.AddXY("Ra hôm nay", vehiclesOutToday);

                // Cập nhật biểu đồ doanh thu
                chartStatistics.Series["Doanh thu"].Points.Clear();
                chartStatistics.Series["Doanh thu"].Points.AddXY("Hôm nay", revenueToday);
                chartStatistics.Series["Doanh thu"].Points.AddXY("Tổng", totalRevenue);
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
    }
}
