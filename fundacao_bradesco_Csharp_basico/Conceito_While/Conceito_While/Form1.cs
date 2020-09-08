using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conceito_While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            //Declarando e inicializando com zero a variavel:
            int c = 0;

            //Criando repetição: enquanto a varialve c for menor que 10000 
            //será executado o laço de repetição
            while (c< 10000)
            {
                c++;
                lblNumero.Text = Convert.ToString(c);
                //Refresh é utilizado para que haja a varição dos números
                lblNumero.Refresh();
            }
        }
    }
}
