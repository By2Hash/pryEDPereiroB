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

    //Pre-Orden (R-I-D): Muestra primero la raíz. El resultado sería: 10, 5, 15.

    //In-Orden(I-R-D) : Muestra la raíz en el medio.El resultado sería: 5, 10, 15 (¡Ordenados!).

    //Post-Orden(I-D-R) : Muestra la raíz al final.El resultado sería: 5, 15, 10.
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }

        clsArbolBinario arbol = new clsArbolBinario();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodos nuevo = new clsNodos();
            nuevo.Codigo = Convert.ToInt32(txtCodigo.Text);
            nuevo.Nombre = txtNombre.Text;
            nuevo.Tramite = txtTramite.Text;

            arbol.Agregar(nuevo);
            arbol.Recorrer(trvArbolBinario);
            CargarComboBox();  // <-- agregar esta línea

            if (optInOrden.Checked) arbol.Recorrer(dgvArbolBinario, "InOrden");
            else if (optPreOrden.Checked) arbol.Recorrer(dgvArbolBinario, "PreOrden");
            else if (optPostOrden.Checked) arbol.Recorrer(dgvArbolBinario, "PostOrden");

            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
            txtCodigo.Focus();
        }

        private void optInOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (optInOrden.Checked)
            {
                arbol.Recorrer(dgvArbolBinario, "InOrden");
                //In - Orden(Izquierda $\rightarrow$ Raíz $\rightarrow$ Derecha)
            }
        }

        private void rdbPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            // Pre-Orden (Raíz $\rightarrow$ Izquierda $\rightarrow$ Derecha)
            if (optPreOrden.Checked)
            {
                arbol.Recorrer(dgvArbolBinario, "PreOrden");
            }
        }

        private void rdbPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            // Post-Orden (Izquierda $\rightarrow$ Derecha $\rightarrow$ Raíz)
            if (optPostOrden.Checked)
            {
                arbol.Recorrer(dgvArbolBinario, "PostOrden");
            }
        }

        private void frmArbolBinario_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void optInOrden_CheckedChanged_1(object sender, EventArgs e)
        {
            if (optInOrden.Checked)
                arbol.Recorrer(dgvArbolBinario, "InOrden");
        }

        private void optPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (optPreOrden.Checked)
                arbol.Recorrer(dgvArbolBinario, "PreOrden");
        }

        private void optPostOrden_CheckedChanged(object sender, EventArgs e)
        {
             if (optPostOrden.Checked)
        arbol.Recorrer(dgvArbolBinario, "PostOrden");
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            if (arbol.Raiz == null)
            {
                MessageBox.Show("El arbol está vacó.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            arbol.Equilibrar();
            arbol.Recorrer(trvArbolBinario);

            if (optInOrden.Checked) arbol.Recorrer(dgvArbolBinario, "InOrden");
            else if (optPreOrden.Checked) arbol.Recorrer(dgvArbolBinario, "PreOrden");
            else if (optPostOrden.Checked) arbol.Recorrer(dgvArbolBinario, "PostOrden");

            MessageBox.Show("Árbol equilibrado correctamente.", "Equilibrar",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CargarComboBox()
        {
            cmbCodigo.Items.Clear();
            CargarCodigos(arbol.Raiz);
        }

        private void CargarCodigos(clsNodos nodo)
        {
            if (nodo == null) return;
            CargarCodigos(nodo.Anterior);
            cmbCodigo.Items.Add(nodo.Codigo);
            CargarCodigos(nodo.Siguiente);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbCodigo.SelectedItem == null)
            {
                MessageBox.Show("Seleccioná un código para eliminar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int codigo = Convert.ToInt32(cmbCodigo.SelectedItem);

            DialogResult confirm = MessageBox.Show(
                $"¿Eliminar el nodo con código {codigo}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            bool eliminado = arbol.Eliminar(codigo);

            if (eliminado)
            {
                arbol.Recorrer(trvArbolBinario);
                CargarComboBox();

                if (optInOrden.Checked) arbol.Recorrer(dgvArbolBinario, "InOrden");
                else if (optPreOrden.Checked) arbol.Recorrer(dgvArbolBinario, "PreOrden");
                else if (optPostOrden.Checked) arbol.Recorrer(dgvArbolBinario, "PostOrden");

                MessageBox.Show($"Nodo {codigo} eliminado correctamente.", "Eliminado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"No se encontró el nodo {codigo}.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
