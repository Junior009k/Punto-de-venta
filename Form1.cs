using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuProyectoWinForm.Clases;

namespace PV
{
    public partial class Form1: Form
    {
        private Ventas formSale = new Ventas();
        private Inventario formInventory = new Inventario();
        private Proveedores formSupplier = new Proveedores();
        private Caja formBox = new Caja();
        private Clientes formClient = new Clientes();
        private Report formReport = new Report();
        Conexion conexion = new Conexion();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSale_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = conexion.AbrirConexion())
            {
                string query = "SELECT * FROM Client";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

            }

            formSale = new Ventas();
            formSale.Show();

        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            formInventory = new Inventario();
            formInventory.Show();

        }

        private void buttonSuppliers_Click(object sender, EventArgs e)
        {
            formSupplier= new Proveedores();
            formSupplier.Show();
        }

        private void buttonBox_Click(object sender, EventArgs e)
        {
            formBox = new Caja();
            formBox.Show();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            formClient = new Clientes();
            formClient.Show();
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            formReport = new Report();
            formReport.Show();
        }
    }
}
