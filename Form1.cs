using CRM_Project.Src.Classes;
using CRM_Project.Src.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_Project
{
    public partial class MainForm : Form
    {
        //MainForm
        public MainForm()
        {
            Thread splashScreen = new Thread(new ThreadStart(StartForm));
            splashScreen.Start();
            Thread.Sleep(3000);
            InitializeComponent();
            splashScreen.Abort();
        }

        public void StartForm()
        {
            Application.Run(new FormSplash());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Network.status())
            {
                UcHome UcH = new UcHome();
                UserControls.show(UcH, contentPanel);
            }
            else
            {
                leftPanel.Enabled = false;
                UcNetwork UcN = new UcNetwork();
                UserControls.show(UcN, contentPanel);
            }            
        }

        //topPanel
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        Point lastPoint;

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        //btnMinimize
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinimize_MouseHover(object sender, EventArgs e)
        {
            AppIcons.replace(btnMinimize, "minimize-hover");
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            AppIcons.replace(btnMinimize, "minimize");
        }

        //btnClose
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            AppIcons.replace(btnClose, "close-hover");
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            AppIcons.replace(btnClose, "close");
        }

        //btnHome
        private void btnHome_Click(object sender, EventArgs e)
        {
            UcHome UcH = new UcHome();
            UserControls.show(UcH, contentPanel);
        }

        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            AppIcons.replace(btnHome, "home-hover");
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            AppIcons.replace(btnHome, "home");
        }

        //btnCustomers
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            UcCustomers UcC = new UcCustomers();
            UserControls.show(UcC, contentPanel);
        }

        private void btnCustomers_MouseHover(object sender, EventArgs e)
        {
            AppIcons.replace(btnCustomers, "customers-hover");
        }

        private void btnCustomers_MouseLeave(object sender, EventArgs e)
        {
            AppIcons.replace(btnCustomers, "customers");
        }

        //btnEvent
        private void btnEvent_Click(object sender, EventArgs e)
        {
            UcEvent UcE = new UcEvent();
            UserControls.show(UcE, contentPanel);
        }

        private void btnEvent_MouseHover(object sender, EventArgs e)
        {
            AppIcons.replace(btnEvent, "event-hover");
        }

        private void btnEvent_MouseLeave(object sender, EventArgs e)
        {
            AppIcons.replace(btnEvent, "event");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            UcSettings UcS = new UcSettings();
            UserControls.show(UcS, contentPanel);
        }

        private void btnSettings_MouseHover(object sender, EventArgs e)
        {
            AppIcons.replace(btnSettings, "settings-hover");
        }

        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            AppIcons.replace(btnSettings, "settings");
        }
    }
}
