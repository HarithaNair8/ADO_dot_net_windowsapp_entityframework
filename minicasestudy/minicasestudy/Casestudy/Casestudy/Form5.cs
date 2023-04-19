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
    public partial class Form5 : Form
    {
        public Form5()
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
                customer o = new customer();
                
                o.customer_name = textBox1.Text;
                o.contact_number = textBox2.Text;
                o.rcity= textBox3.Text;
                o.address = textBox4.Text;
                o.username = textBox5.Text;
                o.pwdwrd = textBox6.Text;
                ob.customers.Add(o); //insert
                int noOfRows = ob.SaveChanges();//save this datbase table
                if (noOfRows > 0)
                {
                    MessageBox.Show("successful");
                    Form1 a = new Form1();
                    a.Show();
                }

                else
                {
                    MessageBox.Show("Sign Up is not successful");

                }
                    
            }
            catch (Exception u)
            {
                MessageBox.Show(u.Message);

            }
            


        }
    }
}
