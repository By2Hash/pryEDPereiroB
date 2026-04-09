using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDPereiroB
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivoTexto objCliente = new clsArchivoTexto();
            objCliente.NombreArchivo = "Cliente.CSV";
            objCliente.Guardar(txtCodigo.Text, txtNombre.Text, txtDeuda.Text);
            objCliente.Recorrer(dgvClientes);

            txtCodigo.Clear();
            txtDeuda.Clear();
            txtNombre.Clear();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            clsArchivoTexto x = new clsArchivoTexto();
            x.NombreArchivo = "Cliente.CSV";
            if (File.Exists(x.NombreArchivo)) x.Recorrer(dgvClientes) ;
        }
    }
}
