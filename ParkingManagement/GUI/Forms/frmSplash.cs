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
    public partial class frmSplash: Form
    {
        public frmSplash()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Ẩn viền cửa sổ
            this.StartPosition = FormStartPosition.CenterScreen; // Căn giữa màn hình
        }
        private void frmSplash_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 3000; // Hiển thị Splash trong 3 giây
            timer.Tick += (s, ev) =>
            {
                timer.Stop();
                this.Close();
            };
            timer.Start();
        }

    }
}
