namespace ParkingManagement.GUI.Forms.staff
{
    partial class frmManagePay
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
            this.kDgvListVehiclePay = new Krypton.Toolkit.KryptonDataGridView();
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.kryptonGroupBox2 = new Krypton.Toolkit.KryptonGroupBox();
            this.kBtnSearch = new Krypton.Toolkit.KryptonButton();
            this.kTbSearch = new System.Windows.Forms.TextBox();
            this.kDtpSDate = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel16 = new Krypton.Toolkit.KryptonLabel();
            this.kCbbPayMethod = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.kCbbSFilter = new Krypton.Toolkit.KryptonComboBox();
            this.kCbPaymentMethod = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kTbBks = new System.Windows.Forms.TextBox();
            this.kTbCodeInvoice = new System.Windows.Forms.TextBox();
            this.kTbTotalTime = new System.Windows.Forms.TextBox();
            this.kryptonLabel14 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel15 = new Krypton.Toolkit.KryptonLabel();
            this.kTbTotalPrice = new System.Windows.Forms.TextBox();
            this.kryptonLabel12 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel13 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            this.kDtpPaymentDate = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kTbStaffPay = new System.Windows.Forms.TextBox();
            this.kLbStaffPay = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kDgvListVehiclePay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbPayMethod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbSFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kCbPaymentMethod)).BeginInit();
            this.SuspendLayout();
            // 
            // kDgvListVehiclePay
            // 
            this.kDgvListVehiclePay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kDgvListVehiclePay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kDgvListVehiclePay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kDgvListVehiclePay.Location = new System.Drawing.Point(0, 3);
            this.kDgvListVehiclePay.Name = "kDgvListVehiclePay";
            this.kDgvListVehiclePay.Size = new System.Drawing.Size(1011, 215);
            this.kDgvListVehiclePay.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kDgvListVehiclePay.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kDgvListVehiclePay.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kDgvListVehiclePay.StateCommon.DataCell.Content.Padding = new System.Windows.Forms.Padding(40, 2, 40, 1);
            this.kDgvListVehiclePay.StateCommon.HeaderColumn.Content.Padding = new System.Windows.Forms.Padding(2);
            this.kDgvListVehiclePay.TabIndex = 0;
            this.kDgvListVehiclePay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kDgvListVehiclePay_CellClick);
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(0, 257);
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kDgvListVehiclePay);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(1015, 241);
            this.kryptonGroupBox1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox1.TabIndex = 2;
            this.kryptonGroupBox1.Values.Heading = "Quản lý thanh toán";
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Location = new System.Drawing.Point(532, 14);
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.kBtnSearch);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kTbSearch);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kDtpSDate);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonLabel16);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kCbbPayMethod);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonLabel10);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonLabel6);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kCbbSFilter);
            this.kryptonGroupBox2.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonGroupBox2_Panel_Paint);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(301, 243);
            this.kryptonGroupBox2.TabIndex = 3;
            this.kryptonGroupBox2.Values.Heading = "Lọc";
            // 
            // kBtnSearch
            // 
            this.kBtnSearch.Location = new System.Drawing.Point(216, 155);
            this.kBtnSearch.Name = "kBtnSearch";
            this.kBtnSearch.Size = new System.Drawing.Size(58, 25);
            this.kBtnSearch.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kBtnSearch.TabIndex = 84;
            this.kBtnSearch.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kBtnSearch.Values.Text = "Tìm";
            this.kBtnSearch.Click += new System.EventHandler(this.kBtnSearch_Click_1);
            // 
            // kTbSearch
            // 
            this.kTbSearch.Font = new System.Drawing.Font("Arial", 12F);
            this.kTbSearch.Location = new System.Drawing.Point(23, 154);
            this.kTbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.kTbSearch.Name = "kTbSearch";
            this.kTbSearch.Size = new System.Drawing.Size(236, 26);
            this.kTbSearch.TabIndex = 77;
            // 
            // kDtpSDate
            // 
            this.kDtpSDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.kDtpSDate.Location = new System.Drawing.Point(122, 104);
            this.kDtpSDate.Margin = new System.Windows.Forms.Padding(2);
            this.kDtpSDate.Name = "kDtpSDate";
            this.kDtpSDate.Size = new System.Drawing.Size(140, 24);
            this.kDtpSDate.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kDtpSDate.TabIndex = 78;
            // 
            // kryptonLabel16
            // 
            this.kryptonLabel16.Location = new System.Drawing.Point(29, 108);
            this.kryptonLabel16.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel16.Name = "kryptonLabel16";
            this.kryptonLabel16.Size = new System.Drawing.Size(52, 19);
            this.kryptonLabel16.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel16.TabIndex = 83;
            this.kryptonLabel16.Values.Text = "Ngày :";
            // 
            // kCbbPayMethod
            // 
            this.kCbbPayMethod.DropDownWidth = 217;
            this.kCbbPayMethod.Location = new System.Drawing.Point(122, 65);
            this.kCbbPayMethod.Name = "kCbbPayMethod";
            this.kCbbPayMethod.Size = new System.Drawing.Size(140, 22);
            this.kCbbPayMethod.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kCbbPayMethod.TabIndex = 82;
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(29, 69);
            this.kryptonLabel10.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(91, 19);
            this.kryptonLabel10.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel10.TabIndex = 81;
            this.kryptonLabel10.Values.Text = "Thanh toán :";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(29, 32);
            this.kryptonLabel6.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(70, 19);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 79;
            this.kryptonLabel6.Values.Text = "Tiêu chí :";
            // 
            // kCbbSFilter
            // 
            this.kCbbSFilter.DropDownWidth = 217;
            this.kCbbSFilter.Location = new System.Drawing.Point(122, 28);
            this.kCbbSFilter.Name = "kCbbSFilter";
            this.kCbbSFilter.Size = new System.Drawing.Size(140, 22);
            this.kCbbSFilter.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kCbbSFilter.TabIndex = 80;
            // 
            // kCbPaymentMethod
            // 
            this.kCbPaymentMethod.DropDownWidth = 217;
            this.kCbPaymentMethod.Location = new System.Drawing.Point(250, 162);
            this.kCbPaymentMethod.Name = "kCbPaymentMethod";
            this.kCbPaymentMethod.Size = new System.Drawing.Size(289, 22);
            this.kCbPaymentMethod.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kCbPaymentMethod.TabIndex = 91;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(200, 32);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(17, 21);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 90;
            this.kryptonLabel5.Values.Text = ":";
            // 
            // kTbBks
            // 
            this.kTbBks.Font = new System.Drawing.Font("Arial", 12F);
            this.kTbBks.Location = new System.Drawing.Point(248, 93);
            this.kTbBks.Margin = new System.Windows.Forms.Padding(2);
            this.kTbBks.Name = "kTbBks";
            this.kTbBks.Size = new System.Drawing.Size(288, 26);
            this.kTbBks.TabIndex = 89;
            // 
            // kTbCodeInvoice
            // 
            this.kTbCodeInvoice.Font = new System.Drawing.Font("Arial", 12F);
            this.kTbCodeInvoice.Location = new System.Drawing.Point(248, 59);
            this.kTbCodeInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.kTbCodeInvoice.Name = "kTbCodeInvoice";
            this.kTbCodeInvoice.Size = new System.Drawing.Size(288, 26);
            this.kTbCodeInvoice.TabIndex = 88;
            // 
            // kTbTotalTime
            // 
            this.kTbTotalTime.Font = new System.Drawing.Font("Arial", 12F);
            this.kTbTotalTime.Location = new System.Drawing.Point(249, 193);
            this.kTbTotalTime.Margin = new System.Windows.Forms.Padding(2);
            this.kTbTotalTime.Name = "kTbTotalTime";
            this.kTbTotalTime.Size = new System.Drawing.Size(288, 26);
            this.kTbTotalTime.TabIndex = 87;
            // 
            // kryptonLabel14
            // 
            this.kryptonLabel14.Location = new System.Drawing.Point(200, 198);
            this.kryptonLabel14.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel14.Name = "kryptonLabel14";
            this.kryptonLabel14.Size = new System.Drawing.Size(17, 21);
            this.kryptonLabel14.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel14.TabIndex = 86;
            this.kryptonLabel14.Values.Text = ":";
            // 
            // kryptonLabel15
            // 
            this.kryptonLabel15.Location = new System.Drawing.Point(40, 198);
            this.kryptonLabel15.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel15.Name = "kryptonLabel15";
            this.kryptonLabel15.Size = new System.Drawing.Size(119, 21);
            this.kryptonLabel15.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel15.TabIndex = 85;
            this.kryptonLabel15.Values.Text = "Tổng thời gian";
            // 
            // kTbTotalPrice
            // 
            this.kTbTotalPrice.Font = new System.Drawing.Font("Arial", 12F);
            this.kTbTotalPrice.Location = new System.Drawing.Point(249, 227);
            this.kTbTotalPrice.Margin = new System.Windows.Forms.Padding(2);
            this.kTbTotalPrice.Name = "kTbTotalPrice";
            this.kTbTotalPrice.Size = new System.Drawing.Size(288, 26);
            this.kTbTotalPrice.TabIndex = 84;
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(199, 232);
            this.kryptonLabel12.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(17, 21);
            this.kryptonLabel12.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel12.TabIndex = 83;
            this.kryptonLabel12.Values.Text = ":";
            // 
            // kryptonLabel13
            // 
            this.kryptonLabel13.Location = new System.Drawing.Point(40, 232);
            this.kryptonLabel13.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel13.Name = "kryptonLabel13";
            this.kryptonLabel13.Size = new System.Drawing.Size(81, 21);
            this.kryptonLabel13.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel13.TabIndex = 82;
            this.kryptonLabel13.Values.Text = "Tổng tiền";
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(200, 163);
            this.kryptonLabel11.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(17, 21);
            this.kryptonLabel11.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel11.TabIndex = 81;
            this.kryptonLabel11.Values.Text = ":";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(40, 163);
            this.kryptonLabel9.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(111, 21);
            this.kryptonLabel9.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.TabIndex = 80;
            this.kryptonLabel9.Values.Text = "Phương thức";
            // 
            // kDtpPaymentDate
            // 
            this.kDtpPaymentDate.Location = new System.Drawing.Point(248, 129);
            this.kDtpPaymentDate.Margin = new System.Windows.Forms.Padding(2);
            this.kDtpPaymentDate.Name = "kDtpPaymentDate";
            this.kDtpPaymentDate.Size = new System.Drawing.Size(289, 24);
            this.kDtpPaymentDate.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kDtpPaymentDate.TabIndex = 79;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(200, 132);
            this.kryptonLabel7.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(17, 21);
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 78;
            this.kryptonLabel7.Values.Text = ":";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(40, 132);
            this.kryptonLabel8.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(133, 21);
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.TabIndex = 77;
            this.kryptonLabel8.Values.Text = "Ngày thanh toán";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(200, 98);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(17, 21);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 76;
            this.kryptonLabel3.Values.Text = ":";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(40, 98);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(89, 21);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 75;
            this.kryptonLabel4.Values.Text = "Biển số xe";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(200, 64);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(17, 21);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 74;
            this.kryptonLabel1.Values.Text = ":";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(40, 64);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(99, 21);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 73;
            this.kryptonLabel2.Values.Text = "Mã hoá đơn";
            // 
            // kTbStaffPay
            // 
            this.kTbStaffPay.Font = new System.Drawing.Font("Arial", 12F);
            this.kTbStaffPay.Location = new System.Drawing.Point(248, 29);
            this.kTbStaffPay.Margin = new System.Windows.Forms.Padding(2);
            this.kTbStaffPay.Multiline = true;
            this.kTbStaffPay.Name = "kTbStaffPay";
            this.kTbStaffPay.Size = new System.Drawing.Size(288, 24);
            this.kTbStaffPay.TabIndex = 72;
            // 
            // kLbStaffPay
            // 
            this.kLbStaffPay.Location = new System.Drawing.Point(40, 32);
            this.kLbStaffPay.Margin = new System.Windows.Forms.Padding(2);
            this.kLbStaffPay.Name = "kLbStaffPay";
            this.kLbStaffPay.Size = new System.Drawing.Size(169, 21);
            this.kLbStaffPay.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kLbStaffPay.TabIndex = 71;
            this.kLbStaffPay.Values.Text = "Nhân viên thanh toán";
            // 
            // frmManagePay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 498);
            this.Controls.Add(this.kCbPaymentMethod);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kTbBks);
            this.Controls.Add(this.kTbCodeInvoice);
            this.Controls.Add(this.kTbTotalTime);
            this.Controls.Add(this.kryptonLabel14);
            this.Controls.Add(this.kryptonLabel15);
            this.Controls.Add(this.kTbTotalPrice);
            this.Controls.Add(this.kryptonLabel12);
            this.Controls.Add(this.kryptonLabel13);
            this.Controls.Add(this.kryptonLabel11);
            this.Controls.Add(this.kryptonLabel9);
            this.Controls.Add(this.kDtpPaymentDate);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.kryptonLabel8);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kTbStaffPay);
            this.Controls.Add(this.kLbStaffPay);
            this.Controls.Add(this.kryptonGroupBox1);
            this.Controls.Add(this.kryptonGroupBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmManagePay";
            this.Text = "frmManagePay";
            ((System.ComponentModel.ISupportInitialize)(this.kDgvListVehiclePay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kCbbPayMethod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbSFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kCbPaymentMethod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView kDgvListVehiclePay;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private Krypton.Toolkit.KryptonButton kBtnSearch;
        private System.Windows.Forms.TextBox kTbSearch;
        private Krypton.Toolkit.KryptonDateTimePicker kDtpSDate;
        private Krypton.Toolkit.KryptonLabel kryptonLabel16;
        private Krypton.Toolkit.KryptonComboBox kCbbPayMethod;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonComboBox kCbbSFilter;
        private Krypton.Toolkit.KryptonComboBox kCbPaymentMethod;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private System.Windows.Forms.TextBox kTbBks;
        private System.Windows.Forms.TextBox kTbCodeInvoice;
        private System.Windows.Forms.TextBox kTbTotalTime;
        private Krypton.Toolkit.KryptonLabel kryptonLabel14;
        private Krypton.Toolkit.KryptonLabel kryptonLabel15;
        private System.Windows.Forms.TextBox kTbTotalPrice;
        private Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private Krypton.Toolkit.KryptonLabel kryptonLabel13;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonDateTimePicker kDtpPaymentDate;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private System.Windows.Forms.TextBox kTbStaffPay;
        private Krypton.Toolkit.KryptonLabel kLbStaffPay;
    }
}