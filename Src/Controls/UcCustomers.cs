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
    }
}
