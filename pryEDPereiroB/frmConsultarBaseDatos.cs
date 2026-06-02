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
    public partial class frmConsultarSQL : Form
    {
        public frmConsultarSQL()
        {
            InitializeComponent();
        }

        clsBaseDeDatos db = new clsBaseDeDatos();
        private void frmConsultarSQL_Load(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {

            string baseDeDatos = txtBaseDeDatos.Text.Trim();
            db.Listar(dgvConsultarBaseDeDatos, baseDeDatos);

        }
    }
}
