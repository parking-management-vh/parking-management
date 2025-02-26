using Krypton.Toolkit;
using MySql.Data.MySqlClient;
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
        public frmVehicleType()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None; // Bỏ viền cửa sổ
            this.Dock = DockStyle.Fill; // Full trong container
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.txtDescription.Enter += new System.EventHandler(this.txtDescription_Enter);
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
        }


        private void frmVehicleType_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            kryptonDgvVehicleType.ScrollBars = ScrollBars.Both;
            kryptonDgvVehicleType.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txtSearch.KeyPress += txtSearch_KeyPress;

            LoadVehicleTypes();
            SetPlaceholder();
        }

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
                
                cmbVehicle.SelectedIndex = -1; // Bỏ chọn combo box
                txtDescription.Text = ""; // Xóa nội dung mô tả
                cmbVehicle.Focus(); // Đưa con trỏ vào combo box

                LoadVehicleTypes(); // Cập nhật lại danh sách
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

                // 🔥 Reset dữ liệu sau khi lưu
                cmbVehicle.SelectedIndex = -1;
                txtDescription.Clear();
                selectedId = null;
                kryptonDgvVehicleType.ScrollBars = ScrollBars.Both;
                kryptonDgvVehicleType.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                LoadVehicleTypes(); // Refresh lại bảng
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kryptonDgvVehicleType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Kiểm tra chỉ mục hợp lệ
            {
                DataGridViewRow row = kryptonDgvVehicleType.Rows[e.RowIndex];

                // 🟢 Lấy dữ liệu từ bảng đưa lên combobox & textbox
                cmbVehicle.Text = row.Cells["vehicle_type_name"].Value?.ToString();
                txtDescription.Text = row.Cells["description"].Value?.ToString();

                // 🔥 Lưu lại ID của dòng được chọn
                selectedId = row.Cells["id"].Value?.ToString();
            }
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

                    // 🔥 Cập nhật lại bảng sau khi xóa
                    selectedId = null;
                    cmbVehicle.SelectedIndex = -1;
                    txtDescription.Clear();
                    LoadVehicleTypes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                txtDescription.Text = "Nhập mô tả loại xe...";
                txtDescription.ForeColor = Color.Gray;
            }
        }
        private void txtDescription_Enter(object sender, EventArgs e)
        {
            if (txtDescription.Text == "Nhập mô tả loại xe...")
            {
                txtDescription.Text = "";
                txtDescription.ForeColor = Color.Black;
            }
        }
        private void txtDescription_Leave(object sender, EventArgs e)
        {
            SetPlaceholder();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

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

            // 🔥 Chỉ hiện thông báo MỘT lần nếu không tìm thấy
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
