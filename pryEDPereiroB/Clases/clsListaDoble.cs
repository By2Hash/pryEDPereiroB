using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDPereiroB
{
    internal class clsListaDoble
    {
        private clsNodos primero;
        private clsNodos ultimo;

        public clsNodos Primero
        {
            get { return primero; }
            set { primero = value; }
        }

        public clsNodos Ultimo
        {
            get { return ultimo; }
            set { ultimo = value; }
        }




        public void Agregar(clsNodos Nuevo)
        {
            if (primero == null)
            {
                primero = Nuevo;
                ultimo = Nuevo;

            }
            else
            {
                if (Nuevo.Codigo <= primero.Codigo)
                {
                    Nuevo.Siguiente = primero;
                    primero.Anterior = Nuevo;
                    primero = Nuevo;
                }
                else
                {
                    if (Nuevo.Codigo >= ultimo.Codigo)
                    {
                        ultimo.Siguiente = Nuevo;
                        Nuevo.Anterior = ultimo;
                        ultimo = Nuevo;
                    }
                    else
                    {
                        clsNodos aux = primero;
                        clsNodos ant = primero;
                        while (aux.Codigo < Nuevo.Codigo)
                        {
                            ant = aux;
                            aux = aux.Siguiente;
                        }

                        ant.Siguiente = Nuevo;
                        Nuevo.Siguiente = aux;
                        aux.Anterior = Nuevo;
                        Nuevo.Anterior = ant;
                    }
                }
            }
        }



        public void Recorrer()
        {
            clsNodos Aux = Primero;
            StreamWriter sw = new StreamWriter("ListaDoble.txt");
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

        public void RecorrerDesc()
        {
            clsNodos Aux = Ultimo;

            StreamWriter sw = new StreamWriter("ListaDobleDesc.txt");

            while (Aux != null)
            {
                sw.WriteLine("Codigo: " + Aux.Codigo);
                sw.WriteLine("Nombre: " + Aux.Nombre);
                sw.WriteLine("Tramite: " + Aux.Tramite);
                sw.WriteLine("");

                Aux = Aux.Anterior;
            }

            sw.Close();
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

            if (primero.Codigo == Codigo && ultimo == primero)
            {
                primero = null;
                ultimo = null;
            }
            else
            {
                if (primero.Codigo == Codigo)
                {
                    primero = primero.Siguiente;
                    primero.Anterior = null;
                }
                else
                {
                    if (ultimo.Codigo == Codigo)
                    {
                        ultimo = ultimo.Anterior;
                        ultimo.Siguiente = null;
                    }
                    else
                    { 
                        clsNodos aux1 = primero;
                        clsNodos ant = primero;
                        while (aux1 != null && aux1.Codigo != Codigo)
                        {
                            ant = aux1;
                            aux1 = aux1.Siguiente;
                        }
                        if (aux1 != null)
                        {
                            clsNodos aux2 = aux1.Siguiente;
                            aux2.Anterior = ant;
                            ant.Siguiente = aux2;
                        }
                    }
                }

            }

        }


        public void RecorrerDesc(DataGridView Grilla)
        {
            clsNodos Aux = Ultimo;
            Grilla.Rows.Clear();

            while (Aux != null)
            {
                Grilla.Rows.Add(Aux.Codigo, Aux.Nombre, Aux.Tramite);
                Aux = Aux.Anterior;
            }
        }

        public void RecorrerDesc(ListBox Lista)
        {
            clsNodos Aux = Ultimo;
            Lista.Items.Clear();

            while (Aux != null)
            {
                Lista.Items.Add(Aux.Codigo);
                Aux = Aux.Anterior;
            }
        }

        public void RecorrerDesc(ComboBox Combo)
        {
            clsNodos Aux = Ultimo;
            Combo.Items.Clear();

            while (Aux != null)
            {
                Combo.Items.Add(Aux.Codigo);
                Aux = Aux.Anterior;
            }
        }

    }
}
