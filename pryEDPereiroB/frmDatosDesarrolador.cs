using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace pryEDPereiroB
{
    public partial class frmDatosDesarrolador : Form
    {
        public frmDatosDesarrolador()
        {
            InitializeComponent();
        }

        private void frmDatosDesarrolador_Load(object sender, EventArgs e)
        {

        }

        private void llblGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llblGitHub.LinkVisited = true;
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/By2Hash?tab=repositories",
                UseShellExecute = true
            });
        }
    }
}
