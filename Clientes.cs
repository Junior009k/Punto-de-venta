using PV.bbdd.Controladores;
using PV.bbdd.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PV
{
    public partial class Clientes: Form
    {
        
        public Clientes()
        {
            InitializeComponent();
        }
        private void reloadClient()
        {
            dgvClient.Columns.Clear();

            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.HeaderText = "ID";
            colId.DataPropertyName = "Id"; // vincula con la propiedad del objeto
            colId.Name = "colId";

            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.HeaderText = "Nombre";
            colNombre.DataPropertyName = "Name";
            colNombre.Name = "colNombre";

            DataGridViewTextBoxColumn colApellido = new DataGridViewTextBoxColumn();
            colApellido.HeaderText = "Apellido";
            colApellido.DataPropertyName = "LastName";
            colApellido.Name = "colApellido";

            DataGridViewTextBoxColumn colEdad = new DataGridViewTextBoxColumn();
            colEdad.HeaderText = "Edad";
            colEdad.DataPropertyName = "Age";
            colEdad.Name = "colEdad";

            dgvClient.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colApellido, colEdad });

            // Datos de ejemplo
            List<ClientI> clientes = new ClientController().ObtenerClientes();

            dgvClient.AutoGenerateColumns = false;
            dgvClient.DataSource = clientes;
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            this.reloadClient();
            buttonDelete.Enabled = false;
            buttonUpdate.Enabled = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //textBoxProductCode.Text= "000001";
            //textBoxProductName.Text = "Coca Cola";
            //textBoxProductPrice.Text = "50";
            //textBoxProductAmount.Text = "25";

           
            ClientI miCliente = new ClientI
            {
                Id = long.Parse(textBoxClientCode.Text),
                Name = textBoxClientName.Text,
                LastName = textBoxClientLastName.Text,
                Age = textBoxClientAge.Text
            };
            new ClientController().InsertarCliente(miCliente);
            this.reloadClient();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            buttonDelete.Enabled = false;
            buttonUpdate.Enabled = false;
            textBoxClientCode.Text = "";
            textBoxClientName.Text = "";
            textBoxClientLastName.Text = "";
            textBoxClientAge.Text = "";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            ClientI miCliente = new ClientI
            {
                Id = long.Parse(textBoxClientCode.Text),
                Name = textBoxClientName.Text,
                LastName = textBoxClientLastName.Text,
                Age = textBoxClientAge.Text
            };
            new ClientController().EliminarCliente((int)miCliente.Id);
            this.reloadClient();
            buttonDelete.Enabled = false;
            buttonUpdate.Enabled = false;
        }

        private void dgvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonDelete.Enabled = true;
            buttonUpdate.Enabled = true;
        
            textBoxClientCode.Text = dgvClient.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxClientName.Text = dgvClient.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxClientLastName.Text = dgvClient.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxClientAge.Text = dgvClient.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            ClientI miCliente = new ClientI
            {
                Id = long.Parse(textBoxClientCode.Text),
                Name = textBoxClientName.Text,
                LastName = textBoxClientLastName.Text,
                Age = textBoxClientAge.Text
            };
            new ClientController().ActualizarCliente(miCliente);
            this.reloadClient();
            buttonDelete.Enabled = false;
            buttonUpdate.Enabled = false;
        }
    }
}
