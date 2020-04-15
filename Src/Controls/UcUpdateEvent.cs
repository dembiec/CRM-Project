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
using System.Text.RegularExpressions;

namespace CRM_Project.Src.Controls
{
    public partial class UcUpdateEvent : UserControl
    {
        private int idEvent;
        public UcUpdateEvent(int id)
        {
            idEvent = id;
            InitializeComponent();
        }

        private int idCustomer;
        private void UcUpdateEvent_Load(object sender, EventArgs e)
        {
            Database.connect();
            Database.query("SELECT * FROM `events` WHERE id = "+idEvent);
            if (Database.status) {
                if (Database.reader.HasRows) {
                    while (Database.reader.Read()) {
                        idCustomer = int.Parse(Database.reader.GetString(1));
                        tbTitle.Text = Database.reader.GetString(2);
                        dateTimePicker.CustomFormat = "dd-MM-yyy HH:mm";
                        dateTimePicker.Text = Database.reader.GetString(5);
                        if (Database.reader.GetBoolean(4)) {
                            cbStatus.SelectedIndex = 0;
                        } else {
                            cbStatus.SelectedIndex = 1;
                        }

                        if (Database.reader.IsDBNull(3)) {
                            tbDescription.Text = string.Empty;
                        } else {
                            tbDescription.Text = Database.reader.GetString(3);
                        }
                    }
                } else {
                    MessageBox.Show("Dane Nie Zostały Znalezione");
                }
            } else {
                MessageBox.Show("Błąd Bazy Danych");
            }
            Database.close();

            Database.connect();
            Database.query("SELECT id, name, email FROM `customers` ORDER BY name ASC");
            if (Database.status) {
                if (Database.reader.HasRows) {
                    List<Customers> list = new List<Customers>();
                    while (Database.reader.Read()) {
                        list.Add(new Customers() { ID = int.Parse(Database.reader.GetString(0)), Name = Database.reader.GetString(1) + " - " + Database.reader.GetString(2) });
                    }
                    cbCustomer.DataSource = list;
                    cbCustomer.ValueMember = "ID";
                    cbCustomer.DisplayMember = "Name";
                    cbCustomer.SelectedValue = idCustomer;
                }
            } else {
                MessageBox.Show("Bład bazy danych");
            }
            Database.close();
        }

        //title
        bool title = true;
        private void tbTitle_Validated(object sender, EventArgs e)
        {
            if (tbTitle.Text == "") {
                title = false;
                pbTitle.Image = Properties.Resources.not_accept;
            } else {
                title = true;
                pbTitle.Image = Properties.Resources.check;
            }
        }

        //date
        bool date = true;
        private void dateTimePicker_Validated(object sender, EventArgs e)
        {
            if (dateTimePicker.Text == " ") {
                date = false;
                pbDate.Image = Properties.Resources.not_accept;
            } else {
                date = true;
                pbDate.Image = Properties.Resources.check;
            }
        }

        //status
        bool status = true;
        private void cbStatus_Validated(object sender, EventArgs e)
        {
            if (dateTimePicker.Text == " ") {
                status = false;
                pbStatus.Image = Properties.Resources.not_accept;
            } else {
                status = true;
                pbStatus.Image = Properties.Resources.check;
            }
        }

        //customer
        private void cbCustomer_MouseClick(object sender, MouseEventArgs e)
        {
            cbCustomer.DroppedDown = true;
        }

        bool customer = true;
        private void cbCustomer_Validated(object sender, EventArgs e)
        {
            if (cbCustomer.Text == "") {
                customer = false;
                pbCustomer.Image = Properties.Resources.not_accept;
            } else {
                customer = true;
                pbCustomer.Image = Properties.Resources.check;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Database.connect();
            Database.query("DELETE FROM `events` WHERE `events`.`id` = "+idEvent);
            if (Database.status) {
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;

                tbTitle.Clear();
                pbTitle.Image = null;

                dateTimePicker.Format = DateTimePickerFormat.Custom;
                dateTimePicker.CustomFormat = " ";
                pbDate.Image = null;

                cbStatus.ResetText();
                pbStatus.Image = null;

                cbCustomer.ResetText();
                pbCustomer.Image = null;

                tbDescription.Text = "";

                MessageBox.Show("Poprawnie usunięto wydarzenie z bazy danych");
            } else {
                MessageBox.Show("Wystąpił błąd bazy danych. Spróbuj ponownie za chwilę");
            }
            Database.close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (title && date && status && customer) {
                string dbQuery;
                Customers Selectedcustomer = cbCustomer.SelectedItem as Customers;
                string outTitle= Regex.Replace(tbTitle.Text, @"('|=|-{2})", string.Empty);
                string outDescription;
                int selectedStatus = 1;
                string dateFormat = Convert.ToDateTime(dateTimePicker.Text).ToString("yyyy-MM-dd HH:mm:ss");
                if (tbDescription.Text == "") {
                    outDescription = string.Empty;
                } else {
                    outDescription = Regex.Replace(tbDescription.Text, @"('|=|-{2})", string.Empty);
                }

                if (cbStatus.SelectedIndex == 0) {
                    selectedStatus = 1;
                } else {
                    selectedStatus = 0;
                }
                dbQuery = "UPDATE `events` SET `customer_id` = '"+ Selectedcustomer.ID+ "', `title` = '"+outTitle+"', `description` = '"+outDescription+"', `status` = '"+selectedStatus+"', `date` = '"+dateFormat+"', `update_date` = current_timestamp() WHERE `events`.`id` = " + idEvent;

                Database.connect();
                Database.query(dbQuery);
                if (Database.status) {
                    UcUpdateEvent_Load(sender, e);
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
