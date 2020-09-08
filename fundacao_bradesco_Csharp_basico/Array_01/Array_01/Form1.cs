using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declarar e instanciar vetor
            int[] vetor = new int[4];

            //Atribuição de valores de acordo com cada indice
            vetor[0] = 7;
            vetor[1] = 3;
            vetor[2] = 5;
            vetor[3] = 1;

            //Declara variavel "valor" para acessar vetor
            int valor = vetor[1];

            //Ordena o vetor
            System.Array.Sort(vetor);

            //Percorre o vetor em cada indice
            for (int i = 0; i < 4; i++)
                MessageBox.Show(vetor[i].ToString(), "Array");
        }

        private void btnVetorTextos_Click(object sender, EventArgs e)
        {
            //Declarar e instanciar vetor
            string[] semana = new string[7];

            //Atribuição de valores de acordo com cada indice
            semana[0] = "Domingo";
            semana[1] = "Segunda";
            semana[2] = "Terça";
            semana[3] = "Quarta";
            semana[4] = "Quinta";
            semana[5] = "Sexta";
            semana[6] = "Sábado";

            string valor = semana[1];
            for (int i = 0; i < 7; i++)
                MessageBox.Show(semana[i].ToString(), "Array");
        }
    }
}
