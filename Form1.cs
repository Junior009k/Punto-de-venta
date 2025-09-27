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
    public partial class Form1: Form
    {
        private Ventas formSale = new Ventas();
        private Inventario formInventory = new Inventario();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSale_Click(object sender, EventArgs e)
        {

            formSale = new Ventas();
            formSale.Show();

        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            formInventory = new Inventario();
            formInventory.Show();

        }
    }
}
