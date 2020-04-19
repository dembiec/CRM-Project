using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM_Project.Src.Classes;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace CRM_Project.Src.Controls
{
    public partial class UcUpdateCustomer : UserControl
    {
        public static int idCustomer;

        public UcUpdateCustomer(int id)
        {
            idCustomer = id;
            InitializeComponent();
        }

        private void UcUpdateCustomer_Load(object sender, EventArgs e)
        {
            Database.connect();
            Database.query("SELECT * FROM `customers` WHERE id = "+idCustomer);

            if (Database.status) {
                if (Database.reader.HasRows) {
                    string description = "";
                    while (Database.reader.Read()) {
                        if (Database.reader.IsDBNull(5)) {
                            description = "";
                        } else {
                            description = Database.reader.GetString(5);
                        }
                        tbName.Text = Database.reader.GetString(1);
                        tbEmail.Text = Database.reader.GetString(2);
                        tbTelephone.Text = Database.reader.GetString(3);
                        tbAdress.Text = Database.reader.GetString(4);
                        tbDescription.Text = description;
                    }
                } else {
                    MessageBox.Show("Dane Nie Zostały Znalezione");
                }
            } else {
                MessageBox.Show("Błąd Bazy Danych");
            }

            Database.close();
        }

        //name
        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) {
                e.Handled = true;
            }
        }

        bool name = true;

        private void tbName_Validated(object sender, EventArgs e)
        {
            if (tbName.Text == "") {
                name = false;
                pbName.Image = Properties.Resources.not_accept;
            } else {
                name = true;
                pbName.Image = Properties.Resources.check;
            }
        }

        //email
        bool email = true;
        private void tbEmail_Validated(object sender, EventArgs e)
        {
            try {
                MailAddress mail = new MailAddress(tbEmail.Text);
                email = true;
                pbEmail.Image = Properties.Resources.check;
            } catch {
                email = false;
                pbEmail.Image = Properties.Resources.not_accept;
            }
        }

        //telephone
        private void tbTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        bool telephone = true;

        private void tbTelephone_Validated(object sender, EventArgs e)
        {
            if (tbTelephone.Text == "" || tbTelephone.TextLength != 9) {
                telephone = false;
                pbTelephone.Image = Properties.Resources.not_accept;
            } else {
                telephone = true;
                pbTelephone.Image = Properties.Resources.check;
            }
        }

        //adress
        bool adress = true;

        private void tbAdress_Validated(object sender, EventArgs e)
        {
            if (tbAdress.Text == "") {
                adress = false;
                pbAdress.Image = Properties.Resources.not_accept;
            } else {
                adress = true;
                pbAdress.Image = Properties.Resources.check;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Database.connect();
            Database.query("DELETE FROM `customers` WHERE `customers`.`id` = "+idCustomer);
            if (Database.status) {
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;

                tbName.Text = "";
                tbEmail.Text = "";
                tbTelephone.Text = "";
                tbAdress.Text = "";
                tbDescription.Text = "";

                MessageBox.Show("Poprawnie usunięto klienta z bazy danych");
            } else {
                MessageBox.Show("Wystąpił błąd bazy danych. Spróbuj ponownie za chwilę");
            }
            Database.close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (name && email && telephone && adress) {
                string outAdress = Regex.Replace(tbAdress.Text, @"('|=|-{2})", string.Empty);
                string outEmail = Regex.Replace(tbEmail.Text, @"('|=|-{2})", string.Empty);
                string dbQuery;
                string description;
                if (tbDescription.Text == "") {
                    description = string.Empty;
                } else {
                    description = Regex.Replace(tbDescription.Text, @"('|=|-{2})", string.Empty); ;
                }
                dbQuery = "UPDATE `customers` SET `name` = '" + tbName.Text + "', `email` = '" + outEmail + "', `telephone` = '" + tbTelephone.Text + "', `address` = '" + outAdress + "', `description` = '" + description + "' WHERE `customers`.`id` = " + idCustomer;

                Database.connect();
                Database.query(dbQuery);
                if (Database.status) {
                    UcUpdateCustomer_Load(sender, e);
                    MessageBox.Show("Poprawnie zaktualizowano dane klienta w bazie danych");
                } else {
                    MessageBox.Show("Wystąpił błąd bazy danych. Spróbuj ponownie za chwilę");
                }
                Database.close();

            } else {
                MessageBox.Show("Sprawdź Wszystkie Pola");
            }
        }
    }
}
