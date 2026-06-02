using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryEDPereiroB
{
    internal class clsBaseDeDatos
    {
        OleDbConnection conexion = new OleDbConnection();
        OleDbCommand comando = new OleDbCommand();
        OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\DB\\Libreria.mdb";

        // ─────────────────────────────────────────────────────────────
        // Devuelve los nombres de las tablas del usuario (excluye
        // tablas del sistema que empiezan con "MSys")
        // ─────────────────────────────────────────────────────────────
        public List<string> ObtenerTablas()
        {
            List<string> tablas = new List<string>();
           

            try
              
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();

                // GetSchema("Tables") devuelve metadatos de todas las tablas
                DataTable esquema = conexion.GetSchema("Tables");

                foreach (DataRow fila in esquema.Rows)
                {
                    string tipo = fila["TABLE_TYPE"].ToString();
                    string nombre = fila["TABLE_NAME"].ToString();

                    // Solo tablas reales del usuario (TABLE o VIEW),
                    // descartando las tablas internas "MSys..."
                    if ((tipo == "TABLE" || tipo == "VIEW")
                        && !nombre.StartsWith("MSys"))
                    {
                        tablas.Add(nombre);
                    }
                }

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener tablas: " + ex.Message);
            }

            return tablas;
        }

        // ─────────────────────────────────────────────────────────────
        // Lista el contenido completo de una tabla en el DataGridView
        // ─────────────────────────────────────────────────────────────
        public void Listar(string tabla, DataGridView Grilla )
        {
            try
            {
            
                
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;

                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(DS, tabla);

                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables[tabla];

                conexion.Close();
            }

           
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar: " + ex.Message);
            }
        }

        public void Listar(DataGridView Grilla, string varInstructionSQL)
        {
            try
            {
           

                comando.Connection = conexion;
               comando.CommandType = CommandType.Text;
                comando.CommandText = varInstructionSQL;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, "Resultado");

                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables["Resultado"];

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar con condición: " + ex.Message);
            }
        }
    }
}