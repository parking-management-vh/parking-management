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
            this.kTbParkingArea = new Krypton.Toolkit.KryptonTextBox();
            this.kTbDescription = new Krypton.Toolkit.KryptonTextBox();
            this.kCbbStatus = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kCbbSStatus = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kBtnPArea = new Krypton.Toolkit.KryptonDataGridView();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel5 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonGroupBox3 = new Krypton.Toolkit.KryptonGroupBox();
            this.kryptonGroupBox4 = new Krypton.Toolkit.KryptonGroupBox();
            this.kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonGroupBox2 = new Krypton.Toolkit.KryptonGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kPnArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbSStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kBtnPArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).BeginInit();
            this.kryptonPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3.Panel)).BeginInit();
            this.kryptonGroupBox3.Panel.SuspendLayout();
            this.kryptonGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox4.Panel)).BeginInit();
            this.kryptonGroupBox4.Panel.SuspendLayout();
            this.kryptonGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.CaptionStyle = Krypton.Toolkit.LabelStyle.ItalicControl;
            this.kryptonGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.kryptonGroupBox1.Margin = new System.Windows.Forms.Padding(4);
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kbtnRefresh);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kbtnDelete);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kbtnEdit);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kbtnCreate);
            this.kryptonGroupBox1.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonGroupBox1_Panel_Paint);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(1166, 100);
            this.kryptonGroupBox1.TabIndex = 0;
            this.kryptonGroupBox1.Values.Heading = "Tùy chọn";
            // 
            // kbtnRefresh
            // 
            this.kbtnRefresh.Cursor = System.Windows.Forms.Cursors.No;
            this.kbtnRefresh.Location = new System.Drawing.Point(800, 13);
            this.kbtnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.kbtnRefresh.Name = "kbtnRefresh";
            this.kbtnRefresh.Size = new System.Drawing.Size(120, 41);
            this.kbtnRefresh.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnRefresh.TabIndex = 3;
            this.kbtnRefresh.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kbtnRefresh.Values.Image = global::ParkingManagement.Properties.Resources.refersh241;
            this.kbtnRefresh.Values.Text = "Làm mới";
            this.kbtnRefresh.Click += new System.EventHandler(this.kbtnRefresh_Click);
            // 
            // kbtnDelete
            // 
            this.kbtnDelete.Cursor = System.Windows.Forms.Cursors.No;
            this.kbtnDelete.Location = new System.Drawing.Point(571, 13);
            this.kbtnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.kbtnDelete.Name = "kbtnDelete";
            this.kbtnDelete.Size = new System.Drawing.Size(120, 41);
            this.kbtnDelete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnDelete.TabIndex = 2;
            this.kbtnDelete.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kbtnDelete.Values.Image = global::ParkingManagement.Properties.Resources.delete24;
            this.kbtnDelete.Values.Text = "Xóa";
            this.kbtnDelete.Click += new System.EventHandler(this.kbtnDelete_Click);
            // 
            // kbtnEdit
            // 
            this.kbtnEdit.Cursor = System.Windows.Forms.Cursors.No;
            this.kbtnEdit.Location = new System.Drawing.Point(337, 13);
            this.kbtnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.kbtnEdit.Name = "kbtnEdit";
            this.kbtnEdit.Size = new System.Drawing.Size(120, 41);
            this.kbtnEdit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnEdit.TabIndex = 1;
            this.kbtnEdit.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kbtnEdit.Values.Image = global::ParkingManagement.Properties.Resources.edit;
            this.kbtnEdit.Values.Text = "Sửa";
            this.kbtnEdit.Click += new System.EventHandler(this.kbtnEdit_Click);
            // 
            // kbtnCreate
            // 
            this.kbtnCreate.Cursor = System.Windows.Forms.Cursors.No;
            this.kbtnCreate.Location = new System.Drawing.Point(109, 13);
            this.kbtnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.kbtnCreate.Name = "kbtnCreate";
            this.kbtnCreate.Size = new System.Drawing.Size(120, 41);
            this.kbtnCreate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCreate.TabIndex = 0;
            this.kbtnCreate.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kbtnCreate.Values.Image = global::ParkingManagement.Properties.Resources.newfile24;
            this.kbtnCreate.Values.Text = "Tạo";
            this.kbtnCreate.Click += new System.EventHandler(this.kbtnCreate_Click);
            // 
            // kbtnSearch
            // 
            this.kbtnSearch.Location = new System.Drawing.Point(262, 103);
            this.kbtnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.kbtnSearch.Name = "kbtnSearch";
            this.kbtnSearch.Size = new System.Drawing.Size(106, 41);
            this.kbtnSearch.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSearch.TabIndex = 3;
            this.kbtnSearch.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kbtnSearch.Values.Image = global::ParkingManagement.Properties.Resources.search24;
            this.kbtnSearch.Values.Text = "Tìm";
            this.kbtnSearch.Click += new System.EventHandler(this.kbtnSearch_Click);
            // 
            // kPnArea
            // 
            this.kPnArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kPnArea.Location = new System.Drawing.Point(0, 0);
            this.kPnArea.Margin = new System.Windows.Forms.Padding(4);
            this.kPnArea.Name = "kPnArea";
            this.kPnArea.Size = new System.Drawing.Size(1166, 0);
            this.kPnArea.StateCommon.Color1 = System.Drawing.Color.White;
            this.kPnArea.TabIndex = 1;
            // 
            // kTbParkingArea
            // 
            this.kTbParkingArea.Location = new System.Drawing.Point(193, 14);
            this.kTbParkingArea.Margin = new System.Windows.Forms.Padding(4);
            this.kTbParkingArea.Name = "kTbParkingArea";
            this.kTbParkingArea.Size = new System.Drawing.Size(314, 24);
            this.kTbParkingArea.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kTbParkingArea.TabIndex = 7;
            // 
            // kTbDescription
            // 
            this.kTbDescription.Location = new System.Drawing.Point(193, 120);
            this.kTbDescription.Margin = new System.Windows.Forms.Padding(4);
            this.kTbDescription.Name = "kTbDescription";
            this.kTbDescription.Size = new System.Drawing.Size(314, 24);
            this.kTbDescription.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kTbDescription.TabIndex = 5;
            // 
            // kCbbStatus
            // 
            this.kCbbStatus.DropDownWidth = 216;
            this.kCbbStatus.Items.AddRange(new object[] {
            "Đầy bãi",
            "Còn chỗ",
            "Sửa chữa"});
            this.kCbbStatus.Location = new System.Drawing.Point(193, 67);
            this.kCbbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.kCbbStatus.Name = "kCbbStatus";
            this.kCbbStatus.Size = new System.Drawing.Size(314, 23);
            this.kCbbStatus.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kCbbStatus.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kCbbStatus.TabIndex = 4;
            this.kCbbStatus.Click += new System.EventHandler(this.kCbbStatus_Click);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(34, 120);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel3.Size = new System.Drawing.Size(119, 21);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Values.Text = "Mô tả khu vực :";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(34, 66);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel2.Size = new System.Drawing.Size(92, 21);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Trạng thái :";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(34, 14);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel1.Size = new System.Drawing.Size(100, 21);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Khu vực đỗ :";
            // 
            // kCbbSStatus
            // 
            this.kCbbSStatus.DropDownWidth = 216;
            this.kCbbSStatus.Location = new System.Drawing.Point(169, 60);
            this.kCbbSStatus.Margin = new System.Windows.Forms.Padding(4);
            this.kCbbSStatus.Name = "kCbbSStatus";
            this.kCbbSStatus.Size = new System.Drawing.Size(199, 23);
            this.kCbbSStatus.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kCbbSStatus.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kCbbSStatus.TabIndex = 9;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel4.Location = new System.Drawing.Point(54, 63);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel4.Size = new System.Drawing.Size(92, 21);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 8;
            this.kryptonLabel4.Values.Text = "Trạng thái :";
            // 
            // kBtnPArea
            // 
            this.kBtnPArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kBtnPArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kBtnPArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kBtnPArea.Location = new System.Drawing.Point(0, 0);
            this.kBtnPArea.Margin = new System.Windows.Forms.Padding(4);
            this.kBtnPArea.Name = "kBtnPArea";
            this.kBtnPArea.RowHeadersWidth = 51;
            this.kBtnPArea.Size = new System.Drawing.Size(1162, 200);
            this.kBtnPArea.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kBtnPArea.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kBtnPArea.StateCommon.DataCell.Content.Padding = new System.Windows.Forms.Padding(30, -1, 30, -1);
            this.kBtnPArea.TabIndex = 2;
            this.kBtnPArea.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kBtnPArea_CellClick);
            this.kBtnPArea.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kBtnPArea_CellContentClick);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1166, 100);
            this.kryptonPanel1.TabIndex = 5;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonPanel5);
            this.kryptonPanel2.Controls.Add(this.kryptonPanel4);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 100);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1166, 241);
            this.kryptonPanel2.TabIndex = 6;
            // 
            // kryptonPanel5
            // 
            this.kryptonPanel5.Controls.Add(this.kPnArea);
            this.kryptonPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel5.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel5.Name = "kryptonPanel5";
            this.kryptonPanel5.Size = new System.Drawing.Size(1166, 0);
            this.kryptonPanel5.TabIndex = 1;
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.kryptonGroupBox3);
            this.kryptonPanel4.Controls.Add(this.kryptonGroupBox4);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.HeaderSecondary;
            this.kryptonPanel4.Size = new System.Drawing.Size(1166, 241);
            this.kryptonPanel4.TabIndex = 0;
            // 
            // kryptonGroupBox3
            // 
            this.kryptonGroupBox3.CaptionStyle = Krypton.Toolkit.LabelStyle.ItalicControl;
            this.kryptonGroupBox3.Location = new System.Drawing.Point(91, 17);
            // 
            // kryptonGroupBox3.Panel
            // 
            this.kryptonGroupBox3.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kTbDescription);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kCbbStatus);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kTbParkingArea);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonGroupBox3.Size = new System.Drawing.Size(557, 195);
            this.kryptonGroupBox3.TabIndex = 12;
            this.kryptonGroupBox3.Values.Heading = "Tuỳ chọn";
            // 
            // kryptonGroupBox4
            // 
            this.kryptonGroupBox4.CaptionStyle = Krypton.Toolkit.LabelStyle.ItalicControl;
            this.kryptonGroupBox4.Location = new System.Drawing.Point(710, 17);
            // 
            // kryptonGroupBox4.Panel
            // 
            this.kryptonGroupBox4.Panel.Controls.Add(this.kryptonLabel4);
            this.kryptonGroupBox4.Panel.Controls.Add(this.kCbbSStatus);
            this.kryptonGroupBox4.Panel.Controls.Add(this.kbtnSearch);
            this.kryptonGroupBox4.Size = new System.Drawing.Size(421, 195);
            this.kryptonGroupBox4.TabIndex = 11;
            this.kryptonGroupBox4.Values.Heading = "Tuỳ chọn";
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.kryptonGroupBox2);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 341);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(1166, 228);
            this.kryptonPanel3.TabIndex = 7;
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroupBox2.Location = new System.Drawing.Point(0, 0);
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.kBtnPArea);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(1166, 228);
            this.kryptonGroupBox2.TabIndex = 0;
            this.kryptonGroupBox2.Values.Heading = "Dữ liệu người dùng";
            // 
            // frmParkingArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 569);
            this.Controls.Add(this.kryptonPanel3);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmParkingArea";
            this.Text = "frmParkingArea";
            this.Load += new System.EventHandler(this.ParkingArea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kPnArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbSStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kBtnPArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).EndInit();
            this.kryptonPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3.Panel)).EndInit();
            this.kryptonGroupBox3.Panel.ResumeLayout(false);
            this.kryptonGroupBox3.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3)).EndInit();
            this.kryptonGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox4.Panel)).EndInit();
            this.kryptonGroupBox4.Panel.ResumeLayout(false);
            this.kryptonGroupBox4.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox4)).EndInit();
            this.kryptonGroupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox4;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox3;
    }
}