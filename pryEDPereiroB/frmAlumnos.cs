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
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCarrera.Text))
            {
                MessageBox.Show("No se puede grabar. Por favor, complete todos los campos. ", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                clsArchivoTexto objAlumno = new clsArchivoTexto();
                objAlumno.NombreArchivo = "Alumno.CSV";
                objAlumno.Guardar(txtCodigo.Text, txtNombre.Text, txtCarrera.Text);
                objAlumno.Recorrer(dgvAlumnos);

                txtCodigo.Clear();
                txtCarrera.Clear();
                txtNombre.Clear();
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
