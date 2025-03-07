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
        }

        private void kryptonPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void kBtbLogin_Click(object sender, EventArgs e)
        {
            string inputCode = kTbCodeUser.Text.Trim();
            string inputPassword = kTbPwUser.Text.Trim();

            createUser user = userBLL.Login(inputCode, inputPassword);

            if (user != null)
            {
                MessageBox.Show($"Welcome !!!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmMain mainForm = new frmMain();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Code or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
