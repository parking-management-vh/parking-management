using Krypton.Navigator;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingManagement.GUI.Forms.staff
{
    public partial class frmStaffDashboard: Form
    {
        public frmStaffDashboard()
        {
            InitializeComponent();
            LoadStartPage();

        }
        private void LoadStartPage()
        {
            OpenFormInTab<frmStartStaff>("StartStaff");
        }


        private void OpenFormInTab<T>(string tabName) where T : Form, new()
        {
            foreach (Krypton.Navigator.KryptonPage page in kryptonNavigator1.Pages)
            {
                if (page.Text == tabName)
                {
                    kryptonNavigator1.SelectedPage = page;
                    return;
                }
            }

            Krypton.Navigator.KryptonPage newPage = new Krypton.Navigator.KryptonPage
            {
                Text = tabName,
                Name = $"tab{typeof(T).Name}"
            };

            T formInstance = new T
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            newPage.Controls.Add(formInstance);
            formInstance.Show();

            kryptonNavigator1.Pages.Add(newPage);
            kryptonNavigator1.SelectedPage = newPage;
        }



        private void btnManageVehicle_Click(object sender, EventArgs e)
        {
            OpenFormInTab<frmManageVehicle>("ManageVehicle");
        }

        private void btnManagePay_Click(object sender, EventArgs e)
        {
            OpenFormInTab<frmManagePay>("ManagePay");
        }

        private void btnInOutVehicle_Click(object sender, EventArgs e)
        {
            OpenFormInTab<frmInOutVehicle>("InOutVehicle");
        }
        //thêm ảnh nền cho kryptonNavigator1
        //private void KryptonGroupPanel_Paint(object sender, PaintEventArgs e)
        //{
        //    string imagePath = @"download.jpg";
        //    if (System.IO.File.Exists(imagePath))
        //    {
        //        kryptonNavigator1.StateCommon.Back.Image = Image.FromFile(imagePath);
        //        kryptonNavigator1.StateCommon.Back.ImageStyle = PaletteImageStyle.Stretch;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Không tìm thấy ảnh!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}
