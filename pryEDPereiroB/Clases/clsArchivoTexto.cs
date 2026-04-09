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

        public void Guardar(String dato1, String dato2, String dato3)
        {
            StreamWriter sw = new StreamWriter(NombreArchivo, true);
            sw.Write(dato1);
            sw.Write(";");
            sw.Write(dato2);
            sw.Write(";");
            sw.WriteLine(dato3);
            sw.Close();


        }

        public void Recorrer(ListBox lst)
        {
            string DatoLeido;
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

        public void Recorrer(ComboBox lst)
        {
            string DatoLeido;
            lst.Items.Clear();

            StreamReader sr = new StreamReader(NombreArchivo);
            DatoLeido = sr.ReadLine();

            while (DatoLeido != null)
            {
                lst.Items.Add(DatoLeido);
                DatoLeido = sr.ReadLine();
            }
            sr.Close();
            lst.SelectedIndex = 0;
        }

        public void Recorrer(DataGridView Grilla)
        {
            string DatoLeido;
            Grilla.Rows.Clear();
            StreamReader sr = new StreamReader(NombreArchivo);
            DatoLeido = sr.ReadLine();
            while (DatoLeido != null)
            {
                Grilla.Rows.Add(DatoLeido.Split(';'));
                DatoLeido = sr.ReadLine();
            }
            sr.Close();
            
        }


    }
}
