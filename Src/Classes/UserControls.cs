using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_Project.Src.Classes
{
    class UserControls
    {
        public static Control[] elements = new Control[2];

        public static void show(Control control, Control content)
        {
            content.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            content.Controls.Add(control);
        }
    }
}
