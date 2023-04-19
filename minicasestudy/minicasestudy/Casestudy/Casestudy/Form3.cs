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
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        foodEntities ob = new foodEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                restaurant o = new restaurant();
                o.restaurant_id = Convert.ToInt32(textBox1.Text);
                o.restaurant_name = textBox2.Text;
                o.rcity= textBox3.Text;
                o.rlocation= textBox4.Text;
                o.details = textBox5.Text;
                o.details = textBox6.Text;

                ob.restaurants.Add(o);
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
                var result = (from u in ob.restaurants
                              where u.restaurant_id == portalIdValue
                              select u).FirstOrDefault();
                if (result == null)
                    MessageBox.Show("record not found");
                else
                {
                    result.restaurant_name = textBox2.Text;
                    result.rcity= textBox3.Text;
                    result.rlocation= textBox4.Text;
                    result.details = textBox5.Text;
                    result.branch = textBox6.Text;
                    
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
                var result = (from u in ob.restaurants
                              where u.restaurant_id == portalIdValue
                              select u).FirstOrDefault();
                if (result == null)
                    MessageBox.Show("record not found");
                else
                {
                    ob.restaurants.Remove(result);
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
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}
