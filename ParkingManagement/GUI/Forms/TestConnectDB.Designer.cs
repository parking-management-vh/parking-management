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
            this.label1.Location = new System.Drawing.Point(142, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhấn vào đây để test connect tới db, nếu hiện: kết nối thành công + số bảng thì đ" +
    "ã thành công";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "test connect db";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvParkingArea
            // 
            this.dgvParkingArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParkingArea.Location = new System.Drawing.Point(198, 146);
            this.dgvParkingArea.Name = "dgvParkingArea";
            this.dgvParkingArea.Size = new System.Drawing.Size(364, 175);
            this.dgvParkingArea.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(252, 66);
            this.button2.TabIndex = 3;
            this.button2.Text = "test load data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TestConnectDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvParkingArea);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
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