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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        FoodEntities ob = new FoodEntities();
        //foodEntities ob = new foodEntities();
        //foodEntities ob = new foodEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
                MessageBox.Show("Are You Sure ?");


            try
            {
                Restaurant o = new Restaurant();
               // Restaurant1 o = new Restaurant1();
               // restaurant o = new restaurant();
                o.Restaurantid = Convert.ToInt32(textBox1.Text);
                o.Restaurantname = textBox2.Text;
                o.Rcity = textBox3.Text;
                o.Rlocation = textBox4.Text;
                o.Details = textBox5.Text;
                o.Branch = textBox6.Text;

                ob.Restaurants.Add(o);
                int noOfRows = ob.SaveChanges();//save this datbase table
                if (noOfRows > 0)
                    MessageBox.Show(  "insertion is successful");
                else
                    MessageBox.Show("Insertion is not successful");
            }
            catch (Exception u)
            {
                MessageBox.Show(u.Message);
                throw u;
                


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
                MessageBox.Show("Are You Sure ?");

            try
            {
                int portalIdValue = Convert.ToInt32(textBox1.Text);
                //linq to entity update
                var result = (from u in ob.Restaurants
                              where u.Restaurantid == portalIdValue
                              select u).FirstOrDefault();
                if (result == null)
                    MessageBox.Show("record not found");
                else
                {
                    result.Restaurantname = textBox2.Text;
                    result.Rcity = textBox3.Text;
                    result.Rlocation = textBox4.Text;
                    result.Details = textBox5.Text;
                    result.Branch = textBox6.Text;

                    int finalResult = ob.SaveChanges();
                    if (finalResult > 0)
                        MessageBox.Show("record update successfully" );
                    else
                        MessageBox.Show("record is not updated successfully");
                }


            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message);
                throw y;
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
                MessageBox.Show("Are You Sure ?");

            try
            {
                int portalIdValue = Convert.ToInt32(textBox1.Text);
                //linq to entity update
                var result = (from u in ob.Restaurants
                              where u.Restaurantid == portalIdValue
                              select u).FirstOrDefault();
                if (result == null)
                    MessageBox.Show("record not found");
                else
                {
                    ob.Restaurants.Remove(result);
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
                throw y;
                
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

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "please enter your name");

            }
            else
            {
                e.Cancel = false;
                
                errorProvider1.SetError(textBox1, "");
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
