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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }

        clsListaDoble ld = new clsListaDoble();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtCodigo.Text) &&
                !String.IsNullOrWhiteSpace(txtNombre.Text) &&
                !String.IsNullOrWhiteSpace(txtTramite.Text))
            { 
                clsNodos n = new clsNodos();
                n.Codigo = Convert.ToInt32(txtCodigo.Text);
                n.Nombre = txtNombre.Text;
                n.Tramite = txtTramite.Text;
                ld.Agregar(n);
                ld.Recorrer(lstListaDoble);
                ld.Recorrer(dgvListaDoble);
                ld.Recorrer(cmbCodigo);

                txtCodigo.Clear();
                txtNombre.Clear();
                txtTramite.Clear();

            }
            else 
            { 
                MessageBox.Show("Debe completar todos los campos");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbCodigo.SelectedItem != null)
            {
                Int32 codigo = Convert.ToInt32(cmbCodigo.SelectedItem);
                ld.Eliminar(codigo);
                ld.Recorrer(dgvListaDoble);
                ld.Recorrer(lstListaDoble);
                ld.Recorrer(cmbCodigo);

                
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un código");
            }

        }
    }
}
