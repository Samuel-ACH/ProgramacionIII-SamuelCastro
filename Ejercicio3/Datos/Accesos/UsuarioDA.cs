using Datos.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Datos.Accesos
{
    public class UsuarioDA
    {
        readonly string cadena = "server = localhost; Port=3306; Database = Ejercicio3; Uid = root; Pwd = 12345;";
        MySqlConnection conn;
        MySqlCommand cmd;

        public Usuario Login(string idUsuario, string clave)
        {
            Usuario user = null;
            try
            {
                string sql = "SELECT * FROM usuario WHERE IdUsuario = @IdUsuario and Clave = @Clave;";
                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("IdUsuario", idUsuario);
                cmd.Parameters.AddWithValue("Clave", clave);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    user = new Usuario();
                    user.IdUsuario = reader[0].ToString();
                    user.Nombre = reader[1].ToString();
                    user.Clave = reader[2].ToString();

                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {

            }
            return user;        
            }

        public DataTable ListarUsuarios()
        {
            DataTable listaUsuariosDT = new DataTable();

            try
            {
                string sql = "SELECT * FROM usuario;";
                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                listaUsuariosDT.Load(reader);
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return listaUsuariosDT;
        }
        public bool InsertarUsuario(Usuario usuario)
        {
            bool inserto = false;
            try
            {
                string sql = "INSERT INTO usuario VALUES (@IdUsuario, @Nombre, @Clave;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@IdUsuario", usuario.IdUsuario);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@Clave", usuario.Clave);

                cmd.ExecuteNonQuery();
                inserto = true;

                conn.Close();
            }
            catch (Exception)
            {
            }
            return inserto;
        }
    }
}

