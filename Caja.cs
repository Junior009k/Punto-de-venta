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
    public partial class Caja: Form
    {
        public Caja()
        {
            InitializeComponent();
        }


        private void reloadBox()
        {
            dgvCaja.Columns.Clear();

            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.HeaderText = "ID";
            colId.DataPropertyName = "id"; // vincula con la propiedad del objeto
            colId.Name = "colId";

            DataGridViewTextBoxColumn colConcept = new DataGridViewTextBoxColumn();
            colConcept.HeaderText = "Concepto";
            colConcept.DataPropertyName = "concept";
            colConcept.Name = "colConcept";

            DataGridViewTextBoxColumn colDate = new DataGridViewTextBoxColumn();
            colDate.HeaderText = "Fecha";
            colDate.DataPropertyName = "date";
            colDate.Name = "colDate";

            DataGridViewTextBoxColumn colAmount = new DataGridViewTextBoxColumn();
            colAmount.HeaderText = "Monto";
            colAmount.DataPropertyName = "amount";
            colAmount.Name = "colAmount";

            dgvCaja.Columns.AddRange(new DataGridViewColumn[] { colId, colConcept, colDate, colAmount });

            // Datos de ejemplo
            List<BoxI> cajas = new BoxController().ObtenerCaja();

            dgvCaja.AutoGenerateColumns = false;
            dgvCaja.DataSource = cajas;
            textBoxBoxCode.Text = "";
            textBoxBoxAmount.Text = "";
            textBoxBoxConcept.Text = "";
            textBoxBoxDate.Text = "";
        }

        private void Cajas_Load(object sender, EventArgs e)
        {
            this.reloadBox();
            buttonDelete.Enabled = false;
            buttonUpdate.Enabled = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //textBoxProductCode.Text= "000001";
            //textBoxProductName.Text = "Coca Cola";
            //textBoxProductPrice.Text = "50";
            //textBoxProductAmount.Text = "25";


            BoxI miCaja = new BoxI
            {
                id = long.Parse(textBoxBoxCode.Text),
                concept = textBoxBoxConcept.Text,
                date = textBoxBoxDate.Text,
                amount = textBoxBoxAmount.Text
            };
            Console.WriteLine(miCaja);
            new BoxController().InsertarCaja(miCaja);
            this.reloadBox();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            buttonDelete.Enabled = false;
            buttonUpdate.Enabled = false;
            textBoxBoxCode.Text = "";
            textBoxBoxAmount.Text = "";
            textBoxBoxConcept.Text = "";
            textBoxBoxDate.Text = "";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            BoxI miCaja = new BoxI
            {
                id = long.Parse(textBoxBoxCode.Text),
                concept = textBoxBoxConcept.Text,
                date = textBoxBoxDate.Text,
                amount = textBoxBoxAmount.Text
            };
            new BoxController().EliminarCaja((int)miCaja.id);
            this.reloadBox();
            buttonDelete.Enabled = false;
            buttonUpdate.Enabled = false;
        }

        private void dgvCaja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonDelete.Enabled = true;
            buttonUpdate.Enabled = true;

            textBoxBoxCode.Text = dgvCaja.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxBoxConcept.Text = dgvCaja.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxBoxDate.Text = dgvCaja.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxBoxAmount.Text = dgvCaja.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            BoxI miCaja = new BoxI
            {
                id = long.Parse(textBoxBoxCode.Text),
                concept = textBoxBoxConcept.Text,
                date = textBoxBoxDate.Text,
                amount = textBoxBoxAmount.Text
            };
            new BoxController().ActualizarCaja(miCaja);
            this.reloadBox();
            buttonDelete.Enabled = false;
            buttonUpdate.Enabled = false;

        }
    }
}
