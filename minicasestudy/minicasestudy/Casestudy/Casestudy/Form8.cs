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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        foodEntities ob = new foodEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var resultValue = from r in ob.fooditems
                                 
                                 select r;
                dataGridView1.DataSource = resultValue.ToList();

            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message);
            }



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn chkbox = new DataGridViewCheckBoxColumn();
            chkbox.HeaderText = "Select";
            chkbox.Width = 25;
            chkbox.Name = "dgvchkbox";
            chkbox.DefaultCellStyle.BackColor = Color.Red;
            dataGridView1.Columns.Insert(0, chkbox);

            DataGridViewCheckBoxColumn chkboxx = new DataGridViewCheckBoxColumn();
            chkboxx.HeaderText = "Select";
            chkboxx.Width = 25;
            chkboxx.Name = "dgvchkbox";
            chkboxx.DefaultCellStyle.BackColor = Color.Red;
            dataGridView3.Columns.Insert(0, chkboxx);
            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("food_id");
            dt.Columns.Add("food_name");
            dt.Columns.Add("price_per_unit");
            dt.Columns.Add("order_food");


            foreach (DataGridViewRow drv in dataGridView1.Rows)
            {
                bool chkboxselect = Convert.ToBoolean(drv.Cells["dgvchkbox"].Value);
                if(chkboxselect)
                {
                    dt.Rows.Add(drv.Cells[2].Value, drv.Cells[3].Value, drv.Cells[4].Value);
                    drv.DefaultCellStyle.BackColor = Color.Gray;
                    drv.DefaultCellStyle.ForeColor = Color.Aqua;
                }
                dataGridView2.DataSource = dt;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal sum=0;
            for(int i=0; i < dataGridView2.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
            }
           // MessageBox.Show(sum.ToString());
            // textBox1.Show(sum.ToString());
            //Control.Show(sum.ToString)
            textBox1.Text = sum.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                var resultValue = from r in ob.restaurants
                                  where r.rcity == textBox3.Text
                                  select r;
                dataGridView3.DataSource = resultValue.ToList();

            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message);
            }

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                order_status o = new order_status();
                o.grandtotal = Convert.ToDecimal(textBox1.Text);
                o.customer_id = Convert.ToInt32( textBox2.Text);
                o.paymtd = comboBox1.Text;
                ob.order_status.Add(o);//insert
                int noOfRows = ob.SaveChanges();//save this datbase table
                if (noOfRows > 0)
                    MessageBox.Show("insertion is successful");
                else
                    MessageBox.Show("Insertion is not successful");
            }
            catch (Exception u)
            {
                MessageBox.Show(u.Message);

            }


        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
