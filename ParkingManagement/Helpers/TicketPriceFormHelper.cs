using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingManagement.Helpers
{
    public class TicketPriceFormHelper
    {
        private readonly DataGridView dgvTicketPrice;
        private readonly Control txtPrice;
        private readonly Control txtDescription;
        private readonly Control rdMonthlyPass;
        private readonly Control rdHourlyPass;
        private readonly Control cmbVehicleType;

        private readonly KryptonTextBox ktxtPrice;
        private readonly KryptonTextBox ktxtDescription;
        private readonly KryptonRadioButton krdMonthlyPass;
        private readonly KryptonRadioButton krdHourlyPass;
        private readonly KryptonComboBox kcmbVehicleType;

        private readonly bool isKrypton;

        // Constructor for Windows Forms Controls
        public TicketPriceFormHelper(DataGridView dgvTicketPrice, Control txtPrice, Control txtDescription, Control rdMonthlyPass, Control rdHourlyPass, Control cmbVehicleType)
        {
            this.dgvTicketPrice = dgvTicketPrice;
            this.txtPrice = txtPrice;
            this.txtDescription = txtDescription;
            this.rdMonthlyPass = rdMonthlyPass;
            this.rdHourlyPass = rdHourlyPass;
            this.cmbVehicleType = cmbVehicleType;

            // Kiểm tra nếu control là của Krypton
            isKrypton = txtPrice is KryptonTextBox;
        }

        // Constructor for Krypton Controls
        public TicketPriceFormHelper(KryptonDataGridView dgvTicketPrice, KryptonTextBox ktxtPrice, KryptonTextBox ktxtDescription, KryptonRadioButton krdMonthlyPass, KryptonRadioButton krdHourlyPass, KryptonComboBox kcmbVehicleType)
        {
            this.dgvTicketPrice = dgvTicketPrice;
            this.ktxtPrice = ktxtPrice;
            this.ktxtDescription = ktxtDescription;
            this.krdMonthlyPass = krdMonthlyPass;
            this.krdHourlyPass = krdHourlyPass;
            this.kcmbVehicleType = kcmbVehicleType;

            isKrypton = true;
        }


        public void ResetForm()
        {
            if (isKrypton)
            {
                ktxtPrice.Text = "";
                ktxtDescription.Text = "";
                krdMonthlyPass.Checked = false;
                krdHourlyPass.Checked = true;
                kcmbVehicleType.SelectedIndex = -1;
            }
            else
            {
                ((TextBox)txtPrice).Text = "";
                ((TextBox)txtDescription).Text = "";
                ((RadioButton)rdMonthlyPass).Checked = false;
                ((RadioButton)rdHourlyPass).Checked = true;
                ((ComboBox)cmbVehicleType).SelectedIndex = -1;
            }
        }
        public void LoadSelectedRowToForm(DataGridViewRow row, ref string selectedId)
        {
            if (row == null || dgvTicketPrice.DataSource == null)
            {
                MessageBox.Show("Dữ liệu trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!row.DataGridView.Columns.Contains("vehicle_type_id"))
            {
                MessageBox.Show("Cột 'vehicle_type_id' không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            kcmbVehicleType.SelectedValue = row.Cells["vehicle_type_id"].Value ?? DBNull.Value;
            ktxtPrice.Text = row.Cells["price"].Value?.ToString() ?? "";
            ktxtDescription.Text = row.Cells["description"].Value?.ToString() ?? "";
            krdMonthlyPass.Checked = Convert.ToBoolean(row.Cells["is_month"].Value);
            krdHourlyPass.Checked = !Convert.ToBoolean(row.Cells["is_month"].Value);

            selectedId = row.Cells["id"].Value?.ToString() ?? "";
        }



        public void ConfigureDataGridView()
        {
            dgvTicketPrice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            if (dgvTicketPrice.Columns.Contains("id"))
            {
                dgvTicketPrice.Columns["id"].Width = 250;
                dgvTicketPrice.Columns["id"].Resizable = DataGridViewTriState.False;
            }

            EnsureRequiredColumns();

            dgvTicketPrice.ScrollBars = ScrollBars.Both;
            dgvTicketPrice.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void EnsureRequiredColumns()
        {
            string[] requiredColumns = { "id", "vehicle_type_id", "price", "description", "is_month" };

            foreach (string colName in requiredColumns)
            {
                if (!dgvTicketPrice.Columns.Contains(colName))
                {
                    dgvTicketPrice.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = colName,
                        HeaderText = colName.Replace("_", " ").ToUpper(),
                        DataPropertyName = colName
                    });
                }
            }
        }

    }
}
