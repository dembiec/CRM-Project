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
    public partial class UcCustomers : UserControl
    {
        public UcCustomers()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            UcAddCustomer UcAC = new UcAddCustomer();
            UserControls.show(UcAC, contentPanel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UcCustomers_Load(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text != "") {
                string outData = Regex.Replace(tbSearch.Text, @"('|=|-{2})", string.Empty);
                Database.connect();
                Database.query("SELECT * FROM `customers` WHERE name LIKE '%"+ outData + "%' OR email LIKE '%"+ outData +"%' OR telephone LIKE '%"+ outData +"%'");
                if (Database.status) {
                    if (Database.reader.HasRows) {
                        DataTable table = new DataTable();
                        table.Columns.Add("Id", typeof(int));
                        table.Columns.Add("Imię i Nazwisko", typeof(string));
                        table.Columns.Add("Adres E-mail", typeof(string));
                        table.Columns.Add("Numer Telefonu", typeof(string));
                        table.Columns.Add("Adres Zamieszkania", typeof(string));
                        table.Columns.Add("Dodatkowe Informacje", typeof(string));
                        string description = "";
                        while (Database.reader.Read()) {
                            if (Database.reader.IsDBNull(5)) {
                                description = "-";
                            } else {
                                description = Database.reader.GetString(5);
                            }
                            table.Rows.Add(Database.reader.GetString(0), Database.reader.GetString(1), Database.reader.GetString(2), Database.reader.GetString(3), Database.reader.GetString(4), description);
                        }
                        tblCustomers.DataSource = table;
                    } else {
                        MessageBox.Show("Dane Nie Zostały Znalezione");
                    }
                } else {
                    contentPanel.Dock = DockStyle.Fill;
                    UcDbError UcDE = new UcDbError();
                    UserControls.show(UcDE, contentPanel);
                }
                Database.close();
            }
        }

        private void UcCustomers_Load(object sender, EventArgs e)
        {
            Database.connect();
            Database.query("SELECT * FROM `customers`");
            if (Database.status) {
                if (Database.reader.HasRows) {
                    DataTable table = new DataTable();
                    table.Columns.Add("Id", typeof(int));
                    table.Columns.Add("Imię i Nazwisko", typeof(string));
                    table.Columns.Add("Adres E-mail", typeof(string));
                    table.Columns.Add("Numer Telefonu", typeof(string));
                    table.Columns.Add("Adres Zamieszkania", typeof(string));
                    table.Columns.Add("Dodatkowe Informacje", typeof(string));
                    string description = "";
                    while (Database.reader.Read()) {
                        if (Database.reader.IsDBNull(5)) {
                            description = "-";
                        } else {
                            description = Database.reader.GetString(5);
                        }
                        table.Rows.Add(Database.reader.GetString(0), Database.reader.GetString(1), Database.reader.GetString(2), Database.reader.GetString(3), Database.reader.GetString(4), description);
                    }
                    tblCustomers.DataSource = table;
                } else {
                    Label lblNoData = new Label();
                    lblNoData.Name = "lblNoData";
                    lblNoData.Top = 150;
                    lblNoData.Left = 235;
                    lblNoData.Height = 36;
                    lblNoData.Width = 380;
                    lblNoData.Text = "Brak Danych Do Wyświetlenia";
                    lblNoData.Font = new Font("Calibri", 22);
                    lblNoData.ForeColor = Color.FromArgb(243, 242, 251);
                    tblCustomers.Controls.Add(lblNoData);
                }
            } else {
                contentPanel.Dock = DockStyle.Fill;
                UcDbError UcDE = new UcDbError();
                UserControls.show(UcDE, contentPanel);
            }
            Database.close();
        }
    }
}
