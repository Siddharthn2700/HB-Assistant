using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hypapp_test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 f2;
        private void Form1_Load(object sender, EventArgs e)
        {
            //MaximizeBox = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (f2 == null)
            {
                f2 = new Form2();
                f2.MdiParent = this;
                f2.FormClosed += new FormClosedEventHandler(f2_FormClosed);
                f2.Show();
                button1.Hide();
                pictureBox1.Hide();



            }
            else
            {
                f2.Activate();           
            
            }
        }

        private void f2_FormClosed(object sender, FormClosedEventArgs e)
        {
            f2 = null;
            //throw new NotImplementedException();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
