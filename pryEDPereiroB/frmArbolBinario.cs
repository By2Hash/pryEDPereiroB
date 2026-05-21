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

            // Esto hace que la grilla se dibuje inmediatamente al agregar el nodo
            if (optInOrden.Checked) arbol.Recorrer(dgvArbolBinario, "InOrden");
            else if (optPreOrden.Checked) arbol.Recorrer(dgvArbolBinario, "PreOrden");
            else if (optPostOrden.Checked) arbol.Recorrer(dgvArbolBinario, "PostOrden");

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
            // Corregido: cambié optPreOrden por rdbPreOrden para que coincida con el control
            if (optPreOrden.Checked)
            {
                arbol.Recorrer(dgvArbolBinario, "PreOrden");
            }
        }

        private void rdbPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            // Corregido: cambié optPostOrden por rdbPostOrden
            if (optPostOrden.Checked)
            {
                arbol.Recorrer(dgvArbolBinario, "PostOrden");
            }
        }

        private void frmArbolBinario_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void optInOrden_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void optPreOrden_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void optPostOrden_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
