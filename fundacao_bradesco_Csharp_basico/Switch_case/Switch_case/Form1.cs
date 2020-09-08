using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboSemana.Text)
            {
                case "Domingo":
                    MessageBox.Show("Oba, você escolheu domingo!", "Mensagem", MessageBoxButtons.OK);
                    break;

                case "Segunda":
                    MessageBox.Show("Você escolheu Segunda que é o 2º dia da semana, sabia?", "Mensagem", MessageBoxButtons.OK);
                    break;

                case "Terça":
                    MessageBox.Show("Terça é uma ótima escolha!", "Mensagem", MessageBoxButtons.OK);
                    break;

                case "Quarta":
                    MessageBox.Show("Quarta, seria o meio da semana a sua escolha?", "Mensagem", MessageBoxButtons.OK);
                    break;

                case "Quinta":
                    MessageBox.Show("Quinta, boa escolha!", "Mensagem", MessageBoxButtons.OK);
                    break;

                case "Sexta":
                    MessageBox.Show("Finalmente sexta, escolheu super bem!", "Mensagem", MessageBoxButtons.OK);
                    break;

                case "Sábado":
                    MessageBox.Show("Que sabado lindo, mandou super bem!", "Mensagem", MessageBoxButtons.OK);
                    break;
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Instanciando o objeto do novo tipo de forms:
            Form2 novo = new Form2();

            //chamando o novo objeto instanciado anteriormente logo abaixo:
            novo.Show();

            //fechando o Form 1 atualmente aberto
            this.Visible = false;
        }
    }
}
