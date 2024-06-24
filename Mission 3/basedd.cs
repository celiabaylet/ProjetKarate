using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_3
{
    internal class basedd
    {

        public static MySqlConnection ConnectBD()
        {
            // Création de la chaîne de connexion
            string connectionString = "SERVER=localhost; DATABASE=karate; UID=root; PASSWORD=";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
    }
}
