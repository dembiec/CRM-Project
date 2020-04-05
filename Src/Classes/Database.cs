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
        public static void manipulation(string queryContent)
        {
            string host = "localhost";
            string dbUser = "root";
            string dbPassword = "";
            string dbName = "crm-project";

            string connectionData = "datasource=" + host + ";port=3306;username=" + dbUser + ";password=" + dbPassword + ";database=" + dbName + ";";
            string query = queryContent;

            MySqlConnection databaseConnection = new MySqlConnection(connectionData);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                MessageBox.Show("Poprawnie wykonano zapytanie do bazy danych");
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Wystąpił błąd bazy danych");
            }
        }
    }
}
