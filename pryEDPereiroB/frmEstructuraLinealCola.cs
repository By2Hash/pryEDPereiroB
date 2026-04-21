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
    public partial class frmEstructuraLinealCola : Form
    {
        public frmEstructuraLinealCola()
        {
            InitializeComponent();
        }

        private void pnlEliminado_Paint(object sender, PaintEventArgs e)
        {

        }

        clsCola fila = new clsCola();
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
                fila.Agregar(n);
                fila.Recorrer(dgvCola);
                fila.Recorrer(lstCola);

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
            if (fila.Primero != null)
            {
                lblCodEliminado.Text = fila.Primero.Codigo.ToString();
                lblNomEliminado.Text = fila.Primero.Nombre;
                lblTraEliminado.Text = fila.Primero.Tramite;
                fila.Eliminar();
                fila.Recorrer(dgvCola);
                fila.Recorrer(lstCola);
                fila.Recorrer();
            }
            else
            { 
                lblTraEliminado.Text = "";
                lblNomEliminado.Text = "";  
                lblCodEliminado.Text = "";
            }
        }
    }
}
