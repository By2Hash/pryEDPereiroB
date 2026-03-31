using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDPereiroB
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void consultaDeUnaTablaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void coloresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void desarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosDesarrolador desarrolador = new frmDatosDesarrolador();
            desarrolador.ShowDialog();
        }
    }
}
