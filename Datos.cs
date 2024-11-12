using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MatchWords
{
    public class Datos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector; }
        }
        public Datos()
        {
            conexion = new SqlConnection("server=LAPTOP-O826RRH4\\SQLEXPRESS; database=MatchWords; integrated security=true");
            comando = new SqlCommand();
        }
        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }
        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void setearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }
        public void cerrarConexion()
        {
            if (lector !=null)

                lector.Close();
            conexion.Close();
        }
        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool ProbarConexion()
        {
            try
            {
                conexion.Open();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar: " + ex.Message);
                return false;
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
    }
}

