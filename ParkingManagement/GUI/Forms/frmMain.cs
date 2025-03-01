using ParkingManagement.DAL.Database;
using ParkingManagement.GUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Navigator;
using ComponentFactory.Krypton.Navigator;
using Krypton.Toolkit;

namespace ParkingManagement
{
    public partial class frmMain: Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            kryptonNavigator1.Dock = DockStyle.Fill;

            this.Resize += (s, e) =>
            {
                kryptonNavigator1.PageBackStyle = PaletteBackStyle.PanelClient;
                kryptonNavigator1.PerformLayout();
            };
            this.Resize += FrmMain_Resize;


        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            kryptonNavigator1.Dock = DockStyle.Fill;
            kryptonNavigator1.PageBackStyle = PaletteBackStyle.PanelClient;
            kryptonNavigator1.PerformLayout();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            kryptonNavigator1.Dock = DockStyle.Fill;


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

        /// mở form trong tab mới
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenFormInTab<frmCustomer>("Customer");
        }
       
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            OpenFormInTab<frmEmployee>("Employee");
        }

        private void btnVehicleType_Click(object sender, EventArgs e)
        {
            OpenFormInTab<frmVehicleType>("Vehicle");

        }

        private void btnTicketPrice_Click(object sender, EventArgs e)
        {
            OpenFormInTab<frmTicketPrice>("TicketPrice");
        }
    }
}
