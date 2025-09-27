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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //textBoxProductCode.Text= "000001";
            //textBoxProductName.Text = "Coca Cola";
            //textBoxProductPrice.Text = "50";
            //textBoxProductAmount.Text = "25";
            if (textBoxProductCode.Text.Length > 0 && textBoxProductName.Text.Length > 0 && textBoxProductPrice.Text.Length > 0 && textBoxProductAmount.Text.Length > 0)
            {
                var index = this.dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = textBoxProductCode.Text;
                dataGridView1.Rows[index].Cells[1].Value = textBoxProductName.Text;
                dataGridView1.Rows[index].Cells[2].Value = textBoxProductPrice.Text;
                dataGridView1.Rows[index].Cells[3].Value = textBoxProductAmount.Text;
                textBoxProductCode.Text = "";
                textBoxProductName.Text = "";
                textBoxProductPrice.Text = "";
                textBoxProductAmount.Text = "";

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
//DGV vincularlo a una fuente de datos