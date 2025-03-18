using ParkingManagement.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace ParkingManagement.GUI.Forms.staff
{
    public partial class frmStartStaff: Form
    {
        public frmStartStaff()
        {
            InitializeComponent();
            LoadYouTubeVideo();
            LoadInfoUser();
        }

        private void LoadYouTubeVideo()
        {
            string videoId = "TKj8PVHNh3k";
            string embedHtml = $@"
                <html>
                <head>
                    <meta http-equiv='X-UA-Compatible' content='IE=Edge'/>
                </head>
                <body>
                    <iframe width=""560"" height=""315"" src=""https://www.youtube.com/embed/{videoId}?autoplay=1"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share"" referrerpolicy=""strict-origin-when-cross-origin"" allowfullscreen></iframe>
                </body>
                </html>";

            kryptonWebBrowser1.DocumentText = embedHtml;
        }

        private void kryptonGroupBox1_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadInfoUser()
        {
            lbArea.Text = SessionManager.CurrentUser.AreaName;
            kTbCode.Text = SessionManager.CurrentUser.Code;
            kTbFulName.Text = SessionManager.CurrentUser.FullName;
            kTbAdd.Text = SessionManager.CurrentUser.Address;
            kTbMail.Text = SessionManager.CurrentUser.Email;
            kryptonDateTimePicker1.Value = SessionManager.CurrentUser.DateOfBirth ?? DateTime.Now;
            kTbGender.Text = SessionManager.CurrentUser.Gender;
            kTbArea.Text = SessionManager.CurrentUser.AreaName;
        }

        private void kryptonGroupBox1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
