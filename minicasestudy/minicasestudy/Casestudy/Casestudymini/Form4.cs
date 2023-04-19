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
    public partial class Form4 : Form
    {
        public Form4()
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
                Fooditem o = new Fooditem();
                //Fooditem1 o = new Fooditem1();
               // fooditem o = new fooditem();
                o.Foodid = Convert.ToInt32(textBox1.Text);
                o.Foodname = textBox2.Text;
                o.Priceperunit = (decimal)Convert.ToDouble(textBox3.Text);
                ob.Fooditems.Add(o);
                int noOfRows = ob.SaveChanges();//save this datbase table
                if (noOfRows > 0)
                    MessageBox.Show("insertion is successful");
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
                MessageBox.Show("Are You Sure ? ");

            try
            {
                int portalIdValue = Convert.ToInt32(textBox1.Text);
                //linq to entity update
                var result = (from u in ob.Fooditems
                              where u.Foodid == portalIdValue
                              select u).FirstOrDefault();
                if (result == null)
                    MessageBox.Show("record not found");
                else
                {
                    result.Foodname = textBox2.Text;
                    result.Priceperunit = Convert.ToDecimal(textBox3.Text);


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
                var result = (from u in ob.Fooditems
                              where u.Foodid == portalIdValue
                              select u).FirstOrDefault();
                if (result == null)
                    MessageBox.Show("record not found");
                else
                {
                    ob.Fooditems.Remove(result);
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
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "please enter ");

            }
            else
            {
                e.Cancel = false;
                
                errorProvider1.SetError(textBox1, "");
            }

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
