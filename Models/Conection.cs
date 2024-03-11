using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace fundamentos_CSHARP.Models
{
    public class Conection
    {
        public static MySqlConnection conectDB()
        {
            string connectionString = "datasource=localhost;" +
                                      "port=3306;" +
                                      "username=root;" +
                                      "password=;" +
                                      "database=animales;";

            MySqlConnection conectionDB = new MySqlConnection(connectionString);

            return conectionDB;
        }
    }
}
