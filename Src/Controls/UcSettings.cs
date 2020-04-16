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
    public partial class UcSettings : UserControl
    {
        public UcSettings()
        {
            InitializeComponent();
        }

        private void UcSettings_Load(object sender, EventArgs e)
        {
            UcSettingsDatabase UcSD = new UcSettingsDatabase();
            UserControls.show(UcSD, contentPanel);
        }

        private void btnDataBase_Click(object sender, EventArgs e)
        {
            UcSettingsDatabase UcSD = new UcSettingsDatabase();
            UserControls.show(UcSD, contentPanel);
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            UcSettingsAccess UcSA = new UcSettingsAccess();
            UserControls.show(UcSA, contentPanel);
        }
    }
}
