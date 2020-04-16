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
    public partial class UcAccess : UserControl
    {
        public UcAccess()
        {
            InitializeComponent();
        }

        private void tbAccessPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void addNumber_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (tbAccessPin.TextLength < tbAccessPin.MaxLength) {
                tbAccessPin.Text += btn.Text;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbAccessPin.Text = string.Empty;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (tbAccessPin.TextLength < 4) {
                MessageBox.Show("Pin wymaga minimum czterech znaków");
            } else {
                if (Properties.Settings.Default.accessLock == tbAccessPin.Text) {
                    UserControls.elements[0].Enabled = true;
                    UcHome UcH = new UcHome();
                    UserControls.show(UcH, UserControls.elements[1]);

                } else {
                    MessageBox.Show("Błędny pin");
                }
            }
        }
    }
}
