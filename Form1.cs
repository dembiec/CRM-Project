using CRM_Project.Src.Classes;
using CRM_Project.Src.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            this.Activate();

            if (Network.status()) {
                AppIcons.activeMenuItem = btnHome;
                AppIcons.replace(btnHome, "home-hover");

                UserControls.elements[0] = leftPanel;
                UserControls.elements[1] = contentPanel;

                if (Properties.Settings.Default.firstStart) {
                    if (Properties.Settings.Default.accessLock != string.Empty) {
                        leftPanel.Enabled = false;

                        UcAccess UcA = new UcAccess();
                        UserControls.show(UcA, contentPanel);
                    } else {
                        UcHome UcH = new UcHome();
                        UserControls.show(UcH, contentPanel);
                    }
                } else {
                    leftPanel.Enabled = false;

                    UcSettingsDatabase UcSD = new UcSettingsDatabase();
                    UserControls.show(UcSD, contentPanel);
                }
            } else {
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
            if (e.Button == MouseButtons.Left) {
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

        //btnGithub
        private void btnGithub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/dembiec/CRM-Project");
        }

        //btnHome
        private void btnHome_Click(object sender, EventArgs e)
        {
            UcHome UcH = new UcHome();
            UserControls.show(UcH, contentPanel);
        }

        //btnCustomers
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            UcCustomers UcC = new UcCustomers();
            UserControls.show(UcC, contentPanel);
        }

        //btnEvent
        private void btnEvent_Click(object sender, EventArgs e)
        {
            UcEvent UcE = new UcEvent();
            UserControls.show(UcE, contentPanel);
        }

        //btnSettings
        private void btnSettings_Click(object sender, EventArgs e)
        {
            UcSettings UcS = new UcSettings();
            UserControls.show(UcS, contentPanel);
        }

        //btnMenu
        private void btnMenu_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string btnName = btn.Name.Remove(0, 3).ToLower();
            string activeButton = AppIcons.activeMenuItem.Name.Remove(0, 3).ToLower();

            AppIcons.replace(AppIcons.activeMenuItem, activeButton);
            AppIcons.activeMenuItem = btn;
            AppIcons.replace(btn, btnName+"-hover");
        }

        private void btnMenu_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string btnName = btn.Name.Remove(0, 3).ToLower();
            AppIcons.replace(btn, btnName+"-hover");
        }

        private void btnMenu_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string activeElement = AppIcons.activeMenuItem.Name.Remove(0, 3).ToLower();
            string btnName = btn.Name.Remove(0, 3).ToLower();

            if (btnName != activeElement) {
                AppIcons.replace(btn, btnName);
            }
        }
    }
}
