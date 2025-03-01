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
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;

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
            this.WindowState = FormWindowState.Maximized;

            //kryptonDgvVehicleType.ScrollBars = ScrollBars.Both;

            //kryptonDgvVehicleType.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
                selectedId = kryptonDgvVehicleType.SelectedRows[0].Cells["id"].Value.ToString();
                btnDelete.Enabled = true; // Hiện nút Delete khi có dòng được chọn
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
    }
}
