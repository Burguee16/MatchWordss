using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Identity.Client;
using System.IdentityModel.Metadata;

namespace MatchWords
{
    public class Datos
    {
        public List<Word> listar()
        {
            List<Word> lista = new List<Word>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server=LAPTOP-O826RRH4\\SQLEXPRESS; database=MatchWords; integrated security = true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Id, palabra, translatee from words";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Word aux = new Word();
                    aux.Id = (int)lector["Id"];
                    aux.palabra = (string)lector["palabra"];
                    aux.translate = (string)lector["translatee"];

                    lista.Add(aux);
                }
                conexion.Close();
                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}

