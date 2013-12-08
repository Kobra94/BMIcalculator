using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMIcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        double BMI;
        private void button1_Click(object sender, EventArgs e)
        {
            double visina,tezina;
            if(double.TryParse(textBox1.Text, out tezina)&&tezina>0)
            {if(double.TryParse(textBox2.Text,out visina)&&visina>0)
                {
                    BMI=tezina/Math.Pow(visina,2)*10000;
                    BMI=Math.Round(BMI,2);
                    textBox3.Text = Convert.ToString(BMI);
                }
            else { MessageBox.Show("Pogresno uneta visina!"); }
            }
            else { MessageBox.Show("Pogresno uneta tezina!"); }
           
            if (BMI <= 18.5)
            { label4.Text = "Jedite vise";
            label4.ForeColor = Color.Blue;
            }
            else if (BMI <= 24.9 && BMI > 18.5)
                { label4.Text = "Vas BMI je normalan";
                label4.ForeColor = Color.Green;
                }

            else if (BMI>24.9)
            {
                label4.Text = "Jedite manje";
                label4.ForeColor = Color.Red;
            }

	{
		 
	}
        }
    }
}
