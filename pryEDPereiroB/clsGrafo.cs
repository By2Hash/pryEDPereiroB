using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDPereiroB
{
    internal class clsGrafo
    {
        //Se define un array
        private String[] Ciudades = new String[] {"Córdoba","Mendoza","Santa Fe","Buenos Aires","Salta" };
        //Matriz0
        private Decimal[,] Precio = new Decimal [5,5];


        public void Agregar(Int32 c, Int32 f,Int32 p )
        {
            Precio[c, f] = p;
        }

        public void Eliminar(Int32 c, Int32 f)
        {
            Precio[c, f] = 0;        
        }

        public Decimal Consultar (Int32 c, Int32 f)
        {
            return Precio[c, f];

        }

        public void BorrarTodo()
        { 
            for (Int32 f = 0; f >= Precio.Length;f++)
            {
                for (Int32 c = 0; c >= Precio.Length;c++)
                {
                    Precio[c,f] = 0;
                }

            }
        }

        public void MostrarDestinos(Int32 f, Int32 c, DataGridView Grilla)
        { 
            Grilla.Rows.Clear();
            Grilla.Columns.Clear();

            Grilla.Columns.Add("Col1", "Destino");
            Grilla.Columns.Add("Col2", "Precio");
            Grilla.Columns[0].Width = 200;
            Grilla.Columns[1].Width = 200;
            Grilla.Rows.Clear();
            for (c = 0; c < Precio.Length; c++)
            {
                if (Precio[f,c] > 0)
                {
                    Grilla.Rows.Add(Ciudades[c], Precio[f,c]);
                }
            }
        }

        public void MostrarOrigenes(Int32 c, Int32 f ,DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            Grilla.Columns.Clear();

            Grilla.Columns.Add("Col1", "Origen");
            Grilla.Columns.Add("Col2", "Precio");
            Grilla.Columns[0].Width = 200;
            Grilla.Columns[1].Width = 200;
            Grilla.Rows.Clear();
            for (c = 0; c < Precio.Length; c++)
            {
                if (Precio[f, c] > 0)
                {
                    Grilla.Rows.Add(Ciudades[c], Precio[f, c]);
                }
            }
        }

        public void MostrarTodo(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            Grilla.Columns.Clear();
            Grilla.Columns.Add("NomOrigen", "Origen");
            for (Int32 i = 0; i <= Precio.Length; i++)
            {
                Grilla.Columns.Add("Destino" + i.ToString(), Ciudades[i]);
            }
            for (Int32 f = 0; f <= Precio.Length; f++)
            {
                Grilla.Rows.Add(Ciudades[f]);
                for (Int32 c = 0; c < Precio.Length; c++)
                {
                    Grilla.Rows[f].Cells[c+1].Value = Precio[f,c];
                }
            }

        }

        public void MostrarCiudades(ComboBox cmb)
        {
            cmb.Items.Clear();
            for (Int32 i = 0; i <= Precio.Length; i++)
            { 
                cmb.Items.Add(Ciudades[i]);

            }
            cmb.SelectedIndex = 0;

        }
    }
}















