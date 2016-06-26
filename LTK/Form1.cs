using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTK
{
    public partial class frmLtk : Form
    {
        public frmLtk()
        {
            InitializeComponent();
        }

        //private frmGerador_Aleatorio fGerador_Aleatorio = null;

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGerador_Aleatorio_Click(object sender, EventArgs e)
        {
            frmGerador_Aleatorio fGerador_Aleatorio = new frmGerador_Aleatorio();
            fGerador_Aleatorio.ShowDialog(this);
        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
