using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conceito_Do_While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            //Declarando a variavel inicializada com 0
            int c = 0;

            //vai executar e verificar a condição depois
            do
            {
                c++;
                lblTest.Text = Convert.ToString(c);
                lblTest.Refresh();
            }
            while (c < 100);
        }
    }
}
