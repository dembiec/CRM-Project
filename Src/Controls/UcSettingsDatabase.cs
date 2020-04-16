using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using CRM_Project.Src.Classes;

namespace CRM_Project.Src.Controls
{
    public partial class UcSettingsDatabase : UserControl
    {
        public UcSettingsDatabase()
        {
            InitializeComponent();
        }

        private void UcSettingsDatabase_Load(object sender, EventArgs e)
        {
            string dbHost = Properties.SettingsDatabase.Default.Host;
            tbHost.Text = (dbHost != string.Empty) ? dbHost : string.Empty;

            string dbUser = Properties.SettingsDatabase.Default.User;
            tbUser.Text = (dbUser != string.Empty) ? dbUser : string.Empty;

            string dbPassword = Properties.SettingsDatabase.Default.Password;
            tbPassword.Text = (dbPassword != string.Empty) ? dbPassword : string.Empty;

            string dbName = Properties.SettingsDatabase.Default.Database;
            tbDatabase.Text = (dbName != string.Empty) ? dbName : string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                Properties.SettingsDatabase.Default.Host = (tbHost.Text != string.Empty) ? tbHost.Text : string.Empty;
                Properties.SettingsDatabase.Default.User = (tbUser.Text != string.Empty) ? tbUser.Text : string.Empty;
                Properties.SettingsDatabase.Default.Password = (tbPassword.Text != string.Empty) ? tbPassword.Text : string.Empty;
                Properties.SettingsDatabase.Default.Database = (tbDatabase.Text != string.Empty) ? tbDatabase.Text : string.Empty;
                Properties.SettingsDatabase.Default.Save();
                MessageBox.Show("Poprawnie zapisano ustawienia");
            } catch (Exception ex) {
                MessageBox.Show("Wystąpił błąd podczas zapisywania ustawień");
            }

            string tableCustomers = "CREATE TABLE `"+ tbDatabase.Text + "`.`customers` ( `id` INT NOT NULL AUTO_INCREMENT , `name` TEXT NOT NULL , `email` TEXT NOT NULL , `telephone` TEXT NOT NULL , `address` TEXT NOT NULL , `description` LONGTEXT NULL DEFAULT NULL , `update_date` TIMESTAMP on update CURRENT_TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP , PRIMARY KEY (`id`), UNIQUE (`email`), UNIQUE (`telephone`)) ENGINE = InnoDB;";
            string tableEvents = "CREATE TABLE `" + tbDatabase.Text + "`.`events` ( `id` INT NOT NULL AUTO_INCREMENT , `customer_id` INT NULL , `title` TEXT NOT NULL , `description` MEDIUMTEXT NULL DEFAULT NULL , `status` BOOLEAN NOT NULL , `date` DATETIME NOT NULL , `update_date` TIMESTAMP on update CURRENT_TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP , PRIMARY KEY (`id`)) ENGINE = InnoDB;";
            string dbQuery = tableCustomers + " " + tableEvents;


            if (tbHost.Text != "" && tbUser.Text != "" && tbDatabase.Text != "") {
                Database.connect();
                Database.query(dbQuery);
                if (Database.status) {
                    MessageBox.Show("Poprawnie dodano tabele do bazy danych");
                    UcSettingsDatabase_Load(sender, e);
                } else {
                    MessageBox.Show("Wystąpił błąd bazy danych lub w bazie istnieją już wymagane tabele");
                }

                if (!Properties.Settings.Default.firstStart) {
                    Properties.Settings.Default.firstStart = true;
                    Properties.Settings.Default.Save();

                    Application.Restart();
                }
            }
        }
    }
}
