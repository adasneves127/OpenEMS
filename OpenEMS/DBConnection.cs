using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using MySqlConnector;
using System.IO;
using System.Text;

namespace OpenEMS
{
    public partial class DBConnection
    {
        /// <summary>
        /// Constructor and Destructors. Do not modify
        /// </summary>
        private MySqlConnection conn;

        /// <summary>
        /// Connect to a MySql Database given an explicit connection string
        /// </summary>
        /// <param name="connString"></param> <summary>
        /// Connection String in the format "server=;uid=;pwd=;database=;
        /// </summary>
        /// <param name="connString"></param>
        public DBConnection(string connString){
            conn = new MySqlConnection(connString);
            conn.Open();
        }

        /// <summary>
        /// Connect to a MySql Database given a Hostname, Port, Username, Password, and Database.
        /// </summary>
        /// <param name="host">FQDN for the server</param>
        /// <param name="port">Port of the MySql Database</param>
        /// <param name="username">Username to access MySql Database</param>
        /// <param name="password">Password to access MySql Database</param>
        /// <param name="db_name">Database Name</param>
        public DBConnection(string host, int port, string username, string password, string db_name){
            string connString = "server=" + host + ":" + port.ToString() + ";uid=" + username +
                                ";pwd=" + password + ";database=" + db_name;
            conn = new MySqlConnection(connString);
            conn.Open();
        }

        /// <summary>
        /// Deconstructor for Object. Cannot be called directly.
        /// </summary>
        ~DBConnection(){
            conn.Close();
        }

        
    }
}