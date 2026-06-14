using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDPereiroB
{
    internal class clsListaSimple
    {

        private clsNodos primero;

        public clsNodos Primero
        {
            get { return primero; }
            set { primero = value; }
        }

        public void Agregar(clsNodos Nuevo)
        {
            if (primero == null)
            {
                primero = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo <= primero.Codigo)
                {
                    Nuevo.Siguiente = primero;
                    primero = Nuevo;
                }
                else
                {
                    clsNodos aux = primero;
                    clsNodos ant = primero;
                    while (Nuevo.Codigo > aux.Codigo)
                    {
                        ant = aux;
                        aux = aux.Siguiente;
                        if (aux == null) break;

                    }
                    Nuevo.Siguiente = aux;
                    ant.Siguiente = Nuevo;
                }

            }
        }

        public void Recorrer()
        {
            clsNodos Aux = Primero;
            StreamWriter sw = new StreamWriter("ListaSimple.txt");
            while (Aux != null)
            {
                sw.WriteLine("Codigo: " + Aux.Codigo);
                sw.WriteLine("Nombre: " + Aux.Nombre);
                sw.WriteLine("Tramite: " + Aux.Tramite);
                sw.WriteLine("");
                Aux = Aux.Siguiente;
            }
            sw.Close();
        }

        public void Recorrer(DataGridView Grilla)
        {
            clsNodos Aux = Primero;
            Grilla.Rows.Clear();

            while (Aux != null)
            {
                Grilla.Rows.Add(Aux.Codigo, Aux.Nombre, Aux.Tramite);
                Aux = Aux.Siguiente;


            }
        }

        public void Recorrer(ListBox Lista)
        {
            clsNodos Aux = Primero;
            Lista.Items.Clear();

            while (Aux != null)
            {
                Lista.Items.Add(Aux.Codigo);
                Aux = Aux.Siguiente;


            }
        }

        public void Recorrer(ComboBox Combo)
        {
            clsNodos Aux = Primero;
            Combo.Items.Clear();

            while (Aux != null)
            {
                Combo.Items.Add(Aux.Codigo);
                Aux = Aux.Siguiente;


            }
        }

        public clsNodos Buscar(Int32 Codigo)
        {
            clsNodos aux = primero;
            while (aux != null)
            {
                if (aux.Codigo == Codigo)
                    return aux;
                aux = aux.Siguiente;
            }
            return null;
        }

        public void Eliminar(Int32 Codigo)
        {
            if (primero == null) return;

            if (primero.Codigo == Codigo)
            {
                primero = primero.Siguiente;
            }
            else
            {   
                clsNodos aux1 = primero;
                clsNodos aux2 = primero;
                while (aux1 != null && aux1.Codigo != Codigo)
                {
                    aux2 = aux1;
                    aux1 = aux1.Siguiente;
                }
                if (aux1 != null)
                    aux2.Siguiente = aux1.Siguiente;
            }
        }
    }
}
