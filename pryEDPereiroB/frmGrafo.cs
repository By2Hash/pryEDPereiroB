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
        public frmGrafo()
        {
            InitializeComponent();
        }


        private void frmGrafo_Load(object sender, EventArgs e)
        {
            cmbOrigen.SelectedIndex = 0;
            cmbDestino.SelectedIndex = 0;
            cmbCOrigen.SelectedIndex = 0;


        }
    }
}
