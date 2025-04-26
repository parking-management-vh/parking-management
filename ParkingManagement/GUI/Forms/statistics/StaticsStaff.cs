using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;
using ParkingManagement.Models;

namespace ParkingManagement.GUI.Forms.statistics
{
    public partial class StaticsStaff : Form
    {
        // MySQL connection string (adjust accordingly)
        private string connectionString = "server=localhost;port=3306;database=railway;uid=root;pwd=123456;SslMode=none;AllowPublicKeyRetrieval=True;";

        public StaticsStaff()
        {
            InitializeComponent();
        }

        // Load data when the form is loaded
        private void StaticsStaff_Load(object sender, EventArgs e)
        {
          
            // Pre-load with the current month and year
            dateTimePicker.Value = DateTime.Now;

            // Fetch data based on the current date
            LoadPaymentData(dateTimePicker.Value.Year, dateTimePicker.Value.Month);
        }

        // Function to load data from the database
        private void LoadPaymentData(int year, int month)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                SELECT staff_code, 
                       SUM(total_time) AS total_time, 
                       SUM(total_price) AS total_price, 
                       COUNT(id) AS total_receipts
                FROM payment_receipt 
                WHERE YEAR(payment_date) = @Year 
                AND MONTH(payment_date) = @Month 
                AND payment_status = 'Hoàn tất' 
                GROUP BY staff_code";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Year", year);
                    cmd.Parameters.AddWithValue("@Month", month);

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Bind data to DataGridView
                    dataGridView.DataSource = dataTable;

                    // Set user-friendly column headers
                    dataGridView.Columns[0].HeaderText = "Mã nhân viên";
                    dataGridView.Columns[1].HeaderText = "Tổng thời gian gửi xe (phút)";
                    dataGridView.Columns[2].HeaderText = "Tổng số tiền thanh toán (VND)";
                    dataGridView.Columns[3].HeaderText = "Số biên lai thanh toán";

                    // Add calculated salary column
                    DataColumn salaryColumn = new DataColumn("Lương", typeof(decimal));
                    dataTable.Columns.Add(salaryColumn);

                    // Add note column
                    DataColumn noteColumn = new DataColumn("Ghi chú", typeof(string));
                    dataTable.Columns.Add(noteColumn);

                    // Calculate salary for each staff
                    foreach (DataRow row in dataTable.Rows)
                    {
                        decimal totalPrice = Convert.ToDecimal(row["total_price"]);
                        decimal totalTime = Convert.ToDecimal(row["total_time"]);
                        int totalReceipts = Convert.ToInt32(row["total_receipts"]);

                        // Example of salary calculation: Basic salary + commission
                        decimal basicSalary = 5000000; // Base salary for staff
                        decimal commissionRate = 0.05m; // 5% commission based on total payment
                        decimal commission = totalPrice * commissionRate;

                        // Check if no cars were scanned (total time is 0)
                        if (totalTime == 0)
                        {
                            decimal penalty = 500000; // Penalty if no cars were scanned
                            commission -= penalty;  // Deduct the penalty

                            row["Ghi chú"] = "Bị trừ lương (Không quẹt xe)";
                        }
                        else
                        {
                            row["Ghi chú"] = "Lương đầy đủ";
                        }

                        // Calculate the total salary
                        decimal totalSalary = basicSalary + commission;

                        // Ensure salary is not negative
                        if (totalSalary < 0)
                        {
                            totalSalary = 0;
                        }

                        row["Lương"] = totalSalary;
                    }

                    // Format currency columns
                    dataGridView.Columns["total_price"].DefaultCellStyle.Format = "#,##0'đ'";
                    dataGridView.Columns["Lương"].DefaultCellStyle.Format = "#,##0'đ'";

                    DrawChart2(dataTable);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DrawChart2(DataTable dataTable)
        {
            // Clear existing series
            chart2.Series.Clear();
            chart2.ChartAreas.Clear();
            chart2.Titles.Clear();

            // Create chart area
            ChartArea chartArea = new ChartArea("ChartArea2");
            chart2.ChartAreas.Add(chartArea);

            // Create series
            Series series = new Series("Số lượng biên lai")
            {
                ChartType = SeriesChartType.Column,
                XValueMember = "staff_code",
                YValueMembers = "total_receipts"
            };

            chart2.Series.Add(series);

            // Bind data
            chart2.DataSource = dataTable;
            chart2.DataBind();

            // Chart Title
            chart2.Titles.Add("Tần suất nhân viên theo số biên lai trong tháng");

            // Customize axis
            chart2.ChartAreas[0].AxisX.Title = "Mã nhân viên";
            chart2.ChartAreas[0].AxisY.Title = "Số biên lai";

            chart2.ChartAreas[0].AxisX.Interval = 1; // mỗi nhân viên 1 cột
        }
        // Button click event to filter by month and year
        private void btnFilter_Click(object sender, EventArgs e)
        {
            // Filter data based on selected month and year
            int selectedYear = dateTimePicker.Value.Year;
            int selectedMonth = dateTimePicker.Value.Month;
            LoadPaymentData(selectedYear, selectedMonth);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Create SaveFileDialog for Excel export
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Chọn nơi lưu file Excel";
                saveFileDialog.FileName = "BaoCaoBangLuong.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = saveFileDialog.FileName;

                    var excelApp = new Microsoft.Office.Interop.Excel.Application();
                    var workbook = excelApp.Workbooks.Add(Type.Missing);
                    Microsoft.Office.Interop.Excel._Worksheet worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.ActiveSheet;
                    worksheet.Name = "Báo Cáo Lương";

                    int totalColumns = dataGridView.Columns.Count;

                    // ===== Thêm tiêu đề =====
                    Microsoft.Office.Interop.Excel.Range titleRange = worksheet.Range["A1", worksheet.Cells[1, totalColumns]];
                    titleRange.Merge();
                    titleRange.Value = "BẢNG LƯƠNG NHÂN VIÊN";
                    titleRange.Font.Size = 18;
                    titleRange.Font.Bold = true;
                    titleRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                    // ===== Thêm ngày xuất báo cáo =====
                    Microsoft.Office.Interop.Excel.Range dateRange = worksheet.Range["A2", worksheet.Cells[2, totalColumns]];
                    dateRange.Merge();
                    dateRange.Value = "Ngày xuất báo cáo: " + DateTime.Now.ToString("dd/MM/yyyy");
                    dateRange.Font.Size = 12;
                    dateRange.Font.Italic = true;
                    dateRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                    // ===== Thêm tiêu đề cột =====
                    for (int i = 1; i <= dataGridView.Columns.Count; i++)
                    {
                        worksheet.Cells[4, i] = dataGridView.Columns[i - 1].HeaderText;
                    }

                    // ===== Thêm dữ liệu =====
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView.Columns.Count; j++)
                        {
                            var value = dataGridView.Rows[i].Cells[j].Value;
                            worksheet.Cells[i + 5, j + 1] = value != null ? value.ToString() : "";
                        }
                    }

                    // ===== Định dạng bảng =====
                    Microsoft.Office.Interop.Excel.Range dataRange = worksheet.Range["A4", worksheet.Cells[dataGridView.Rows.Count + 4, totalColumns]];
                    dataRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                    dataRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                    worksheet.Columns.AutoFit();

                    // Save the Excel file
                    workbook.SaveAs(filePath);
                    workbook.Close();
                    excelApp.Quit();

                    MessageBox.Show("Xuất file Excel thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi xuất Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
