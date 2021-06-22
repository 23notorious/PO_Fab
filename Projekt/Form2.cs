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
    public partial class Form2 : Form
    {

        private Color[] Pasek12 = {Color.Black, Color.SaddleBrown, Color.Red,
                                    Color.DarkOrange, Color.Yellow, Color.Green,
                                        Color.Blue, Color.Purple, Color.Gray, Color.White };

        private Color[] Pasek3 = {Color.Black, Color.Brown, Color.Red,
                                    Color.DarkOrange, Color.Yellow, Color.Green,
                                        Color.Blue, Color.Purple, Color.Gray, 
                                            Color.Gold, Color.Silver};

        private Color[] Pasek4 = {Color.Brown, Color.Red, Color.Green,
                                        Color.Blue, Color.Purple, Color.Gray,
                                            Color.Gold, Color.Silver};

        private int[] cyfry = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        private double[] mnoznik = {1, 10, 100, 1000, 10000, 100000, 1000000, 10000000, 1, 0.1, 0.01};

        private void updateV()
        {
            if (comboBox1.SelectedIndex >= 0 &&
                comboBox2.SelectedIndex >= 0 &&
                comboBox3.SelectedIndex >= 0 &&
                comboBox4.SelectedIndex >= 0)
            {
                double value = 0;
                value = cyfry[comboBox1.SelectedIndex] * 10 + cyfry[comboBox2.SelectedIndex];
                value *= mnoznik[comboBox3.SelectedIndex]; 

                textBox1.Text = value.ToString("N2");
            }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.BackColor = Pasek12[comboBox1.SelectedIndex];
            updateV();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.BackColor = Pasek12[comboBox2.SelectedIndex];
            updateV();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.BackColor = Pasek3[comboBox3.SelectedIndex];
            updateV();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.BackColor = Pasek4[comboBox4.SelectedIndex];
            updateV();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
