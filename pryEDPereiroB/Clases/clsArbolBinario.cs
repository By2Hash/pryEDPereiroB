using System;
using System.IO;
using System.Windows.Forms;

namespace pryEDPereiroB
{
    internal class clsArbolBinario
    {
        private clsNodos raiz;

        public clsNodos Raiz
        {
            get { return raiz; }
            set { raiz = value; }
        }

        // ─── AGREGAR (árbol binario de búsqueda por Codigo) ───────────────────
        public void Agregar(clsNodos Nuevo)
        {
            if (raiz == null)
            {
                raiz = Nuevo;
            }
            else
            {
                clsNodos Ant = raiz;
                clsNodos Aux = raiz;
                while (Aux != null)
                {
                    Ant = Aux;
                    if (Nuevo.Codigo < Aux.Codigo)
                        Aux = Aux.Anterior;  // Hacia la izquierda
                    else
                        Aux = Aux.Siguiente; // Hacia la derecha
                }
                if (Nuevo.Codigo < Ant.Codigo)
                    Ant.Anterior = Nuevo;
                else
                    Ant.Siguiente = Nuevo;
            }
        }

       

        // ─── BUSCAR ───────────────────────────────────────────────────────────
        public clsNodos Buscar(int codigoBuscado)
        {
            return BuscarRecursivo(raiz, codigoBuscado);
        }

        private clsNodos BuscarRecursivo(clsNodos actual, int codigoBuscado)
        {
            if (actual == null)
                return null;

            if (codigoBuscado == actual.Codigo)
                return actual;
            else if (codigoBuscado < actual.Codigo)
                return BuscarRecursivo(actual.Anterior, codigoBuscado);
            else
                return BuscarRecursivo(actual.Siguiente, codigoBuscado);
        }

        // ─── RECORRIDOS A ARCHIVO (como clsPila) ──────────────────────────────
        public void Recorrer()
        {
            StreamWriter sw = new StreamWriter("Arbol.txt");
            RecorrerInOrden(raiz, sw);
            sw.Close();
        }

        private void RecorrerInOrden(clsNodos actual, StreamWriter sw)
        {
            if (actual == null) return;

            RecorrerInOrden(actual.Anterior, sw);   // Izquierda
            sw.WriteLine("Codigo: " + actual.Codigo);
            sw.WriteLine("Nombre: " + actual.Nombre);
            sw.WriteLine("Tramite: " + actual.Tramite);
            sw.WriteLine("");
            RecorrerInOrden(actual.Siguiente, sw);  // Derecha
        }

        // ─── RECORRER → DataGridView ──────────────────────────────────────────
        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            RecorrerGrilla(raiz, Grilla);
        }

        private void RecorrerGrilla(clsNodos actual, DataGridView Grilla)
        {
            if (actual == null) return;

            RecorrerGrilla(actual.Anterior, Grilla);
            Grilla.Rows.Add(actual.Codigo, actual.Nombre, actual.Tramite);
            RecorrerGrilla(actual.Siguiente, Grilla);
        }

        // ─── RECORRER → TreeView (estructura visual del árbol) ────────────────
        public void Recorrer(TreeView arbol)
        {
            arbol.Nodes.Clear();

            if (raiz == null) return;

            TreeNode nodoRaiz = new TreeNode("Raíz: " + raiz.Codigo + " - " + raiz.Nombre);
            arbol.Nodes.Add(nodoRaiz);

            RecorrerTreeView(raiz, nodoRaiz);

            arbol.ExpandAll();
        }

        public void Recorrer(DataGridView grilla, String modo)
        {
            grilla.Rows.Clear();
            switch (modo)
            { 
                case "InOrden":
                    RecorrerGrilla(raiz, grilla);
                    break;
                case "PreOrden":
                    PreOrden(raiz, grilla);     // Raíz → Izq → Der
                    break;
                case "PostOrden":
                    PostOrden(raiz, grilla);    // Izq → Der → Raíz
                    break;
            }
        }

        private void InOrden(clsNodos actual, DataGridView Grilla)
        {
            if (actual == null) return;
            InOrden(actual.Anterior, Grilla);                                      // Izquierda
            Grilla.Rows.Add(actual.Codigo, actual.Nombre, actual.Tramite);         // Raíz
            InOrden(actual.Siguiente, Grilla);                                     // Derecha
        }

        private void PreOrden(clsNodos actual, DataGridView Grilla)
        {
            if (actual == null) return;
            Grilla.Rows.Add(actual.Codigo, actual.Nombre, actual.Tramite);         // Raíz
            PreOrden(actual.Anterior, Grilla);                                     // Izquierda
            PreOrden(actual.Siguiente, Grilla);                                    // Derecha
        }

        private void PostOrden(clsNodos actual, DataGridView Grilla)
        {
            if (actual == null) return;
            PostOrden(actual.Anterior, Grilla);                                    // Izquierda
            PostOrden(actual.Siguiente, Grilla);                                   // Derecha
            Grilla.Rows.Add(actual.Codigo, actual.Nombre, actual.Tramite);         // Raíz
        }

        private void RecorrerTreeView(clsNodos actual, TreeNode nodoActual)
        {
            // Hijo izquierdo (Anterior)
            if (actual.Anterior != null)
            {
                TreeNode nodoIzq = new TreeNode("Izq: " + actual.Anterior.Codigo
                                                + " - " + actual.Anterior.Nombre);
                nodoActual.Nodes.Add(nodoIzq);
                RecorrerTreeView(actual.Anterior, nodoIzq);
            }

            // Hijo derecho (Siguiente)
            if (actual.Siguiente != null)
            {
                TreeNode nodoDer = new TreeNode("Der: " + actual.Siguiente.Codigo
                                                + " - " + actual.Siguiente.Nombre);
                nodoActual.Nodes.Add(nodoDer);
                RecorrerTreeView(actual.Siguiente, nodoDer);
            }
        }

        // ─── RECORRER → ListBox ───────────────────────────────────────────────
        public void Recorrer(ListBox Lista)
        {
            Lista.Items.Clear();
            RecorrerLista(raiz, Lista);
        }

        private void RecorrerLista(clsNodos actual, ListBox Lista)
        {
            if (actual == null) return;

            RecorrerLista(actual.Anterior, Lista);
            Lista.Items.Add(actual.Codigo + " - " + actual.Nombre);
            RecorrerLista(actual.Siguiente, Lista);
        }
    }
}