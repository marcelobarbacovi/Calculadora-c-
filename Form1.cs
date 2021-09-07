using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        string operador = "";
        decimal valor1 = 0, valor2 = 0;


        public Form1()
        {
            InitializeComponent();
        }



        private void textResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textResultado.Text = textResultado.Text + b.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textResultado.Text = textResultado.Text + b.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textResultado.Text = textResultado.Text + b.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textResultado.Text = textResultado.Text + b.Text;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToInt32(textResultado.Text);
            if (operador == "soma")
            {
                textResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operador == "diminui")

            {
                textResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operador == "diminui")
            {
                textResultado.Text = Convert.ToString(valor1 - valor2);
            }

            else if (operador == "multiplica")
            {

                textResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operador == "divide")
            {
                textResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }
            private void btnDiminuir_Click(object sender, EventArgs e)
           
            {
                valor1 = Convert.ToInt32(textResultado.Text);
                textResultado.Text = "";
                operador = "diminui";
                label1.Text = "-";
            }
        
            private void btnDividir_Click(object sender, EventArgs e)
            {
                valor1 = Convert.ToInt32(textResultado.Text);
                textResultado.Text = "";
                operador = "divide";
                label1.Text = "/";
            }

            private void btnMultiplicar_Click(object sender, EventArgs e)
            {
                valor1 = Convert.ToInt32(textResultado.Text);
                textResultado.Text = "";
                operador = "multiplica";
                label1.Text = "*";
            }

            private void btnSomar_Click(object sender, EventArgs e)
            {
                valor1 = Convert.ToInt32(textResultado.Text);
                textResultado.Text = "";
                operador = "soma";
                label1.Text = "+";


            }
        }
 }



