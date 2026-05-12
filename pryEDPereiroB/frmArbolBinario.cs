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
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }

        clsArbolBinario arbol = new clsArbolBinario();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodos nuevo = new clsNodos();
            nuevo.Codigo = Convert.ToInt32(txtCodigo.Text);
            nuevo.Nombre = txtNombre.Text;
            nuevo.Tramite = txtTramite.Text;

            arbol.Agregar(nuevo);

            arbol.Recorrer(trvArbolBinario);

            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
            txtCodigo.Focus();
        }

        private void optInOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (optInOrden.Checked)
            {
                arbol.Recorrer(dgvArbolBinario, "InOrden");
            }

        }

        private void rdbPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (optPreOrden.Checked)
                arbol.Recorrer(dgvArbolBinario, "PreOrden");
        }

        private void rdbPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (optPostOrden.Checked)
                arbol.Recorrer(dgvArbolBinario, "PostOrden");
        }
    }
}
