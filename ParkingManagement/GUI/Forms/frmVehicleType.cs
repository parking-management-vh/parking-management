using Krypton.Toolkit;
using MySql.Data.MySqlClient;
using Mysqlx.Session;
using ParkingManagement.BLL;
using ParkingManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;
using ExcelLicenseContext = OfficeOpenXml.LicenseContext;
using OfficeOpenXml.Style;
using System.Globalization;

namespace ParkingManagement.GUI.Forms
{

    public partial class frmVehicleType: Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

        private string selectedId;

        /// <summary>
        /// Khởi tạo form VehicleType.
        /// </summary>
        public frmVehicleType()
        {
            InitializeComponent();
            //this.TopLevel = false;
            //this.FormBorderStyle = FormBorderStyle.None;
           // this.Dock = DockStyle.Fill;

            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.txtDescription.Enter += new System.EventHandler(this.txtDescription_Enter);
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
        }

        /// <summary>
        /// Load dữ liệu khi form được mở.
        /// </summary>
        private void frmVehicleType_Load(object sender, EventArgs e)
        {
           ///this.WindowState = FormWindowState.Maximized;

            kryptonDgvVehicleType.ScrollBars = ScrollBars.Both;

            kryptonDgvVehicleType.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            txtSearch.KeyPress += txtSearch_KeyPress;

            kryptonDgvVehicleType.ClearSelection();

            LoadVehicleTypes();

            SetPlaceholder();
        }

        /// <summary>
        /// Tải dữ liệu loại xe từ database và hiển thị lên DataGridView.
        /// </summary>
        private void LoadVehicleTypes()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id, vehicle_type_name, description, created_at, updated_at FROM vehicle_type";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();

                            adapter.Fill(dt);

                            kryptonDgvVehicleType.DataSource = dt;

                            kryptonDgvVehicleType.ScrollBars = ScrollBars.Both;

                            kryptonDgvVehicleType.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                            foreach (DataGridViewColumn column in kryptonDgvVehicleType.Columns)
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


        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cmbVehicle.SelectedItem == null || string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Vui lòng chọn loại xe và nhập mô tả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO vehicle_type (vehicle_type_name, description, created_at) VALUES (@name, @desc, NOW())";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", cmbVehicle.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Thêm loại xe thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                cmbVehicle.SelectedIndex = -1;

                txtDescription.Text = "";

                cmbVehicle.Focus();

