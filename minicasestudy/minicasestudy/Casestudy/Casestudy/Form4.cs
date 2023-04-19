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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        foodEntities ob = new foodEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                fooditem o = new fooditem();
                o.food_id = Convert.ToInt32(textBox1.Text);
                o.food_name = textBox2.Text;
                o.price_per_unit= (decimal)Convert.ToDouble( textBox3.Text);
                ob.fooditems.Add(o);
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int portalIdValue = Convert.ToInt32(textBox1.Text);
                //linq to entity update
                var result = (from u in ob.fooditems
                              where u.food_id == portalIdValue
                              select u).FirstOrDefault();
                if (result == null)
                    MessageBox.Show("record not found");
                else
                {
                    result.food_name = textBox2.Text;
                    result.price_per_unit = Convert.ToInt32( textBox3.Text);
                   

                    int finalResult = ob.SaveChanges();
                    if (finalResult > 0)
                        MessageBox.Show("record update successfully");
                    else
                        MessageBox.Show("record is not updated successfully");
                }


            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int portalIdValue = Convert.ToInt32(textBox1.Text);
                //linq to entity update
                var result = (from u in ob.fooditems
                              where u.food_id == portalIdValue
                              select u).FirstOrDefault();
                if (result == null)
                    MessageBox.Show("record not found");
                else
                {
                    ob.fooditems.Remove(result);
                    int finalResult = ob.SaveChanges();
                    if (finalResult > 0)
                        MessageBox.Show("record deleted successfully");
                    else
                        MessageBox.Show("record is not deleted successfully");

                }


            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
