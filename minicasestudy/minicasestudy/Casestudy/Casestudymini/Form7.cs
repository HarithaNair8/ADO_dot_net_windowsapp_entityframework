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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        FoodEntities ob = new FoodEntities();
        //foodEntities ob = new foodEntities();
        //foodEntities ob = new foodEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //var resultValue = from r in ob.customers
                //                  where r.customer_name == textBox1.Text
                //                 select r.customer_id;
                var resultValue2 = from r in ob.Customers
                                   where r.Pwdwrd == textBox1.Text
                                   select r;
                //  var resultValue3 = from r in ob.customers
                //                   where r.rcity == textBox3.Text
                //                   select r.customer_id;
                dataGridView1.DataSource = resultValue2.ToList();
                this.dataGridView1.Columns["Customername"].Visible = false;
                this.dataGridView1.Columns["Contactnumber"].Visible = false;
                this.dataGridView1.Columns["Rcity"].Visible = false;
                this.dataGridView1.Columns["Address"].Visible = false;
                this.dataGridView1.Columns["Username"].Visible = false;
                this.dataGridView1.Columns["Pwdwrd"].Visible = false;
                //this.dataGridView1.Columns["Orderfood"].Visible = false;




            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message);
                throw y;
                

            }

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
