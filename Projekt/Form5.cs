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
    public partial class Form5 : Form
    {
        public double nigger(string input)
        {
            return Convert.ToDouble(input.Replace(".", ","));
        }
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
            {
                double R = nigger(textBox2.Text.ToString());
                double U = nigger(textBox3.Text.ToString());
                double I = U / R;

                textBox1.Text = I.ToString();
            }
            else if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text != "" && textBox4.Text != "")
            {
                double P = nigger(textBox4.Text.ToString());
                double U = nigger(textBox3.Text.ToString());
                double I = P / U;

                textBox1.Text = I.ToString();
            }
            else if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text != "" && textBox4.Text != "")
            {
                double P = nigger(textBox4.Text.ToString());
                double R = nigger(textBox2.Text.ToString());
                double A = P / R;
                double I = Math.Sqrt(A);

                textBox1.Text = I.ToString();
            }
            else
            {
                textBox1.Text = "brak danych";
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text == "" && textBox3.Text != "" && textBox4.Text == "")
            {
                double U = nigger(textBox3.Text.ToString());
                double I = nigger(textBox1.Text.ToString());
                double R = U / I;

                textBox2.Text = R.ToString();
            }
            else if (textBox1.Text != "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text != "")
            {
                double P = nigger(textBox4.Text.ToString());
                double I = nigger(textBox1.Text.ToString());
                double R = P / Math.Pow(I, 2);

                textBox2.Text = R.ToString();
            }
            else if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text != "" && textBox4.Text != "")
            {
                double P = nigger(textBox4.Text.ToString());
                double U = nigger(textBox3.Text.ToString());
                double R = Math.Pow(P, 2) / U;

                textBox2.Text = R.ToString();
            }
            else
            {
                textBox2.Text = "brak danych";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "" && textBox4.Text == "")
            {
                double I = nigger(textBox1.Text.ToString());
                double R = nigger(textBox2.Text.ToString());
                double U = I * R;

                textBox3.Text = U.ToString();
            }
            else if (textBox1.Text != "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text != "")
            {
                double P = nigger(textBox4.Text.ToString());
                double I = nigger(textBox1.Text.ToString());
                double U = P / I;

                textBox3.Text = U.ToString();
            }
            else if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text != "" && textBox4.Text != "")
            {
                double P = nigger(textBox4.Text.ToString());
                double R = nigger(textBox2.Text.ToString());
                double U = Math.Sqrt(P*R) ;

                textBox3.Text = U.ToString();
            }
            else
            {
                textBox3.Text = "brak danych";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "" && textBox4.Text == "")
            {
                double I = nigger(textBox1.Text.ToString());
                double R = nigger(textBox2.Text.ToString());
                double P = R* Math.Pow(I,2);

                textBox4.Text = P.ToString();
            }
            else if (textBox1.Text != "" && textBox2.Text == "" && textBox3.Text != "" && textBox4.Text == "")
            {
                double U = nigger(textBox3.Text.ToString());
                double I = nigger(textBox1.Text.ToString());
                double P = I*U;

                textBox4.Text = P.ToString();
            }
            else if (textBox1.Text == "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
            {
                double U = nigger(textBox3.Text.ToString());
                double R = nigger(textBox2.Text.ToString());
                double P = Math.Pow(U,2)/R;

                textBox4.Text = P.ToString();
            }
            else
            {
                textBox4.Text = "brak danych";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
