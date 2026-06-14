using System;
using System.Windows.Forms;

namespace pryEDPereiroB
{
    public partial class frmOperaciones : Form
    {
        private clsBaseDeDatos bd = new clsBaseDeDatos();

        public frmOperaciones()
        {
            InitializeComponent();

            btnProyeccionSimple.Click += (s, e) => bd.Listar(dgvDB, "SELECT Titulo FROM Libro");
            btnProyecciónMulti.Click += (s, e) => bd.Listar(dgvDB, "SELECT Titulo, Precio, Cantidad FROM Libro");
            btnJuntar.Click += (s, e) => bd.Listar(dgvDB,
                "SELECT Libro.Titulo, Autor.Nombre FROM Libro INNER JOIN Autor ON Libro.IdAutor = Autor.IdAutor");
            btnSellecionSimple.Click += (s, e) => bd.Listar(dgvDB, "SELECT * FROM Libro WHERE Precio > 100");
            lblSeleccionMultiatributo.Click += (s, e) => bd.Listar(dgvDB,
                "SELECT * FROM Libro WHERE Precio > 50 AND Cantidad > 0");
            btnSeleccionConvolucion.Click += (s, e) => bd.Listar(dgvDB,
                "SELECT * FROM Libro WHERE IdAutor IN (SELECT IdAutor FROM Autor WHERE Nombre LIKE 'J%')");
            btnUnion.Click += (s, e) => bd.Listar(dgvDB,
                "SELECT Titulo FROM Libro WHERE Precio < 50 UNION SELECT Titulo FROM Libro WHERE Precio > 200");
            btnIntersección.Click += (s, e) => bd.Listar(dgvDB,
                "SELECT L.Titulo FROM Libro L INNER JOIN Autor A ON L.IdAutor = A.IdAutor WHERE A.Nombre LIKE 'G%'");
            btnDiferencia.Click += (s, e) => bd.Listar(dgvDB,
                "SELECT Titulo FROM Libro WHERE IdIdioma = 1 AND IdLibro NOT IN (SELECT IdLibro FROM Libro WHERE IdIdioma = 2)");
        }
    }
}
