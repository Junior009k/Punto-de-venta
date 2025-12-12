using PV.bbdd.Controladores;
using PV.bbdd.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void reloadReport()
        {
            dgvReport.Columns.Clear();

            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.HeaderText = "ID";
            colId.DataPropertyName = "id"; // vincula con la propiedad del objeto
            colId.Name = "colId";

            DataGridViewTextBoxColumn colClientName = new DataGridViewTextBoxColumn();
            colClientName.HeaderText = "Nombre";
            colClientName.DataPropertyName = "fullName";
            colClientName.Name = "colClientName";

            DataGridViewTextBoxColumn colAge = new DataGridViewTextBoxColumn();
            colAge.HeaderText = "Edad";
            colAge.DataPropertyName = "ageClient";
            colAge.Name = "colAge";

            DataGridViewTextBoxColumn colTotal = new DataGridViewTextBoxColumn();
            colTotal.HeaderText = "Total";
            colTotal.DataPropertyName = "total";
            colTotal.Name = "colTotal";

            DataGridViewTextBoxColumn colDate = new DataGridViewTextBoxColumn();
            colDate.HeaderText = "Fecha";
            colDate.DataPropertyName = "dateS";
            colDate.Name = "colDate";


            dgvReport.Columns.AddRange(new DataGridViewColumn[] { colId, colClientName, colAge, colTotal, colDate });

            // Datos de ejemplo
            List<SalesI> sales = new SalesController().ObtenerVentasReport(dateTimePickerReportDesde.Value, dateTimePickerReporthasta.Value);
            dgvReport.AutoGenerateColumns = false;
            dgvReport.DataSource = sales;
            //buttonDelete.Enabled = false;
            //buttonUpdate.Enabled = false;

        }

        private void reloadReportDetails()
        {
            dgvReport.Columns.Clear();

            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.HeaderText = "ID";
            colId.DataPropertyName = "id"; // vincula con la propiedad del objeto
            colId.Name = "colId";

            DataGridViewTextBoxColumn colProductName = new DataGridViewTextBoxColumn();
            colProductName.HeaderText = "Producto";
            colProductName.DataPropertyName = "nameProduct";
            colProductName.Name = "colProductName";

            DataGridViewTextBoxColumn colAmount = new DataGridViewTextBoxColumn();
            colAmount.HeaderText = "Cantidad";
            colAmount.DataPropertyName = "amount";
            colAmount.Name = "colAmount";

            DataGridViewTextBoxColumn colPrice = new DataGridViewTextBoxColumn();
            colPrice.HeaderText = "Precio";
            colPrice.DataPropertyName = "priceProduct";
            colPrice.Name = "colPrice";

            DataGridViewTextBoxColumn colTotal = new DataGridViewTextBoxColumn();
            colTotal.HeaderText = "Total";
            colTotal.DataPropertyName = "total";
            colTotal.Name = "colTotal";
            dgvReport.Columns.AddRange(new DataGridViewColumn[] { colId, colProductName, colAmount, colPrice, colTotal });

            // Datos de ejemplo
            List<SalesDetailsI> salesDetails = new SalesDetailsController().ObtenerDetalleVentasReport(dateTimePickerReportDesde.Value, dateTimePickerReporthasta.Value);
            dgvReport.AutoGenerateColumns = false;
            dgvReport.DataSource = salesDetails;
            //buttonDelete.Enabled = false;
            //buttonUpdate.Enabled = false;

        }
        private void buttonQuery_Click(object sender, EventArgs e)
        { 
            if(comboBoxTypeQueryReport.Text=="Ventas totales")
            {
                reloadReport();
            }
            else
            {   
                reloadReportDetails();
            }
        }

        private void Report_Load(object sender, EventArgs e)
        {
            reloadReportDetails();
        }
    }
}
