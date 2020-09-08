using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculos_basicos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtResultado.Text = ""; 
        }
     
        private void btnSomar_Click(object sender, EventArgs e)
        {
            //declarando as variaveis;
            double num1, num2, resultado;
            
            //colocando nas variaveis o que será digitado dentro das caixinhas de texto;
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            //Fazendo a soma;
            resultado = num1 + num2;

            //Colocando o resultado da variavel para mostrar para o usuario e convertido em numero;
            txtResultado.Text = resultado.ToString();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            //declarando as variaveis;
            double num1, num2, resultado;

            //colocando nas variaveis o que será digitado dentro das caixinhas de texto;
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            //Fazendo a soma;
            resultado = num1 - num2;

            //Colocando o resultado da variavel para mostrar para o usuario e convertido em numero;
            txtResultado.Text = resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            //declarando as variaveis;
            double num1, num2, resultado;

            //colocando nas variaveis o que será digitado dentro das caixinhas de texto;
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            //Fazendo a soma;
            resultado = num1 * num2;

            //Colocando o resultado da variavel para mostrar para o usuario e convertido em numero;
            txtResultado.Text = resultado.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            //declarando as variaveis;
            double num1, num2, resultado;

            //colocando nas variaveis o que será digitado dentro das caixinhas de texto;
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            //Fazendo a soma;
            resultado = num1 / num2;

            //Colocando o resultado da variavel para mostrar para o usuario e convertido em numero;
            txtResultado.Text = resultado.ToString();
        }
    }
}
