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
    public partial class frmMeses : Form
    {
        public frmMeses()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtMeses.Text))
            {
                MessageBox.Show("Ingrese un mes", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                clsArchivoTexto x = new clsArchivoTexto();
                x.NombreArchivo = "Meses.txt";
                x.Guardar(txtMeses.Text);

                txtMeses.Clear();
                lstMeses.Items.Clear();
                lstMeses.Items.AddRange(File.ReadAllLines("Meses.txt"));
            }
        }

      
    }
}
