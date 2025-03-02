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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehicleType));
            this.kryptonGroupBox2 = new Krypton.Toolkit.KryptonGroupBox();
            this.btnSaveToDatabase = new Krypton.Toolkit.KryptonButton();
            this.btnImportExcel = new Krypton.Toolkit.KryptonButton();
            this.btnExportExcel = new Krypton.Toolkit.KryptonButton();
            this.btnReset = new Krypton.Toolkit.KryptonButton();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.btnDelete = new Krypton.Toolkit.KryptonButton();
            this.btnCreate = new Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDescription = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.cmbVehicle = new System.Windows.Forms.ComboBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.lblLoaiXe = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.txtSearch = new Krypton.Toolkit.KryptonTextBox();
            this.btnCancel = new Krypton.Toolkit.KryptonButton();
            this.btnSearch = new Krypton.Toolkit.KryptonButton();
            this.kryptonDgvVehicleType = new Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDgvVehicleType)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonGroupBox2
            // 
            resources.ApplyResources(this.kryptonGroupBox2, "kryptonGroupBox2");
            this.kryptonGroupBox2.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ButtonForm;
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
            this.kryptonGroupBox2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox2.Values.Heading = resources.GetString("kryptonGroupBox2.Values.Heading");
            // 
            // btnSaveToDatabase
            // 
            resources.ApplyResources(this.btnSaveToDatabase, "btnSaveToDatabase");
            this.btnSaveToDatabase.Name = "btnSaveToDatabase";
            this.btnSaveToDatabase.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnSaveToDatabase.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSaveToDatabase.Values.Image = global::ParkingManagement.Properties.Resources.saveExcel;
            this.btnSaveToDatabase.Values.Text = resources.GetString("btnSaveToDatabase.Values.Text");
            // 
            // btnImportExcel
            // 
            resources.ApplyResources(this.btnImportExcel, "btnImportExcel");
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnImportExcel.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnImportExcel.Values.Image = global::ParkingManagement.Properties.Resources.export_excel;
            this.btnImportExcel.Values.Text = resources.GetString("btnImportExcel.Values.Text");
            // 
            // btnExportExcel
            // 
            resources.ApplyResources(this.btnExportExcel, "btnExportExcel");
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnExportExcel.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnExportExcel.Values.Image = global::ParkingManagement.Properties.Resources.export_excel;
            this.btnExportExcel.Values.Text = resources.GetString("btnExportExcel.Values.Text");
            // 
            // btnReset
            // 
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Name = "btnReset";
            this.btnReset.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnReset.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnReset.Values.Image = global::ParkingManagement.Properties.Resources.refersh242;
            this.btnReset.Values.Text = resources.GetString("btnReset.Values.Text");
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnSave.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSave.Values.Image = global::ParkingManagement.Properties.Resources.edit;
            this.btnSave.Values.Text = resources.GetString("btnSave.Values.Text");
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnDelete.Values.Image = global::ParkingManagement.Properties.Resources.delete24;
            this.btnDelete.Values.Text = resources.GetString("btnDelete.Values.Text");
            // 
            // btnCreate
            // 
            resources.ApplyResources(this.btnCreate, "btnCreate");
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnCreate.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCreate.Values.Image = global::ParkingManagement.Properties.Resources.newfile24;
            this.btnCreate.Values.Text = resources.GetString("btnCreate.Values.Text");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kryptonPanel1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ParkingManagement.Properties.Resources.sign;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // txtDescription
            // 
            resources.ApplyResources(this.txtDescription, "txtDescription");
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Tag = "";
            // 
            // kryptonLabel2
            // 
            resources.ApplyResources(this.kryptonLabel2, "kryptonLabel2");
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.Values.Text = resources.GetString("kryptonLabel2.Values.Text");
            // 
            // kryptonLabel3
            // 
            resources.ApplyResources(this.kryptonLabel3, "kryptonLabel3");
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 12F);
            this.kryptonLabel3.Values.Text = resources.GetString("kryptonLabel3.Values.Text");
            // 
            // cmbVehicle
            // 
            resources.ApplyResources(this.cmbVehicle, "cmbVehicle");
            this.cmbVehicle.FormattingEnabled = true;
            this.cmbVehicle.Items.AddRange(new object[] {
            resources.GetString("cmbVehicle.Items"),
            resources.GetString("cmbVehicle.Items1"),
            resources.GetString("cmbVehicle.Items2"),
            resources.GetString("cmbVehicle.Items3"),
            resources.GetString("cmbVehicle.Items4"),
            resources.GetString("cmbVehicle.Items5"),
            resources.GetString("cmbVehicle.Items6"),
            resources.GetString("cmbVehicle.Items7"),
            resources.GetString("cmbVehicle.Items8"),
            resources.GetString("cmbVehicle.Items9")});
            this.cmbVehicle.Name = "cmbVehicle";
            // 
            // kryptonLabel1
            // 
            resources.ApplyResources(this.kryptonLabel1, "kryptonLabel1");
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.Values.Text = resources.GetString("kryptonLabel1.Values.Text");
            // 
            // lblLoaiXe
            // 
            resources.ApplyResources(this.lblLoaiXe, "lblLoaiXe");
            this.lblLoaiXe.Name = "lblLoaiXe";
            this.lblLoaiXe.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 12F);
            this.lblLoaiXe.Values.Text = resources.GetString("lblLoaiXe.Values.Text");
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonDgvVehicleType);
            this.kryptonPanel1.Controls.Add(this.txtSearch);
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            this.kryptonPanel1.Controls.Add(this.btnCancel);
            this.kryptonPanel1.Controls.Add(this.btnSearch);
            this.kryptonPanel1.Controls.Add(this.txtDescription);
            this.kryptonPanel1.Controls.Add(this.lblLoaiXe);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.cmbVehicle);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            resources.ApplyResources(this.kryptonPanel1, "kryptonPanel1");
            this.kryptonPanel1.Name = "kryptonPanel1";
            // 
            // txtSearch
            // 
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.StateCommon.Content.Font = new System.Drawing.Font("Arial", 11F);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCancel.Values.Image = global::ParkingManagement.Properties.Resources.square1;
            this.btnCancel.Values.Text = resources.GetString("btnCancel.Values.Text");
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSearch.Values.Image = global::ParkingManagement.Properties.Resources.search24;
            this.btnSearch.Values.Text = resources.GetString("btnSearch.Values.Text");
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // kryptonDgvVehicleType
            // 
            this.kryptonDgvVehicleType.AllowUserToOrderColumns = true;
            this.kryptonDgvVehicleType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.kryptonDgvVehicleType.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.kryptonDgvVehicleType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kryptonDgvVehicleType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.kryptonDgvVehicleType, "kryptonDgvVehicleType");
            this.kryptonDgvVehicleType.Name = "kryptonDgvVehicleType";
            this.kryptonDgvVehicleType.RowTemplate.Height = 24;
            // 
            // frmVehicleType
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonGroupBox2);
            this.Name = "frmVehicleType";
            this.Load += new System.EventHandler(this.frmVehicleType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDgvVehicleType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonTextBox txtDescription;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private System.Windows.Forms.ComboBox cmbVehicle;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel lblLoaiXe;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private Krypton.Toolkit.KryptonButton btnSaveToDatabase;
        private Krypton.Toolkit.KryptonButton btnImportExcel;
        private Krypton.Toolkit.KryptonButton btnExportExcel;
        private Krypton.Toolkit.KryptonButton btnReset;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonButton btnDelete;
        private Krypton.Toolkit.KryptonButton btnCreate;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonTextBox txtSearch;
        private Krypton.Toolkit.KryptonButton btnCancel;
        private Krypton.Toolkit.KryptonButton btnSearch;
        private Krypton.Toolkit.KryptonDataGridView kryptonDgvVehicleType;
    }
}