using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casestudymini
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        FoodEntities ob = new FoodEntities();
        //foodEntities ob = new foodEntities();
        //foodEntities ob = new foodEntities();
        private void Form6_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form1.Recby;
            textBox2.Text = Form1.setvalue1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var resultValue = from r in ob.Restaurants
                                  where r.Rcity == textBox1.Text
                                  select r;
                dataGridView1.DataSource = resultValue.ToList();

            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message);
                throw y;
                
            }
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
    }
}
