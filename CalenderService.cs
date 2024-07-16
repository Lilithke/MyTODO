using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newproject
{
    internal class CalenderService
    {
        private static string DB_HOST = "localhost";
        private static string DB_USER = "root";
        private static string DB_PASSWORD = "";
        private static string DB_DBNAME = "evi/todo";

        private MySqlConnection connection;

        public CalenderService()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = DB_HOST;
            builder.UserID = DB_USER;
            builder.Password = DB_PASSWORD;
            builder.Database = DB_DBNAME;
            
            
            this.connection = new MySqlConnection(builder.ConnectionString);
            this.connection.Open();
        }
    }
}
