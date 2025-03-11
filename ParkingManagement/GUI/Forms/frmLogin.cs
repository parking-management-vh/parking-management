using ParkingManagement.BLL;
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

            // Check if username or password is empty
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
                    MessageBox.Show($"Login successful!\nWelcome, {user.FullName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frmMain mainForm = new frmMain();
                    mainForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid User ID or Password!\nPlease check again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during login!\nError details: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
