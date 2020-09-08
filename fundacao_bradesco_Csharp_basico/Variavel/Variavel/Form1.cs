using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variavel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClique_Click(object sender, EventArgs e)
        {
            string nome;
            nome = "Seja Bem Vindo!";
            txtNome.Text = nome;
        }
    }
}
