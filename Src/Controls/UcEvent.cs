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
    }
}
