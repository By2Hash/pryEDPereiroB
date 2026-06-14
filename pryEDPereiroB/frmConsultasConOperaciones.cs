using System;
using System.Windows.Forms;

namespace pryEDPereiroB
{
    public partial class frmConsultasConOperaciones : Form
    {
        private clsBaseDeDatos bd = new clsBaseDeDatos();
        private string[] consultas;

        public frmConsultasConOperaciones()
        {
            InitializeComponent();

            consultas = new string[]
            {
                "SELECT * FROM Autor",
                "SELECT * FROM Idioma",
                "SELECT * FROM Libro",
                "SELECT * FROM Pais",
                "SELECT Titulo, Precio FROM Libro WHERE Precio > 100",
                "SELECT L.Titulo, A.Nombre FROM Libro L INNER JOIN Autor A ON L.IdAutor = A.IdAutor",
                "SELECT COUNT(*) FROM Libro",
                "SELECT AVG(Precio) FROM Libro",
                "SELECT Nombre, COUNT(*) FROM Libro L INNER JOIN Autor A ON L.IdAutor = A.IdAutor GROUP BY A.Nombre"
            };

            string[] nombres = new string[]
            {
                "Todos los autores",
                "Todos los idiomas",
                "Todos los libros",
                "Todos los países",
                "Libros caros (>100)",
                "Libros con autor",
                "Cantidad de libros",
                "Precio promedio",
                "Libros por autor"
            };

            comboBox1.Items.Clear();
            for (int i = 0; i < nombres.Length; i++)
                comboBox1.Items.Add(nombres[i]);

            btnListar.Click += (s, e) =>
            {
                if (comboBox1.SelectedIndex < 0)
                {
                    lblMensaje.Text = "Seleccione una consulta.";
                    return;
                }
                lblMensaje.Text = "Ejecutando: " + consultas[comboBox1.SelectedIndex];
                bd.Listar(dgvOperaciones, consultas[comboBox1.SelectedIndex]);
            };
        }
    }
}
