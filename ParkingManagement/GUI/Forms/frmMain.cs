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
using System.Threading;
using ParkingManagement.GUI.Forms.staff;
using ParkingManagement.GUI.Forms.statistics;

namespace ParkingManagement
{
    public partial class frmMain: Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            t.Abort();
        }
        public void StartForm()
        {
            Application.Run(new frmSplash());
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
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

        private void kBtnUsers_Click(object sender, EventArgs e)
        {
            OpenFormInTab<frmUsers>("Users");
        }

        private void btnTicketPrice_Click(object sender, EventArgs e)
        {
            OpenFormInTab<frmTicketPrice>("Ticket Price");
        }

        private void btnVehicleType_Click(object sender, EventArgs e)
        {
            OpenFormInTab<frmVehicleType>("Vehicle Type");
        }
        private void btnParkingSpot_Click(object sender, EventArgs e)
        {
            OpenFormInTab<frmParkingSlot>("Parking Slot");
        }

        private void btnParkingArea_Click(object sender, EventArgs e)
        {
            OpenFormInTab<frmParkingArea>("Parking Area");
        }

        private void kryptonRibbonGroupButton1_Click(object sender, EventArgs e)
        {
            OpenFormInTab<frmInOutVehicle>("Vehicle In Out");
        }

<<<<<<< HEAD
        private void kryptonRibbonGroupButton3_Click(object sender, EventArgs e)
        {
            OpenFormInTab<frmStatistics>("frmStatistics");
=======
        private void btnParkingCard_Click(object sender, EventArgs e)
        {
            OpenFormInTab<frmParkingCard>("Parking Card");
        }

        private void kryptonRibbon1_SelectedTabChanged(object sender, EventArgs e)
        {
>>>>>>> develop

        }
    }
} 
