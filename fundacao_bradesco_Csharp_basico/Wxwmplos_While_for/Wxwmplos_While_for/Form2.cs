using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wxwmplos_While_for
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int i;
            i = 2016;

            while (i >= 1950)
            {
                cboAno2.Items.Add(i);
                i--;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 novo = new Form1();
            novo.Show();
            this.Visible = false;
        }
    }
}
