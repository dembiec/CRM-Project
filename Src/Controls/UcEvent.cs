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
    public partial class UcEvent : UserControl
    {
        public UcEvent()
        {
            InitializeComponent();
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            UcAddEvent UcAE = new UcAddEvent();
            contentPanel.Dock = DockStyle.Fill;
            UserControls.show(UcAE, contentPanel);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UcEvent_Load(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text != "") {
                string outData = Regex.Replace(tbSearch.Text, @"('|=|-{2})", string.Empty);
                Database.connect();
                Database.query("SELECT events.id, events.status, events.title, events.description, events.date, customers.name FROM `events` INNER JOIN `customers` ON events.customer_id = customers.id WHERE events.title LIKE '%"+outData+"%' OR customers.name LIKE '%"+outData+"%' ORDER BY events.date ASC");
                if (Database.status) {
                    if (Database.reader.HasRows) {
                        DataTable table = new DataTable();
                        table.Columns.Add("Id", typeof(int));
                        table.Columns.Add("Status", typeof(string));
                        table.Columns.Add("Tytuł", typeof(string));
                        table.Columns.Add("Opis", typeof(string));
                        table.Columns.Add("Data", typeof(string));
                        table.Columns.Add("Imię i Nazwisko Klienta", typeof(string));
                        string description = "";
                        string status = "Aktywne";
                        while (Database.reader.Read()) {
                            if (Database.reader.IsDBNull(3)) {
                                description = "-";
                            } else {
                                description = Database.reader.GetString(3);
                            }

                            if (Database.reader.GetBoolean(1)) {
                                status = "Aktywne";
                            } else {
                                status = "Nieaktywne ";
                            }
                            table.Rows.Add(Database.reader.GetString(0), status, Database.reader.GetString(2), description, Database.reader.GetString(4), Database.reader.GetString(5));
                        }
                        tblEvents.DataSource = table;
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

        private void UcEvent_Load(object sender, EventArgs e)
        {
            Database.connect();
            Database.query("SELECT events.id, events.status, events.title, events.description, events.date, customers.name FROM `events` INNER JOIN `customers` ON events.customer_id = customers.id ORDER BY events.date ASC");
            if (Database.status) {
                if (Database.reader.HasRows) {
                    DataTable table = new DataTable();
                    table.Columns.Add("Id", typeof(int));
                    table.Columns.Add("Status", typeof(string));
                    table.Columns.Add("Tytuł", typeof(string));
                    table.Columns.Add("Opis", typeof(string));
                    table.Columns.Add("Data", typeof(string));
                    table.Columns.Add("Imię i Nazwisko Klienta", typeof(string));
                    string description = "";
                    string status = "Aktywne";
                    while (Database.reader.Read()) {
                        if (Database.reader.IsDBNull(3)) {
                            description = "-";
                        } else {
                            description = Database.reader.GetString(3);
                        }

                        if (Database.reader.GetBoolean(1)) {
                            status = "Aktywne";
                        } else {
                            status = "Nieaktywne ";
                        }
                        table.Rows.Add(Database.reader.GetString(0), status, Database.reader.GetString(2), description, Database.reader.GetString(4), Database.reader.GetString(5));
                    }
                    tblEvents.DataSource = table;
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
                    tblEvents.Controls.Add(lblNoData);
                }
            } else {
                contentPanel.Dock = DockStyle.Fill;
                UcDbError UcDE = new UcDbError();
                UserControls.show(UcDE, contentPanel);
            }
            Database.close();
        }

        private void tblEvents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(tblEvents.Rows[e.RowIndex].Cells[0].Value.ToString());
            UcUpdateEvent UcUE = new UcUpdateEvent(id);
            contentPanel.Dock = DockStyle.Fill;
            UserControls.show(UcUE, contentPanel);
        }
    }
}
