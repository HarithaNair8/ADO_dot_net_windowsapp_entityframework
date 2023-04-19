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
    public partial class Form1 : Form
    {
        public static string userrrname;
        public static string setvalue1 = " ";
        
        public static string recby
        {
            get { return userrrname;  }
            set { userrrname = value;}
            
        }
        
        foodEntities db = new foodEntities();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
                MessageBox.Show("ok ");


            try
            {
                var user = (from m in db.customers
                            where m.username == textBox3.Text
                            select m).First();
                if (user.pwdwrd == textBox4.Text)
                {
                    recby = textBox5.Text;
                    setvalue1 = textBox3.Text;
                    this.Hide();
                    Form6 c = new Form6();
                    c.Show();

                }
                else
                {
                    MessageBox.Show("enter correct password and username");
                }
                var user2 = (from m in db.customers
                             where m.rcity == textBox5.Text
                             select m).First();


            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message);

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var user = (from s in db.userpasswords
                            where s.usr == textBox1.Text
                            select s).First();
                if(user.pwd ==textBox2.Text)
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
            catch(Exception y)
            {
                MessageBox.Show(y.Message);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 a = new Form5();
            a.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                e.Cancel = true;
                textBox3.Focus();
                errorProvider1.SetError(textBox3, "please enter ");

            }
            else
            {
                e.Cancel = false;
                
                errorProvider1.SetError(textBox3, "");
            }

        }
    }
}
