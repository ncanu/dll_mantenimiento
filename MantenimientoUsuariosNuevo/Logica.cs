using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoUsuariosNuevo
{
    class Logica
    {
        MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();

        public void crearUsuario(string usuario, string contrasena)
        {
            conn_string = new MySqlConnectionStringBuilder();
            conn_string.Server = "localhost";
            conn_string.UserID = "root";
            conn_string.Password = "MyPass12345";
            conn_string.Database = "seguridad_bd";

            string username = usuario;
            string password = contrasena;


            MySqlConnection con = new MySqlConnection(conn_string.ToString());
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into usuario (usu_nickname, usu_password, usu_estado) values ('" + username + "', '" + password + "',1)";
            cmd.ExecuteNonQuery();    
      
        }


    }
}
