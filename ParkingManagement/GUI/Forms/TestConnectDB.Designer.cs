namespace ParkingManagement.GUI.Forms
{
    partial class TestConnectDB
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvParkingArea = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParkingArea)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhấn vào đây để test connect tới db, nếu hiện: kết nối thành công + số bảng thì đ" +
    "ã thành công";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 62);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(336, 81);
            this.button1.TabIndex = 1;
            this.button1.Text = "test connect db";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvParkingArea
            // 
            this.dgvParkingArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParkingArea.Location = new System.Drawing.Point(264, 180);
            this.dgvParkingArea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvParkingArea.Name = "dgvParkingArea";
            this.dgvParkingArea.Size = new System.Drawing.Size(485, 215);
            this.dgvParkingArea.TabIndex = 2;
            this.dgvParkingArea.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParkingArea_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 437);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(336, 81);
            this.button2.TabIndex = 3;
            this.button2.Text = "test load data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TestConnectDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvParkingArea);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TestConnectDB";
            this.Text = "TestConnectDB";
            this.Load += new System.EventHandler(this.TestConnectDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParkingArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvParkingArea;
        private System.Windows.Forms.Button button2;
    }
}