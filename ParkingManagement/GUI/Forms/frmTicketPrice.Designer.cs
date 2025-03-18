namespace ParkingManagement.GUI.Forms
{
    partial class frmTicketPrice
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdHourlyPass = new Krypton.Toolkit.KryptonRadioButton();
            this.rdMonthlyPass = new Krypton.Toolkit.KryptonRadioButton();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.lblTicketPrice = new Krypton.Toolkit.KryptonLabel();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.kryptonLabel12 = new Krypton.Toolkit.KryptonLabel();
            this.lblPrice = new Krypton.Toolkit.KryptonLabel();
            this.dgvTicketPrice = new Krypton.Toolkit.KryptonDataGridView();
            this.txtDescriptionn = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            this.lblDetails = new Krypton.Toolkit.KryptonLabel();
            this.cmbVehicleType = new System.Windows.Forms.ComboBox();
            this.kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            this.txtSearchh = new Krypton.Toolkit.KryptonTextBox();
            this.btnCancell = new Krypton.Toolkit.KryptonButton();
            this.btnSearchh = new Krypton.Toolkit.KryptonButton();
            this.lblVehicle_type_id = new Krypton.Toolkit.KryptonLabel();
            this.kryptonGroupBox2 = new Krypton.Toolkit.KryptonGroupBox();
            this.btnSaveToDatabase = new Krypton.Toolkit.KryptonButton();
            this.btnImportExcel = new Krypton.Toolkit.KryptonButton();
            this.btnExportExcel = new Krypton.Toolkit.KryptonButton();
            this.btnRefresh = new Krypton.Toolkit.KryptonButton();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.btnDelete = new Krypton.Toolkit.KryptonButton();
            this.btnCreate = new Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicketPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.panel2);
            this.kryptonPanel1.Controls.Add(this.kryptonGroupBox2);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1031, 619);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1031, 525);
            this.panel2.TabIndex = 39;
            // 
            // rdHourlyPass
            // 
            this.rdHourlyPass.Location = new System.Drawing.Point(770, 66);
            this.rdHourlyPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdHourlyPass.Name = "rdHourlyPass";
            this.rdHourlyPass.Size = new System.Drawing.Size(104, 27);
            this.rdHourlyPass.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 12F);
            this.rdHourlyPass.TabIndex = 46;
            this.rdHourlyPass.Values.Text = "Vé ngày";
            // 
            // rdMonthlyPass
            // 
            this.rdMonthlyPass.Location = new System.Drawing.Point(636, 66);
            this.rdMonthlyPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdMonthlyPass.Name = "rdMonthlyPass";
            this.rdMonthlyPass.Size = new System.Drawing.Size(111, 27);
            this.rdMonthlyPass.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 12F);
            this.rdMonthlyPass.TabIndex = 45;
            this.rdMonthlyPass.Values.Text = "Vé tháng";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(602, 68);
            this.kryptonLabel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(18, 25);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 44;
            this.kryptonLabel6.Values.Text = ":";
            // 
            // lblTicketPrice
            // 
            this.lblTicketPrice.Location = new System.Drawing.Point(516, 66);
            this.lblTicketPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTicketPrice.Name = "lblTicketPrice";
            this.lblTicketPrice.Size = new System.Drawing.Size(80, 27);
            this.lblTicketPrice.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 12F);
            this.lblTicketPrice.TabIndex = 43;
            this.lblTicketPrice.Values.Text = "Loại vé";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPrice.Location = new System.Drawing.Point(186, 61);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(300, 30);
            this.txtPrice.TabIndex = 42;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(160, 66);
            this.kryptonLabel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(18, 25);
            this.kryptonLabel12.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel12.TabIndex = 41;
            this.kryptonLabel12.Values.Text = ":";
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(15, 65);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(73, 27);
            this.lblPrice.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 12F);
            this.lblPrice.TabIndex = 40;
            this.lblPrice.Values.Text = "Giá vé";
            // 
            // dgvTicketPrice
            // 
            this.dgvTicketPrice.AllowUserToOrderColumns = true;
            this.dgvTicketPrice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTicketPrice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTicketPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTicketPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicketPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTicketPrice.Location = new System.Drawing.Point(0, 0);
            this.dgvTicketPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTicketPrice.Name = "dgvTicketPrice";
            this.dgvTicketPrice.RowHeadersWidth = 51;
            this.dgvTicketPrice.RowTemplate.Height = 24;
            this.dgvTicketPrice.Size = new System.Drawing.Size(1031, 284);
            this.dgvTicketPrice.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvTicketPrice.StateCommon.DataCell.Content.Padding = new System.Windows.Forms.Padding(33, 2, 33, 2);
            this.dgvTicketPrice.TabIndex = 24;
            this.dgvTicketPrice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTicketPrice_CellClick);
            this.dgvTicketPrice.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvTicketPrice_DataBindingComplete);
            // 
            // txtDescriptionn
            // 
            this.txtDescriptionn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescriptionn.Location = new System.Drawing.Point(186, 104);
            this.txtDescriptionn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtDescriptionn.Multiline = true;
            this.txtDescriptionn.Name = "txtDescriptionn";
            this.txtDescriptionn.Size = new System.Drawing.Size(772, 66);
            this.txtDescriptionn.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptionn.TabIndex = 33;
            this.txtDescriptionn.Tag = "";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(162, 105);
            this.kryptonLabel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(18, 25);
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.TabIndex = 32;
            this.kryptonLabel8.Values.Text = ":";
            // 
            // lblDetails
            // 
            this.lblDetails.Location = new System.Drawing.Point(16, 104);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(130, 27);
            this.lblDetails.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 12F);
            this.lblDetails.TabIndex = 31;
            this.lblDetails.Values.Text = "Mô tả chi tiết";
            // 
            // cmbVehicleType
            // 
            this.cmbVehicleType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbVehicleType.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbVehicleType.FormattingEnabled = true;
            this.cmbVehicleType.Items.AddRange(new object[] {
            "Xe Máy",
            "Xe đạp",
            "Xe Điện",
            "Xe Tay Ga",
            "Ô tô",
            "Ô tô 5 chỗ",
            "Ô tô 7 chỗ",
            "Ô tô bán tải",
            "Xe khách",
            "Xe tải"});
            this.cmbVehicleType.Location = new System.Drawing.Point(184, 17);
            this.cmbVehicleType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbVehicleType.Name = "cmbVehicleType";
            this.cmbVehicleType.Size = new System.Drawing.Size(772, 31);
            this.cmbVehicleType.TabIndex = 27;
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(160, 22);
            this.kryptonLabel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(18, 25);
            this.kryptonLabel10.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel10.TabIndex = 30;
            this.kryptonLabel10.Values.Text = ":";
            // 
            // txtSearchh
            // 
            this.txtSearchh.Location = new System.Drawing.Point(16, 191);
            this.txtSearchh.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSearchh.Name = "txtSearchh";
            this.txtSearchh.Size = new System.Drawing.Size(412, 29);
            this.txtSearchh.StateCommon.Content.Font = new System.Drawing.Font("Arial", 11F);
            this.txtSearchh.TabIndex = 26;
            this.txtSearchh.Text = " Nhập loại xe....";
            // 
            // btnCancell
            // 
            this.btnCancell.Location = new System.Drawing.Point(474, 190);
            this.btnCancell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancell.Name = "btnCancell";
            this.btnCancell.Size = new System.Drawing.Size(31, 32);
            this.btnCancell.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnCancell.TabIndex = 29;
            this.btnCancell.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCancell.Values.Image = global::ParkingManagement.Properties.Resources.square1;
            this.btnCancell.Values.Text = "";
            this.btnCancell.Click += new System.EventHandler(this.btnCancell_Click);
            // 
            // btnSearchh
            // 
            this.btnSearchh.Location = new System.Drawing.Point(438, 191);
            this.btnSearchh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchh.Name = "btnSearchh";
            this.btnSearchh.Size = new System.Drawing.Size(31, 30);
            this.btnSearchh.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnSearchh.TabIndex = 25;
            this.btnSearchh.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSearchh.Values.Image = global::ParkingManagement.Properties.Resources.search24;
            this.btnSearchh.Values.Text = "Search";
            this.btnSearchh.Click += new System.EventHandler(this.btnSearchh_Click);
            // 
            // lblVehicle_type_id
            // 
            this.lblVehicle_type_id.Location = new System.Drawing.Point(16, 23);
            this.lblVehicle_type_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblVehicle_type_id.Name = "lblVehicle_type_id";
            this.lblVehicle_type_id.Size = new System.Drawing.Size(114, 27);
            this.lblVehicle_type_id.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 12F);
            this.lblVehicle_type_id.TabIndex = 28;
            this.lblVehicle_type_id.Values.Text = "Tên loại xe";
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.CaptionStyle = Krypton.Toolkit.LabelStyle.ToolTip;
            this.kryptonGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonGroupBox2.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ButtonForm;
            this.kryptonGroupBox2.Location = new System.Drawing.Point(0, 0);
            this.kryptonGroupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.btnSaveToDatabase);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btnImportExcel);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btnExportExcel);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btnRefresh);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btnSave);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btnDelete);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btnCreate);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(1031, 94);
            this.kryptonGroupBox2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox2.TabIndex = 2;
            this.kryptonGroupBox2.Values.Heading = "Tùy chọn";
            this.kryptonGroupBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonGroupBox2_Paint);
            // 
            // btnSaveToDatabase
            // 
            this.btnSaveToDatabase.Location = new System.Drawing.Point(748, 9);
            this.btnSaveToDatabase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveToDatabase.Name = "btnSaveToDatabase";
            this.btnSaveToDatabase.Size = new System.Drawing.Size(141, 48);
            this.btnSaveToDatabase.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnSaveToDatabase.TabIndex = 8;
            this.btnSaveToDatabase.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSaveToDatabase.Values.Image = global::ParkingManagement.Properties.Resources.saveExcel;
            this.btnSaveToDatabase.Values.Text = "SaveDB";
            this.btnSaveToDatabase.Click += new System.EventHandler(this.btnSaveToDatabase_Click);
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.Location = new System.Drawing.Point(627, 9);
            this.btnImportExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(115, 48);
            this.btnImportExcel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnImportExcel.TabIndex = 7;
            this.btnImportExcel.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnImportExcel.Values.Image = global::ParkingManagement.Properties.Resources.export_excel;
            this.btnImportExcel.Values.Text = "Import";
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(512, 9);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(109, 48);
            this.btnExportExcel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnExportExcel.TabIndex = 6;
            this.btnExportExcel.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnExportExcel.Values.Image = global::ParkingManagement.Properties.Resources.export_excel;
            this.btnExportExcel.Values.Text = "Export";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(256, 9);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(128, 48);
            this.btnRefresh.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnRefresh.Values.Image = global::ParkingManagement.Properties.Resources.refersh242;
            this.btnRefresh.Values.Text = "Refersh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(133, 9);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 48);
            this.btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnSave.TabIndex = 3;
            this.btnSave.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSave.Values.Image = global::ParkingManagement.Properties.Resources.edit;
            this.btnSave.Values.Text = "Edit";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(389, 9);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 48);
            this.btnDelete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnDelete.Values.Image = global::ParkingManagement.Properties.Resources.delete24;
            this.btnDelete.Values.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 9);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(116, 48);
            this.btnCreate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCreate.Values.Image = global::ParkingManagement.Properties.Resources.newfile24;
            this.btnCreate.Values.Text = "Create";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.lblVehicle_type_id);
            this.panel1.Controls.Add(this.btnSearchh);
            this.panel1.Controls.Add(this.rdHourlyPass);
            this.panel1.Controls.Add(this.btnCancell);
            this.panel1.Controls.Add(this.rdMonthlyPass);
            this.panel1.Controls.Add(this.txtSearchh);
            this.panel1.Controls.Add(this.kryptonLabel6);
            this.panel1.Controls.Add(this.kryptonLabel10);
            this.panel1.Controls.Add(this.lblTicketPrice);
            this.panel1.Controls.Add(this.cmbVehicleType);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.lblDetails);
            this.panel1.Controls.Add(this.kryptonLabel12);
            this.panel1.Controls.Add(this.kryptonLabel8);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.txtDescriptionn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 241);
            this.panel1.TabIndex = 47;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.dgvTicketPrice);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 241);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1031, 284);
            this.panel3.TabIndex = 48;
            // 
            // frmTicketPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1031, 619);
            this.Controls.Add(this.kryptonPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTicketPrice";
            this.Text = "frmTicketPrice";
            this.Load += new System.EventHandler(this.frmTicketPrice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicketPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private Krypton.Toolkit.KryptonButton btnRefresh;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonButton btnDelete;
        private Krypton.Toolkit.KryptonButton btnCreate;
        private System.Windows.Forms.Panel panel2;
        private Krypton.Toolkit.KryptonRadioButton rdMonthlyPass;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel lblTicketPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private Krypton.Toolkit.KryptonLabel lblPrice;
        private Krypton.Toolkit.KryptonDataGridView dgvTicketPrice;
        private Krypton.Toolkit.KryptonTextBox txtDescriptionn;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonLabel lblDetails;
        private System.Windows.Forms.ComboBox cmbVehicleType;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonTextBox txtSearchh;
        private Krypton.Toolkit.KryptonButton btnCancell;
        private Krypton.Toolkit.KryptonButton btnSearchh;
        private Krypton.Toolkit.KryptonLabel lblVehicle_type_id;
        private Krypton.Toolkit.KryptonRadioButton rdHourlyPass;
        private Krypton.Toolkit.KryptonButton btnExportExcel;
        private Krypton.Toolkit.KryptonButton btnImportExcel;
        private Krypton.Toolkit.KryptonButton btnSaveToDatabase;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
    }
}