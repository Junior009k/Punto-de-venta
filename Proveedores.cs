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
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }



        private void reloadSupplier()
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

            DataGridViewTextBoxColumn colRNC = new DataGridViewTextBoxColumn();
            colRNC.HeaderText = "RNC";
            colRNC.DataPropertyName = "rnc";
            colRNC.Name = "colRNC";

            dgvSupplier.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colRNC });

            // Datos de ejemplo
            List<ProveedorI> proveedor = new ProveedorController().ObtenerProveedor();
            buttonDelete.Enabled = false;
            buttonUpdate.Enabled = false;
            dgvSupplier.AutoGenerateColumns = false;
            dgvSupplier.DataSource = proveedor;
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            this.reloadSupplier();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ProveedorI miProveedor = new ProveedorI
            {
                id = long.Parse(textBoxSupplierCode.Text),
                name = textBoxSupplierName.Text,
                RNC = textBoxSupplierRNC.Text
            };
            new ProveedorController().InsertarProveedor(miProveedor);
            this.reloadSupplier();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            buttonDelete.Enabled = false;
            buttonUpdate.Enabled = false;
            textBoxSupplierCode.Text = "";
            textBoxSupplierName.Text = "";
            textBoxSupplierRNC.Text = "";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            ProveedorI miProveedor = new ProveedorI
            {
                id = long.Parse(textBoxSupplierCode.Text),
                name = textBoxSupplierName.Text,
                RNC = textBoxSupplierRNC.Text
            };
            Console.WriteLine(miProveedor); 
            new ProveedorController().EliminarProveedor((int)miProveedor.id);
            this.reloadSupplier();
            
        }

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonDelete.Enabled = true;
            buttonUpdate.Enabled = true;

            textBoxSupplierCode.Text = dgvSupplier.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxSupplierName.Text = dgvSupplier.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxSupplierRNC.Text = dgvSupplier.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            ProveedorI miProveedor = new ProveedorI
            {
                id = long.Parse(textBoxSupplierCode.Text),
                name = textBoxSupplierName.Text,
                RNC = textBoxSupplierRNC.Text
            };
            new ProveedorController().ActualizarProveedor(miProveedor);
            this.reloadSupplier();

        }
    }
}
