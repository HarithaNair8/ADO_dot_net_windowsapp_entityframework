using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
[assembly: CLSCompliant(true)]
namespace Casestudymini
{
    public partial class Form1 : Form
    {
        public static string userrrname;
        public static string setvalue1 = " ";

        public static string Recby
        {
            get { return userrrname; }
            set { userrrname = value; }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        FoodEntities ob = new FoodEntities();
        //foodEntities ob = new foodEntities();
       // foodEntities ob = new foodEntities();
        private void button3_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
                MessageBox.Show( "Login!! ");


            try
            {
                var user = (from s in ob.Userpasswords
                            where s.Usr == textBox4.Text
                            select s).First();
                if (user.Pwd == textBox5.Text)
                {
                    this.Hide();
                    Form2 a = new Form2();
                    a.Show();

                }
                else
                {
                    MessageBox.Show("enter correct password and username");
                    
                }



            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message);
                throw y;
               

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            try
            {
                var user = (from m in ob.Customers
                            where m.UserName == textBox1.Text
                            select m).First();
                if (user.Pwdwrd == textBox2.Text)
                {
                    Recby = textBox3.Text;
                    setvalue1 = textBox1.Text;
                    this.Hide();
                    Form6 c = new Form6();
                    c.Show();

                }
                else
                {
                    MessageBox.Show("enter correct password and username");
                }
                var user2 = (from m in ob.Customers
                             where m.Rcity == textBox3.Text
                             select m).First();


            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message);
                throw y;
                

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 a = new Form5();
            a.Show();
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                e.Cancel = true;
                textBox4.Focus();
                errorProvider1.SetError(textBox4, "please enter ");

            }
            else
            {
                e.Cancel = false;
                
                errorProvider1.SetError(textBox4, "");
            }


        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
