using System;
using System.Collections.Generic;
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

        // ─── EQUILIBRAR ───────────────────────────────────────────────────────────
        public void Equilibrar()
        {
            // 1. Recolectar todos los nodos en orden (ya están ordenados por Codigo)
            List<clsNodos> lista = new List<clsNodos>();
            RecolectarInOrden(raiz, lista);

            // 2. Limpiar el árbol
            raiz = null;

            // 3. Reconstruir desde el centro
            raiz = ConstruirEquilibrado(lista, 0, lista.Count - 1);
        }

        private void RecolectarInOrden(clsNodos actual, List<clsNodos> lista)
        {
            if (actual == null) return;
            RecolectarInOrden(actual.Anterior, lista);
            lista.Add(actual);
            RecolectarInOrden(actual.Siguiente, lista);
        }

        private clsNodos ConstruirEquilibrado(List<clsNodos> lista, int inicio, int fin)
        {
            if (inicio > fin) return null;

            int medio = (inicio + fin) / 2;
            clsNodos nodo = lista[medio];

            // Limpiar punteros antes de reinsertar
            nodo.Anterior = null;
            nodo.Siguiente = null;

            nodo.Anterior = ConstruirEquilibrado(lista, inicio, medio - 1);
            nodo.Siguiente = ConstruirEquilibrado(lista, medio + 1, fin);

            return nodo;
        }

        // ─── ELIMINAR ─────────────────────────────────────────────────────────────
        public bool Eliminar(int codigo)
        {
            bool eliminado = false;
            raiz = EliminarRecursivo(raiz, codigo, ref eliminado);
            return eliminado;
        }

        private clsNodos EliminarRecursivo(clsNodos actual, int codigo, ref bool eliminado)
        {
            if (actual == null) return null;

            if (codigo < actual.Codigo)
            {
                actual.Anterior = EliminarRecursivo(actual.Anterior, codigo, ref eliminado);
            }
            else if (codigo > actual.Codigo)
            {
                actual.Siguiente = EliminarRecursivo(actual.Siguiente, codigo, ref eliminado);
            }
            else
            {
                // Nodo encontrado
                eliminado = true;

                // Caso 1: Nodo hoja
                if (actual.Anterior == null && actual.Siguiente == null)
                    return null;

                // Caso 2a: Solo hijo derecho
                if (actual.Anterior == null)
                    return actual.Siguiente;

                // Caso 2b: Solo hijo izquierdo
                if (actual.Siguiente == null)
                    return actual.Anterior;

                // Caso 3: Dos hijos → buscar sucesor in-orden (mínimo del subárbol derecho)
                clsNodos sucesor = ObtenerMinimo(actual.Siguiente);

                // Copiar datos del sucesor al nodo actual
                actual.Codigo = sucesor.Codigo;
                actual.Nombre = sucesor.Nombre;
                actual.Tramite = sucesor.Tramite;

                // Eliminar el sucesor del subárbol derecho
                actual.Siguiente = EliminarRecursivo(actual.Siguiente, sucesor.Codigo, ref eliminado);
                eliminado = true;
            }

            return actual;
        }

        private clsNodos ObtenerMinimo(clsNodos actual)
        {
            while (actual.Anterior != null)
                actual = actual.Anterior;
            return actual;
        }

    }
}