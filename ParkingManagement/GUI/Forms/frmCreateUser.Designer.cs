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
            this.kAddressLb = new Krypton.Toolkit.KryptonLabel();
            this.kAddressTb = new Krypton.Toolkit.KryptonTextBox();
            this.kEmailLb = new Krypton.Toolkit.KryptonLabel();
            this.kEmailTb = new Krypton.Toolkit.KryptonTextBox();
            this.kPhoneLb = new Krypton.Toolkit.KryptonLabel();
            this.kPhoneTb = new Krypton.Toolkit.KryptonTextBox();
            this.kFullNameLb = new Krypton.Toolkit.KryptonLabel();
            this.kFullNameTb = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kAreaCbb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kTypeAccCbb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kSexCbb)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
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
            this.kryptonPanel1.Location = new System.Drawing.Point(12, 12);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(776, 426);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kSaveAddUser
            // 
            this.kSaveAddUser.Location = new System.Drawing.Point(141, 341);
            this.kSaveAddUser.Name = "kSaveAddUser";
            this.kSaveAddUser.Size = new System.Drawing.Size(90, 25);
            this.kSaveAddUser.TabIndex = 19;
            this.kSaveAddUser.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kSaveAddUser.Values.Text = "Save";
            this.kSaveAddUser.Click += new System.EventHandler(this.kSaveAddUser_Click);
            // 
            // kAreaCbb
            // 
            this.kAreaCbb.DropDownWidth = 100;
            this.kAreaCbb.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.kAreaCbb.Location = new System.Drawing.Point(234, 282);
            this.kAreaCbb.Name = "kAreaCbb";
            this.kAreaCbb.Size = new System.Drawing.Size(145, 22);
            this.kAreaCbb.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kAreaCbb.TabIndex = 18;
            // 
            // kAreaLb
            // 
            this.kAreaLb.Location = new System.Drawing.Point(141, 284);
            this.kAreaLb.Name = "kAreaLb";
            this.kAreaLb.Size = new System.Drawing.Size(54, 20);
            this.kAreaLb.TabIndex = 17;
            this.kAreaLb.Values.Text = "Khu vực";
            // 
            // kTypeAccCbb
            // 
            this.kTypeAccCbb.DropDownWidth = 100;
            this.kTypeAccCbb.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.kTypeAccCbb.Location = new System.Drawing.Point(234, 254);
            this.kTypeAccCbb.Name = "kTypeAccCbb";
            this.kTypeAccCbb.Size = new System.Drawing.Size(145, 22);
            this.kTypeAccCbb.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kTypeAccCbb.TabIndex = 16;
            // 
            // kDtBirthday
            // 
            this.kDtBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.kDtBirthday.Location = new System.Drawing.Point(234, 227);
            this.kDtBirthday.Name = "kDtBirthday";
            this.kDtBirthday.Size = new System.Drawing.Size(145, 21);
            this.kDtBirthday.TabIndex = 15;
            // 
            // kSexCbb
            // 
            this.kSexCbb.DropDownWidth = 145;
            this.kSexCbb.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.kSexCbb.Location = new System.Drawing.Point(234, 198);
            this.kSexCbb.Name = "kSexCbb";
            this.kSexCbb.Size = new System.Drawing.Size(145, 22);
            this.kSexCbb.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kSexCbb.TabIndex = 14;
            // 
            // kTypeAccLb
            // 
            this.kTypeAccLb.Location = new System.Drawing.Point(141, 256);
            this.kTypeAccLb.Name = "kTypeAccLb";
            this.kTypeAccLb.Size = new System.Drawing.Size(87, 20);
            this.kTypeAccLb.TabIndex = 13;
            this.kTypeAccLb.Values.Text = "Loại tài khoản";
            // 
            // kBirthdayLb
            // 
            this.kBirthdayLb.Location = new System.Drawing.Point(141, 227);
            this.kBirthdayLb.Name = "kBirthdayLb";
            this.kBirthdayLb.Size = new System.Drawing.Size(65, 20);
            this.kBirthdayLb.TabIndex = 11;
            this.kBirthdayLb.Values.Text = "Ngày sinh";
            // 
            // kSexLb
            // 
            this.kSexLb.Location = new System.Drawing.Point(141, 198);
            this.kSexLb.Name = "kSexLb";
            this.kSexLb.Size = new System.Drawing.Size(57, 20);
            this.kSexLb.TabIndex = 9;
            this.kSexLb.Values.Text = "Giới tính";
            // 
            // kAddressLb
            // 
            this.kAddressLb.Location = new System.Drawing.Point(141, 169);
            this.kAddressLb.Name = "kAddressLb";
            this.kAddressLb.Size = new System.Drawing.Size(48, 20);
            this.kAddressLb.TabIndex = 7;
            this.kAddressLb.Values.Text = "Địa chỉ";
            // 
            // kAddressTb
            // 
            this.kAddressTb.Location = new System.Drawing.Point(234, 166);
            this.kAddressTb.Name = "kAddressTb";
            this.kAddressTb.Size = new System.Drawing.Size(145, 23);
            this.kAddressTb.TabIndex = 6;
            // 
            // kEmailLb
            // 
            this.kEmailLb.Location = new System.Drawing.Point(141, 140);
            this.kEmailLb.Name = "kEmailLb";
            this.kEmailLb.Size = new System.Drawing.Size(40, 20);
            this.kEmailLb.TabIndex = 5;
            this.kEmailLb.Values.Text = "Email";
            // 
            // kEmailTb
            // 
            this.kEmailTb.Location = new System.Drawing.Point(234, 137);
            this.kEmailTb.Name = "kEmailTb";
            this.kEmailTb.Size = new System.Drawing.Size(145, 23);
            this.kEmailTb.TabIndex = 4;
            // 
            // kPhoneLb
            // 
            this.kPhoneLb.Location = new System.Drawing.Point(141, 111);
            this.kPhoneLb.Name = "kPhoneLb";
            this.kPhoneLb.Size = new System.Drawing.Size(83, 20);
            this.kPhoneLb.TabIndex = 3;
            this.kPhoneLb.Values.Text = "Số điện thoại";
            // 
            // kPhoneTb
            // 
            this.kPhoneTb.Location = new System.Drawing.Point(234, 108);
            this.kPhoneTb.Name = "kPhoneTb";
            this.kPhoneTb.Size = new System.Drawing.Size(145, 23);
            this.kPhoneTb.TabIndex = 2;
            // 
            // kFullNameLb
            // 
            this.kFullNameLb.Location = new System.Drawing.Point(141, 82);
            this.kFullNameLb.Name = "kFullNameLb";
            this.kFullNameLb.Size = new System.Drawing.Size(63, 20);
            this.kFullNameLb.TabIndex = 1;
            this.kFullNameLb.Values.Text = "Họ và tên";
            // 
            // kFullNameTb
            // 
            this.kFullNameTb.Location = new System.Drawing.Point(234, 79);
            this.kFullNameTb.Name = "kFullNameTb";
            this.kFullNameTb.Size = new System.Drawing.Size(145, 23);
            this.kFullNameTb.TabIndex = 0;
            // 
            // frmCreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kryptonPanel1);
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
        private Krypton.Toolkit.KryptonLabel kAddressLb;
        private Krypton.Toolkit.KryptonTextBox kAddressTb;
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
    }
}