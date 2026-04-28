using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDPereiroB
{
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }

        private void frmListaSimple_Load(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        clsListaSimple ls = new clsListaSimple();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCodigo.Text) && 
                !string.IsNullOrWhiteSpace(txtNombre.Text) &&
                !string.IsNullOrWhiteSpace(txtTramite.Text))
            {
                clsNodos n = new clsNodos();
                n.Codigo = Convert.ToInt32(txtCodigo.Text);
                n.Nombre = txtNombre.Text;
                n.Tramite = txtTramite.Text;
                ls.Agregar(n);
                ls.Recorrer(dgvListaSimple);
                ls.Recorrer(lstListaSimple);
                ls.Recorrer(cmbCodigo);

                txtCodigo.Clear();
                txtNombre.Clear();
                txtTramite.Clear();

            }
            else
            { 
                MessageBox.Show("Complete los campos");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbCodigo.SelectedItem != null)
            {
                Int32 codigo = Convert.ToInt32(cmbCodigo.SelectedItem);
                ls.Eliminar(codigo);

                ls.Recorrer(dgvListaSimple); 
                ls.Recorrer(lstListaSimple); 
                ls.Recorrer(cmbCodigo);

                MessageBox.Show("Elemento eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un código.");
            }
        }
    }
}
