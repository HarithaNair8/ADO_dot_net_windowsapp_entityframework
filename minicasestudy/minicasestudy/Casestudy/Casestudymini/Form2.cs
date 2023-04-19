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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void addResturantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            a.Show();
        }

        private void addMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 b = new Form4();
            b.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Form1 a = new Form1();
            // a.Show();
            
            Form1 a = new Form1();
            a.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
