using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskApp.Models
{
    public class ConexionDb
    {
        public static MySqlConnection ObtenerConexion()
        {
            string cs = @"server=localhost;userid=root;password=123456;database=taskio";
            MySqlConnection con = new MySqlConnection(cs);
            con.Open();
            return con;

        }
    }
}
