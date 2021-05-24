using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krzysiek
{
    public partial class Form1 : Form
    { 
        double K = 0.85;
        double M = 0.90;
        double wzr;
        double wynik;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wzr = Convert.ToDouble(textBox1.Text);
            if ((radioButton1.Checked == true) || (radioButton2.Checked == true))
            {
                if ((checkBox1.Checked == true) && (checkBox2.Checked == true))
                {
                    MessageBox.Show("Nie zaznaczaj 2 wag");
                }
                else if ((radioButton1.Checked == true) && (checkBox1.Checked == true))
                {
                    wynik = (wzr - 100);
                    label3.Text = Convert.ToString(wynik);
                }
                else if ((radioButton1.Checked == true) && (checkBox2.Checked == true))
                {
                    wynik = (wzr - 100) * K;
                    label3.Text = Convert.ToString(wynik);
                }
                else if ((radioButton2.Checked == true) && (checkBox1.Checked == true))
                {
                    wynik = (wzr - 100);
                    label3.Text = Convert.ToString(wynik);
                }
                else if ((radioButton2.Checked == true) && (checkBox2.Checked == true))
                {
                    wynik = (wzr - 100) * M;
                    label3.Text = Convert.ToString(wynik);
                }
            }
            else
            {
                MessageBox.Show("Zaznacz dane !");
            }

        }
    }
}
