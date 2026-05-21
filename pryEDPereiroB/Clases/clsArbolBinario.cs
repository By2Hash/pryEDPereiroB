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

        // ─── RECORRIDOS A ARCHIVO ─────────────────────────────────────────────
        public void Recorrer()
        {
            StreamWriter sw = new StreamWriter("Arbol.txt");
            RecorrerEscribirArchivo(raiz, sw);
            sw.Close();
        }

        private void RecorrerEscribirArchivo(clsNodos actual, StreamWriter sw)
        {
            if (actual == null) return;
            RecorrerEscribirArchivo(actual.Anterior, sw);
            sw.WriteLine(actual.Codigo + "," + actual.Nombre + "," + actual.Tramite);
            RecorrerEscribirArchivo(actual.Siguiente, sw);
        }

        // ─── RECORRER → DataGridView (Según el RadioButton) ───────────────────
        public void Recorrer(DataGridView Grilla, string orden)
        {
            Grilla.Rows.Clear();

            switch (orden)
            {
                case "InOrden":
                    RecorrerInOrden(raiz, Grilla);
                    break;
                case "PreOrden":
                    RecorrerPreOrden(raiz, Grilla);
                    break;
                case "PostOrden":
                    RecorrerPostOrden(raiz, Grilla);
                    break;
            }
        }

        // Izquierda -> Raíz -> Derecha
        private void RecorrerInOrden(clsNodos actual, DataGridView Grilla)
        {
            if (actual == null) return;
            RecorrerInOrden(actual.Anterior, Grilla);
            Grilla.Rows.Add(actual.Codigo, actual.Nombre, actual.Tramite);
            RecorrerInOrden(actual.Siguiente, Grilla);
        }

        // Raíz -> Izquierda -> Derecha
        private void RecorrerPreOrden(clsNodos actual, DataGridView Grilla)
        {
            if (actual == null) return;
            Grilla.Rows.Add(actual.Codigo, actual.Nombre, actual.Tramite);
            RecorrerPreOrden(actual.Anterior, Grilla);
            RecorrerPreOrden(actual.Siguiente, Grilla);
        }

        // Izquierda -> Derecha -> Raíz
        private void RecorrerPostOrden(clsNodos actual, DataGridView Grilla)
        {
            if (actual == null) return;
            RecorrerPostOrden(actual.Anterior, Grilla);
            RecorrerPostOrden(actual.Siguiente, Grilla);
            Grilla.Rows.Add(actual.Codigo, actual.Nombre, actual.Tramite);
        }

        // ─── RECORRER → TreeView (Estructura visual) ──────────────────────────
        public void Recorrer(TreeView arbol)
        {
            arbol.Nodes.Clear();
            if (raiz == null) return;

            TreeNode nodoRaiz = new TreeNode("Raíz: " + raiz.Codigo + " - " + raiz.Nombre);
            arbol.Nodes.Add(nodoRaiz);

            RecorrerTreeView(raiz, nodoRaiz);
            arbol.ExpandAll();
        }

        private void RecorrerTreeView(clsNodos actual, TreeNode nodoActual)
        {
            // Hijo izquierdo (Anterior)
            if (actual.Anterior != null)
            {
                TreeNode nodoIzq = new TreeNode("Izq: " + actual.Anterior.Codigo + " - " + actual.Anterior.Nombre);
                nodoActual.Nodes.Add(nodoIzq);
                RecorrerTreeView(actual.Anterior, nodoIzq);
            }

            // Hijo derecho (Siguiente)
            if (actual.Siguiente != null)
            {
                TreeNode nodoDer = new TreeNode("Der: " + actual.Siguiente.Codigo + " - " + actual.Siguiente.Nombre);
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