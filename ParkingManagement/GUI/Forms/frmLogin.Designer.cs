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
            this.kBtbLogin = new Krypton.Toolkit.KryptonButton();
            this.kTbCodeUser = new Krypton.Toolkit.KryptonTextBox();
            this.kTbPwUser = new Krypton.Toolkit.KryptonTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPictureBox1
            // 
            this.kryptonPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPictureBox1.Image")));
            this.kryptonPictureBox1.Location = new System.Drawing.Point(12, -2);
            this.kryptonPictureBox1.Name = "kryptonPictureBox1";
            this.kryptonPictureBox1.Size = new System.Drawing.Size(959, 535);
            this.kryptonPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kryptonPictureBox1.TabIndex = 0;
            this.kryptonPictureBox1.TabStop = false;
            // 
            // kBtbLogin
            // 
            this.kBtbLogin.Location = new System.Drawing.Point(95, 227);
            this.kBtbLogin.Name = "kBtbLogin";
            this.kBtbLogin.Size = new System.Drawing.Size(90, 25);
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
            this.kTbCodeUser.Location = new System.Drawing.Point(58, 148);
            this.kTbCodeUser.Name = "kTbCodeUser";
            this.kTbCodeUser.Size = new System.Drawing.Size(161, 29);
            this.kTbCodeUser.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kTbCodeUser.StateActive.Border.Rounding = 10F;
            this.kTbCodeUser.StateNormal.Back.Color1 = System.Drawing.Color.Black;
            this.kTbCodeUser.TabIndex = 5;
            this.kTbCodeUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kTbPwUser
            // 
            this.kTbPwUser.Location = new System.Drawing.Point(58, 183);
            this.kTbPwUser.Name = "kTbPwUser";
            this.kTbPwUser.PasswordChar = '*';
            this.kTbPwUser.Size = new System.Drawing.Size(161, 29);
            this.kTbPwUser.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kTbPwUser.StateActive.Border.Rounding = 10F;
            this.kTbPwUser.StateNormal.Back.Color1 = System.Drawing.Color.Black;
            this.kTbPwUser.TabIndex = 6;
            this.kTbPwUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-261, -71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(579, 580);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(40, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chào mừng bạn đến với hệ thống";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(69, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Quản lý bãi đỗ xe";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(730, 407);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kBtbLogin);
            this.Controls.Add(this.kTbPwUser);
            this.Controls.Add(this.kTbCodeUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kryptonPictureBox1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonButton kBtbLogin;
        private Krypton.Toolkit.KryptonTextBox kTbCodeUser;
        private Krypton.Toolkit.KryptonTextBox kTbPwUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
    }
}