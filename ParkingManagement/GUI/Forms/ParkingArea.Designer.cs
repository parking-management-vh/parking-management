namespace ParkingManagement.GUI.Forms
{
    partial class frmParkingArea
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
            this.kPnArea = new Krypton.Toolkit.KryptonPanel();
            this.kCbbSStatus = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kTbParkingArea = new Krypton.Toolkit.KryptonTextBox();
            this.kTbDescription = new Krypton.Toolkit.KryptonTextBox();
            this.kCbbStatus = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kBtnPArea = new Krypton.Toolkit.KryptonDataGridView();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kPnArea)).BeginInit();
            this.kPnArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbSStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kBtnPArea)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.CaptionStyle = Krypton.Toolkit.LabelStyle.ItalicControl;
            this.kryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(2, -1);
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kbtnRefresh);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kbtnDelete);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kbtnEdit);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kbtnCreate);
            this.kryptonGroupBox1.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonGroupBox1_Panel_Paint);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(633, 94);
            this.kryptonGroupBox1.TabIndex = 0;
            this.kryptonGroupBox1.Values.Heading = "Tùy chọn";
            // 
            // kbtnRefresh
            // 
            this.kbtnRefresh.Cursor = System.Windows.Forms.Cursors.No;
            this.kbtnRefresh.Location = new System.Drawing.Point(492, 18);
            this.kbtnRefresh.Name = "kbtnRefresh";
            this.kbtnRefresh.Size = new System.Drawing.Size(90, 30);
            this.kbtnRefresh.TabIndex = 3;
            this.kbtnRefresh.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kbtnRefresh.Values.Image = global::ParkingManagement.Properties.Resources.refersh241;
            this.kbtnRefresh.Values.Text = "Làm mới";
            this.kbtnRefresh.Click += new System.EventHandler(this.kbtnRefresh_Click);
            // 
            // kbtnDelete
            // 
            this.kbtnDelete.Cursor = System.Windows.Forms.Cursors.No;
            this.kbtnDelete.Location = new System.Drawing.Point(341, 18);
            this.kbtnDelete.Name = "kbtnDelete";
            this.kbtnDelete.Size = new System.Drawing.Size(90, 30);
            this.kbtnDelete.TabIndex = 2;
            this.kbtnDelete.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kbtnDelete.Values.Image = global::ParkingManagement.Properties.Resources.delete24;
            this.kbtnDelete.Values.Text = "Xóa";
            this.kbtnDelete.Click += new System.EventHandler(this.kbtnDelete_Click);
            // 
            // kbtnEdit
            // 
            this.kbtnEdit.Cursor = System.Windows.Forms.Cursors.No;
            this.kbtnEdit.Location = new System.Drawing.Point(182, 18);
            this.kbtnEdit.Name = "kbtnEdit";
            this.kbtnEdit.Size = new System.Drawing.Size(90, 30);
            this.kbtnEdit.TabIndex = 1;
            this.kbtnEdit.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kbtnEdit.Values.Image = global::ParkingManagement.Properties.Resources.edit;
            this.kbtnEdit.Values.Text = "Sửa";
            this.kbtnEdit.Click += new System.EventHandler(this.kbtnEdit_Click);
            // 
            // kbtnCreate
            // 
            this.kbtnCreate.Cursor = System.Windows.Forms.Cursors.No;
            this.kbtnCreate.Location = new System.Drawing.Point(34, 18);
            this.kbtnCreate.Name = "kbtnCreate";
            this.kbtnCreate.Size = new System.Drawing.Size(90, 30);
            this.kbtnCreate.TabIndex = 0;
            this.kbtnCreate.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kbtnCreate.Values.Image = global::ParkingManagement.Properties.Resources.newfile24;
            this.kbtnCreate.Values.Text = "Tạo";
            this.kbtnCreate.Click += new System.EventHandler(this.kbtnCreate_Click);
            // 
            // kbtnSearch
            // 
            this.kbtnSearch.Location = new System.Drawing.Point(494, 87);
            this.kbtnSearch.Name = "kbtnSearch";
            this.kbtnSearch.Size = new System.Drawing.Size(90, 30);
            this.kbtnSearch.TabIndex = 3;
            this.kbtnSearch.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kbtnSearch.Values.Image = global::ParkingManagement.Properties.Resources.search24;
            this.kbtnSearch.Values.Text = "Tìm kiếm";
            this.kbtnSearch.Click += new System.EventHandler(this.kbtnSearch_Click);
            // 
            // kPnArea
            // 
            this.kPnArea.Controls.Add(this.kCbbSStatus);
            this.kPnArea.Controls.Add(this.kryptonLabel4);
            this.kPnArea.Controls.Add(this.kTbParkingArea);
            this.kPnArea.Controls.Add(this.kbtnSearch);
            this.kPnArea.Controls.Add(this.kTbDescription);
            this.kPnArea.Controls.Add(this.kCbbStatus);
            this.kPnArea.Controls.Add(this.kryptonLabel3);
            this.kPnArea.Controls.Add(this.kryptonLabel2);
            this.kPnArea.Controls.Add(this.kryptonLabel1);
            this.kPnArea.Location = new System.Drawing.Point(2, 92);
            this.kPnArea.Name = "kPnArea";
            this.kPnArea.Size = new System.Drawing.Size(633, 138);
            this.kPnArea.StateCommon.Color1 = System.Drawing.Color.White;
            this.kPnArea.TabIndex = 1;
            // 
            // kCbbSStatus
            // 
            this.kCbbSStatus.DropDownWidth = 216;
            this.kCbbSStatus.Location = new System.Drawing.Point(494, 57);
            this.kCbbSStatus.Name = "kCbbSStatus";
            this.kCbbSStatus.Size = new System.Drawing.Size(90, 22);
            this.kCbbSStatus.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kCbbSStatus.TabIndex = 9;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel4.Location = new System.Drawing.Point(416, 61);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel4.Size = new System.Drawing.Size(77, 20);
            this.kryptonLabel4.TabIndex = 8;
            this.kryptonLabel4.Values.Text = "Trạng thái :";
            // 
            // kTbParkingArea
            // 
            this.kTbParkingArea.Location = new System.Drawing.Point(131, 21);
            this.kTbParkingArea.Name = "kTbParkingArea";
            this.kTbParkingArea.Size = new System.Drawing.Size(186, 23);
            this.kTbParkingArea.TabIndex = 7;
            // 
            // kTbDescription
            // 
            this.kTbDescription.Location = new System.Drawing.Point(131, 95);
            this.kTbDescription.Name = "kTbDescription";
            this.kTbDescription.Size = new System.Drawing.Size(186, 23);
            this.kTbDescription.TabIndex = 5;
            // 
            // kCbbStatus
            // 
            this.kCbbStatus.DropDownWidth = 216;
            this.kCbbStatus.Items.AddRange(new object[] {
            "Đầy bãi",
            "Còn chỗ",
            "Sửa chữa"});
            this.kCbbStatus.Location = new System.Drawing.Point(131, 59);
            this.kCbbStatus.Name = "kCbbStatus";
            this.kCbbStatus.Size = new System.Drawing.Size(186, 22);
            this.kCbbStatus.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kCbbStatus.TabIndex = 4;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(20, 98);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel3.Size = new System.Drawing.Size(101, 20);
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Values.Text = "Mô tả khu vực :";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(20, 60);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel2.Size = new System.Drawing.Size(77, 20);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Trạng thái :";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(20, 24);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel1.Size = new System.Drawing.Size(83, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Khu vực đỗ :";
            // 
            // kBtnPArea
            // 
            this.kBtnPArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kBtnPArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kBtnPArea.Location = new System.Drawing.Point(2, 257);
            this.kBtnPArea.Name = "kBtnPArea";
            this.kBtnPArea.Size = new System.Drawing.Size(643, 252);
            this.kBtnPArea.TabIndex = 2;
            this.kBtnPArea.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kBtnPArea_CellClick);
            this.kBtnPArea.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kBtnPArea_CellContentClick);
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.LabelStyle = Krypton.Toolkit.LabelStyle.ItalicControl;
            this.kryptonLabel8.Location = new System.Drawing.Point(5, 236);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(114, 20);
            this.kryptonLabel8.TabIndex = 4;
            this.kryptonLabel8.Values.Text = "Dữ liệu người dùng";
            // 
            // frmParkingArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 523);
            this.Controls.Add(this.kryptonLabel8);
            this.Controls.Add(this.kBtnPArea);
            this.Controls.Add(this.kPnArea);
            this.Controls.Add(this.kryptonGroupBox1);
            this.Name = "frmParkingArea";
            this.Text = "frmParkingArea";
            this.Load += new System.EventHandler(this.ParkingArea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kPnArea)).EndInit();
            this.kPnArea.ResumeLayout(false);
            this.kPnArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbSStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kBtnPArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonButton kbtnCreate;
        private Krypton.Toolkit.KryptonButton kbtnSearch;
        private Krypton.Toolkit.KryptonButton kbtnDelete;
        private Krypton.Toolkit.KryptonButton kbtnEdit;
        private Krypton.Toolkit.KryptonPanel kPnArea;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox kTbDescription;
        private Krypton.Toolkit.KryptonComboBox kCbbStatus;
        private Krypton.Toolkit.KryptonDataGridView kBtnPArea;
        private Krypton.Toolkit.KryptonButton kbtnRefresh;
        private Krypton.Toolkit.KryptonTextBox kTbParkingArea;
        private Krypton.Toolkit.KryptonComboBox kCbbSStatus;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
    }
}