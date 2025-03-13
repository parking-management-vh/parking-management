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
            this.kBtbLogin = new Krypton.Toolkit.KryptonButton();
            this.kTbCodeUser = new Krypton.Toolkit.KryptonTextBox();
            this.kTbPwUser = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            this.btnPower = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kBtbLogin
            // 
            this.kBtbLogin.Location = new System.Drawing.Point(662, 299);
            this.kBtbLogin.Margin = new System.Windows.Forms.Padding(4);
            this.kBtbLogin.Name = "kBtbLogin";
            this.kBtbLogin.Size = new System.Drawing.Size(140, 42);
            this.kBtbLogin.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.kBtbLogin.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kBtbLogin.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.kBtbLogin.StateCommon.Border.Rounding = 10F;
            this.kBtbLogin.StateCommon.Border.Width = 2;
            this.kBtbLogin.StateCommon.Content.ShortText.Font = new System.Drawing.Font("UTM Facebook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kBtbLogin.TabIndex = 4;
            this.kBtbLogin.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kBtbLogin.Values.Text = "LOGIN";
            this.kBtbLogin.Click += new System.EventHandler(this.kBtbLogin_Click);
            // 
            // kTbCodeUser
            // 
            this.kTbCodeUser.Location = new System.Drawing.Point(563, 201);
            this.kTbCodeUser.Margin = new System.Windows.Forms.Padding(4);
            this.kTbCodeUser.Name = "kTbCodeUser";
            this.kTbCodeUser.Size = new System.Drawing.Size(337, 41);
            this.kTbCodeUser.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kTbCodeUser.StateActive.Border.Rounding = 10F;
            this.kTbCodeUser.StateCommon.Content.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kTbCodeUser.StateNormal.Back.Color1 = System.Drawing.Color.Black;
            this.kTbCodeUser.TabIndex = 5;
            // 
            // kTbPwUser
            // 
            this.kTbPwUser.Location = new System.Drawing.Point(563, 250);
            this.kTbPwUser.Margin = new System.Windows.Forms.Padding(4);
            this.kTbPwUser.Name = "kTbPwUser";
            this.kTbPwUser.PasswordChar = '*';
            this.kTbPwUser.Size = new System.Drawing.Size(337, 41);
            this.kTbPwUser.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kTbPwUser.StateActive.Border.Rounding = 10F;
            this.kTbPwUser.StateCommon.Content.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kTbPwUser.StateNormal.Back.Color1 = System.Drawing.Color.Black;
            this.kTbPwUser.TabIndex = 6;
            // 
            // kryptonPictureBox1
            // 
            this.kryptonPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPictureBox1.Image")));
            this.kryptonPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPictureBox1.Name = "kryptonPictureBox1";
            this.kryptonPictureBox1.Size = new System.Drawing.Size(973, 501);
            this.kryptonPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kryptonPictureBox1.TabIndex = 10;
            this.kryptonPictureBox1.TabStop = false;
            // 
            // btnPower
            // 
            this.btnPower.Location = new System.Drawing.Point(922, 456);
            this.btnPower.Name = "btnPower";
            this.btnPower.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlackDarkMode;
            this.btnPower.Size = new System.Drawing.Size(42, 37);
            this.btnPower.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnPower.TabIndex = 12;
            this.btnPower.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnPower.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnPower.Values.Image")));
            this.btnPower.Values.Text = "";
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(973, 501);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.kBtbLogin);
            this.Controls.Add(this.kTbPwUser);
            this.Controls.Add(this.kTbCodeUser);
            this.Controls.Add(this.kryptonPictureBox1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonButton kBtbLogin;
        private Krypton.Toolkit.KryptonTextBox kTbCodeUser;
        private Krypton.Toolkit.KryptonTextBox kTbPwUser;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Toolkit.KryptonButton btnPower;
    }
}