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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i;
            for (i = 2016; i >= 1950; i--)
            {
                cboAno.Items.Add(i);
            }
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            Form2 novo = new Form2();
            novo.Show();
            this.Visible = false;
        }
    }
}
