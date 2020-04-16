using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_Project.Src.Classes
{
    class Database
    {
        public static MySqlConnection databaseConnection;
        public static MySqlDataReader reader;
        public static bool status = true;

        public static void connect()
        {
            /*string host = "localhost";
            string user = "root";
            string password = "";
            string db = "crm-project";*/

            string host = Properties.SettingsDatabase.Default.Host;
            string user = Properties.SettingsDatabase.Default.User;
            string password = Properties.SettingsDatabase.Default.Password;
            string db = Properties.SettingsDatabase.Default.Database;

            string connectionData = "datasource=" + host + ";port=3306;username=" + user + ";password=" + password + ";database=" + db + ";";
            databaseConnection = new MySqlConnection(connectionData);
        }

        public static void query(string dbQuery)
        {
            MySqlCommand commandDatabase = new MySqlCommand(dbQuery, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
            }
            catch (Exception ex)
            {
                status = false;
            }
        }

        public static void close()
        {
            databaseConnection.Close();
        }
    }
}
