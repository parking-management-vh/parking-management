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
            LoadStartPage();

        }
        private void LoadStartPage()
        {
            OpenFormInTab<LoadStartPage>("Start Page");
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

        //tabHome
        private void btnManageVehicle2_Click(object sender, EventArgs e)
        {
            OpenFormInTab<frmManageVehicle>("Manage Vehicle");
        }

        private void btnbtnManagePay2_Click(object sender, EventArgs e)
        {
            OpenFormInTab<frmManagePay>("Manage Pay");
        }

        private void btnInOutVehicle_Click(object sender, EventArgs e)
        {
            OpenFormInTab<frmInOutVehicle>("In Out Vehicle");
        }
        //tabParkingManagement
        private void btnParkingSlot_Click(object sender, EventArgs e)
        {
            OpenFormInTab<frmParkingSlot>("Parking Slot");
        }
        private void btnParkingCard_Click(object sender, EventArgs e)
        {
            OpenFormInTab<frmParkingCard>("Parking Card");
        }

        private void btnParkingRecord_Click(object sender, EventArgs e)
        {
            //OpenFormInTab<frmParkingRecord>("Parking Record");
        }

        private void btnManageVehicle_Click(object sender, EventArgs e)
        {
            OpenFormInTab<frmManageVehicle>("Manage Vehicle");
        }

        private void btnVehicleType_Click(object sender, EventArgs e)
        {
            OpenFormInTab<frmVehicleType>("Vehicle Type");
        }

        //tabFinancialManagement
        private void btnTicketPrice_Click(object sender, EventArgs e)
        {
            OpenFormInTab<frmTicketPrice>("Ticket Price");

        }
        private void btnManagePay_Click(object sender, EventArgs e)
        {
            OpenFormInTab<frmManagePay>("Manage Pay");
        }

        private void btnCreatePayment_Click(object sender, EventArgs e)
        {
            //OpenFormInTab<frmCreatePayment>("Create Payment");
        }

        private void btnPaymentReceipt_Click(object sender, EventArgs e)
        {
            OpenFormInTab<frmPaymentReceipt>("Payment Receipt");
        }
        private void kryptonRibbonGroupButton1_Click_1(object sender, EventArgs e)
        {
            OpenFormInTab<frmVehicle>("Vehicle");
        }

        private void kryptonRibbonGroupButton3_Click_1(object sender, EventArgs e)
        {
            OpenFormInTab<frmParkingArea>("Parking Area");
        }
        //tabUserManagement
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            //OpenFormInTab<frmEmployee>("Employee");
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenFormInTab<frmUsers>("Users");
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            OpenFormInTab<frmCreateUser>("Create User");
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            //OpenFormInTab<frmCustomer>("Customer");
        }
        //tabStatistics
        private void btnStatistics_Click(object sender, EventArgs e)
        {
            OpenFormInTab<frmStatistics>("Statistics");
        }
      
        private void btnStaticStaff_Click(object sender, EventArgs e)
        {
            OpenFormInTab<StaticsStaff>("Statics Staff");
        }
    }
} 
