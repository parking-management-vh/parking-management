using ParkingManagement.BLL;
using ParkingManagement.GUI.Forms.staff;
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
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace ParkingManagement.GUI.Forms
{
    public partial class frmLogin: Form
    {
        private userBLL userBLL = new userBLL();


        public frmLogin()
        {
            InitializeComponent();
            this.TransparencyKey = Color.Magenta;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TransparencyKey = this.BackColor;

        }
        private void kBtbLogin_Click(object sender, EventArgs e)
        {
            string inputCode = kTbCodeUser.Text.Trim();
            string inputPassword = kTbPwUser.Text.Trim();

            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrEmpty(inputCode) || string.IsNullOrEmpty(inputPassword))
            {
                MessageBox.Show("Please enter both User ID and Password!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                createUser user = userBLL.Login(inputCode, inputPassword);

                if (user != null)
                {
                    SessionManager.SetUser(user);

                    MessageBox.Show($"Welcome {user.Code}!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    if (user.Role == "Admin")
                    {
                        frmMain mainForm = new frmMain();
                        mainForm.ShowDialog();
                    }
                    else if (user.Role == "Staff")
                    {
                        frmStaffDashboard staffForm = new frmStaffDashboard();
                        staffForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Unknown role. Please contact the administrator.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Code or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error: {ex.Message}", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Magenta;

        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
