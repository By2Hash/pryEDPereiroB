using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryEDPereiroB
{
    internal class clsNodos
    {
        private int codigo;
        private string nombre;
        private string tramite;
        private clsNodos siguiente;

        public int Codigo
        {
            get { return codigo; }
            set { codigo =value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Tramite
        {
            get { return tramite; }
            set { tramite = value; }
        }
        public clsNodos Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

    }
}
