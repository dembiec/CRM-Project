using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_Project.Src.Classes
{
    class AppIcons
    {
        public static void replace(Button button, string iconName)
        {
            Object rm = Properties.Resources.ResourceManager.GetObject(iconName);
            Bitmap icon = (Bitmap)rm;
            button.Image = icon;
        }
    }
}
