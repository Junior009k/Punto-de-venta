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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Inventario_Load(object sender, EventArgs e)
        {


        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void reloadProduct()
        {
            dgvSupplier.Columns.Clear();

            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.HeaderText = "ID";
            colId.DataPropertyName = "Id"; // vincula con la propiedad del objeto
            colId.Name = "colId";

            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.HeaderText = "Nombre";
            colNombre.DataPropertyName = "name";
            colNombre.Name = "colNombre";

            DataGridViewTextBoxColumn colAmount = new DataGridViewTextBoxColumn();
            colAmount.HeaderText = "Cantidad";
            colAmount.DataPropertyName = "amount";
            colAmount.Name = "colAmount";

            DataGridViewTextBoxColumn colPrice = new DataGridViewTextBoxColumn();
            colPrice.HeaderText = "Precio";
            colPrice.DataPropertyName = "price";
            colPrice.Name = "colPrice";

            dgvSupplier.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colAmount, colPrice });

            // Datos de ejemplo
            List<InventarioI> inventarios = new InventarioController().ObtenerInventario();

            dgvSupplier.AutoGenerateColumns = false;
            dgvSupplier.DataSource = inventarios;
            buttonDelete.Enabled = false;
            buttonUpdate.Enabled = false;
            textBoxProductCode.Text = "";
            textBoxProductName.Text = "";
            textBoxProductAmount.Text = "";
            textBoxProductPrice.Text = "";
        }

        private void Product_Load(object sender, EventArgs e)
        {
            this.reloadProduct();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {


            InventarioI miInventario = new InventarioI
            {
                id = long.Parse(textBoxProductCode.Text),
                name = textBoxProductName.Text,
                amount = textBoxProductAmount.Text,
                price = textBoxProductPrice.Text
            };
            new InventarioController().InsertarInventario(miInventario);
            this.reloadProduct();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            buttonDelete.Enabled = false;
            buttonUpdate.Enabled = false;
            textBoxProductCode.Text = "";
            textBoxProductName.Text = "";
            textBoxProductAmount.Text = "";
            textBoxProductPrice.Text = "";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            InventarioI miInventario = new InventarioI
            {
                id = long.Parse(textBoxProductCode.Text),
                name = textBoxProductName.Text,
                amount = textBoxProductAmount.Text,
                price = textBoxProductPrice.Text
            };
            Console.WriteLine(miInventario);    
            new InventarioController().EliminarInventario((int)miInventario.id);
            this.reloadProduct();
        }

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonDelete.Enabled = true;
            buttonUpdate.Enabled = true;

            textBoxProductCode.Text = dgvSupplier.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxProductName.Text = dgvSupplier.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxProductAmount.Text = dgvSupplier.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxProductPrice.Text = dgvSupplier.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            InventarioI miInventario = new InventarioI
            {
                id = long.Parse(textBoxProductCode.Text),
                name = textBoxProductName.Text,
                amount = textBoxProductAmount.Text,
                price = textBoxProductPrice.Text
            };
            new InventarioController().ActualizarInventario(miInventario);
            this.reloadProduct();

        }
    }
}
//DGV vincularlo a una fuente de datos