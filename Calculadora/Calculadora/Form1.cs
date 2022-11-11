using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        //Declaração de variavies
        double valor1;
        double valor2;
        double total;
        int factorial = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(textv1.Text);
            valor2 = double.Parse(texv2.Text);

            total = valor1 + valor2;

            textv3.Text = total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(textv1.Text);
            valor2 = double.Parse(texv2.Text);

            total = valor1 - valor2;

            textv3.Text = total.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(textv1.Text);
            valor2 = double.Parse(texv2.Text);

            total = valor1 * valor2;

            textv3.Text = total.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(textv1.Text);
            valor2 = double.Parse(texv2.Text);

            total = valor1 / valor2;

            textv3.Text = total.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int fact = 1;
            factorial = int.Parse(textBox4.Text);

            for (int i = factorial; i > 0; i--)

            {

                fact = fact * i;

            }

            textv3.Text = fact.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double exp;
            double exp1;

            exp = double.Parse(tex1.Text);
            exp1 = double.Parse(tex2.Text);

            double result = Math.Pow(exp, exp1);

            textv3.Text = result.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int num;
            num = int.Parse(textconverter.Text);


        }

        private void buttonbin_Click(object sender, EventArgs e)
        {
            int num2;
            num2 = int.Parse(textconverter.Text);


        }
    }
}
