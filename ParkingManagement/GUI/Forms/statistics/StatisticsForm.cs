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
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using LiveCharts.Definitions.Charts;

namespace ParkingManagement.GUI.Forms.statistics
{
    public partial class StatisticsForm: Form
    {
        private StatisticsBLL statisticsBLL = new StatisticsBLL();

        public StatisticsForm()
        {
            InitializeComponent();
            LoadRevenueStatistics();
            LoadVehicleTraffic();
            LoadParkingSlotStatus();
            LoadParkingCards();
            LoadEmployeeAndCustomerReport();


        }

        /// <summary>
        /// hiển thị thống kê doanh thu theo thời gian dưới dạng biểu đồ cột.
        /// </summary>
        private void LoadRevenueStatistics()
        {
            DataTable dt = statisticsBLL.GetRevenueStatistics();
            cartesianChart.Series.Clear();

            if (dt == null || dt.Rows.Count == 0)
            {
                cartesianChart.Series.Add(new ColumnSeries
                {
                    Title = "Doanh thu",
                    Values = new ChartValues<double> { 0 },
                    DataLabels = true // Hiển thị nhãn dữ liệu
                });

                cartesianChart.AxisX.Clear();
                cartesianChart.AxisX.Add(new Axis
                {
                    Labels = new List<string> { "Không có dữ liệu" }
                });

                return;
            }

            ChartValues<double> values = new ChartValues<double>();
            List<string> labels = new List<string>();

            foreach (DataRow row in dt.Rows)
            {
                labels.Add(row["date"].ToString());
                values.Add(Convert.ToDouble(row["revenue"]));
            }

            cartesianChart.Series.Add(new ColumnSeries
            {
                Title = "Doanh thu",
                Values = values,
                Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(60, 120, 216)),
                DataLabels = true, // Hiển thị nhãn dữ liệu trên cột
                LabelPoint = point => point.Y.ToString("N0") // Định dạng số
            });

            cartesianChart.AxisX.Clear();
            cartesianChart.AxisX.Add(new Axis { Labels = labels });
        }

        /// <summary>
        /// hiển thị thống kê lưu lượng xe ra vào bãi đỗ theo thời gian dưới dạng biểu đồ đường.
        /// </summary>
        private void LoadVehicleTraffic()
        {
            DataTable dt = statisticsBLL.GetVehicleTraffic();
            cartesianChart1.Series.Clear();

            if (dt == null || dt.Rows.Count == 0)
            {
                cartesianChart1.Series.Add(new LineSeries
                {
                    Title = "Lượt xe",
                    Values = new ChartValues<int> { 0 },
                    DataLabels = true // Hiển thị nhãn dữ liệu
                });

                cartesianChart1.AxisX.Clear();
                cartesianChart1.AxisX.Add(new Axis
                {
                    Labels = new List<string> { "Không có dữ liệu" }
                });

                return;
            }

            ChartValues<int> values = new ChartValues<int>();
            List<string> labels = new List<string>();

            foreach (DataRow row in dt.Rows)
            {
                labels.Add(row["date"].ToString());
                values.Add(Convert.ToInt32(row["vehicle_count"]));
            }

            cartesianChart1.Series.Add(new LineSeries
            {
                Title = "Lượt xe",
                Values = values,
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 69, 0)),
                DataLabels = true, // Hiển thị nhãn dữ liệu trên điểm
                LabelPoint = point => point.Y.ToString() // Hiển thị giá trị số
            });

            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisX.Add(new Axis { Labels = labels });
        }


        /// <summary>
        /// hiển thị trạng thái bãi đỗ (số lượng chỗ đỗ trống và đã sử dụng) dưới dạng biểu đồ tròn.
        /// </summary>
        private void LoadParkingSlotStatus()
        {
            DataTable dt = statisticsBLL.GetParkingSlotStatus();
            pieChart.Series.Clear();

            foreach (DataRow row in dt.Rows)
            {
                pieChart.Series.Add(new PieSeries
                {
                    Title = row["slot_type"].ToString(),
                    Values = new ChartValues<int> { Convert.ToInt32(row["count"]) },
                    DataLabels = true,
                    //LabelPoint = point => $"{point.Title}: {point.Y}" // Hiển thị tên và giá trị
                });
            }
        }

        /// <summary>
        /// hiển thị số lượng thẻ giữ xe đang hoạt động và không hoạt động dưới dạng biểu đồ tròn.
        /// </summary>
        private void LoadParkingCards()
            {
                DataTable dt = statisticsBLL.GetParkingCards();
                pieChart1.Series.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    pieChart1.Series.Add(new PieSeries
                    {
                        Title = row["status"].ToString(),
                        Values = new ChartValues<int> { Convert.ToInt32(row["count"]) },
                        DataLabels = true
                    });
                }
            }

        /// <summary>
        /// Tải và hiển thị báo cáo nhân sự và khách hàng theo vai trò dưới dạng biểu đồ tròn.
        /// </summary>
        private void LoadEmployeeAndCustomerReport()
        {
            DataTable dt = statisticsBLL.GetEmployeeAndCustomerReport();
            pieChart2.Series.Clear();

            foreach (DataRow row in dt.Rows)
            {
                pieChart2.Series.Add(new PieSeries
                {
                    Title = row["role_id"].ToString(),
                    Values = new ChartValues<int> { Convert.ToInt32(row["count"]) },
                    DataLabels = true
                });
            }
        }
    }
}
