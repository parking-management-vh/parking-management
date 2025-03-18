namespace ParkingManagement.GUI.Forms.staff
{
    partial class frmManageVehicle
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
            this.kDgvListVehicle = new Krypton.Toolkit.KryptonDataGridView();
            this.kryptonGroupBox2 = new Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            this.kBtnSearch = new Krypton.Toolkit.KryptonButton();
            this.kTbSBks = new System.Windows.Forms.TextBox();
            this.kCbbSTypeV = new Krypton.Toolkit.KryptonComboBox();
            this.kCbbSSlot = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.kCbbTypeVehicle = new Krypton.Toolkit.KryptonComboBox();
            this.kCbbSlot = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kDTPOut = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kDTPIn = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kTbLicense_Plate = new System.Windows.Forms.TextBox();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kDgvListVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbSTypeV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbSSlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbTypeVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbSlot)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(0, 253);
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kDgvListVehicle);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(987, 254);
            this.kryptonGroupBox1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox1.TabIndex = 0;
            this.kryptonGroupBox1.Values.Heading = "Quản lý phương tiện";
            // 
            // kDgvListVehicle
            // 
            this.kDgvListVehicle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kDgvListVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kDgvListVehicle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kDgvListVehicle.Location = new System.Drawing.Point(0, 4);
            this.kDgvListVehicle.Name = "kDgvListVehicle";
            this.kDgvListVehicle.Size = new System.Drawing.Size(983, 227);
            this.kDgvListVehicle.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kDgvListVehicle.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kDgvListVehicle.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kDgvListVehicle.StateCommon.DataCell.Content.Padding = new System.Windows.Forms.Padding(36, 2, 36, 0);
            this.kDgvListVehicle.StateCommon.HeaderColumn.Content.Padding = new System.Windows.Forms.Padding(1);
            this.kDgvListVehicle.TabIndex = 0;
            this.kDgvListVehicle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kDgvListVehicle_CellClick);
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Location = new System.Drawing.Point(514, 18);
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonLabel10);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kBtnSearch);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kTbSBks);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kCbbSTypeV);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kCbbSSlot);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonLabel8);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonLabel7);
            this.kryptonGroupBox2.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonGroupBox2_Panel_Paint);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(368, 226);
            this.kryptonGroupBox2.TabIndex = 1;
            this.kryptonGroupBox2.Values.Heading = "Lọc";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(38, 105);
            this.kryptonLabel10.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(109, 19);
            this.kryptonLabel10.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel10.TabIndex = 29;
            this.kryptonLabel10.Values.Text = "Biển kiểm soát :";
            // 
            // kBtnSearch
            // 
            this.kBtnSearch.Location = new System.Drawing.Point(258, 142);
            this.kBtnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.kBtnSearch.Name = "kBtnSearch";
            this.kBtnSearch.Size = new System.Drawing.Size(68, 26);
            this.kBtnSearch.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kBtnSearch.TabIndex = 23;
            this.kBtnSearch.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kBtnSearch.Values.Text = "Tìm";
            this.kBtnSearch.Click += new System.EventHandler(this.kBtnSearch_Click);
            // 
            // kTbSBks
            // 
            this.kTbSBks.Location = new System.Drawing.Point(194, 102);
            this.kTbSBks.Margin = new System.Windows.Forms.Padding(2);
            this.kTbSBks.Name = "kTbSBks";
            this.kTbSBks.Size = new System.Drawing.Size(132, 20);
            this.kTbSBks.TabIndex = 24;
            // 
            // kCbbSTypeV
            // 
            this.kCbbSTypeV.DropDownWidth = 198;
            this.kCbbSTypeV.Location = new System.Drawing.Point(194, 60);
            this.kCbbSTypeV.Margin = new System.Windows.Forms.Padding(2);
            this.kCbbSTypeV.Name = "kCbbSTypeV";
            this.kCbbSTypeV.Size = new System.Drawing.Size(132, 22);
            this.kCbbSTypeV.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kCbbSTypeV.TabIndex = 28;
            // 
            // kCbbSSlot
            // 
            this.kCbbSSlot.DropDownWidth = 198;
            this.kCbbSSlot.Location = new System.Drawing.Point(194, 18);
            this.kCbbSSlot.Margin = new System.Windows.Forms.Padding(2);
            this.kCbbSSlot.Name = "kCbbSSlot";
            this.kCbbSSlot.Size = new System.Drawing.Size(132, 22);
            this.kCbbSSlot.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kCbbSSlot.TabIndex = 27;
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(38, 64);
            this.kryptonLabel8.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(121, 19);
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.TabIndex = 25;
            this.kryptonLabel8.Values.Text = "Loại phương tiện :";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(38, 23);
            this.kryptonLabel7.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(46, 19);
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 26;
            this.kryptonLabel7.Values.Text = "Vị trí :";
            // 
            // kCbbTypeVehicle
            // 
            this.kCbbTypeVehicle.DropDownWidth = 198;
            this.kCbbTypeVehicle.Location = new System.Drawing.Point(200, 85);
            this.kCbbTypeVehicle.Margin = new System.Windows.Forms.Padding(2);
            this.kCbbTypeVehicle.Name = "kCbbTypeVehicle";
            this.kCbbTypeVehicle.Size = new System.Drawing.Size(207, 22);
            this.kCbbTypeVehicle.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kCbbTypeVehicle.TabIndex = 14;
            // 
            // kCbbSlot
            // 
            this.kCbbSlot.DropDownWidth = 198;
            this.kCbbSlot.Location = new System.Drawing.Point(200, 41);
            this.kCbbSlot.Margin = new System.Windows.Forms.Padding(2);
            this.kCbbSlot.Name = "kCbbSlot";
            this.kCbbSlot.Size = new System.Drawing.Size(207, 22);
            this.kCbbSlot.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kCbbSlot.TabIndex = 13;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(52, 44);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(46, 19);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 11;
            this.kryptonLabel3.Values.Text = "Vị trí :";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(52, 88);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(121, 19);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 10;
            this.kryptonLabel2.Values.Text = "Loại phương tiện :";
            // 
            // kDTPOut
            // 
            this.kDTPOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.kDTPOut.Location = new System.Drawing.Point(200, 215);
            this.kDTPOut.Margin = new System.Windows.Forms.Padding(2);
            this.kDTPOut.Name = "kDTPOut";
            this.kDTPOut.Size = new System.Drawing.Size(207, 21);
            this.kDTPOut.TabIndex = 20;
            // 
            // kDTPIn
            // 
            this.kDTPIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.kDTPIn.Location = new System.Drawing.Point(200, 171);
            this.kDTPIn.Margin = new System.Windows.Forms.Padding(2);
            this.kDTPIn.Name = "kDTPIn";
            this.kDTPIn.Size = new System.Drawing.Size(207, 21);
            this.kDTPIn.TabIndex = 19;
            // 
            // kTbLicense_Plate
            // 
            this.kTbLicense_Plate.Location = new System.Drawing.Point(200, 128);
            this.kTbLicense_Plate.Margin = new System.Windows.Forms.Padding(2);
            this.kTbLicense_Plate.Name = "kTbLicense_Plate";
            this.kTbLicense_Plate.Size = new System.Drawing.Size(207, 20);
            this.kTbLicense_Plate.TabIndex = 18;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(52, 217);
            this.kryptonLabel6.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(92, 19);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 17;
            this.kryptonLabel6.Values.Text = "Thời gian ra :";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(52, 173);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(102, 19);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 16;
            this.kryptonLabel5.Values.Text = "Thời gian vào :";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(52, 129);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(109, 19);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 15;
            this.kryptonLabel4.Values.Text = "Biển kiểm soát :";
            // 
            // frmManageVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 507);
            this.Controls.Add(this.kDTPOut);
            this.Controls.Add(this.kDTPIn);
            this.Controls.Add(this.kTbLicense_Plate);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kCbbTypeVehicle);
            this.Controls.Add(this.kCbbSlot);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonGroupBox2);
            this.Controls.Add(this.kryptonGroupBox1);
            this.Name = "frmManageVehicle";
            this.Text = "frmManageVehicle";
            this.Load += new System.EventHandler(this.frmManageVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kDgvListVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kCbbSTypeV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbSSlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbTypeVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbSlot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonDataGridView kDgvListVehicle;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonButton kBtnSearch;
        private System.Windows.Forms.TextBox kTbSBks;
        private Krypton.Toolkit.KryptonComboBox kCbbSTypeV;
        private Krypton.Toolkit.KryptonComboBox kCbbSSlot;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonComboBox kCbbTypeVehicle;
        private Krypton.Toolkit.KryptonComboBox kCbbSlot;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonDateTimePicker kDTPOut;
        private Krypton.Toolkit.KryptonDateTimePicker kDTPIn;
        private System.Windows.Forms.TextBox kTbLicense_Plate;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
    }
}