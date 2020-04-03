using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinimize_MouseHover(object sender, EventArgs e)
        {
            Object rm = Properties.Resources.ResourceManager.GetObject("minimize-hover");
            Bitmap icon = (Bitmap)rm;
            btnMinimize.Image = icon;
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            Object rm = Properties.Resources.ResourceManager.GetObject("minimize");
            Bitmap icon = (Bitmap)rm;
            btnMinimize.Image = icon;
        }
    }
}
