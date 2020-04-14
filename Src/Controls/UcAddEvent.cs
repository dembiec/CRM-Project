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
using System.Globalization;

namespace CRM_Project.Src.Controls
{
    public partial class UcAddEvent : UserControl
    {
        public UcAddEvent()
        {
            InitializeComponent();
        }

        private void UcAddEvent_Load(object sender, EventArgs e)
        {
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
                } else {
                    MessageBox.Show("Brak danych do wyświetlenia");
                }
            } else {
                MessageBox.Show("Bład bazy danych");
            }
            Database.close();

            cbCustomer.ResetText();
        }

        //name

        bool title = false;
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
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker.CustomFormat = "dd-MM-yyy HH:mm";
        }

        bool date = false;
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

        //customer
        private void cbCustomer_MouseClick(object sender, MouseEventArgs e)
        {
            cbCustomer.DroppedDown = false;
        }

        bool customer = false;
        private void cbCustomer_Validated(object sender, EventArgs e)
        {
            if (cbCustomer.Text == "") {
                customer = false;
                pbCustomer.Image = Properties.Resources.not_accept;
            }
            else
            {
                customer = true;
                pbCustomer.Image = Properties.Resources.check;
            }
        }

        //btmClear
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbTitle.Clear();
            pbTitle.Image = null;

            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = " ";
            pbDate.Image = null;

            cbCustomer.ResetText();
            pbCustomer.Image = null;

            tbDescription.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (title && date && customer) {
                string dbQuery;
                Customers customer = cbCustomer.SelectedItem as Customers;
                string dateFormat = Convert.ToDateTime(dateTimePicker.Text).ToString("yyyy-MM-dd HH:mm:ss");
                if (tbDescription.Text == "") {
                    dbQuery = "INSERT INTO `events` (`id`, `customer_id`, `title`, `description`, `status`, `date`, `update_date`) VALUES (NULL, '"+customer.ID+ "', '"+tbTitle.Text+"', NULL, '1', '"+dateFormat+"', current_timestamp())";
                } else {
                    dbQuery = "INSERT INTO `events` (`id`, `customer_id`, `title`, `description`, `status`, `date`, `update_date`) VALUES (NULL, '"+customer.ID+"', '"+tbTitle.Text+"', '"+tbDescription.Text+"', '1', '"+dateFormat+"', current_timestamp())";
                }

                Database.connect();
                Database.query(dbQuery);
                if (Database.status) {
                    MessageBox.Show("Poprawnie dodano wydarzenie do bazy danych");
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
