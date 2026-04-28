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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }


        clsPila pila = new clsPila();
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
                pila.Agregar(n);
                pila.Recorrer(dgvPila);
                pila.Recorrer(lstPila);

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
            if (pila.Primero != null)
            {
                lblCodEliminado.Text = pila.Primero.Codigo.ToString();
                lblNomEliminado.Text = pila.Primero.Nombre;
                lblTraEliminado.Text = pila.Primero.Tramite;
                pila.Eliminar();
                pila.Recorrer(dgvPila);
                pila.Recorrer(lstPila);
                pila.Recorrer();
            }
            else
            {
                lblTraEliminado.Text = "";
                lblNomEliminado.Text = "";
                lblCodEliminado.Text = "";
            }
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
    }
}
