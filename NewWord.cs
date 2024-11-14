using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace MatchWords
{
    public partial class NewWord : Form
    {
        public NewWord()
        {
            InitializeComponent();
        }
        private void recargarDatos() //POR ACA VAS
        {
            Datos datos = new Datos();
            SqlCommand consulta = new SqlCommand();
            consulta.CommandText = "select Id, palabra, translatee from words";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            

            try
                
            {
                
                if (txtNewWord.Text != null && txtNewTranslate != null)
                {
                    conexion.ConnectionString = "server=LAPTOP-O826RRH4\\SQLEXPRESS; database=MatchWords; integrated security = true";
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.CommandText = "INSERT into words (Id, palabra, translatee) values (@id,@palabra,@translatee)";
                    comando.Parameters.AddWithValue("@id", txtId.Text);
                    comando.Parameters.AddWithValue("@palabra", txtNewWord.Text);
                    comando.Parameters.AddWithValue("@translatee", txtNewTranslate.Text);
                    comando.Connection = conexion;
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    NewWord.ActiveForm.Close();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
