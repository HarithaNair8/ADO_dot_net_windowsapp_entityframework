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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        FoodEntities ob = new FoodEntities();
        //foodEntities ob = new foodEntities();
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var resultValue = from r in ob.Fooditems

                                  select r;
                dataGridView2.DataSource = resultValue.ToList();

            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message);
                throw y;
                
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn chkbox = new DataGridViewCheckBoxColumn();
            chkbox.HeaderText = "Select";
            chkbox.Width = 25;
            chkbox.Name = "dgvchkbox";
            chkbox.DefaultCellStyle.BackColor = Color.Red;
            dataGridView2.Columns.Insert(0, chkbox);

            DataGridViewCheckBoxColumn chkboxx = new DataGridViewCheckBoxColumn();
            chkboxx.HeaderText = "Select";
            chkboxx.Width = 25;
            chkboxx.Name = "dgvchkbox";
            chkboxx.DefaultCellStyle.BackColor = Color.Red;
            dataGridView1.Columns.Insert(0, chkboxx);



        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Foodid");
            dt.Columns.Add("Foodname");
            dt.Columns.Add("Priceperunit");
            dt.Columns.Add("Orderfood");


            foreach (DataGridViewRow drv in dataGridView2.Rows)
            {
                bool chkboxselect = Convert.ToBoolean(drv.Cells["dgvchkbox"].Value);
                if (chkboxselect)
                {
                    dt.Rows.Add(drv.Cells[2].Value, drv.Cells[3].Value, drv.Cells[4].Value);
                    drv.DefaultCellStyle.BackColor = Color.Gray;
                    drv.DefaultCellStyle.ForeColor = Color.Aqua;
                }
                dataGridView3.DataSource = dt;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal sum = 0;
            for (int i = 0; i < dataGridView3.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(dataGridView3.Rows[i].Cells[1].Value);
            }
            // MessageBox.Show(sum.ToString());
            // textBox1.Show(sum.ToString());
            //Control.Show(sum.ToString)
            textBox2.Text = sum.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                Orderstatu o = new Orderstatu();
                //Orderstatu1 o = new Orderstatu1();
                //orderstatu o = new orderstatu();
                o.Grandtotal = Convert.ToDecimal(textBox2.Text);
                o.Customerid = Convert.ToInt32(textBox3.Text);
                o.Payment = comboBox1.Text;
                ob.Orderstatus.Add(o);//insert
                int noOfRows = ob.SaveChanges();//save this datbase table
                if (noOfRows > 0)
                    MessageBox.Show(" Order Confirmed");
                else
                    MessageBox.Show("Order is not successful");
            }
            catch (Exception u)
            {
                MessageBox.Show(u.Message);
                throw u;
               

            }

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void knowYourCustIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 a = new Form7();
            a.Show();
        }
    }
}