                LoadVehicleTypes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedId))
            {
                MessageBox.Show("Vui lòng chọn dòng cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbVehicle.SelectedItem == null || string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Vui lòng chọn loại xe và nhập mô tả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                                    UPDATE vehicle_type 
                                    SET vehicle_type_name = @name, 
                                        description = @desc, 
                                        updated_at = NOW() 
                                    WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", cmbVehicle.Text);
                        cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                        cmd.Parameters.AddWithValue("@id", selectedId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

             /*   // 🔥 Reset dữ liệu sau khi lưu
                cmbVehicle.SelectedIndex = -1;
                txtDescription.Clear();
                selectedId = null;
                kryptonDgvVehicleType.ScrollBars = ScrollBars.Both;
                kryptonDgvVehicleType.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;*/

                LoadVehicleTypes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sự kiện khi click vào một ô trong DataGridView.
        /// </summary>
        private void kryptonDgvVehicleType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng click vào khoảng trắng hoặc tiêu đề cột thì không làm gì
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            // Đặt lại màu nền của tất cả các dòng về màu mặc định
            foreach (DataGridViewRow row in kryptonDgvVehicleType.Rows)
            {
                row.DefaultCellStyle.BackColor = kryptonDgvVehicleType.DefaultCellStyle.BackColor;
            }

            DataGridViewRow selectedRow = kryptonDgvVehicleType.Rows[e.RowIndex];

            kryptonDgvVehicleType.ClearSelection();
            selectedRow.Selected = true;
            selectedRow.DefaultCellStyle.BackColor = Color.LightBlue; // Chỉ đổi màu dòng đang chọn

            // ✅ Lấy dữ liệu từ bảng đưa lên combobox & textbox
            cmbVehicle.Text = selectedRow.Cells["vehicle_type_name"].Value?.ToString() ?? "";
            txtDescription.Text = selectedRow.Cells["description"].Value?.ToString() ?? "";

            selectedId = selectedRow.Cells["id"].Value?.ToString() ?? "";

            btnDelete.Enabled = true;
        }

        private void kryptonDgvVehicleType_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Tắt auto resize
            kryptonDgvVehicleType.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Cố định kích thước cột ID
            if (kryptonDgvVehicleType.Columns["id"] != null)
            {
                kryptonDgvVehicleType.Columns["id"].Width = 250;
                kryptonDgvVehicleType.Columns["id"].Resizable = DataGridViewTriState.False;  // Không cho phép thay đổi kích thước
            }

            // Hiển thị ScrollBar nếu nội dung dài
            kryptonDgvVehicleType.ScrollBars = ScrollBars.Both;

            // Không cho phép giãn hàng
            kryptonDgvVehicleType.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                      
        }
        /// <summary>
        /// Sự kiện khi chọn một dòng trong DataGridView
        /// </summary>
        private void kryptonDgvVehicleType_SelectionChanged(object sender, EventArgs e)
        {
            if (kryptonDgvVehicleType.SelectedRows.Count > 0)
            {
                var selectedRow = kryptonDgvVehicleType.SelectedRows[0];
                if (selectedRow.Cells["id"].Value != null)
                {
                    selectedId = selectedRow.Cells["id"].Value.ToString();
                    btnDelete.Enabled = true; // Hiện nút Delete khi có dòng được chọn
                }
                else
                {
                    selectedId = null;
                    btnDelete.Enabled = false; // Ẩn nút Delete khi không có dòng nào được chọn
                }
            }
            else
            {
                selectedId = null;
                btnDelete.Enabled = false; // Ẩn nút Delete khi không có dòng nào được chọn
            }
        }

        /// <summary>
        /// Xử lý sự kiện xóa dữ liệu khi bấm nút Delete.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedId))
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận xóa",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM vehicle_type WHERE id = @id";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", selectedId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadVehicleTypes();
                   
                    selectedId = null;

                    cmbVehicle.SelectedIndex = -1;

                    txtDescription.Clear();

           

                    btnDelete.Enabled = false; // Ẩn nút Delete sau khi xóa
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Đặt placeholder cho textbox mô tả.
        /// </summary>
        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                txtDescription.Text = "Nhập mô tả loại xe...";
                txtDescription.ForeColor = Color.Gray;
            }
        }
        /// <summary>
        /// Sự kiện khi textbox mô tả được focus.
        /// </summary>
        private void txtDescription_Enter(object sender, EventArgs e)
        {
            if (txtDescription.Text == "Nhập mô tả loại xe...")
            {
                txtDescription.Text = "";
                txtDescription.ForeColor = Color.Black;
            }
        }

        /// <summary>
        /// Sự kiện khi textbox mô tả bị mất focus.
        /// </summary>
        private void txtDescription_Leave(object sender, EventArgs e)
        {
            SetPlaceholder();
        }
        /// <summary>
        /// Reset form về trạng thái ban đầu.
        /// </summary>
        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadVehicleTypes();
            kryptonDgvVehicleType.ClearSelection();
            cmbVehicle.SelectedIndex = -1;
            txtDescription.Clear();
            selectedId = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool found = false; // Biến kiểm tra có tìm thấy hay không

            foreach (DataGridViewRow row in kryptonDgvVehicleType.Rows)
            {
                if (row.Cells["id"].Value != null &&
                    row.Cells["vehicle_type_name"].Value != null &&
                    row.Cells["description"].Value != null)
                {
                    string id = row.Cells["id"].Value.ToString().ToLower();
                    string name = row.Cells["vehicle_type_name"].Value.ToString().ToLower();
                    string description = row.Cells["description"].Value.ToString().ToLower();

                    if (id.Contains(searchText) || name.Contains(searchText) || description.Contains(searchText))
                    {
                        row.Selected = true;
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                        kryptonDgvVehicleType.FirstDisplayedScrollingRowIndex = row.Index;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();

            foreach (DataGridViewRow row in kryptonDgvVehicleType.Rows)
            {
                row.Selected = false;
                row.DefaultCellStyle.BackColor = Color.White; // Trả lại màu nền ban đầu
                row.DefaultCellStyle.ForeColor = Color.Black;
            }
        }


        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch.PerformClick();
                e.Handled = true; // Ngăn chặn âm thanh "beep"
            }
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
                    for (int i = 0; i < kryptonDgvVehicleType.Columns.Count; i++)
                    {
                        worksheet.Cells[4, i + 1].Value = kryptonDgvVehicleType.Columns[i].HeaderText;
                        worksheet.Cells[4, i + 1].Style.Font.Bold = true;
                        worksheet.Cells[4, i + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[4, i + 1].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                        worksheet.Cells[4, i + 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    }

                    // Xuất dữ liệu từ DataGridView (bắt đầu từ hàng 5)
                    for (int i = 0; i < kryptonDgvVehicleType.Rows.Count; i++)
                    {
                        for (int j = 0; j < kryptonDgvVehicleType.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 5, j + 1].Value = kryptonDgvVehicleType.Rows[i].Cells[j].Value?.ToString();
                        }
                    }

                    // Căn chỉnh độ rộng cột tự động
                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                    // Hiển thị hộp thoại lưu file
                    SaveFileDialog saveDialog = new SaveFileDialog
                    {
                        Filter = "Excel Files|*.xlsx",
                        Title = "Lưu file Excel",
                        FileName = "DanhSachLoaiXe.xlsx"
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
                            kryptonDgvVehicleType.DataSource = dt;
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
            if (kryptonDgvVehicleType.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để lưu vào database!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    foreach (DataGridViewRow row in kryptonDgvVehicleType.Rows)
                    {
                        if (row.IsNewRow) continue; // Bỏ qua hàng trống cuối cùng của DataGridView

                        object idObj = row.Cells["id"].Value;
                        string id = idObj != null && !string.IsNullOrWhiteSpace(idObj.ToString())
                            ? idObj.ToString().Trim()
                            : Guid.NewGuid().ToString(); // Tạo ID mới nếu trống

                        object nameObj = row.Cells["vehicle_type_name"].Value;
                        object descriptionObj = row.Cells["description"].Value;

                        // Kiểm tra dữ liệu hợp lệ
                        if (nameObj == null || string.IsNullOrWhiteSpace(nameObj.ToString()))
                        {
                            MessageBox.Show("Tên loại xe không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string name = nameObj.ToString().Trim();
                        string description = descriptionObj != null ? descriptionObj.ToString().Trim() : "";

                        // SQL query: Chèn dữ liệu hoặc cập nhật nếu đã tồn tại
                        string query = @"INSERT INTO vehicle_type (id, vehicle_type_name, description, created_at, updated_at)
                                 VALUES (@id, @name, @description, NOW(), NOW())
                                 ON DUPLICATE KEY UPDATE 
                                 vehicle_type_name = @name, description = @description, updated_at = NOW()";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.Parameters.AddWithValue("@name", name);
                            cmd.Parameters.AddWithValue("@description", description);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadVehicleTypes(); // Refresh DataGridView
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
