using System;
using System.Windows.Forms;

namespace pryEDPereiroB
{
    public partial class frmGrafo : Form
    {
        clsGrafo grafo = new clsGrafo();
        public frmGrafo()
        {
            InitializeComponent();
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            btnBorrar.Click += btnBorrar_Click;
            btnListarDestinos.Click += btnListarDestinos_Click;
            btnListarOrigenes.Click += btnListarOrigenes_Click;
            btnVerTodo.Click += btnVerTodo_Click;
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

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            grafo.BorrarTodo();
            grafo.MostrarTodo(dgvGrafo);
            lblCargaDatos.Text = "Todos los datos fueron borrados";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Int32 origen = cmbCOrigen.SelectedIndex;
            Int32 destino = cmbCDestino.SelectedIndex;
            Decimal precio = grafo.Consultar(destino, origen);
            if (precio > 0)
                label7.Text = "$ " + precio.ToString();
            else
                label7.Text = "Sin conexión";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Int32 origen = cmbCOrigen.SelectedIndex;
            Int32 destino = cmbCDestino.SelectedIndex;
            grafo.Eliminar(destino, origen);
            grafo.MostrarTodo(dgvGrafo);
            label7.Text = "Eliminado";
        }

        private void btnListarDestinos_Click(object sender, EventArgs e)
        {
            grafo.MostrarDestinos(cmbOrigenDesde.SelectedIndex, dgvGrafo);
        }

        private void btnListarOrigenes_Click(object sender, EventArgs e)
        {
            grafo.MostrarOrigenes(cmbDestinoHasta.SelectedIndex, dgvGrafo);
        }

        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            grafo.MostrarTodo(dgvGrafo);
        }
    }
}
