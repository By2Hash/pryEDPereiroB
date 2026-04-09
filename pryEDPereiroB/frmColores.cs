using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDPereiroB
{
    public partial class frmColores : Form
    {
        public frmColores()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtColores.Text))
            {
                MessageBox.Show("Ingrese un color, daltonico","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                clsArchivoTexto x = new clsArchivoTexto();
                x.NombreArchivo = "Colores.txt";
                x.Guardar(txtColores.Text);

                txtColores.Clear();
                lstColores.Items.Clear();
                lstColores.Items.AddRange(File.ReadAllLines("Colores.txt"));

            }



            
        }

        private void frmColores_Load(object sender, EventArgs e)
        {

        }

        
    }
}
