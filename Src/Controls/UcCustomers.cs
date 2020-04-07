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

        private void UcCustomers_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Imię i Nazwisko", typeof(string));
            table.Columns.Add("Adres E-mail", typeof(string));
            table.Columns.Add("Numer Telefonu", typeof(int));

            for (int i = 1; i <= 100; i++) {
                table.Rows.Add(i, "Dominik Rembis", "dominik.rembis@vp.pl", 795167676);
            }

            tblCustomers.DataSource = table;
        }
    }
}
