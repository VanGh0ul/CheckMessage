using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp04
{
    public static class ConDB
    {

        public static MySqlConnection GetMainConnection() {

            return GetConnection("localhost", "3306", "root", "6199", "databasesList");
        }

        public static MySqlConnection GetConnection(string serverName, string port, string user, string password, string dbName) { 
        
            return new MySqlConnection(String.Format(
                "server={0};" +
                "port={1};" +
                "username={2};" +
                "password={3};" +
                "database={4}",
                serverName,
                port,
                user,
                password,
                dbName
            ));
        }

        // MySqlConnection connection = 
        /*
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
        */

    }
}
