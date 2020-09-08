using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While_Com_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            //Declarando e inicializando a variavel com 1;
            int numero = 1;

            //Equanto a variavel numero for menor ou igual a 10 
            //o listBox será preenchido

            while (numero <= 10)
            {
                listBox.Items.Add(numero);
                numero++;
            }
        }
    }
}
