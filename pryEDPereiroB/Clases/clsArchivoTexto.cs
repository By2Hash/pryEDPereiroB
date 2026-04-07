using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace pryEDPereiroB
{
    internal class clsArchivoTexto
    {
        public string NombreArchivo = "";

        public void Guardar()
        {
            StreamWriter sw = new StreamWriter(NombreArchivo, true);
            sw.WriteLine("Rojo");
            sw.Close();
        }

        public void Guardar(String Nombre)
        {
            StreamWriter sw = new StreamWriter(NombreArchivo, true);
            sw.WriteLine(Nombre);
            sw.Close();
        }

        public void Guardar(string Nombre, string Color)
        {
            StreamWriter sw = new StreamWriter(NombreArchivo, true);
            sw.WriteLine(Nombre);
            sw.Write(" ,");
            sw.WriteLine(Color);
            sw.Close();
        }

        public void Recorrer(ListBox lst)
        {
            String DatoLeido;
            lst.Items.Clear();
             StreamReader sr = new StreamReader(NombreArchivo);
            DatoLeido = sr.ReadLine();

            while (DatoLeido != null)
                {
                   lst.Items.Add(DatoLeido);
                    DatoLeido = sr.ReadLine();
            }
                sr.Close();
        }


    }
}
