using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casestudy
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        foodEntities ob = new foodEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var resultValue = from r in ob.restaurants
                                  where r.rcity == textBox1.Text
                                  select r;
                dataGridView1.DataSource = resultValue.ToList();

            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message);
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form1.recby;
            textBox2.Text = Form1.setvalue1;
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void generateCustIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 c = new Form7();
            c.Show();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 c = new Form8();
            c.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
