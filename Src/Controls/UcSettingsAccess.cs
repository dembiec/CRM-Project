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
    public partial class UcSettingsAccess : UserControl
    {
        public UcSettingsAccess()
        {
            InitializeComponent();
        }

        private void UcSettingsAccess_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.accessLock == string.Empty) {
                cbAccesLock.Checked = false;
                tbAccessPin.Text = string.Empty;
            } else {
                cbAccesLock.Checked = true;
                tbAccessPin.Text = Properties.Settings.Default.accessLock;
            }
        }

        private void tbAccessPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbAccessPin.TextLength >= 4) {
                if (cbAccesLock.Checked) {
                    Properties.Settings.Default.accessLock = tbAccessPin.Text;
                    Properties.Settings.Default.Save();
                } else {
                    Properties.Settings.Default.accessLock = string.Empty;
                    Properties.Settings.Default.Save();
                }
                UcSettingsAccess_Load(sender, e);
                MessageBox.Show("Poprawnie zapisano ustawienia");
            } else {
                MessageBox.Show("Pin musi mieć minimum cztery znaki");
            } 
        }
    }
}
