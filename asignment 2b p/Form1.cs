using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asignment_2b_p
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double R1, R2, R3, RT;

            try
            {
                R1 = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect Input.");
                R1 = 0.0;
            }
            try
            {
                R2 = double.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect Input.");
                R2 = 0.0;
            }
            try
            {
                R3 = double.Parse(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect Input.");
                R3 = 0.0;
            }
            RT = 1.0 / (1.0 / R1 + 1.0 / R2 + 1.0 / R3);
            label1.Text = "RT =" + RT;
        }
private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
