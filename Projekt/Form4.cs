using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Form4 : Form
    {
        public double nigger(string input)
        {
            return Convert.ToDouble(input.Replace(".", ","));
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            double R1 = nigger(textBox3.Text.ToString());
            double R2 = nigger(textBox2.Text.ToString());
            double Iwe = nigger(textBox1.Text.ToString());

            double IR1 = Iwe * (R2 / (R1 + R2));
            textBox4.Text = IR1.ToString("N2");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double IR1 = nigger(textBox4.Text.ToString());
            double R2 = nigger(textBox2.Text.ToString());
            double Iwe = nigger(textBox1.Text.ToString());

            double R1 = (Iwe * R2) / IR1 - R2;

            textBox4.Text = R1.ToString("N2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double R2 = nigger(textBox2.Text.ToString());
            double IR1 = nigger(textBox4.Text.ToString());
            double R1 = nigger(textBox3.Text.ToString());

            double Iwe = IR1 * (R1 + R2) / R2;
            textBox1.Text = Iwe.ToString("N2");
        }
       
    }
}
