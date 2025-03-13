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
using ParkingManagement.DAL.Database;
using System.Windows.Forms.DataVisualization.Charting;
using Mysqlx.Crud;

namespace ParkingManagement.GUI.Forms.statistics
{
    public partial class frmStatistics: Form
    {
        private StatisticsBLL statisticsBLL = new StatisticsBLL();

        private DatabaseHelper dbHelper;

        private Panel headerPanel;

        public frmStatistics()
        {

            InitializeComponent();
            LoadRevenueStatistics();
            LoadParkingCards();
            LoadVehicleTraffic();
            LoadParkingSlotStatus();
            LoadStatistics();
            LoadParkingSlotStatus();
            InitializeHeaderPanel();
            
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fromDate = dtpFromDate.Value.Date;
                DateTime toDate = dtpToDate.Value.Date;

                if (fromDate > toDate)
                {
                    MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Pass date parameters to all statistical methods
                LoadRevenueStatistics(fromDate, toDate);
                //LoadVehicleTraffic(fromDate, toDate);
                //LoadParkingCards(fromDate, toDate);
                //LoadParkingSlotStatus(fromDate, toDate);
                //LoadParkingStatistics(fromDate, toDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmStatistics_Load(object sender, EventArgs e)
        {
            LoadParkingStatistics();
            InitializeHeaderPanel();
            UpdateHeaderLabels();

            dataGridViewStatistics.RowPrePaint += (s, ev) =>
            {
                var cellValue = dataGridViewStatistics.Rows[ev.RowIndex].Cells[0].Value;
                if (cellValue != null && cellValue.ToString() == "Tổng")
                {
                    dataGridViewStatistics.Rows[ev.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
                    dataGridViewStatistics.Rows[ev.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                    dataGridViewStatistics.Rows[ev.RowIndex].DefaultCellStyle.Font = new Font(dataGridViewStatistics.Font, FontStyle.Bold);
                }
            };
        }

        /// <summary>
        /// hiển thị thống kê doanh thu theo thời gian dưới dạng biểu đồ cột.
        /// </summary>
        private void LoadRevenueStatistics()
        {
            LoadRevenueStatistics(System.DateTime.MinValue, System.DateTime.MaxValue);
        }
        private void LoadRevenueStatistics(DateTime fromDate, DateTime toDate)
        {
            if (chart2 == null)
            {
                MessageBox.Show("Lỗi: Biểu đồ chưa được khởi tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Xóa dữ liệu cũ
            chart2.Series.Clear();
            chart2.ChartAreas.Clear();
            chart2.Legends.Clear();

            // Thiết lập ChartArea
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea =
                new System.Windows.Forms.DataVisualization.Charting.ChartArea("RevenueChartArea")
                {
                    AxisX = { Title = "Ngày", MajorGrid = { Enabled = false } },
                    AxisY = { Title = "Doanh thu", MajorGrid = { LineColor = Color.LightGray } },
                    BackColor = Color.WhiteSmoke
                };
            chart2.ChartAreas.Add(chartArea);

            // Thiết lập Legend
            System.Windows.Forms.DataVisualization.Charting.Legend legend =
                new System.Windows.Forms.DataVisualization.Charting.Legend("Legend")
                {
                    Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom,
                    Alignment = StringAlignment.Center,
                    Font = new Font("Arial", 10, FontStyle.Bold)
                };
            chart2.Legends.Add(legend);

            // Lấy dữ liệu từ database
            DataTable dt = statisticsBLL.GetRevenueStatisticsByVehicleType(fromDate, toDate);

            if (dt == null || dt.Rows.Count == 0)
            {
                System.Windows.Forms.DataVisualization.Charting.Series emptySeries =
                    new System.Windows.Forms.DataVisualization.Charting.Series("Doanh thu")
                    {
                        ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column,
                        Color = Color.LightGray,
                        IsValueShownAsLabel = true
                    };
                emptySeries.Points.AddXY("Không có dữ liệu", 0);
                chart2.Series.Add(emptySeries);
                return;
            }

            // Tạo danh sách màu cho các loại phương tiện
            Color[] colors = new Color[]
            {
                Color.FromArgb(60, 120, 216),  // Blue
                Color.FromArgb(255, 87, 87),   // Red
                Color.FromArgb(87, 255, 87),   // Green
                Color.FromArgb(255, 215, 0),   // Gold
                Color.FromArgb(147, 112, 219)  // Purple
            };

            // Lấy danh sách loại phương tiện duy nhất
            var vehicleTypes = dt.AsEnumerable()
                .Select(row => row.Field<string>("vehicle_type"))
                .Distinct()
                .ToList();

            // Tạo Series cho từng loại phương tiện
            for (int i = 0; i < vehicleTypes.Count; i++)
            {
                string vehicleType = vehicleTypes[i];
                System.Windows.Forms.DataVisualization.Charting.Series series =
                    new System.Windows.Forms.DataVisualization.Charting.Series(vehicleType)
                    {
                        ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column,
                        Color = colors[i % colors.Length],
                        IsValueShownAsLabel = true,
                        Font = new Font("Arial", 10, FontStyle.Bold),
                        BorderWidth = 2,
                        Legend = "Legend"
                    };

                // Lọc dữ liệu cho loại phương tiện này
                var typeData = dt.AsEnumerable()
                    .Where(row => row.Field<string>("vehicle_type") == vehicleType);

                foreach (DataRow row in typeData)
                {
                    string date = row["date"].ToString();
                    double revenue = Convert.ToDouble(row["revenue"]);
                    series.Points.AddXY(date, revenue);
                }

                chart2.Series.Add(series);
            }

            // Điều chỉnh khoảng cách giữa các cột
            chart2.Series[0]["PointWidth"] = "0.8";
            chart2.Series[0]["BarLabelAlignment"] = "Center";
        }

        /// <summary>
        /// hiển thị thống kê lưu lượng xe ra vào bãi đỗ theo thời gian dưới dạng biểu đồ đường.
        /// </summary>
        private void LoadVehicleTraffic()
        {
            if (chart3 == null)
            {
                MessageBox.Show("Lỗi: Biểu đồ chưa được khởi tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Xóa dữ liệu cũ
            chart3.Series.Clear();
            chart3.ChartAreas.Clear();
            chart3.Legends.Clear();

            // Thiết lập vùng vẽ biểu đồ
            ChartArea chartArea = new ChartArea("VehicleTrafficArea");
            chartArea.AxisX.Title = "Ngày";
            chartArea.AxisY.Title = "Số lượt xe";
            chartArea.AxisX.MajorGrid.Enabled = false; // Tắt lưới trục X
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray; // Lưới trục Y màu nhạt
            chartArea.BackColor = Color.WhiteSmoke; // Màu nền sáng
            chart3.ChartAreas.Add(chartArea);

            // Thêm chú thích (Legend)
            Legend legend = new Legend("Legend");
            legend.Docking = Docking.Bottom;
            legend.Alignment = StringAlignment.Center;
            legend.Font = new Font("Arial", 10, FontStyle.Bold);
            chart3.Legends.Add(legend);

            // Lấy dữ liệu từ database
            DataTable dt = statisticsBLL.GetVehicleTraffic();

            if (dt == null || dt.Rows.Count == 0)
            {
                System.Windows.Forms.DataVisualization.Charting.Series emptySeries =
                    new System.Windows.Forms.DataVisualization.Charting.Series("Lượt xe")
                    {
                        ChartType = SeriesChartType.Line,
                        Color = Color.LightGray,
                        BorderWidth = 3,
                        IsValueShownAsLabel = true
                    };
                emptySeries.Points.AddXY("Không có dữ liệu", 0);
                chart3.Series.Add(emptySeries);
                return;
            }

            // Tạo Series cho biểu đồ đường
            System.Windows.Forms.DataVisualization.Charting.Series vehicleSeries =
                new System.Windows.Forms.DataVisualization.Charting.Series("Lượt xe")
                {
                    ChartType = SeriesChartType.Line,
                    Color = Color.FromArgb(255, 69, 0), // Màu cam hiện đại
                    BorderWidth = 3,
                    MarkerStyle = MarkerStyle.Circle, // Hiển thị dấu tròn tại điểm dữ liệu
                    MarkerSize = 8,
                    MarkerColor = Color.FromArgb(255, 69, 0),
                    IsValueShownAsLabel = true, // Hiển thị nhãn giá trị trên đường
                    Font = new Font("Arial", 10, FontStyle.Bold)
                };

            // Thêm dữ liệu vào biểu đồ
            foreach (DataRow row in dt.Rows)
            {
                string date = row["date"].ToString();
                int vehicleCount = Convert.ToInt32(row["vehicle_count"]);
                vehicleSeries.Points.AddXY(date, vehicleCount);
            }

            // Thêm Series vào Chart
            chart3.Series.Add(vehicleSeries);
        }
        /// <summary>
        /// hiển thị số lượng thẻ giữ xe đang hoạt động và không hoạt động dưới dạng biểu đồ tròn.
        /// </summary>
        private void LoadParkingCards()
        {
            if (chart1 == null)
            {
                MessageBox.Show("Lỗi: Biểu đồ chưa được khởi tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Xóa dữ liệu cũ
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.Legends.Clear();

            // Thiết lập ChartArea đơn giản, không có 3D
            var chartArea = new System.Windows.Forms.DataVisualization.Charting.ChartArea("PieChartArea");
            chart1.ChartAreas.Add(chartArea);

            // Tạo Legend (Chú thích) và đặt nó ở dưới cùng
            var legend = new System.Windows.Forms.DataVisualization.Charting.Legend("Legend");
            legend.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom; // Chuyển xuống dưới
            legend.Alignment = StringAlignment.Center;
            legend.Font = new Font("Arial", 10, FontStyle.Bold);
            chart1.Legends.Add(legend);

            // Lấy dữ liệu từ database
            DataTable dt = statisticsBLL.GetParkingCards();

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu thẻ giữ xe!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Tạo Series biểu đồ tròn
            var series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "ParkingCards",
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                Font = new Font("Arial", 12, FontStyle.Bold),
                LabelForeColor = Color.White
            };

            // Bảng màu Material Design hiện đại
            Color[] modernColors = { Color.FromArgb(41, 128, 185), // Blue
                              Color.FromArgb(231, 76, 60),  // Red
                              Color.FromArgb(243, 156, 18), // Orange
                              Color.FromArgb(39, 174, 96),  // Green
                              Color.FromArgb(142, 68, 173)  // Purple
                            };

            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                string status = row["status"].ToString();
                int count = Convert.ToInt32(row["count"]);

                var point = series.Points.Add(count);
                point.Label = count.ToString();
                point.LegendText = status;
                point.Color = modernColors[i % modernColors.Length];

                i++;
            }

            // Thêm Series vào Chart
            chart1.Series.Add(series);

            // Sự kiện hover: Làm nổi bật phần khi di chuột vào
            chart1.MouseMove += (s, e) =>
            {
                var result = chart1.HitTest(e.X, e.Y);
                foreach (var p in series.Points)
                {
                    p.CustomProperties = "PieDrawingStyle=SoftEdge"; // Mặc định không nổi bật
                }
                if (result.ChartElementType == System.Windows.Forms.DataVisualization.Charting.ChartElementType.DataPoint)
                {
                    result.Series.Points[result.PointIndex].CustomProperties = "PieDrawingStyle=Concave"; // Hiệu ứng sáng khi hover
                }
                chart1.Invalidate(); // Cập nhật lại biểu đồ
            };
        }

        /// <summary>
        /// hiển thị trạng thái bãi đỗ (số lượng chỗ đỗ trống và đã sử dụng) dưới dạng biểu đồ tròn.
        /// </summary>
        private void LoadParkingSlotStatus()
        {
            DataTable dt = statisticsBLL.GetParkingSlotStatus();
            chart4.Series.Clear(); // Xóa dữ liệu cũ
            chart4.Titles.Clear();

            // Thêm tiêu đề biểu đồ
            chart4.Titles.Add("Trạng thái bãi đỗ");

            // Tạo Series mới cho biểu đồ tròn
            System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie,
                IsValueShownAsLabel = true // Hiển thị nhãn giá trị trên biểu đồ
            };

            foreach (DataRow row in dt.Rows)
            {
                string slotType = row["slot_type"].ToString();
                int count = Convert.ToInt32(row["count"]);

                series.Points.AddXY(slotType, count); // Thêm dữ liệu vào Series
            }

            chart4.Series.Add(series); // Thêm Series vào Chart
        }
        private void LoadStatistics()
        {
            try
            {
                // Lấy dữ liệu thống kê
                DataTable revenueData = statisticsBLL.GetRevenueStatistics();

                // Lấy số xe đang đỗ
                DataTable parkedVehiclesData = statisticsBLL.GetCurrentParkedVehicles();
                int totalParkedVehicles = 0;
                foreach (DataRow row in parkedVehiclesData.Rows)
                {
                    totalParkedVehicles += Convert.ToInt32(row["total_vehicles"]);
                }

                // Lấy số chỗ trống
                DataTable emptySlotsData = statisticsBLL.GetEmptyParkingSlots();
                int totalEmptySlots = 0;
                foreach (DataRow row in emptySlotsData.Rows)
                {
                    totalEmptySlots += Convert.ToInt32(row["empty_slots"]);
                }


                int totalEntries = statisticsBLL.GetTotalEntries();
                int totalExits = statisticsBLL.GetTotalExits();
                int initialStock = statisticsBLL.GetInitialStock();
                int currentStock = statisticsBLL.GetCurrentStock();

                // Xử lý dữ liệu doanh thu
                decimal totalRevenue = 0;
                foreach (DataRow row in revenueData.Rows)
                {
                    totalRevenue += Convert.ToDecimal(row["revenue"]);
                }

                // Gán giá trị vào các Label
                lblRevenue.Text = $"{totalRevenue:C}";
                lblTotalEntries.Text = $"{totalEntries}";
                lblTotalExits.Text = $"{totalExits}";
                lblInitialStock.Text = $"{initialStock}";
                lblParkedVehicles.Text = $"{totalParkedVehicles}";
                lblEmptySlots.Text = $"{totalEmptySlots}";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InitializeHeaderPanel()
        {
            headerPanel = new Panel
            {
                Size = new Size(dataGridViewStatistics.Width, 30),
                Location = new Point(dataGridViewStatistics.Location.X, dataGridViewStatistics.Location.Y - 30),
                BackColor = Color.LightGray
            };
            this.Controls.Add(headerPanel);

            // Đăng ký sự kiện thay đổi kích thước cột
            dataGridViewStatistics.ColumnWidthChanged += (s, e) => UpdateHeaderLabels();
            dataGridViewStatistics.SizeChanged += (s, e) => UpdateHeaderLabels();
        }
        private void UpdateHeaderLabels()
        {
            if (dataGridViewStatistics.Columns.Count < 7) // Kiểm tra số lượng cột tối thiểu
            {
                return;
            }

            headerPanel.Controls.Clear();
            headerPanel.Width = dataGridViewStatistics.Width;

            int startX = dataGridViewStatistics.RowHeadersWidth; // Bắt đầu sau phần header row

            // Tính toán chiều rộng nhóm "Tổng quát"
            int totalStatsWidth = 0;
            for (int i = 1; i <= 6; i++) // Các cột từ 1 đến 6 thuộc nhóm "Tổng quát"
            {
                totalStatsWidth += dataGridViewStatistics.Columns[i].Width;
            }

            Label totalStatsLabel = new Label
            {
                Text = "TỔNG QUÁT",
                Size = new Size(totalStatsWidth, 30),
                Location = new Point(startX, 0),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.DarkOrange,
                ForeColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            // Cập nhật vị trí X cho nhóm tiếp theo
            startX += totalStatsWidth;
            // Tính toán chiều rộng nhóm "Vé tháng"
            int monthlyWidth = 0;
            for (int i = 7; i <= 11; i++) // Các cột từ 7 đến 11 thuộc nhóm "Vé tháng"
            {
                monthlyWidth += dataGridViewStatistics.Columns[i].Width;
            }


            Label monthlyLabel = new Label
            {
                Text = "VÉ THÁNG",
                Size = new Size(monthlyWidth, 30),
                Location = new Point(startX, 0),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Blue,
                ForeColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            startX += monthlyWidth;

            // Tính toán chiều rộng nhóm "Vãng lai"
            int guestWidth = 0;
            for (int i = 12; i <= 16; i++) // Các cột từ 12 đến 16 thuộc nhóm "Vãng lai"
            {
                guestWidth += dataGridViewStatistics.Columns[i].Width;
            }


            Label guestLabel = new Label
            {
                Text = "VÃNG LAI",
                Size = new Size(guestWidth, 30),
                Location = new Point(startX, 0),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Green,
                ForeColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            // Thêm các nhãn nhóm vào headerPanel
            headerPanel.Controls.Add(totalStatsLabel);
            headerPanel.Controls.Add(monthlyLabel);
            headerPanel.Controls.Add(guestLabel);
        }

        private void LoadParkingStatistics()
        {
            DataTable dt = statisticsBLL.GetParkingStatistics();
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để hiển thị!");
                return;
            }

            dataGridViewStatistics.DataSource = dt;
            dataGridViewStatistics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStatistics.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewStatistics.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Định dạng số tiền
            if (dataGridViewStatistics.Columns["Doanh Thu"] != null)
            {
                dataGridViewStatistics.Columns["Doanh Thu"].DefaultCellStyle.Format = "N0";
            }

            // Cập nhật lại tiêu đề nhóm
            UpdateHeaderLabels();
        }


    }
}
