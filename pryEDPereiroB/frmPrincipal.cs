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

        private void coloresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmColores colores = new frmColores();
            colores.ShowDialog();
        }

        private void mesesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMeses meses = new frmMeses();    
            meses.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            clientes.ShowDialog();
        }

        private void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstructuraLinealCola cola = new frmEstructuraLinealCola();
            cola.ShowDialog();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos alumnos = new frmAlumnos();
            alumnos.ShowDialog();
        }
    }
}
