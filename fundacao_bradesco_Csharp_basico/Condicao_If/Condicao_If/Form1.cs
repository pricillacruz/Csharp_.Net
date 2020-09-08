using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condicao_If
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idade;
            idade = Convert.ToInt32(txtIdade.Text);
            if (idade < 18)
                MessageBox.Show("Você ainda é menor de idade", "Mensagem");
            else
                MessageBox.Show("Você já é maior de idade", "Mensagem");
        }
    }
}
