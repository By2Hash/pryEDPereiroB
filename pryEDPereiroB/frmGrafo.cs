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
    
    public partial class frmGrafo : Form
    {
        clsGrafo grafo = new clsGrafo();
        public frmGrafo()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void frmGrafo_Load(object sender, EventArgs e)
        {
            grafo.MostrarCiudades(cmbOrigen);
            grafo.MostrarCiudades(cmbOrigenDesde);
            grafo.MostrarCiudades(cmbCOrigen);
            grafo.MostrarCiudades(cmbDestino);
            grafo.MostrarCiudades(cmbDestinoHasta);
            grafo.MostrarCiudades(cmbCDestino);
            grafo.MostrarTodo(dgvGrafo);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Int32 f = cmbOrigen.SelectedIndex;
            Int32 c = cmbDestino.SelectedIndex;
            Int32 p = Convert.ToInt32(txtPrecio.Text);
            grafo.Agregar(c, f, p);
            grafo.MostrarTodo(dgvGrafo);
            lblCargaDatos.Text = "Datos cargados correctamente";
            txtPrecio.Clear();

        }

        private void pnlConsultarDatos_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
