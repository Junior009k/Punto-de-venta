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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PV
{
    public partial class Ventas: Form
    {
        private string id { get; set; }        // numeric(18,0) → long
        public Ventas()
        {
            InitializeComponent();
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            List<InventarioI> inventarios = new InventarioController().ObtenerInventario();
            List<ClientI> clientes = new ClientController().ObtenerClientes();
            comboBoxClients.DataSource = clientes ;
            comboBoxProducts.DataSource = inventarios;
            comboBoxClients.DisplayMember = "Fullname";
            comboBoxProducts.DisplayMember = "Name";
            buttonDelete.Enabled = false;
            buttonUpdate.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reloadSalesDetails(string id)
        {
            dgvSalesDetails.Columns.Clear();

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
            dgvSalesDetails.Columns.AddRange(new DataGridViewColumn[] { colId, colProductName, colAmount, colPrice, colTotal });

            // Datos de ejemplo
            List<SalesDetailsI> salesDetails = new SalesDetailsController().ObtenerDetalleVentas(idFact.Text);
            dgvSalesDetails.AutoGenerateColumns = false;
            dgvSalesDetails.DataSource = salesDetails;
            buttonDelete.Enabled = false;
            buttonUpdate.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientI miCliente = comboBoxClients.SelectedItem as ClientI;
            InventarioI miProducto = comboBoxProducts.SelectedItem as InventarioI;
            DateTime fechaActual = DateTime.Now;
            if (idFact.Text == "sin factura")
            {
                SalesI sales = new SalesI
                {
                    idClient = miCliente.Id,
                    total = "0",
                    date = fechaActual
                };
                new SalesController().InsertarVenta(sales);
                idFact.Text = (new SalesController().ObtenerIdVentas()).ToString();
            }
            if (amountSales.Value > 0)
            {
                SalesDetailsI salesDetails = new SalesDetailsI
                {
                    idProduct =miProducto.id,
                    idSales = long.Parse(idFact.Text),
                    amount = amountSales.Value.ToString(),
                    total = (decimal.Parse(miProducto.price) * amountSales.Value).ToString(),
                };
                Console.WriteLine(salesDetails.total);
                new SalesDetailsController().InsertarDetalleVenta(salesDetails);
                SalesI sales = new SalesI
                {
                    id= long.Parse(idFact.Text),
                    idClient = miCliente.Id,
                    total = new SalesDetailsController().ObtenerTotalVentas(idFact.Text),
                };
                
                new SalesController().ActualizarVentas(sales);
                labelTotalValue.Text = "RD$" + new SalesDetailsController().ObtenerTotalVentas(idFact.Text);
                reloadSalesDetails(idFact.Text);

            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            buttonDelete.Enabled = false;
            buttonUpdate.Enabled = false;
            amountSales.Text = "0";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            InventarioI miProducto = comboBoxProducts.SelectedItem as InventarioI;
          
            SalesDetailsI salesDetails = new SalesDetailsI
            {
                id = long.Parse(id),
                idProduct = miProducto.id,
                idSales = long.Parse(idFact.Text),
                amount = amountSales.Value.ToString(),
                total = (decimal.Parse(miProducto.price) * amountSales.Value).ToString(),
            };

            new SalesDetailsController().EliminarDetallesVentas((int)salesDetails.id);
            //this.reloadProduct();
        }

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Obtenemos el valor del campo "Nombre" de la fila seleccionada
                id = dgvSalesDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
                string nombreSeleccionado = dgvSalesDetails.Rows[e.RowIndex].Cells[1].Value.ToString();

                // Buscamos ese valor en el ComboBox
                int indice = comboBoxProducts.FindStringExact(nombreSeleccionado);

                // Si lo encuentra, lo seleccionamos
                if (indice != -1)
                {
                    comboBoxProducts.SelectedIndex = indice;
                }
                else
                {
                    // Si no lo encuentra, puedes decidir qué hacer (por ejemplo, limpiar la selección)
                    comboBoxProducts.SelectedIndex = -1;
                }
            }
            buttonDelete.Enabled = true;
            buttonUpdate.Enabled = true;

            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            InventarioI miProducto = comboBoxProducts.SelectedItem as InventarioI;
            ClientI miCliente = comboBoxClients.SelectedItem as ClientI;
            SalesDetailsI salesDetails = new SalesDetailsI
            {
                id = long.Parse(id),
                idProduct = miProducto.id,
                idSales = long.Parse(idFact.Text),
                amount = amountSales.Value.ToString(),
                total = (decimal.Parse(miProducto.price) * amountSales.Value).ToString(),
            };
            new SalesDetailsController().ActualizarDetalleVentas(salesDetails);
            SalesI sales = new SalesI
            {
                id = long.Parse(idFact.Text),
                idClient = miCliente.Id,
                total = new SalesDetailsController().ObtenerTotalVentas(idFact.Text),
            };

            new SalesController().ActualizarVentas(sales);
            labelTotalValue.Text = "RD$" + new SalesDetailsController().ObtenerTotalVentas(idFact.Text);
            this.reloadSalesDetails(idFact.Text);

        }

        private void buttonFact_Click(object sender, EventArgs e)
        {
            idFact.Text = "sin factura";
            labelTotalValue.Text = "0";
            this.reloadSalesDetails(idFact.Text);
        }
    }
}
