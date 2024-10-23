using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double pi = 3.14;
        double r;
        double result;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           r=Convert.ToDouble(textBox1.Text);
           result = r * pi * r;
           label2.Text = " Area result is " + result.ToString();
           MessageBox.Show("Circle Area is " + result);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            r = Convert.ToDouble(textBox1.Text);
            result =2*pi * r;
            label2.Text = "çevre is " + result.ToString();
            MessageBox.Show("Circle Area is " + result);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
