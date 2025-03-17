namespace ParkingManagement.GUI.Forms
{
    partial class frmVehicle
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
            this.kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            this.kDgvVehicle = new Krypton.Toolkit.KryptonDataGridView();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.kBtnFilter = new Krypton.Toolkit.KryptonButton();
            this.kBtnDelete = new Krypton.Toolkit.KryptonButton();
            this.kBtnUpdate = new Krypton.Toolkit.KryptonButton();
            this.kBtnCreateV = new Krypton.Toolkit.KryptonButton();
            this.kBtnReset = new Krypton.Toolkit.KryptonButton();
            this.kDTPOut = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kDTPIn = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kTbLicense_Plate = new System.Windows.Forms.TextBox();
            this.kCbbTypeVehicle = new Krypton.Toolkit.KryptonComboBox();
            this.kCbbSlot = new Krypton.Toolkit.KryptonComboBox();
            this.kCbbArea = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            this.kBtnSearch = new Krypton.Toolkit.KryptonButton();
            this.kTbSBks = new System.Windows.Forms.TextBox();
            this.kCbbSTypeV = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            this.kCbbSSlot = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            this.kCbbSArea = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kDgvVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbTypeVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbSlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbSTypeV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbSSlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbSArea)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonLabel11);
            this.kryptonPanel1.Controls.Add(this.kDgvVehicle);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 305);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1140, 227);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(4, 3);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(49, 18);
            this.kryptonLabel11.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel11.TabIndex = 3;
            this.kryptonLabel11.Values.Text = "Dữ liệu";
            // 
            // kDgvVehicle
            // 
            this.kDgvVehicle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kDgvVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kDgvVehicle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kDgvVehicle.Location = new System.Drawing.Point(0, 23);
            this.kDgvVehicle.Margin = new System.Windows.Forms.Padding(2);
            this.kDgvVehicle.Name = "kDgvVehicle";
            this.kDgvVehicle.RowHeadersWidth = 51;
            this.kDgvVehicle.RowTemplate.Height = 24;
            this.kDgvVehicle.Size = new System.Drawing.Size(1140, 204);
            this.kDgvVehicle.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kDgvVehicle.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kDgvVehicle.StateCommon.DataCell.Content.Padding = new System.Windows.Forms.Padding(38, 2, 38, 2);
            this.kDgvVehicle.TabIndex = 0;
            this.kDgvVehicle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kDgvVehicle_CellClick);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kBtnFilter);
            this.kryptonPanel2.Controls.Add(this.kBtnDelete);
            this.kryptonPanel2.Controls.Add(this.kBtnUpdate);
            this.kryptonPanel2.Controls.Add(this.kBtnCreateV);
            this.kryptonPanel2.Controls.Add(this.kBtnReset);
            this.kryptonPanel2.Controls.Add(this.kDTPOut);
            this.kryptonPanel2.Controls.Add(this.kDTPIn);
            this.kryptonPanel2.Controls.Add(this.kTbLicense_Plate);
            this.kryptonPanel2.Controls.Add(this.kCbbTypeVehicle);
            this.kryptonPanel2.Controls.Add(this.kCbbSlot);
            this.kryptonPanel2.Controls.Add(this.kCbbArea);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel2.Location = new System.Drawing.Point(57, 22);
            this.kryptonPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(413, 258);
            this.kryptonPanel2.TabIndex = 1;
            this.kryptonPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonPanel2_Paint);
            // 
            // kBtnFilter
            // 
            this.kBtnFilter.Location = new System.Drawing.Point(221, 110);
            this.kBtnFilter.Margin = new System.Windows.Forms.Padding(2);
            this.kBtnFilter.Name = "kBtnFilter";
            this.kBtnFilter.Size = new System.Drawing.Size(68, 30);
            this.kBtnFilter.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kBtnFilter.TabIndex = 15;
            this.kBtnFilter.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kBtnFilter.Values.Text = "Lọc";
            this.kBtnFilter.Click += new System.EventHandler(this.kBtnFilter_Click);
            // 
            // kBtnDelete
            // 
            this.kBtnDelete.Location = new System.Drawing.Point(317, 190);
            this.kBtnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.kBtnDelete.Name = "kBtnDelete";
            this.kBtnDelete.Size = new System.Drawing.Size(68, 30);
            this.kBtnDelete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kBtnDelete.TabIndex = 14;
            this.kBtnDelete.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kBtnDelete.Values.Text = "Xoá";
            this.kBtnDelete.Click += new System.EventHandler(this.kBtnDelete_Click);
            // 
            // kBtnUpdate
            // 
            this.kBtnUpdate.Location = new System.Drawing.Point(317, 138);
            this.kBtnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.kBtnUpdate.Name = "kBtnUpdate";
            this.kBtnUpdate.Size = new System.Drawing.Size(68, 29);
            this.kBtnUpdate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kBtnUpdate.TabIndex = 13;
            this.kBtnUpdate.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kBtnUpdate.Values.Text = "Lưu";
            this.kBtnUpdate.Click += new System.EventHandler(this.kBtnUpdate_Click);
            // 
            // kBtnCreateV
            // 
            this.kBtnCreateV.Location = new System.Drawing.Point(317, 30);
            this.kBtnCreateV.Margin = new System.Windows.Forms.Padding(2);
            this.kBtnCreateV.Name = "kBtnCreateV";
            this.kBtnCreateV.Size = new System.Drawing.Size(68, 30);
            this.kBtnCreateV.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kBtnCreateV.TabIndex = 12;
            this.kBtnCreateV.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kBtnCreateV.Values.Text = "Tạo";
            this.kBtnCreateV.Click += new System.EventHandler(this.kBtnCreateV_Click);
            // 
            // kBtnReset
            // 
            this.kBtnReset.Location = new System.Drawing.Point(317, 84);
            this.kBtnReset.Margin = new System.Windows.Forms.Padding(2);
            this.kBtnReset.Name = "kBtnReset";
            this.kBtnReset.Size = new System.Drawing.Size(68, 29);
            this.kBtnReset.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kBtnReset.TabIndex = 0;
            this.kBtnReset.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kBtnReset.Values.Text = "Reset";
            this.kBtnReset.Click += new System.EventHandler(this.kBtnReset_Click);
            // 
            // kDTPOut
            // 
            this.kDTPOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.kDTPOut.Location = new System.Drawing.Point(141, 217);
            this.kDTPOut.Margin = new System.Windows.Forms.Padding(2);
            this.kDTPOut.Name = "kDTPOut";
            this.kDTPOut.Size = new System.Drawing.Size(148, 21);
            this.kDTPOut.TabIndex = 11;
            // 
            // kDTPIn
            // 
            this.kDTPIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.kDTPIn.Location = new System.Drawing.Point(141, 185);
            this.kDTPIn.Margin = new System.Windows.Forms.Padding(2);
            this.kDTPIn.Name = "kDTPIn";
            this.kDTPIn.Size = new System.Drawing.Size(148, 21);
            this.kDTPIn.TabIndex = 10;
            // 
            // kTbLicense_Plate
            // 
            this.kTbLicense_Plate.Location = new System.Drawing.Point(141, 154);
            this.kTbLicense_Plate.Margin = new System.Windows.Forms.Padding(2);
            this.kTbLicense_Plate.Name = "kTbLicense_Plate";
            this.kTbLicense_Plate.Size = new System.Drawing.Size(148, 20);
            this.kTbLicense_Plate.TabIndex = 9;
            // 
            // kCbbTypeVehicle
            // 
            this.kCbbTypeVehicle.DropDownWidth = 198;
            this.kCbbTypeVehicle.Location = new System.Drawing.Point(141, 78);
            this.kCbbTypeVehicle.Margin = new System.Windows.Forms.Padding(2);
            this.kCbbTypeVehicle.Name = "kCbbTypeVehicle";
            this.kCbbTypeVehicle.Size = new System.Drawing.Size(148, 22);
            this.kCbbTypeVehicle.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kCbbTypeVehicle.TabIndex = 8;
            this.kCbbTypeVehicle.SelectedIndexChanged += new System.EventHandler(this.kCbbTypeVehicle_SelectedIndexChanged);
            // 
            // kCbbSlot
            // 
            this.kCbbSlot.DropDownWidth = 198;
            this.kCbbSlot.Location = new System.Drawing.Point(141, 48);
            this.kCbbSlot.Margin = new System.Windows.Forms.Padding(2);
            this.kCbbSlot.Name = "kCbbSlot";
            this.kCbbSlot.Size = new System.Drawing.Size(148, 22);
            this.kCbbSlot.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kCbbSlot.TabIndex = 7;
            // 
            // kCbbArea
            // 
            this.kCbbArea.DropDownWidth = 198;
            this.kCbbArea.Location = new System.Drawing.Point(141, 18);
            this.kCbbArea.Margin = new System.Windows.Forms.Padding(2);
            this.kCbbArea.Name = "kCbbArea";
            this.kCbbArea.Size = new System.Drawing.Size(148, 22);
            this.kCbbArea.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kCbbArea.TabIndex = 6;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(22, 218);
            this.kryptonLabel6.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(85, 18);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 5;
            this.kryptonLabel6.Values.Text = "Thời gian ra :";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(22, 186);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(94, 18);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 4;
            this.kryptonLabel5.Values.Text = "Thời gian vào :";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(22, 154);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(101, 18);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 3;
            this.kryptonLabel4.Values.Text = "Biển kiểm soát :";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(22, 52);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(43, 18);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Values.Text = "Vị trí :";
            this.kryptonLabel3.Click += new System.EventHandler(this.kryptonLabel3_Click);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(22, 82);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(112, 18);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Loại phương tiện :";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(22, 22);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(63, 18);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Khu vực :";
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.kryptonLabel10);
            this.kryptonPanel3.Controls.Add(this.kBtnSearch);
            this.kryptonPanel3.Controls.Add(this.kTbSBks);
            this.kryptonPanel3.Controls.Add(this.kCbbSTypeV);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel9);
            this.kryptonPanel3.Controls.Add(this.kCbbSSlot);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel8);
            this.kryptonPanel3.Controls.Add(this.kCbbSArea);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel7);
            this.kryptonPanel3.Location = new System.Drawing.Point(524, 23);
            this.kryptonPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(371, 258);
            this.kryptonPanel3.TabIndex = 2;
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(32, 160);
            this.kryptonLabel10.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(101, 18);
            this.kryptonLabel10.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel10.TabIndex = 22;
            this.kryptonLabel10.Values.Text = "Biển kiểm soát :";
            // 
            // kBtnSearch
            // 
            this.kBtnSearch.Location = new System.Drawing.Point(254, 199);
            this.kBtnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.kBtnSearch.Name = "kBtnSearch";
            this.kBtnSearch.Size = new System.Drawing.Size(68, 30);
            this.kBtnSearch.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kBtnSearch.TabIndex = 16;
            this.kBtnSearch.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kBtnSearch.Values.Text = "Tìm kiếm";
            this.kBtnSearch.Click += new System.EventHandler(this.kBtnSearch_Click);
            // 
            // kTbSBks
            // 
            this.kTbSBks.Location = new System.Drawing.Point(174, 158);
            this.kTbSBks.Margin = new System.Windows.Forms.Padding(2);
            this.kTbSBks.Name = "kTbSBks";
            this.kTbSBks.Size = new System.Drawing.Size(148, 20);
            this.kTbSBks.TabIndex = 16;
            // 
            // kCbbSTypeV
            // 
            this.kCbbSTypeV.DropDownWidth = 198;
            this.kCbbSTypeV.Location = new System.Drawing.Point(174, 116);
            this.kCbbSTypeV.Margin = new System.Windows.Forms.Padding(2);
            this.kCbbSTypeV.Name = "kCbbSTypeV";
            this.kCbbSTypeV.Size = new System.Drawing.Size(148, 22);
            this.kCbbSTypeV.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kCbbSTypeV.TabIndex = 21;
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(32, 36);
            this.kryptonLabel9.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(63, 18);
            this.kryptonLabel9.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.TabIndex = 16;
            this.kryptonLabel9.Values.Text = "Khu vực :";
            // 
            // kCbbSSlot
            // 
            this.kCbbSSlot.DropDownWidth = 198;
            this.kCbbSSlot.Location = new System.Drawing.Point(174, 74);
            this.kCbbSSlot.Margin = new System.Windows.Forms.Padding(2);
            this.kCbbSSlot.Name = "kCbbSSlot";
            this.kCbbSSlot.Size = new System.Drawing.Size(148, 22);
            this.kCbbSSlot.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kCbbSSlot.TabIndex = 20;
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(32, 120);
            this.kryptonLabel8.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(112, 18);
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.TabIndex = 17;
            this.kryptonLabel8.Values.Text = "Loại phương tiện :";
            // 
            // kCbbSArea
            // 
            this.kCbbSArea.DropDownWidth = 198;
            this.kCbbSArea.Location = new System.Drawing.Point(174, 32);
            this.kCbbSArea.Margin = new System.Windows.Forms.Padding(2);
            this.kCbbSArea.Name = "kCbbSArea";
            this.kCbbSArea.Size = new System.Drawing.Size(148, 22);
            this.kCbbSArea.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kCbbSArea.TabIndex = 19;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(32, 78);
            this.kryptonLabel7.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(43, 18);
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 18;
            this.kryptonLabel7.Values.Text = "Vị trí :";
            // 
            // frmVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 532);
            this.Controls.Add(this.kryptonPanel3);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmVehicle";
            this.Text = "frmVehicle";
            this.Load += new System.EventHandler(this.frmVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kDgvVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbTypeVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbSlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbSTypeV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbSSlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbSArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonDataGridView kDgvVehicle;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonComboBox kCbbArea;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonDateTimePicker kDTPOut;
        private Krypton.Toolkit.KryptonDateTimePicker kDTPIn;
        private System.Windows.Forms.TextBox kTbLicense_Plate;
        private Krypton.Toolkit.KryptonComboBox kCbbTypeVehicle;
        private Krypton.Toolkit.KryptonComboBox kCbbSlot;
        private Krypton.Toolkit.KryptonButton kBtnReset;
        private Krypton.Toolkit.KryptonButton kBtnDelete;
        private Krypton.Toolkit.KryptonButton kBtnUpdate;
        private Krypton.Toolkit.KryptonButton kBtnCreateV;
        private Krypton.Toolkit.KryptonButton kBtnFilter;
        private Krypton.Toolkit.KryptonButton kBtnSearch;
        private System.Windows.Forms.TextBox kTbSBks;
        private Krypton.Toolkit.KryptonComboBox kCbbSTypeV;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonComboBox kCbbSSlot;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonComboBox kCbbSArea;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
    }
}