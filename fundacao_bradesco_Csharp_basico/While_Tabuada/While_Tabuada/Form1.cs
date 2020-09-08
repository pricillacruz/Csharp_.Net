using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While_Tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declarando as variaveis do tipo int; 
            //Inicializando i com 1;
            //E convertendo o numero para int;
            int numero, resultado, i;
            i = 1;
            numero = int.Parse(txtNumero.Text);

            //Enquanto i for menor ou igual a 10, faça a condição
            while (i <= 10)
            {
                resultado = i * numero;
                lstTabuada.Items.Add(String.Concat(numero, "*", i, "=", resultado));
                i++;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            lstTabuada.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
