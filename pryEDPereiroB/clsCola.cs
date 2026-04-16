using System;
using System.IO;

namespace pryEDPereiroB
{
    internal class clsCola
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

        //Metodo
        public void Agregar(clsNodos Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                Ultimo.Siguiente = Nuevo;
                Ultimo = Nuevo;
            }
        }

        public void Eliminar()
        {
            if (Primero == Ultimo)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                Primero = Primero.Siguiente;
            }
        }
        public void Recorrer()
        {   
            clsNodos Actual = Primero;
            StreamWriter sc = new StreamWriter("Cola.txt");
            while (Actual != null)
            {
                sc.WriteLine("Codigo: " + Actual.Codigo);
                sc.WriteLine("Nombre: " + Actual.Nombre);
                sc.WriteLine("Tramite: " + Actual.Tramite);
                sc.WriteLine("");
                Actual = Actual.Siguiente;
            }
        }
    }
}
