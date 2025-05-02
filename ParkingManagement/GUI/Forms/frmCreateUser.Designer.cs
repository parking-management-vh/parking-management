namespace ParkingManagement.GUI.Forms
{
    partial class frmCreateUser
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
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kSaveAddUser = new Krypton.Toolkit.KryptonButton();
            this.kAreaCbb = new Krypton.Toolkit.KryptonComboBox();
            this.kAreaLb = new Krypton.Toolkit.KryptonLabel();
            this.kTypeAccCbb = new Krypton.Toolkit.KryptonComboBox();
            this.kDtBirthday = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kSexCbb = new Krypton.Toolkit.KryptonComboBox();
            this.kTypeAccLb = new Krypton.Toolkit.KryptonLabel();
            this.kBirthdayLb = new Krypton.Toolkit.KryptonLabel();
            this.kSexLb = new Krypton.Toolkit.KryptonLabel();
            this.kEmailLb = new Krypton.Toolkit.KryptonLabel();
            this.kEmailTb = new Krypton.Toolkit.KryptonTextBox();
            this.kPhoneLb = new Krypton.Toolkit.KryptonLabel();
            this.kPhoneTb = new Krypton.Toolkit.KryptonTextBox();
            this.kFullNameLb = new Krypton.Toolkit.KryptonLabel();
            this.kFullNameTb = new Krypton.Toolkit.KryptonTextBox();
            this.kAddressTb = new Krypton.Toolkit.KryptonTextBox();
            this.kAddressLb = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kPasswordTb = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kAreaCbb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kTypeAccCbb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kSexCbb)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.kPasswordTb);
            this.kryptonPanel1.Controls.Add(this.kSaveAddUser);
            this.kryptonPanel1.Controls.Add(this.kAreaCbb);
            this.kryptonPanel1.Controls.Add(this.kAreaLb);
            this.kryptonPanel1.Controls.Add(this.kTypeAccCbb);
            this.kryptonPanel1.Controls.Add(this.kDtBirthday);
            this.kryptonPanel1.Controls.Add(this.kSexCbb);
            this.kryptonPanel1.Controls.Add(this.kTypeAccLb);
            this.kryptonPanel1.Controls.Add(this.kBirthdayLb);
            this.kryptonPanel1.Controls.Add(this.kSexLb);
            this.kryptonPanel1.Controls.Add(this.kAddressLb);
            this.kryptonPanel1.Controls.Add(this.kAddressTb);
            this.kryptonPanel1.Controls.Add(this.kEmailLb);
            this.kryptonPanel1.Controls.Add(this.kEmailTb);
            this.kryptonPanel1.Controls.Add(this.kPhoneLb);
            this.kryptonPanel1.Controls.Add(this.kPhoneTb);
            this.kryptonPanel1.Controls.Add(this.kFullNameLb);
            this.kryptonPanel1.Controls.Add(this.kFullNameTb);
            this.kryptonPanel1.Location = new System.Drawing.Point(16, 15);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(465, 500);
            this.kryptonPanel1.TabIndex = 0;
            this.kryptonPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonPanel1_Paint);
            // 
            // kSaveAddUser
            // 
            this.kSaveAddUser.Location = new System.Drawing.Point(273, 434);
            this.kSaveAddUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kSaveAddUser.Name = "kSaveAddUser";
            this.kSaveAddUser.Size = new System.Drawing.Size(123, 37);
            this.kSaveAddUser.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kSaveAddUser.TabIndex = 19;
            this.kSaveAddUser.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kSaveAddUser.Values.Text = "Lưu";
            this.kSaveAddUser.Click += new System.EventHandler(this.kSaveAddUser_Click);
            // 
            // kAreaCbb
            // 
            this.kAreaCbb.DropDownWidth = 100;
            this.kAreaCbb.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.kAreaCbb.Location = new System.Drawing.Point(203, 347);
            this.kAreaCbb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kAreaCbb.Name = "kAreaCbb";
            this.kAreaCbb.Size = new System.Drawing.Size(193, 26);
            this.kAreaCbb.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kAreaCbb.TabIndex = 18;
            // 
            // kAreaLb
            // 
            this.kAreaLb.Location = new System.Drawing.Point(49, 351);
            this.kAreaLb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kAreaLb.Name = "kAreaLb";
            this.kAreaLb.Size = new System.Drawing.Size(78, 21);
            this.kAreaLb.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kAreaLb.TabIndex = 17;
            this.kAreaLb.Values.Text = "Khu vực :";
            // 
            // kTypeAccCbb
            // 
            this.kTypeAccCbb.DropDownWidth = 100;
            this.kTypeAccCbb.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.kTypeAccCbb.Location = new System.Drawing.Point(203, 303);
            this.kTypeAccCbb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kTypeAccCbb.Name = "kTypeAccCbb";
            this.kTypeAccCbb.Size = new System.Drawing.Size(193, 26);
            this.kTypeAccCbb.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kTypeAccCbb.TabIndex = 16;
            // 
            // kDtBirthday
            // 
            this.kDtBirthday.CalendarTodayDate = new System.DateTime(2025, 3, 16, 0, 0, 0, 0);
            this.kDtBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.kDtBirthday.Location = new System.Drawing.Point(203, 257);
            this.kDtBirthday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kDtBirthday.Name = "kDtBirthday";
            this.kDtBirthday.Size = new System.Drawing.Size(193, 25);
            this.kDtBirthday.TabIndex = 15;
            // 
            // kSexCbb
            // 
            this.kSexCbb.DropDownWidth = 145;
            this.kSexCbb.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.kSexCbb.Location = new System.Drawing.Point(203, 212);
            this.kSexCbb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kSexCbb.Name = "kSexCbb";
            this.kSexCbb.Size = new System.Drawing.Size(193, 26);
            this.kSexCbb.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kSexCbb.TabIndex = 14;
            // 
            // kTypeAccLb
            // 
            this.kTypeAccLb.Location = new System.Drawing.Point(49, 306);
            this.kTypeAccLb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kTypeAccLb.Name = "kTypeAccLb";
            this.kTypeAccLb.Size = new System.Drawing.Size(120, 21);
            this.kTypeAccLb.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kTypeAccLb.TabIndex = 13;
            this.kTypeAccLb.Values.Text = "Loại tài khoản :";
            // 
            // kBirthdayLb
            // 
            this.kBirthdayLb.Location = new System.Drawing.Point(49, 260);
            this.kBirthdayLb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kBirthdayLb.Name = "kBirthdayLb";
            this.kBirthdayLb.Size = new System.Drawing.Size(91, 21);
            this.kBirthdayLb.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kBirthdayLb.TabIndex = 11;
            this.kBirthdayLb.Values.Text = "Ngày sinh :";
            // 
            // kSexLb
            // 
            this.kSexLb.Location = new System.Drawing.Point(49, 215);
            this.kSexLb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kSexLb.Name = "kSexLb";
            this.kSexLb.Size = new System.Drawing.Size(79, 21);
            this.kSexLb.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kSexLb.TabIndex = 9;
            this.kSexLb.Values.Text = "Giới tính :";
            // 
            // kEmailLb
            // 
            this.kEmailLb.Location = new System.Drawing.Point(49, 126);
            this.kEmailLb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kEmailLb.Name = "kEmailLb";
            this.kEmailLb.Size = new System.Drawing.Size(61, 21);
            this.kEmailLb.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kEmailLb.TabIndex = 5;
            this.kEmailLb.Values.Text = "Email :";
            // 
            // kEmailTb
            // 
            this.kEmailTb.Location = new System.Drawing.Point(203, 121);
            this.kEmailTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kEmailTb.Name = "kEmailTb";
            this.kEmailTb.Size = new System.Drawing.Size(193, 27);
            this.kEmailTb.TabIndex = 4;
            // 
            // kPhoneLb
            // 
            this.kPhoneLb.Location = new System.Drawing.Point(49, 79);
            this.kPhoneLb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kPhoneLb.Name = "kPhoneLb";
            this.kPhoneLb.Size = new System.Drawing.Size(114, 21);
            this.kPhoneLb.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kPhoneLb.TabIndex = 3;
            this.kPhoneLb.Values.Text = "Số điện thoại :";
            // 
            // kPhoneTb
            // 
            this.kPhoneTb.Location = new System.Drawing.Point(203, 75);
            this.kPhoneTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kPhoneTb.Name = "kPhoneTb";
            this.kPhoneTb.Size = new System.Drawing.Size(193, 27);
            this.kPhoneTb.TabIndex = 2;
            // 
            // kFullNameLb
            // 
            this.kFullNameLb.Location = new System.Drawing.Point(49, 33);
            this.kFullNameLb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kFullNameLb.Name = "kFullNameLb";
            this.kFullNameLb.Size = new System.Drawing.Size(88, 21);
            this.kFullNameLb.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kFullNameLb.TabIndex = 1;
            this.kFullNameLb.Values.Text = "Họ và tên :";
            // 
            // kFullNameTb
            // 
            this.kFullNameTb.Location = new System.Drawing.Point(203, 28);
            this.kFullNameTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kFullNameTb.Name = "kFullNameTb";
            this.kFullNameTb.Size = new System.Drawing.Size(193, 27);
            this.kFullNameTb.TabIndex = 0;
            // 
            // kAddressTb
            // 
            this.kAddressTb.Location = new System.Drawing.Point(203, 166);
            this.kAddressTb.Margin = new System.Windows.Forms.Padding(4);
            this.kAddressTb.Name = "kAddressTb";
            this.kAddressTb.Size = new System.Drawing.Size(193, 27);
            this.kAddressTb.TabIndex = 6;
            // 
            // kAddressLb
            // 
            this.kAddressLb.Location = new System.Drawing.Point(49, 171);
            this.kAddressLb.Margin = new System.Windows.Forms.Padding(4);
            this.kAddressLb.Name = "kAddressLb";
            this.kAddressLb.Size = new System.Drawing.Size(69, 21);
            this.kAddressLb.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kAddressLb.TabIndex = 7;
            this.kAddressLb.Values.Text = "Địa chỉ :";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(49, 397);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(86, 21);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 21;
            this.kryptonLabel1.Values.Text = "Password:";
            // 
            // kPasswordTb
            // 
            this.kPasswordTb.Location = new System.Drawing.Point(203, 392);
            this.kPasswordTb.Margin = new System.Windows.Forms.Padding(4);
            this.kPasswordTb.Name = "kPasswordTb";
            this.kPasswordTb.Size = new System.Drawing.Size(193, 27);
            this.kPasswordTb.TabIndex = 20;
            // 
            // frmCreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 540);
            this.Controls.Add(this.kryptonPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCreateUser";
            this.Text = "CreateUser";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kAreaCbb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kTypeAccCbb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kSexCbb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonTextBox kFullNameTb;
        private Krypton.Toolkit.KryptonLabel kFullNameLb;
        private Krypton.Toolkit.KryptonLabel kTypeAccLb;
        private Krypton.Toolkit.KryptonLabel kBirthdayLb;
        private Krypton.Toolkit.KryptonLabel kSexLb;
        private Krypton.Toolkit.KryptonLabel kEmailLb;
        private Krypton.Toolkit.KryptonTextBox kEmailTb;
        private Krypton.Toolkit.KryptonLabel kPhoneLb;
        private Krypton.Toolkit.KryptonTextBox kPhoneTb;
        private Krypton.Toolkit.KryptonComboBox kSexCbb;
        private Krypton.Toolkit.KryptonDateTimePicker kDtBirthday;
        private Krypton.Toolkit.KryptonComboBox kTypeAccCbb;
        private Krypton.Toolkit.KryptonComboBox kAreaCbb;
        private Krypton.Toolkit.KryptonLabel kAreaLb;
        private Krypton.Toolkit.KryptonButton kSaveAddUser;
        private Krypton.Toolkit.KryptonLabel kAddressLb;
        private Krypton.Toolkit.KryptonTextBox kAddressTb;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox kPasswordTb;
    }
}