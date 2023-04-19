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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        foodEntities ob = new foodEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //var resultValue = from r in ob.customers
                //                  where r.customer_name == textBox1.Text
                 //                 select r.customer_id;
                var resultValue2 = from r in ob.customers
                                  where r.pwdwrd == textBox2.Text
                                  select r;
              //  var resultValue3 = from r in ob.customers
               //                   where r.rcity == textBox3.Text
               //                   select r.customer_id;
                dataGridView1.DataSource = resultValue2.ToList();
                this.dataGridView1.Columns["customer_name"].Visible = false;
                this.dataGridView1.Columns["contact_number"].Visible = false;
                this.dataGridView1.Columns["rcity"].Visible = false;
                this.dataGridView1.Columns["address"].Visible = false;
                this.dataGridView1.Columns["username"].Visible = false;
                this.dataGridView1.Columns["pwdwrd"].Visible = false;
                this.dataGridView1.Columns["order_food"].Visible = false;




            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message);

            }

        }
    }
}
