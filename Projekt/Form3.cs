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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Uwy;

            double R1 = Convert.ToDouble(textBox1.Text);
            double R2 = Convert.ToDouble(textBox2.Text);
            double Uwe = Convert.ToDouble(textBox3.Text);
            Uwy = (Uwe * R2) / (R1 + R2);
            textBox4.Text = Uwy.ToString("N2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double Uwe;

            double R1 = Convert.ToDouble(textBox1.Text);
            double R2 = Convert.ToDouble(textBox2.Text);
            double Uwy = Convert.ToDouble(textBox4.Text);
            Uwe = (Uwy * (R1+R2)) / R2;
            textBox3.Text = Uwe.ToString("N2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double R1;

            double Uwe = Convert.ToDouble(textBox3.Text);
            double R2 = Convert.ToDouble(textBox2.Text);
            double Uwy = Convert.ToDouble(textBox4.Text);
            R1 = ((Uwe * R2)) / Uwy;
            textBox1.Text = R1.ToString("N2");
        }
    }
}
