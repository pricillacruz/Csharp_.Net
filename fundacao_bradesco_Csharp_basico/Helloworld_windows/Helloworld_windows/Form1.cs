using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helloworld_windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //"Mensagem da Pri" - representa o titulo do box
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!", "Mensagem da Pri", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
