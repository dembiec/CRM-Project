using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_Project.Src.Controls
{
    public partial class UcSettingsDatabase : UserControl
    {
        public UcSettingsDatabase()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*Properties.SettingsDatabase.Default.Host = tbHost.Text;
            Properties.SettingsDatabase.Default.User = tbUser.Text;
            Properties.SettingsDatabase.Default.Password = tbPassword.Text;
            Properties.SettingsDatabase.Default.Database = tbDatabase.Text;
            Properties.SettingsDatabase.Default.Save();*/
        }
    }
}
