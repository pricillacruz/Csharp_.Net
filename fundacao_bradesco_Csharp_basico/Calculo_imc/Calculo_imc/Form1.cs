using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declarando variaveis
            double peso, altura, imc;
            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);
            imc = peso / (altura * altura);

            //mostrando resultado na tela
            txtResultado.Text = imc.ToString("0.00");

            //condições de acordo com os resultados
            if (imc < 18.49)
                MessageBox.Show("Abaixo do peso!", "Calculo IMC", MessageBoxButtons.OK);
            else if (imc < 24.99)
                MessageBox.Show("Peso normal!", "Calculo IMC", MessageBoxButtons.OK);
            else if (imc < 29.99)
                MessageBox.Show("Acima do peso!", "Calculo IMC", MessageBoxButtons.OK);
            else if (imc < 34.99)
                MessageBox.Show("Obesidade Grau I!", "Calculo IMC", MessageBoxButtons.OK);
            else if (imc < 39.99)
                MessageBox.Show("Obesidade Grau II!", "Calculo IMC", MessageBoxButtons.OK);
            else
                MessageBox.Show("Obesidade Grau III!", "Calculo IMC", MessageBoxButtons.OK);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPeso.Text = "";
            txtAltura.Text = "";
            txtResultado.Text = "0.00";
        }
    }
}
