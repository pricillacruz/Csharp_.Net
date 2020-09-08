using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_For
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTesteFor_Click(object sender, EventArgs e)
        {
            //Para criar a estrutura do for de forma rapida utilizamos o Snippet
            //clique com botao direito no espaço em branco
            //clique em Snippet > inserir snippet > visual C# > for

            for (int i = 0; i < 50; i++)
            {
                //MessageBox.Show("O valor do i é: " + i);
                Console.WriteLine("O valor do i é: " + i);
            }
        }
    }
}
