namespace ParkingManagement.GUI.Forms.statistics
{
    partial class StatisticsForm
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
            this.pieChart2 = new LiveCharts.WinForms.PieChart();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.pieChart = new LiveCharts.WinForms.PieChart();
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.pieChart);
            this.kryptonPanel1.Controls.Add(this.pieChart2);
            this.kryptonPanel1.Controls.Add(this.pieChart1);
            this.kryptonPanel1.Controls.Add(this.cartesianChart1);
            this.kryptonPanel1.Controls.Add(this.cartesianChart);
            this.kryptonPanel1.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1388, 656);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // pieChart2
            // 
            this.pieChart2.Location = new System.Drawing.Point(991, 168);
            this.pieChart2.Name = "pieChart2";
            this.pieChart2.Size = new System.Drawing.Size(380, 251);
            this.pieChart2.TabIndex = 7;
            this.pieChart2.Text = "pieChart1";
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(605, 425);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(380, 251);
            this.pieChart1.TabIndex = 6;
            this.pieChart1.Text = "pieChart1";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(0, 425);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(599, 251);
            this.cartesianChart1.TabIndex = 5;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // cartesianChart
            // 
            this.cartesianChart.Location = new System.Drawing.Point(0, 168);
            this.cartesianChart.Name = "cartesianChart";
            this.cartesianChart.Size = new System.Drawing.Size(599, 251);
            this.cartesianChart.TabIndex = 4;
            this.cartesianChart.Text = "cartesianChart1";
            // 
            // pieChart
            // 
            this.pieChart.Location = new System.Drawing.Point(605, 168);
            this.pieChart.Name = "pieChart";
            this.pieChart.Size = new System.Drawing.Size(380, 251);
            this.pieChart.TabIndex = 2;
            this.pieChart.Text = "pieChart1";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(776, 150);
            this.kryptonGroupBox1.TabIndex = 1;
            this.kryptonGroupBox1.Values.Heading = "Option";
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 656);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private LiveCharts.WinForms.CartesianChart cartesianChart;
        private LiveCharts.WinForms.PieChart pieChart;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private LiveCharts.WinForms.PieChart pieChart1;
        private LiveCharts.WinForms.PieChart pieChart2;
    }
}