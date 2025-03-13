namespace ParkingManagement.GUI.Forms
{
    partial class frmParkingSlot
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
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.kbtnRefresh = new Krypton.Toolkit.KryptonButton();
            this.kbtnDelete = new Krypton.Toolkit.KryptonButton();
            this.kbtnEdit = new Krypton.Toolkit.KryptonButton();
            this.kbtnCreate = new Krypton.Toolkit.KryptonButton();
            this.kbtnSearch = new Krypton.Toolkit.KryptonButton();
            this.kCbbSArea = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kPnSlot = new Krypton.Toolkit.KryptonPanel();
            this.kCbbSSlotType = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.kCbbSStatus = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kCbbParkingarea = new Krypton.Toolkit.KryptonComboBox();
            this.kCbbStatus = new Krypton.Toolkit.KryptonComboBox();
            this.kCbbSlottype = new Krypton.Toolkit.KryptonComboBox();
            this.kTbSlotnumber = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kDgvParkingSlot = new Krypton.Toolkit.KryptonDataGridView();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbSArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kPnSlot)).BeginInit();
            this.kPnSlot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbSSlotType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbSStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbParkingarea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbSlottype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kDgvParkingSlot)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.CaptionStyle = Krypton.Toolkit.LabelStyle.ItalicControl;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(0, 0);
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kbtnRefresh);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kbtnDelete);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kbtnEdit);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kbtnCreate);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(641, 91);
            this.kryptonGroupBox1.TabIndex = 0;
            this.kryptonGroupBox1.Values.Heading = "Tùy chọn";
            // 
            // kbtnRefresh
            // 
            this.kbtnRefresh.Location = new System.Drawing.Point(496, 19);
            this.kbtnRefresh.Name = "kbtnRefresh";
            this.kbtnRefresh.Size = new System.Drawing.Size(90, 30);
            this.kbtnRefresh.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnRefresh.TabIndex = 4;
            this.kbtnRefresh.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kbtnRefresh.Values.Image = global::ParkingManagement.Properties.Resources.refersh24;
            this.kbtnRefresh.Values.Text = "Làm mới";
            this.kbtnRefresh.Click += new System.EventHandler(this.kbtnRefresh_Click);
            // 
            // kbtnDelete
            // 
            this.kbtnDelete.Location = new System.Drawing.Point(343, 19);
            this.kbtnDelete.Name = "kbtnDelete";
            this.kbtnDelete.Size = new System.Drawing.Size(90, 30);
            this.kbtnDelete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnDelete.TabIndex = 2;
            this.kbtnDelete.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kbtnDelete.Values.Image = global::ParkingManagement.Properties.Resources.delete24;
            this.kbtnDelete.Values.Text = "Xóa";
            this.kbtnDelete.Click += new System.EventHandler(this.kbtnDelete_Click);
            // 
            // kbtnEdit
            // 
            this.kbtnEdit.Location = new System.Drawing.Point(186, 19);
            this.kbtnEdit.Name = "kbtnEdit";
            this.kbtnEdit.Size = new System.Drawing.Size(90, 30);
            this.kbtnEdit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnEdit.TabIndex = 1;
            this.kbtnEdit.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kbtnEdit.Values.Image = global::ParkingManagement.Properties.Resources.edit;
            this.kbtnEdit.Values.Text = "Sửa";
            this.kbtnEdit.Click += new System.EventHandler(this.kbtnEdit_Click);
            // 
            // kbtnCreate
            // 
            this.kbtnCreate.Location = new System.Drawing.Point(33, 19);
            this.kbtnCreate.Name = "kbtnCreate";
            this.kbtnCreate.Size = new System.Drawing.Size(90, 30);
            this.kbtnCreate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCreate.TabIndex = 0;
            this.kbtnCreate.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kbtnCreate.Values.Image = global::ParkingManagement.Properties.Resources.newfile24;
            this.kbtnCreate.Values.Text = "Tạo";
            this.kbtnCreate.Click += new System.EventHandler(this.kbtnCreate_Click);
            // 
            // kbtnSearch
            // 
            this.kbtnSearch.Location = new System.Drawing.Point(498, 131);
            this.kbtnSearch.Name = "kbtnSearch";
            this.kbtnSearch.Size = new System.Drawing.Size(90, 30);
            this.kbtnSearch.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSearch.TabIndex = 4;
            this.kbtnSearch.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kbtnSearch.Values.Image = global::ParkingManagement.Properties.Resources.search24;
            this.kbtnSearch.Values.Text = "Tìm kiếm";
            this.kbtnSearch.Click += new System.EventHandler(this.kbtnSearch_Click);
            // 
            // kCbbSArea
            // 
            this.kCbbSArea.DropDownWidth = 90;
            this.kCbbSArea.Location = new System.Drawing.Point(514, 92);
            this.kCbbSArea.Name = "kCbbSArea";
            this.kCbbSArea.Size = new System.Drawing.Size(74, 22);
            this.kCbbSArea.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kCbbSArea.TabIndex = 7;
            this.kCbbSArea.SelectedIndexChanged += new System.EventHandler(this.kCbbSArea_SelectedIndexChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(405, 27);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(5);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kryptonLabel2.Size = new System.Drawing.Size(69, 18);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 8;
            this.kryptonLabel2.Values.Text = "Loại vị trí :";
            // 
            // kPnSlot
            // 
            this.kPnSlot.Controls.Add(this.kCbbSSlotType);
            this.kPnSlot.Controls.Add(this.kryptonLabel6);
            this.kPnSlot.Controls.Add(this.kCbbSStatus);
            this.kPnSlot.Controls.Add(this.kryptonLabel1);
            this.kPnSlot.Controls.Add(this.kCbbParkingarea);
            this.kPnSlot.Controls.Add(this.kCbbStatus);
            this.kPnSlot.Controls.Add(this.kCbbSlottype);
            this.kPnSlot.Controls.Add(this.kTbSlotnumber);
            this.kPnSlot.Controls.Add(this.kryptonLabel2);
            this.kPnSlot.Controls.Add(this.kryptonLabel7);
            this.kPnSlot.Controls.Add(this.kryptonLabel5);
            this.kPnSlot.Controls.Add(this.kCbbSArea);
            this.kPnSlot.Controls.Add(this.kryptonLabel4);
            this.kPnSlot.Controls.Add(this.kryptonLabel3);
            this.kPnSlot.Controls.Add(this.kbtnSearch);
            this.kPnSlot.ImeMode = System.Windows.Forms.ImeMode.On;
            this.kPnSlot.Location = new System.Drawing.Point(0, 96);
            this.kPnSlot.Margin = new System.Windows.Forms.Padding(5);
            this.kPnSlot.Name = "kPnSlot";
            this.kPnSlot.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kPnSlot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kPnSlot.Size = new System.Drawing.Size(641, 172);
            this.kPnSlot.StateCommon.Color1 = System.Drawing.Color.White;
            this.kPnSlot.TabIndex = 1;
            this.kPnSlot.Paint += new System.Windows.Forms.PaintEventHandler(this.kPnSlot_Paint);
            // 
            // kCbbSSlotType
            // 
            this.kCbbSSlotType.DropDownWidth = 90;
            this.kCbbSSlotType.Location = new System.Drawing.Point(514, 20);
            this.kCbbSSlotType.Name = "kCbbSSlotType";
            this.kCbbSSlotType.Size = new System.Drawing.Size(74, 22);
            this.kCbbSSlotType.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kCbbSSlotType.TabIndex = 16;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.ImeMode = System.Windows.Forms.ImeMode.On;
            this.kryptonLabel6.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel6.Location = new System.Drawing.Point(405, 97);
            this.kryptonLabel6.Margin = new System.Windows.Forms.Padding(5);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kryptonLabel6.Size = new System.Drawing.Size(81, 18);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 15;
            this.kryptonLabel6.Values.Text = "Khu vực đỗ :";
            // 
            // kCbbSStatus
            // 
            this.kCbbSStatus.DropDownWidth = 90;
            this.kCbbSStatus.Items.AddRange(new object[] {
            "Tất cả",
            "Sẵn sàng",
            "Đã có xe",
            "Sửa chữa"});
            this.kCbbSStatus.Location = new System.Drawing.Point(514, 57);
            this.kCbbSStatus.Name = "kCbbSStatus";
            this.kCbbSStatus.Size = new System.Drawing.Size(74, 22);
            this.kCbbSStatus.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kCbbSStatus.TabIndex = 14;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(404, 62);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(5);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kryptonLabel1.Size = new System.Drawing.Size(102, 18);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 13;
            this.kryptonLabel1.Values.Text = "Trạng thái vị trí :";
            // 
            // kCbbParkingarea
            // 
            this.kCbbParkingarea.DropDownWidth = 149;
            this.kCbbParkingarea.Location = new System.Drawing.Point(134, 131);
            this.kCbbParkingarea.Name = "kCbbParkingarea";
            this.kCbbParkingarea.Size = new System.Drawing.Size(172, 22);
            this.kCbbParkingarea.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kCbbParkingarea.TabIndex = 12;
            // 
            // kCbbStatus
            // 
            this.kCbbStatus.DropDownWidth = 98;
            this.kCbbStatus.Items.AddRange(new object[] {
            "Sẵn sàng",
            "Đã có xe",
            "Sửa chữa"});
            this.kCbbStatus.Location = new System.Drawing.Point(134, 93);
            this.kCbbStatus.Name = "kCbbStatus";
            this.kCbbStatus.Size = new System.Drawing.Size(172, 22);
            this.kCbbStatus.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kCbbStatus.TabIndex = 11;
            // 
            // kCbbSlottype
            // 
            this.kCbbSlottype.DropDownWidth = 149;
            this.kCbbSlottype.Items.AddRange(new object[] {
            "Vừa",
            "Nhỏ",
            "Lớn"});
            this.kCbbSlottype.Location = new System.Drawing.Point(134, 56);
            this.kCbbSlottype.Name = "kCbbSlottype";
            this.kCbbSlottype.Size = new System.Drawing.Size(172, 22);
            this.kCbbSlottype.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kCbbSlottype.TabIndex = 10;
            // 
            // kTbSlotnumber
            // 
            this.kTbSlotnumber.ImeMode = System.Windows.Forms.ImeMode.On;
            this.kTbSlotnumber.Location = new System.Drawing.Point(134, 18);
            this.kTbSlotnumber.Margin = new System.Windows.Forms.Padding(10);
            this.kTbSlotnumber.Name = "kTbSlotnumber";
            this.kTbSlotnumber.Size = new System.Drawing.Size(172, 23);
            this.kTbSlotnumber.TabIndex = 9;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.ImeMode = System.Windows.Forms.ImeMode.On;
            this.kryptonLabel7.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel7.Location = new System.Drawing.Point(23, 133);
            this.kryptonLabel7.Margin = new System.Windows.Forms.Padding(5);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kryptonLabel7.Size = new System.Drawing.Size(81, 18);
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 4;
            this.kryptonLabel7.Values.Text = "Khu vực đỗ :";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.ImeMode = System.Windows.Forms.ImeMode.On;
            this.kryptonLabel5.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel5.Location = new System.Drawing.Point(23, 95);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(5);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kryptonLabel5.Size = new System.Drawing.Size(102, 18);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 2;
            this.kryptonLabel5.Values.Text = "Trạng thái vị trí :";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.ImeMode = System.Windows.Forms.ImeMode.On;
            this.kryptonLabel4.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel4.Location = new System.Drawing.Point(23, 58);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(5);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kryptonLabel4.Size = new System.Drawing.Size(87, 18);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 1;
            this.kryptonLabel4.Values.Text = "Loại vị trí đỗ :";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.ImeMode = System.Windows.Forms.ImeMode.On;
            this.kryptonLabel3.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(25, 21);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(5);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kryptonLabel3.Size = new System.Drawing.Size(78, 18);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 0;
            this.kryptonLabel3.Values.Text = "Vị trí đỗ xe :";
            // 
            // kDgvParkingSlot
            // 
            this.kDgvParkingSlot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kDgvParkingSlot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kDgvParkingSlot.Location = new System.Drawing.Point(-11, 295);
            this.kDgvParkingSlot.Name = "kDgvParkingSlot";
            this.kDgvParkingSlot.Size = new System.Drawing.Size(652, 207);
            this.kDgvParkingSlot.TabIndex = 2;
            this.kDgvParkingSlot.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kDgvParkingSlot_CellClick);
            this.kDgvParkingSlot.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kDgvParkingSlot_CellContentClick);
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.LabelStyle = Krypton.Toolkit.LabelStyle.ItalicControl;
            this.kryptonLabel8.Location = new System.Drawing.Point(3, 273);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(114, 20);
            this.kryptonLabel8.TabIndex = 3;
            this.kryptonLabel8.Values.Text = "Dữ liệu người dùng";
            // 
            // frmParkingSlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 511);
            this.Controls.Add(this.kryptonLabel8);
            this.Controls.Add(this.kDgvParkingSlot);
            this.Controls.Add(this.kPnSlot);
            this.Controls.Add(this.kryptonGroupBox1);
            this.Name = "frmParkingSlot";
            this.Text = "frmParkingSlot";
            this.Load += new System.EventHandler(this.frmParkingSlot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kCbbSArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kPnSlot)).EndInit();
            this.kPnSlot.ResumeLayout(false);
            this.kPnSlot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbSSlotType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbSStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbParkingarea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbSlottype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kDgvParkingSlot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonButton kbtnSearch;
        private Krypton.Toolkit.KryptonButton kbtnDelete;
        private Krypton.Toolkit.KryptonButton kbtnEdit;
        private Krypton.Toolkit.KryptonButton kbtnCreate;
        private Krypton.Toolkit.KryptonComboBox kCbbSArea;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonPanel kPnSlot;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonComboBox kCbbStatus;
        private Krypton.Toolkit.KryptonComboBox kCbbSlottype;
        private Krypton.Toolkit.KryptonTextBox kTbSlotnumber;
        private Krypton.Toolkit.KryptonComboBox kCbbParkingarea;
        private Krypton.Toolkit.KryptonDataGridView kDgvParkingSlot;
        private Krypton.Toolkit.KryptonButton kbtnRefresh;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonComboBox kCbbSStatus;
        private Krypton.Toolkit.KryptonComboBox kCbbSSlotType;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
    }
}