namespace ParkingManagement.GUI.Forms
{
    partial class frmVehicleType
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
            this.kryptonGroupBox2 = new Krypton.Toolkit.KryptonGroupBox();
            this.btnSaveToDatabase = new Krypton.Toolkit.KryptonButton();
            this.btnImportExcel = new Krypton.Toolkit.KryptonButton();
            this.btnExportExcel = new Krypton.Toolkit.KryptonButton();
            this.btnReset = new Krypton.Toolkit.KryptonButton();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.btnDelete = new Krypton.Toolkit.KryptonButton();
            this.btnCreate = new Krypton.Toolkit.KryptonButton();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonDgvVehicleType = new Krypton.Toolkit.KryptonDataGridView();
            this.txtDescription = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.cmbVehicle = new System.Windows.Forms.ComboBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.txtSearch = new Krypton.Toolkit.KryptonTextBox();
            this.btnCancel = new Krypton.Toolkit.KryptonButton();
            this.btnSearch = new Krypton.Toolkit.KryptonButton();
            this.lblLoaiXe = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDgvVehicleType)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonGroupBox2.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ButtonForm;
            this.kryptonGroupBox2.Location = new System.Drawing.Point(0, 0);
            this.kryptonGroupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.btnSaveToDatabase);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btnImportExcel);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btnExportExcel);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btnReset);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btnSave);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btnDelete);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btnCreate);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(716, 76);
            this.kryptonGroupBox2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox2.TabIndex = 2;
            this.kryptonGroupBox2.Values.Heading = "Tùy chọn";
            // 
            // btnSaveToDatabase
            // 
            this.btnSaveToDatabase.Location = new System.Drawing.Point(565, 7);
            this.btnSaveToDatabase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveToDatabase.Name = "btnSaveToDatabase";
            this.btnSaveToDatabase.Size = new System.Drawing.Size(102, 39);
            this.btnSaveToDatabase.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnSaveToDatabase.TabIndex = 10;
            this.btnSaveToDatabase.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSaveToDatabase.Values.Image = global::ParkingManagement.Properties.Resources.saveExcel;
            this.btnSaveToDatabase.Values.Text = "SaveDB";
            this.btnSaveToDatabase.Click += new System.EventHandler(this.btnSaveToDatabase_Click);
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.Location = new System.Drawing.Point(474, 7);
            this.btnImportExcel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(86, 39);
            this.btnImportExcel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnImportExcel.TabIndex = 9;
            this.btnImportExcel.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnImportExcel.Values.Image = global::ParkingManagement.Properties.Resources.export_excel;
            this.btnImportExcel.Values.Text = "Import";
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(385, 7);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(84, 39);
            this.btnExportExcel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnExportExcel.TabIndex = 5;
            this.btnExportExcel.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnExportExcel.Values.Image = global::ParkingManagement.Properties.Resources.export_excel;
            this.btnExportExcel.Values.Text = "Export";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(194, 7);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 39);
            this.btnReset.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnReset.TabIndex = 4;
            this.btnReset.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnReset.Values.Image = global::ParkingManagement.Properties.Resources.refersh242;
            this.btnReset.Values.Text = "Refersh";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(102, 7);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 39);
            this.btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnSave.TabIndex = 3;
            this.btnSave.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSave.Values.Image = global::ParkingManagement.Properties.Resources.edit;
            this.btnSave.Values.Text = "Edit";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(293, 7);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 39);
            this.btnDelete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnDelete.Values.Image = global::ParkingManagement.Properties.Resources.delete24;
            this.btnDelete.Values.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(10, 7);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(87, 39);
            this.btnCreate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCreate.Values.Image = global::ParkingManagement.Properties.Resources.newfile24;
            this.btnCreate.Values.Text = "Create";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.panel1);
            this.kryptonPanel1.Controls.Add(this.kryptonGroupBox2);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(716, 478);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kryptonDgvVehicleType);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.kryptonLabel2);
            this.panel1.Controls.Add(this.kryptonLabel3);
            this.panel1.Controls.Add(this.cmbVehicle);
            this.panel1.Controls.Add(this.kryptonLabel1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.lblLoaiXe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 402);
            this.panel1.TabIndex = 3;
            // 
            // kryptonDgvVehicleType
            // 
            this.kryptonDgvVehicleType.AllowUserToOrderColumns = true;
            this.kryptonDgvVehicleType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonDgvVehicleType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.kryptonDgvVehicleType.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.kryptonDgvVehicleType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kryptonDgvVehicleType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDgvVehicleType.Location = new System.Drawing.Point(0, 175);
            this.kryptonDgvVehicleType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonDgvVehicleType.Name = "kryptonDgvVehicleType";
            this.kryptonDgvVehicleType.RowHeadersWidth = 51;
            this.kryptonDgvVehicleType.RowTemplate.Height = 24;
            this.kryptonDgvVehicleType.Size = new System.Drawing.Size(716, 228);
            this.kryptonDgvVehicleType.TabIndex = 24;
            this.kryptonDgvVehicleType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kryptonDgvVehicleType_CellClick);
            this.kryptonDgvVehicleType.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.kryptonDgvVehicleType_DataBindingComplete);
            this.kryptonDgvVehicleType.SelectionChanged += new System.EventHandler(this.kryptonDgvVehicleType_SelectionChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(142, 50);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(550, 88);
            this.txtDescription.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.TabIndex = 33;
            this.txtDescription.Tag = "";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(124, 52);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(15, 20);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 32;
            this.kryptonLabel2.Values.Text = ":";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(16, 50);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(105, 22);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 12F);
            this.kryptonLabel3.TabIndex = 31;
            this.kryptonLabel3.Values.Text = "Mô tả chi tiết";
            // 
            // cmbVehicle
            // 
            this.cmbVehicle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbVehicle.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbVehicle.FormattingEnabled = true;
            this.cmbVehicle.Items.AddRange(new object[] {
            "Xe Máy",
            "Xe đạp",
            "Xe Điện",
            "Xe Tay Ga",
            "Ô tô",
            "Ô tô 5 chỗ",
            "Ô tô 7 chỗ",
            "Ô tô bán tải",
            "Xe khách",
            "Xe tải",
            "Ô tô điện",
            "Ô tô 4 chỗ"});
            this.cmbVehicle.Location = new System.Drawing.Point(142, 16);
            this.cmbVehicle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbVehicle.Name = "cmbVehicle";
            this.cmbVehicle.Size = new System.Drawing.Size(552, 26);
            this.cmbVehicle.TabIndex = 27;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(124, 20);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(15, 20);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 30;
            this.kryptonLabel1.Values.Text = ":";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 145);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(309, 24);
            this.txtSearch.StateCommon.Content.Font = new System.Drawing.Font("Arial", 11F);
            this.txtSearch.TabIndex = 26;
            this.txtSearch.Text = " Nhập loại xe....";
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(349, 144);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(23, 26);
            this.btnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCancel.Values.Image = global::ParkingManagement.Properties.Resources.square1;
            this.btnCancel.Values.Text = "";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(321, 145);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(23, 24);
            this.btnSearch.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSearch.Values.Image = global::ParkingManagement.Properties.Resources.search24;
            this.btnSearch.Values.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblLoaiXe
            // 
            this.lblLoaiXe.Location = new System.Drawing.Point(16, 20);
            this.lblLoaiXe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblLoaiXe.Name = "lblLoaiXe";
            this.lblLoaiXe.Size = new System.Drawing.Size(92, 22);
            this.lblLoaiXe.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 12F);
            this.lblLoaiXe.TabIndex = 28;
            this.lblLoaiXe.Values.Text = "Tên loại xe";
            // 
            // frmVehicleType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(716, 478);
            this.Controls.Add(this.kryptonPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmVehicleType";
            this.Text = "frmVehicleType";
            this.Load += new System.EventHandler(this.frmVehicleType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDgvVehicleType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonButton btnDelete;
        private Krypton.Toolkit.KryptonButton btnCreate;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.Panel panel1;
        private Krypton.Toolkit.KryptonDataGridView kryptonDgvVehicleType;
        private Krypton.Toolkit.KryptonTextBox txtDescription;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private System.Windows.Forms.ComboBox cmbVehicle;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox txtSearch;
        private Krypton.Toolkit.KryptonButton btnCancel;
        private Krypton.Toolkit.KryptonButton btnSearch;
        private Krypton.Toolkit.KryptonLabel lblLoaiXe;
        private Krypton.Toolkit.KryptonButton btnReset;
        private Krypton.Toolkit.KryptonButton btnExportExcel;
        private Krypton.Toolkit.KryptonButton btnSaveToDatabase;
        private Krypton.Toolkit.KryptonButton btnImportExcel;
    }
}