using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;
using ExcelLicenseContext = OfficeOpenXml.LicenseContext;
using OfficeOpenXml.Style;
using System.Data.SqlClient;

namespace ParkingManagement.GUI.Forms
{
    public partial class frmTicketPrice: Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
       
        private string currentSearchKeyword = "";

        private string selectedId = null;

        public frmTicketPrice()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// Load form và khởi tạo các cài đặt mặc định
        /// </summary>
        private void frmTicketPrice_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            dgvTicketPrice.ScrollBars = ScrollBars.Both;

            dgvTicketPrice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            btnDelete.Enabled = false;

            LoadVehicleTypes();

            LoadTicketPrice();

        }

        /// <summary>
        /// Tải danh sách loại phương tiện vào combobox
        /// </summary>
        private void LoadVehicleTypes()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id, vehicle_type_name FROM vehicle_type";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            cmbVehicleType.DataSource = dt;
                            cmbVehicleType.DisplayMember = "vehicle_type_name";
                            cmbVehicleType.ValueMember = "id";
                            cmbVehicleType.SelectedIndex = -1;


                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách loại xe: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Tải danh sách giá vé vào DataGridView
        /// </summary>
        private void LoadTicketPrice()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
/*                    string query = @"
                        SELECT tp.id, vt.vehicle_type_name, tp.price, tp.is_month, tp.description, tp.created_at, tp.updated_at 
                        FROM ticket_price tp
                        JOIN vehicle_type vt ON tp.vehicle_type_id = vt.id";*/

                    string query = @"
                        SELECT tp.id, vt.id AS vehicle_type_id, vt.vehicle_type_name, 
                               tp.price, tp.is_month, tp.description, tp.created_at, tp.updated_at 
                        FROM ticket_price tp
                        JOIN vehicle_type vt ON tp.vehicle_type_id = vt.id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();

                            adapter.Fill(dt);

                            dgvTicketPrice.DataSource = dt;

                            dgvTicketPrice.ScrollBars = ScrollBars.Both;

                            dgvTicketPrice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                            dgvTicketPrice.Columns["vehicle_type_id"].Visible = false;

                            foreach (DataGridViewColumn column in dgvTicketPrice.Columns)
                            {
                                column.SortMode = DataGridViewColumnSortMode.Automatic;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Thêm, sửa, xóa,làm mới giá vé
        /// </summary>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cmbVehicleType.SelectedValue == null || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal price;
            if (!decimal.TryParse(txtPrice.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("vi-VN"), out price))
            {
                MessageBox.Show("Giá vé không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isMonth = rdMonthlyPass.Checked;
            string description = txtDescriptionn.Text;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO ticket_price (id, vehicle_type_id, price, is_month, description, created_at) VALUES (UUID(), @vehicleTypeId, @price, @isMonth, @description, NOW())";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@vehicleTypeId", cmbVehicleType.SelectedValue);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@isMonth", isMonth);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.ExecuteNonQuery();
                    }


                }

                MessageBox.Show("Thêm giá vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTicketPrice();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm giá vé: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedId))
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mục này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM ticket_price WHERE id = @id";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", selectedId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTicketPrice();
                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtPrice.Text = "";
            txtDescriptionn.Text = "";

            rdMonthlyPass.Checked = false;
            rdHourlyPass.Checked = true;

            cmbVehicleType.SelectedIndex = -1;
            cmbVehicleType.SelectedItem = null;

            selectedId = null;
            btnDelete.Enabled = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvTicketPrice.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một vé để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = dgvTicketPrice.SelectedRows[0].Cells["id"].Value.ToString();


            string priceText = txtPrice.Text.Replace(",", "").Replace(".", ""); // Loại bỏ dấu ngăn cách ngàn
            if (!decimal.TryParse(priceText, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal price))
            {
                MessageBox.Show("Giá vé không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isMonth = rdMonthlyPass.Checked;
            string description = txtDescriptionn.Text;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE ticket_price SET price = @price, is_month = @isMonth, description = @description, updated_at = NOW() WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@isMonth", isMonth);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Cập nhật giá vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTicketPrice();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật giá vé: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ResetForm()
        {
            txtPrice.Text = "";
            txtDescriptionn.Text = "";
            rdMonthlyPass.Checked = false;
            rdHourlyPass.Checked = true; // Mặc định là vé theo giờ
            cmbVehicleType.SelectedIndex = -1; // Bỏ chọn combobox
        }

        /// <summary>
        /// Xử lý sự kiện click trên DataGridView để chọn giá vé
        /// </summary>
        private void dgvTicketPrice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng click vào khoảng trắng hoặc tiêu đề cột thì không làm gì
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            // Đặt lại màu nền của tất cả các dòng về màu mặc định
            foreach (DataGridViewRow r in dgvTicketPrice.Rows)
            {
                r.DefaultCellStyle.BackColor = dgvTicketPrice.DefaultCellStyle.BackColor;
            }
            DataGridViewRow row = dgvTicketPrice.Rows[e.RowIndex];

            dgvTicketPrice.ClearSelection();
            row.Selected = true;
            row.DefaultCellStyle.BackColor = Color.LightBlue; // Chỉ đổi màu dòng đang chọn

            // ✅ Lấy dữ liệu từ bảng đưa lên combobox & textbox
            cmbVehicleType.SelectedValue = row.Cells["vehicle_type_id"].Value ?? DBNull.Value;
            txtPrice.Text = row.Cells["price"].Value?.ToString() ?? "";
            txtDescriptionn.Text = row.Cells["description"].Value?.ToString() ?? "";

            bool isMonth = row.Cells["is_month"].Value != DBNull.Value && Convert.ToBoolean(row.Cells["is_month"].Value);
            rdMonthlyPass.Checked = isMonth;
            rdHourlyPass.Checked = !isMonth;

            selectedId = row.Cells["id"].Value?.ToString() ?? "";

            btnDelete.Enabled = true;
        }
        

        private void dgvTicketPrice_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Tắt auto resize để tránh lỗi hiển thị
            dgvTicketPrice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Cố định kích thước cột ID (nếu tồn tại)
            if (dgvTicketPrice.Columns["id"] != null)
            {
                dgvTicketPrice.Columns["id"].Width = 250;
                dgvTicketPrice.Columns["id"].Resizable = DataGridViewTriState.False;  // Không cho phép thay đổi kích thước
            }

            // Hiển thị ScrollBar nếu nội dung dài
            dgvTicketPrice.ScrollBars = ScrollBars.Both;

            // Không cho phép tự động giãn hàng
            dgvTicketPrice.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void btnSearchh_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchh.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool found = false; // Biến kiểm tra có tìm thấy kết quả hay không

            foreach (DataGridViewRow row in dgvTicketPrice.Rows) // Kiểm tra trong bảng ticket_price
            {
                if (row.Cells["id"].Value != null && 
                    row.Cells["vehicle_type_name"].Value != null &&
                    row.Cells["price"].Value != null &&
                    row.Cells["description"].Value != null)
                {
                    string id = row.Cells["id"].Value.ToString().ToLower();
                    string vehicleType = row.Cells["vehicle_type_name"].Value.ToString().ToLower();
                    string price = row.Cells["price"].Value.ToString().ToLower();
                    string description = row.Cells["description"].Value.ToString().ToLower();

                    if (id.Contains(searchText) || price.Contains(searchText) || description.Contains(searchText))
                    {
                        row.Selected = true;
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                        dgvTicketPrice.FirstDisplayedScrollingRowIndex = row.Index;
                        found = true;
                    }
                    else
                    {
                        row.Selected = false;
                        row.DefaultCellStyle.BackColor = Color.White;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }

            if (!found)
            {
                MessageBox.Show("Không tìm thấy kết quả phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnCancell_Click(object sender, EventArgs e)
        {
            txtSearchh.Text = "";
            currentSearchKeyword = "";
            LoadTicketPrice();
            dgvTicketPrice.Refresh();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                // Đặt chế độ giấy phép
                ExcelPackage.LicenseContext = ExcelLicenseContext.NonCommercial;

                using (ExcelPackage excel = new ExcelPackage())
                {
                    var worksheet = excel.Workbook.Worksheets.Add("Sheet1");

                    // Ghi thông tin ngày xuất file
                    worksheet.Cells["A1"].Value = "Báo cáo danh sách loại xe";
                    worksheet.Cells["A2"].Value = "Ngày xuất: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                    // Định dạng tiêu đề báo cáo
                    worksheet.Cells["A1:B1"].Merge = true; // Gộp ô tiêu đề
                    worksheet.Cells["A1"].Style.Font.Bold = true;
                    worksheet.Cells["A1"].Style.Font.Size = 14;
                    worksheet.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    // Xuất tiêu đề cột (bắt đầu từ hàng 4 để tránh trùng với tiêu đề)
                    for (int i = 0; i < dgvTicketPrice.Columns.Count; i++)
                    {
                        worksheet.Cells[4, i + 1].Value = dgvTicketPrice.Columns[i].HeaderText;
                        worksheet.Cells[4, i + 1].Style.Font.Bold = true;
                        worksheet.Cells[4, i + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[4, i + 1].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                        worksheet.Cells[4, i + 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    }

                    // Xuất dữ liệu từ DataGridView (bắt đầu từ hàng 5)
                    for (int i = 0; i < dgvTicketPrice.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvTicketPrice.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 5, j + 1].Value = dgvTicketPrice.Rows[i].Cells[j].Value?.ToString();
                        }
                    }

                    // Căn chỉnh độ rộng cột tự động
                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                    // Hiển thị hộp thoại lưu file
                    SaveFileDialog saveDialog = new SaveFileDialog
                    {
                        Filter = "Excel Files|*.xlsx",
                        Title = "Lưu file Excel",
                        FileName = "DanhSachGiaVeXe.xlsx"
                    };

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllBytes(saveDialog.FileName, excel.GetAsByteArray());
                        MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openDialog = new OpenFileDialog
                {
                    Filter = "Excel Files|*.xlsx;*.xls",
                    Title = "Chọn file Excel"
                };

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                    using (var package = new ExcelPackage(new FileInfo(openDialog.FileName)))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Lấy sheet đầu tiên
                        DataTable dt = new DataTable();

                        // Đọc tiêu đề cột
                        for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                        {
                            dt.Columns.Add(worksheet.Cells[1, col].Text);
                        }

                        // Đọc dữ liệu
                        for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                        {
                            DataRow newRow = dt.NewRow();
                            for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                            {
                                newRow[col - 1] = worksheet.Cells[row, col].Text;
                            }
                            dt.Rows.Add(newRow);
                        }

                        // Kiểm tra dữ liệu có được đọc hay không
                        if (dt.Rows.Count > 0)
                        {
                            // Convert is_month column to boolean
                            foreach (DataRow row in dt.Rows)
                            {
                                if (dt.Columns.Contains("is_month"))
                                {
                                    string isMonthValue = row["is_month"].ToString().Trim().ToLower();
                                    if (isMonthValue == "true" || isMonthValue == "1")
                                    {
                                        row["is_month"] = true;
                                    }
                                    else if (isMonthValue == "false" || isMonthValue == "0")
                                    {
                                        row["is_month"] = false;
                                    }
                                    else
                                    {
                                        row["is_month"] = DBNull.Value; // or handle invalid value as needed
                                    }
                                }
                            }

                            dgvTicketPrice.DataSource = dt;
                            MessageBox.Show("Nhập file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("File Excel không có dữ liệu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi nhập file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSaveToDatabase_Click(object sender, EventArgs e)
        {
            if (dgvTicketPrice.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để lưu vào database!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    foreach (DataGridViewRow row in dgvTicketPrice.Rows)
                    {
                        if (row.IsNewRow) continue; // Bỏ qua hàng trống cuối cùng của DataGridView

                        // Kiểm tra ID, nếu trống thì tạo mới
                        object idObj = row.Cells["id"].Value;
                        string id = idObj != null && !string.IsNullOrWhiteSpace(idObj.ToString())
                            ? idObj.ToString().Trim()
                            : Guid.NewGuid().ToString(); // Tạo ID mới nếu trống

                        object priceObj = row.Cells["price"].Value;
                        object descriptionObj = row.Cells["description"].Value;
                        object isMonthObj = row.Cells["is_month"].Value;
                        object vehicleTypeIdObj = row.Cells["vehicle_type_id"].Value;

                        // Kiểm tra dữ liệu hợp lệ
                        if (priceObj == null || descriptionObj == null)
                        {
                            MessageBox.Show("Dữ liệu không hợp lệ ở một số hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Xử lý giá vé
                        string priceText = priceObj.ToString().Trim().Replace(",", "").Replace(".", "");
                        if (!decimal.TryParse(priceText, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal price))
                        {
                            MessageBox.Show($"Giá vé không hợp lệ ở ID: {id}!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string description = descriptionObj.ToString().Trim();
                        bool isMonth = isMonthObj != null && (isMonthObj.ToString().ToLower() == "true" || isMonthObj.ToString() == "1");

                        // Kiểm tra vehicle_type_id, nếu trống thì đặt giá trị mặc định là 1
                        string vehicleTypeId = vehicleTypeIdObj != null && !string.IsNullOrWhiteSpace(vehicleTypeIdObj.ToString())
                            ? vehicleTypeIdObj.ToString().Trim()
                            : "1"; // Giá trị mặc định là 1

                        // SQL query với kiểm tra `ON DUPLICATE KEY UPDATE`
                        string query = @"INSERT INTO ticket_price (id, price, is_month, description, vehicle_type_id, updated_at)
                                         VALUES (@id, @price, @isMonth, @description, @vehicleTypeId, NOW())
                                         ON DUPLICATE KEY UPDATE 
                                         price = @price, is_month = @isMonth, description = @description, vehicle_type_id = @vehicleTypeId, updated_at = NOW()";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.Parameters.AddWithValue("@price", price);
                            cmd.Parameters.AddWithValue("@isMonth", isMonth);
                            cmd.Parameters.AddWithValue("@description", description);
                            cmd.Parameters.AddWithValue("@vehicleTypeId", vehicleTypeId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTicketPrice(); // Refresh DataGridView
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show("Lỗi SQL: " + sqlEx.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
