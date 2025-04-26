using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ParkingManagement.Models;
using Krypton.Toolkit;

namespace ParkingManagement.GUI.Forms.statistics
{
    partial class StaticsStaff
    {
        private System.ComponentModel.IContainer components = null;
        private KryptonDateTimePicker dateTimePicker;

        // Dispose resources
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Form initialization and layout
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dateTimePicker = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.btnFilter = new Krypton.Toolkit.KryptonButton();
            this.btnExportExcel = new Krypton.Toolkit.KryptonButton();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            this.dataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.kryptonPanel6 = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).BeginInit();
            this.kryptonPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "MM/yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(109, 34);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker.StateCommon.Content.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.TabIndex = 2;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonPanel6);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel4);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(866, 577);
            this.kryptonPanel1.TabIndex = 3;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(15, 34);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(88, 21);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel1.TabIndex = 28;
            this.kryptonLabel1.Values.Text = "Từ tháng :";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(315, 29);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(31, 30);
            this.btnFilter.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnFilter.TabIndex = 27;
            this.btnFilter.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnFilter.Values.Image = global::ParkingManagement.Properties.Resources.search24;
            this.btnFilter.Values.Text = "Search";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(352, 28);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(109, 31);
            this.btnExportExcel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnExportExcel.TabIndex = 8;
            this.btnExportExcel.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnExportExcel.Values.Image = global::ParkingManagement.Properties.Resources.export_excel;
            this.btnExportExcel.Values.Text = "Export";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Left;
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(0, 0);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(597, 222);
            this.chart2.TabIndex = 31;
            this.chart2.Text = "chart2";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonPanel1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(939, 577);
            this.kryptonPanel2.TabIndex = 4;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.dateTimePicker);
            this.kryptonPanel3.Controls.Add(this.btnExportExcel);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel3.Controls.Add(this.btnFilter);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(866, 74);
            this.kryptonPanel3.TabIndex = 32;
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.dataGridView);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 74);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(866, 281);
            this.kryptonPanel4.TabIndex = 33;
            // 
            // dataGridView
            // 
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(866, 281);
            this.dataGridView.TabIndex = 0;
            // 
            // kryptonPanel6
            // 
            this.kryptonPanel6.Controls.Add(this.chart2);
            this.kryptonPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel6.Location = new System.Drawing.Point(0, 355);
            this.kryptonPanel6.Name = "kryptonPanel6";
            this.kryptonPanel6.Size = new System.Drawing.Size(866, 222);
            this.kryptonPanel6.TabIndex = 35;
            // 
            // StaticsStaff
            // 
            this.ClientSize = new System.Drawing.Size(939, 577);
            this.Controls.Add(this.kryptonPanel2);
            this.Name = "StaticsStaff";
            this.Text = "Statistics Staff";
            this.Load += new System.EventHandler(this.StaticsStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).EndInit();
            this.kryptonPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private KryptonPanel kryptonPanel1;
        private KryptonButton btnExportExcel;
        private KryptonButton btnFilter;
        private KryptonLabel kryptonLabel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private KryptonPanel kryptonPanel4;
        private KryptonPanel kryptonPanel3;
        private KryptonPanel kryptonPanel2;
        private KryptonPanel kryptonPanel6;
        private KryptonDataGridView dataGridView;
    }
}
