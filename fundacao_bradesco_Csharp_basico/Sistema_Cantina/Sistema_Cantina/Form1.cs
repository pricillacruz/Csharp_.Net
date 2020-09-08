using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Cantina
{
    public partial class Form1 : Form
    {
        /*
        Declaração de 3 arrays para armazenar 6 produtos,
        e seus respectivos códigos e valores.
        */
        string[] produtos = new string[6];
        string[] codigo = new string[6];
        double[] valor = new double[6];
        double soma;


        public Form1()
        {
            InitializeComponent();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            {
                /*
                inicia com uma condição, se o usuário digitar um código com 3 caracteres (length), esse
               código é adicionado ao listBox.
                A propriedade length retorna a quantidade de caracteres.
                */
                if (txtCodigo.Text.Length == 3)
                {
                    //Faça enquanto o prod for menor ou igual a qtd de itens do array
                    int indice = 0;
                    for (int prod = 1; prod < codigo.Length; prod++)
                    {
                        //condição, se foi encontrado o produto ele retorna as infs de acordo com o indice;
                        if (txtCodigo.Text == codigo[prod])
                        {
                            indice = prod;
                        }
                    }
                    // caso não encontre, aparecerá a msg abaixo;
                    if (indice == 0)
                    {
                        MessageBox.Show("Produto não encontrado");
                    }
                    else
                    {
                        //conteudo adc no listBox concatena as infs (codigo, nome e valor)
                        lstCaixa.Items.Add(txtCodigo.Text + " -- " + produtos[indice] + " -- R$ " + valor[indice]);

                        soma = soma + valor[indice];
                        label3.Text = ("Valor total R$ " + soma);

                        //localização das imagens
                        picImagem.ImageLocation = "C:/imagem" + codigo[indice] + ".jpg";

                        //txtBom será limpo e o focus posiciona o cursor para o textBom para uma nova digitação
                        txtCodigo.Text = "";
                        txtCodigo.Focus();
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*Ao entrar no Form Load será chamado o método*/
            carregarArray();
            soma = 0;
        }

            private void carregarArray()
            /*Criação do Método para ser chamado quando necessário, isso evita repetir
            várias vezes o mesmo código*/
            {
                codigo[1] = "001";
                codigo[2] = "002";
                codigo[3] = "003";
                codigo[4] = "004";
                codigo[5] = "005";

                produtos[1] = "Pastel";
                produtos[2] = "Coxinha";
                produtos[3] = "Hot_Dog";
                produtos[4] = "Chocolate";
                produtos[5] = "Suco";

                valor[1] = 6.00;
                valor[2] = 5.00;
                valor[3] = 12.00;
                valor[4] = 3.50;
                valor[5] = 8.00;

                /*Códigos, Produtos e Valores ref. os arrays que foram declarados*/
            }
    }
}
