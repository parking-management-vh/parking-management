namespace ParkingManagement.GUI.Forms
{
    partial class frmParkingCard
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
            this.kTbBs = new Krypton.Toolkit.KryptonTextBox();
            this.kTbUserCode = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.kTbContentSearch = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonGroupBox2 = new Krypton.Toolkit.KryptonGroupBox();
            this.kBbnCardMonth = new Krypton.Toolkit.KryptonRadioButton();
            this.kBbnCardDay = new Krypton.Toolkit.KryptonRadioButton();
            this.kryptonGroupBox3 = new Krypton.Toolkit.KryptonGroupBox();
            this.kBbnStatusActive = new Krypton.Toolkit.KryptonRadioButton();
            this.kRbtnAllStatus = new Krypton.Toolkit.KryptonRadioButton();
            this.kBbnStatusInactive = new Krypton.Toolkit.KryptonRadioButton();
            this.kRbtnStatusExpired = new Krypton.Toolkit.KryptonRadioButton();
            this.kBtnSearch = new Krypton.Toolkit.KryptonButton();
            this.kTbPrice = new Krypton.Toolkit.KryptonTextBox();
            this.kRbtnDay = new Krypton.Toolkit.KryptonRadioButton();
            this.kRbtnMonth = new Krypton.Toolkit.KryptonRadioButton();
            this.kCbbStatus = new Krypton.Toolkit.KryptonComboBox();
            this.kDtpEnddate = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kDtpStartdate = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.kBtnRefresh = new Krypton.Toolkit.KryptonButton();
            this.kBtnDelete = new Krypton.Toolkit.KryptonButton();
            this.kBtnEdit = new Krypton.Toolkit.KryptonButton();
            this.kBtnCreat = new Krypton.Toolkit.KryptonButton();
            this.kDgvParkingCard = new Krypton.Toolkit.KryptonDataGridView();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3.Panel)).BeginInit();
            this.kryptonGroupBox3.Panel.SuspendLayout();
            this.kryptonGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kDgvParkingCard)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kTbBs);
            this.kryptonPanel1.Controls.Add(this.kTbUserCode);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel1.Controls.Add(this.kTbPrice);
            this.kryptonPanel1.Controls.Add(this.kRbtnDay);
            this.kryptonPanel1.Controls.Add(this.kRbtnMonth);
            this.kryptonPanel1.Controls.Add(this.kCbbStatus);
            this.kryptonPanel1.Controls.Add(this.kDtpEnddate);
            this.kryptonPanel1.Controls.Add(this.kDtpStartdate);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Location = new System.Drawing.Point(2, 83);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            this.kryptonPanel1.Size = new System.Drawing.Size(666, 208);
            this.kryptonPanel1.TabIndex = 0;
            this.kryptonPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonPanel1_Paint);
            // 
            // kTbBs
            // 
            this.kTbBs.Location = new System.Drawing.Point(232, 56);
            this.kTbBs.Name = "kTbBs";
            this.kTbBs.Size = new System.Drawing.Size(77, 23);
            this.kTbBs.TabIndex = 17;
            this.kTbBs.Text = "Biển số";
            // 
            // kTbUserCode
            // 
            this.kTbUserCode.Location = new System.Drawing.Point(232, 15);
            this.kTbUserCode.Name = "kTbUserCode";
            this.kTbUserCode.Size = new System.Drawing.Size(77, 23);
            this.kTbUserCode.TabIndex = 16;
            this.kTbUserCode.Text = "Code User";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kTbContentSearch);
            this.kryptonPanel2.Controls.Add(this.kryptonGroupBox2);
            this.kryptonPanel2.Controls.Add(this.kryptonGroupBox3);
            this.kryptonPanel2.Controls.Add(this.kBtnSearch);
            this.kryptonPanel2.Location = new System.Drawing.Point(332, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            this.kryptonPanel2.Size = new System.Drawing.Size(334, 209);
            this.kryptonPanel2.TabIndex = 3;
            // 
            // kTbContentSearch
            // 
            this.kTbContentSearch.Location = new System.Drawing.Point(25, 165);
            this.kTbContentSearch.Name = "kTbContentSearch";
            this.kTbContentSearch.Size = new System.Drawing.Size(204, 23);
            this.kTbContentSearch.TabIndex = 16;
            this.kTbContentSearch.TextChanged += new System.EventHandler(this.kTbContentSearch_TextChanged);
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.CaptionStyle = Krypton.Toolkit.LabelStyle.ItalicControl;
            this.kryptonGroupBox2.Location = new System.Drawing.Point(234, 73);
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.kBbnCardMonth);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kBbnCardDay);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(74, 75);
            this.kryptonGroupBox2.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonGroupBox2.TabIndex = 34;
            this.kryptonGroupBox2.Values.Heading = "Thẻ :";
            // 
            // kBbnCardMonth
            // 
            this.kBbnCardMonth.Location = new System.Drawing.Point(12, 4);
            this.kBbnCardMonth.Name = "kBbnCardMonth";
            this.kBbnCardMonth.Size = new System.Drawing.Size(57, 20);
            this.kBbnCardMonth.TabIndex = 26;
            this.kBbnCardMonth.Values.Text = "Tháng";
            // 
            // kBbnCardDay
            // 
            this.kBbnCardDay.Location = new System.Drawing.Point(12, 28);
            this.kBbnCardDay.Name = "kBbnCardDay";
            this.kBbnCardDay.Size = new System.Drawing.Size(51, 20);
            this.kBbnCardDay.TabIndex = 24;
            this.kBbnCardDay.Values.Text = "Ngày";
            this.kBbnCardDay.CheckedChanged += new System.EventHandler(this.kryptonRadioButton8_CheckedChanged);
            // 
            // kryptonGroupBox3
            // 
            this.kryptonGroupBox3.CaptionStyle = Krypton.Toolkit.LabelStyle.ItalicControl;
            this.kryptonGroupBox3.Location = new System.Drawing.Point(25, 73);
            // 
            // kryptonGroupBox3.Panel
            // 
            this.kryptonGroupBox3.Panel.Controls.Add(this.kBbnStatusActive);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kRbtnAllStatus);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kBbnStatusInactive);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kRbtnStatusExpired);
            this.kryptonGroupBox3.Size = new System.Drawing.Size(204, 74);
            this.kryptonGroupBox3.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonGroupBox3.TabIndex = 33;
            this.kryptonGroupBox3.Values.Heading = "Trạng thái thẻ :";
            // 
            // kBbnStatusActive
            // 
            this.kBbnStatusActive.Location = new System.Drawing.Point(84, 4);
            this.kBbnStatusActive.Name = "kBbnStatusActive";
            this.kBbnStatusActive.Size = new System.Drawing.Size(81, 20);
            this.kBbnStatusActive.TabIndex = 27;
            this.kBbnStatusActive.Values.Text = "Hoạt động";
            // 
            // kRbtnAllStatus
            // 
            this.kRbtnAllStatus.Location = new System.Drawing.Point(7, 4);
            this.kRbtnAllStatus.Name = "kRbtnAllStatus";
            this.kRbtnAllStatus.Size = new System.Drawing.Size(55, 20);
            this.kRbtnAllStatus.TabIndex = 26;
            this.kRbtnAllStatus.Values.Text = "Tất cả";
            // 
            // kBbnStatusInactive
            // 
            this.kBbnStatusInactive.Location = new System.Drawing.Point(84, 28);
            this.kBbnStatusInactive.Name = "kBbnStatusInactive";
            this.kBbnStatusInactive.Size = new System.Drawing.Size(118, 20);
            this.kBbnStatusInactive.TabIndex = 25;
            this.kBbnStatusInactive.Values.Text = "Không hoạt động";
            // 
            // kRbtnStatusExpired
            // 
            this.kRbtnStatusExpired.Location = new System.Drawing.Point(7, 28);
            this.kRbtnStatusExpired.Name = "kRbtnStatusExpired";
            this.kRbtnStatusExpired.Size = new System.Drawing.Size(66, 20);
            this.kRbtnStatusExpired.TabIndex = 24;
            this.kRbtnStatusExpired.Values.Text = "Hết hạn";
            // 
            // kBtnSearch
            // 
            this.kBtnSearch.Location = new System.Drawing.Point(234, 158);
            this.kBtnSearch.Margin = new System.Windows.Forms.Padding(6);
            this.kBtnSearch.Name = "kBtnSearch";
            this.kBtnSearch.Size = new System.Drawing.Size(74, 30);
            this.kBtnSearch.TabIndex = 4;
            this.kBtnSearch.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kBtnSearch.Values.Image = global::ParkingManagement.Properties.Resources.search24;
            this.kBtnSearch.Values.Text = "Tìm";
            // 
            // kTbPrice
            // 
            this.kTbPrice.Location = new System.Drawing.Point(117, 167);
            this.kTbPrice.Name = "kTbPrice";
            this.kTbPrice.Size = new System.Drawing.Size(169, 23);
            this.kTbPrice.TabIndex = 15;
            this.kTbPrice.TextChanged += new System.EventHandler(this.kTbPrice_TextChanged);
            // 
            // kRbtnDay
            // 
            this.kRbtnDay.Location = new System.Drawing.Point(172, 92);
            this.kRbtnDay.Name = "kRbtnDay";
            this.kRbtnDay.Size = new System.Drawing.Size(51, 20);
            this.kRbtnDay.TabIndex = 14;
            this.kRbtnDay.Values.Text = "Ngày";
            this.kRbtnDay.CheckedChanged += new System.EventHandler(this.kRbtnDay_CheckedChanged);
            // 
            // kRbtnMonth
            // 
            this.kRbtnMonth.Location = new System.Drawing.Point(115, 92);
            this.kRbtnMonth.Name = "kRbtnMonth";
            this.kRbtnMonth.Size = new System.Drawing.Size(57, 20);
            this.kRbtnMonth.TabIndex = 13;
            this.kRbtnMonth.Values.Text = "Tháng";
            this.kRbtnMonth.CheckedChanged += new System.EventHandler(this.kRbtnMonth_CheckedChanged);
            // 
            // kCbbStatus
            // 
            this.kCbbStatus.DropDownWidth = 168;
            this.kCbbStatus.Location = new System.Drawing.Point(118, 127);
            this.kCbbStatus.Name = "kCbbStatus";
            this.kCbbStatus.Size = new System.Drawing.Size(169, 22);
            this.kCbbStatus.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kCbbStatus.TabIndex = 12;
            // 
            // kDtpEnddate
            // 
            this.kDtpEnddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.kDtpEnddate.Location = new System.Drawing.Point(118, 56);
            this.kDtpEnddate.Name = "kDtpEnddate";
            this.kDtpEnddate.Size = new System.Drawing.Size(76, 21);
            this.kDtpEnddate.TabIndex = 11;
            // 
            // kDtpStartdate
            // 
            this.kDtpStartdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.kDtpStartdate.Location = new System.Drawing.Point(117, 17);
            this.kDtpStartdate.Name = "kDtpStartdate";
            this.kDtpStartdate.Size = new System.Drawing.Size(76, 21);
            this.kDtpStartdate.TabIndex = 10;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(27, 171);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(58, 20);
            this.kryptonLabel5.TabIndex = 9;
            this.kryptonLabel5.Values.Text = "Giá tiền :";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(26, 94);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(36, 20);
            this.kryptonLabel4.TabIndex = 8;
            this.kryptonLabel4.Values.Text = "Thẻ :";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(26, 131);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(93, 20);
            this.kryptonLabel3.TabIndex = 7;
            this.kryptonLabel3.Values.Text = "Trạng thái thẻ :";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(26, 59);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(90, 20);
            this.kryptonLabel2.TabIndex = 6;
            this.kryptonLabel2.Values.Text = "Ngày hết hạn :";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(26, 20);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(90, 20);
            this.kryptonLabel1.TabIndex = 5;
            this.kryptonLabel1.Values.Text = "Ngày bắt đầu :";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.CaptionStyle = Krypton.Toolkit.LabelStyle.ItalicControl;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(2, -11);
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kBtnRefresh);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kBtnDelete);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kBtnEdit);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kBtnCreat);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(673, 88);
            this.kryptonGroupBox1.TabIndex = 1;
            this.kryptonGroupBox1.Values.Heading = "Tùy chọn";
            // 
            // kBtnRefresh
            // 
            this.kBtnRefresh.Location = new System.Drawing.Point(505, 20);
            this.kBtnRefresh.Margin = new System.Windows.Forms.Padding(6);
            this.kBtnRefresh.Name = "kBtnRefresh";
            this.kBtnRefresh.Size = new System.Drawing.Size(83, 30);
            this.kBtnRefresh.TabIndex = 3;
            this.kBtnRefresh.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kBtnRefresh.Values.Image = global::ParkingManagement.Properties.Resources.refersh241;
            this.kBtnRefresh.Values.Text = "Làm mới";
            this.kBtnRefresh.Click += new System.EventHandler(this.kBtnRefresh_Click);
            // 
            // kBtnDelete
            // 
            this.kBtnDelete.Location = new System.Drawing.Point(355, 20);
            this.kBtnDelete.Margin = new System.Windows.Forms.Padding(6);
            this.kBtnDelete.Name = "kBtnDelete";
            this.kBtnDelete.Size = new System.Drawing.Size(83, 30);
            this.kBtnDelete.TabIndex = 2;
            this.kBtnDelete.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kBtnDelete.Values.Image = global::ParkingManagement.Properties.Resources.delete24;
            this.kBtnDelete.Values.Text = "Xóa";
            // 
            // kBtnEdit
            // 
            this.kBtnEdit.Location = new System.Drawing.Point(201, 20);
            this.kBtnEdit.Margin = new System.Windows.Forms.Padding(6);
            this.kBtnEdit.Name = "kBtnEdit";
            this.kBtnEdit.Size = new System.Drawing.Size(83, 30);
            this.kBtnEdit.TabIndex = 1;
            this.kBtnEdit.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kBtnEdit.Values.Image = global::ParkingManagement.Properties.Resources.edit;
            this.kBtnEdit.Values.Text = "Sửa";
            // 
            // kBtnCreat
            // 
            this.kBtnCreat.Location = new System.Drawing.Point(55, 20);
            this.kBtnCreat.Margin = new System.Windows.Forms.Padding(6);
            this.kBtnCreat.Name = "kBtnCreat";
            this.kBtnCreat.Size = new System.Drawing.Size(83, 30);
            this.kBtnCreat.TabIndex = 0;
            this.kBtnCreat.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kBtnCreat.Values.Image = global::ParkingManagement.Properties.Resources.newfile24;
            this.kBtnCreat.Values.Text = "Tạo";
            this.kBtnCreat.Click += new System.EventHandler(this.kBtnCreat_Click);
            // 
            // kDgvParkingCard
            // 
            this.kDgvParkingCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kDgvParkingCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kDgvParkingCard.Location = new System.Drawing.Point(-7, 298);
            this.kDgvParkingCard.Name = "kDgvParkingCard";
            this.kDgvParkingCard.Size = new System.Drawing.Size(675, 180);
            this.kDgvParkingCard.TabIndex = 2;
            this.kDgvParkingCard.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kDgvParkingCard_CellClick);
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.LabelStyle = Krypton.Toolkit.LabelStyle.ItalicControl;
            this.kryptonLabel6.Location = new System.Drawing.Point(2, 298);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(49, 20);
            this.kryptonLabel6.TabIndex = 3;
            this.kryptonLabel6.Values.Text = "Dữ liệu ";
            // 
            // frmParkingCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 490);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.kDgvParkingCard);
            this.Controls.Add(this.kryptonGroupBox1);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "frmParkingCard";
            this.Text = "frmParkingCard";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3.Panel)).EndInit();
            this.kryptonGroupBox3.Panel.ResumeLayout(false);
            this.kryptonGroupBox3.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3)).EndInit();
            this.kryptonGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kCbbStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kDgvParkingCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonDataGridView kDgvParkingCard;
        private Krypton.Toolkit.KryptonButton kBtnRefresh;
        private Krypton.Toolkit.KryptonButton kBtnDelete;
        private Krypton.Toolkit.KryptonButton kBtnEdit;
        private Krypton.Toolkit.KryptonButton kBtnCreat;
        private Krypton.Toolkit.KryptonButton kBtnSearch;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox kTbPrice;
        private Krypton.Toolkit.KryptonRadioButton kRbtnDay;
        private Krypton.Toolkit.KryptonRadioButton kRbtnMonth;
        private Krypton.Toolkit.KryptonComboBox kCbbStatus;
        private Krypton.Toolkit.KryptonDateTimePicker kDtpEnddate;
        private Krypton.Toolkit.KryptonDateTimePicker kDtpStartdate;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox3;
        private Krypton.Toolkit.KryptonRadioButton kRbtnAllStatus;
        private Krypton.Toolkit.KryptonRadioButton kBbnStatusInactive;
        private Krypton.Toolkit.KryptonRadioButton kRbtnStatusExpired;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private Krypton.Toolkit.KryptonRadioButton kBbnCardMonth;
        private Krypton.Toolkit.KryptonRadioButton kBbnCardDay;
        private Krypton.Toolkit.KryptonTextBox kTbContentSearch;
        private Krypton.Toolkit.KryptonRadioButton kBbnStatusActive;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonTextBox kTbBs;
        private Krypton.Toolkit.KryptonTextBox kTbUserCode;
    }
}