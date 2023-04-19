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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        FoodEntities ob = new FoodEntities();
        //foodEntities ob = new foodEntities();
        // foodEntities ob = new foodEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Customer o = new Customer();
                //Customer1 o = new Customer1();
                //customer o = new customer();

                o.Customername = textBox1.Text;
                o.Contactnumber = textBox2.Text;
                o.Rcity = textBox3.Text;
                o.Address = textBox4.Text;
                o.UserName = textBox5.Text;
                o.Pwdwrd = textBox6.Text;
                ob.Customers.Add(o); //insert
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
                throw u;
                

            }
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                e.Cancel = true;
                textBox5.Focus();
                errorProvider1.SetError(textBox5, "please enter your name");

            }
            else
            {
                e.Cancel = false;
                
                errorProvider1.SetError(textBox5, "");
            }

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
