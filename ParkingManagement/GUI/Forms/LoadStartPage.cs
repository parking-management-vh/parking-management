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
            // Cấu hình ListView để hiển thị dữ liệu theo cột
            listViewAllData.View = View.Details;
            listViewAllData.Columns.Clear();
            listViewAllData.Columns.Add("Loại dữ liệu", 150); // Type
            listViewAllData.Columns.Add("Biển số / Mã giao dịch", 200); // License Plate / ID
            listViewAllData.Columns.Add("Chi tiết", 250); // Details
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
            // Lấy danh sách xe mới vào từ BLL
            List<VehicleModel> recentVehicles = recentActivityBLL.GetRecentVehicles();
            foreach (var vehicle in recentVehicles)
            {
                ListViewItem item = new ListViewItem("Xe mới vào"); // Recent Vehicle
                item.SubItems.Add(vehicle.LicensePlate);
                //item.SubItems.Add($"{vehicle.VehicleTypeName} | {vehicle.EntryTime:yyyy-MM-dd HH:mm}");
                item.SubItems.Add($"Thời gian vào: {vehicle.EntryTime:yyyy-MM-dd HH:mm}");
                item.ForeColor = Color.Blue; // Màu xanh dương cho xe mới vào
                listViewAllData.Items.Add(item);
            }
        }

        private void LoadRecentTransactions()
        {
            // Lấy danh sách giao dịch gần đây từ BLL
            List<ParkingCard> recentTransactions = recentActivityBLL.GetRecentTransactions();
            foreach (var transaction in recentTransactions)
            {
                ListViewItem item = new ListViewItem("Giao dịch gần đây"); // Recent Transaction
                item.SubItems.Add($"ID: {transaction.Id}");
                item.SubItems.Add($"Trạng thái: {transaction.Status} | " +
                    (transaction.EndDate.HasValue ? $"Ngày hết hạn: {transaction.EndDate.Value:yyyy-MM-dd HH:mm}" : "Chưa hết hạn"));
                item.ForeColor = Color.DarkGreen; // Màu xanh lá cho giao dịch gần đây
                listViewAllData.Items.Add(item);
            }
        }

        private void LoadOverdueVehicles()
        {
            // Lấy danh sách xe quá hạn từ BLL
            List<VehicleModel> overdueVehicles = recentActivityBLL.GetOverdueVehicles();
            foreach (var vehicle in overdueVehicles)
            {
                ListViewItem item = new ListViewItem("Xe quá hạn"); // Overdue Vehicle
                item.SubItems.Add(vehicle.LicensePlate);
                item.SubItems.Add($"Thời gian vào: {vehicle.EntryTime:yyyy-MM-dd HH:mm}");
                item.ForeColor = Color.Red; // Màu đỏ cho xe quá hạn
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
    }
}
