namespace ParkingManagement.GUI.Forms
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kBtbLogin = new Krypton.Toolkit.KryptonButton();
            this.kTbCodeUser = new Krypton.Toolkit.KryptonTextBox();
            this.kTbPwUser = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPictureBox1
            // 
            this.kryptonPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPictureBox1.Image")));
            this.kryptonPictureBox1.Location = new System.Drawing.Point(-4, -1);
            this.kryptonPictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonPictureBox1.Name = "kryptonPictureBox1";
            this.kryptonPictureBox1.Size = new System.Drawing.Size(1279, 658);
            this.kryptonPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kryptonPictureBox1.TabIndex = 0;
            this.kryptonPictureBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-220, -208);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(627, 894);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // kBtbLogin
            // 
            this.kBtbLogin.Location = new System.Drawing.Point(127, 279);
            this.kBtbLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kBtbLogin.Name = "kBtbLogin";
            this.kBtbLogin.Size = new System.Drawing.Size(120, 31);
            this.kBtbLogin.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.kBtbLogin.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kBtbLogin.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.kBtbLogin.StateCommon.Border.Rounding = 10F;
            this.kBtbLogin.StateCommon.Border.Width = 2;
            this.kBtbLogin.TabIndex = 4;
            this.kBtbLogin.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kBtbLogin.Values.Text = "Login";
            this.kBtbLogin.Click += new System.EventHandler(this.kBtbLogin_Click);
            // 
            // kTbCodeUser
            // 
            this.kTbCodeUser.Location = new System.Drawing.Point(77, 182);
            this.kTbCodeUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kTbCodeUser.Name = "kTbCodeUser";
            this.kTbCodeUser.Size = new System.Drawing.Size(215, 33);
            this.kTbCodeUser.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kTbCodeUser.StateActive.Border.Rounding = 10F;
            this.kTbCodeUser.StateNormal.Back.Color1 = System.Drawing.Color.Black;
            this.kTbCodeUser.TabIndex = 5;
            this.kTbCodeUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kTbPwUser
            // 
            this.kTbPwUser.Location = new System.Drawing.Point(77, 225);
            this.kTbPwUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kTbPwUser.Name = "kTbPwUser";
            this.kTbPwUser.PasswordChar = '*';
            this.kTbPwUser.Size = new System.Drawing.Size(215, 33);
            this.kTbPwUser.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kTbPwUser.StateActive.Border.Rounding = 10F;
            this.kTbPwUser.StateNormal.Back.Color1 = System.Drawing.Color.Black;
            this.kTbPwUser.TabIndex = 6;
            this.kTbPwUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(973, 501);
            this.Controls.Add(this.kTbPwUser);
            this.Controls.Add(this.kTbCodeUser);
            this.Controls.Add(this.kBtbLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kryptonPictureBox1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonButton kBtbLogin;
        private Krypton.Toolkit.KryptonTextBox kTbCodeUser;
        private Krypton.Toolkit.KryptonTextBox kTbPwUser;
    }
}