namespace ParkingManagement.GUI.Forms
{
    partial class frmCreatePayment
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
            this.components = new System.ComponentModel.Container();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.lblClock = new Krypton.Toolkit.KryptonLabel();
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.kryptonDateTimePicker1 = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.kLbCodeStaff = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kCbbPaymentMethod = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kTbBks = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kBtnPaymentNow = new Krypton.Toolkit.KryptonButton();
            this.kCbbCancel = new Krypton.Toolkit.KryptonButton();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kCbbPaymentMethod)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(116, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(98, 23);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Thanh toán";
            // 
            // lblClock
            // 
            this.lblClock.Location = new System.Drawing.Point(12, 56);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(58, 20);
            this.lblClock.TabIndex = 3;
            this.lblClock.Values.Text = "Đồng hồ";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(12, 82);
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonDateTimePicker1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel6);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kLbCodeStaff);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kCbbPaymentMethod);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel5);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kTbBks);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel4);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(307, 192);
            this.kryptonGroupBox1.TabIndex = 4;
            this.kryptonGroupBox1.Values.Heading = "Bill";
            // 
            // kryptonDateTimePicker1
            // 
            this.kryptonDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.kryptonDateTimePicker1.Location = new System.Drawing.Point(138, 128);
            this.kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            this.kryptonDateTimePicker1.Size = new System.Drawing.Size(126, 21);
            this.kryptonDateTimePicker1.TabIndex = 12;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(12, 130);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(116, 19);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 11;
            this.kryptonLabel6.Values.Text = "Ngày thanh toán:";
            // 
            // kLbCodeStaff
            // 
            this.kLbCodeStaff.Location = new System.Drawing.Point(138, 12);
            this.kLbCodeStaff.Name = "kLbCodeStaff";
            this.kLbCodeStaff.Size = new System.Drawing.Size(107, 19);
            this.kLbCodeStaff.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kLbCodeStaff.TabIndex = 10;
            this.kLbCodeStaff.Values.Text = "KH2503021903";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(98, 19);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 9;
            this.kryptonLabel2.Values.Text = "Mã nhân viên:";
            // 
            // kCbbPaymentMethod
            // 
            this.kCbbPaymentMethod.DropDownWidth = 126;
            this.kCbbPaymentMethod.Location = new System.Drawing.Point(138, 85);
            this.kCbbPaymentMethod.Name = "kCbbPaymentMethod";
            this.kCbbPaymentMethod.Size = new System.Drawing.Size(126, 22);
            this.kCbbPaymentMethod.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kCbbPaymentMethod.TabIndex = 8;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(12, 88);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(85, 19);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 7;
            this.kryptonLabel5.Values.Text = "Thanh toán:";
            // 
            // kTbBks
            // 
            this.kTbBks.Location = new System.Drawing.Point(138, 45);
            this.kTbBks.Name = "kTbBks";
            this.kTbBks.Size = new System.Drawing.Size(126, 23);
            this.kTbBks.TabIndex = 6;
            this.kTbBks.Text = "34-aa-12345";
            this.kTbBks.TextChanged += new System.EventHandler(this.kTbBks_TextChanged);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(12, 49);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(61, 19);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 5;
            this.kryptonLabel4.Values.Text = "Biển số:";
            // 
            // kBtnPaymentNow
            // 
            this.kBtnPaymentNow.Location = new System.Drawing.Point(232, 285);
            this.kBtnPaymentNow.Name = "kBtnPaymentNow";
            this.kBtnPaymentNow.Size = new System.Drawing.Size(87, 25);
            this.kBtnPaymentNow.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kBtnPaymentNow.TabIndex = 5;
            this.kBtnPaymentNow.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kBtnPaymentNow.Values.Text = "Hoàn tất";
            this.kBtnPaymentNow.Click += new System.EventHandler(this.kBtnPaymentNow_Click);
            // 
            // kCbbCancel
            // 
            this.kCbbCancel.Location = new System.Drawing.Point(12, 285);
            this.kCbbCancel.Name = "kCbbCancel";
            this.kCbbCancel.Size = new System.Drawing.Size(58, 25);
            this.kCbbCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kCbbCancel.TabIndex = 6;
            this.kCbbCancel.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kCbbCancel.Values.Text = "Huỷ";
            this.kCbbCancel.Click += new System.EventHandler(this.kCbbCancel_Click);
            // 
            // frmCreatePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 322);
            this.Controls.Add(this.kCbbCancel);
            this.Controls.Add(this.kBtnPaymentNow);
            this.Controls.Add(this.kryptonGroupBox1);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.kryptonLabel1);
            this.Name = "frmCreatePayment";
            this.Text = "frmCreatePayment";
            this.Load += new System.EventHandler(this.frmCreatePayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kCbbPaymentMethod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel lblClock;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonTextBox kTbBks;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonComboBox kCbbPaymentMethod;
        private Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kLbCodeStaff;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonButton kBtnPaymentNow;
        private Krypton.Toolkit.KryptonButton kCbbCancel;
        private System.Windows.Forms.Timer timerClock;
    }
}