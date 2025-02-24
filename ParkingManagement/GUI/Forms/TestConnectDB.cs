using ParkingManagement.BLL;
using ParkingManagement.DAL.Database;
using ParkingManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingManagement.GUI.Forms
{
    public partial class TestConnectDB: Form
    {
        private parkingAreaBLL parkingAreaBLL = new parkingAreaBLL();

        public TestConnectDB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseProvider db = new DatabaseProvider();
            try
            {
                DataTable data = db.ExecuteQuery("SHOW TABLES;");
                MessageBox.Show($"Kết nối thành công! Số bảng: {data.Rows.Count}", "Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TestConnectDB_Load(object sender, EventArgs e)
        {

        }
        private void LoadParkingAreaData()
        {
            try
            {
                List<parkingAreaModel> areas = parkingAreaBLL.GetAllParkingAreas();
                dgvParkingArea.DataSource = areas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadParkingAreaData();
        }
    }
}
