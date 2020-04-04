﻿using CRM_Project.Src.Classes;
using CRM_Project.Src.Controls;
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

        }

        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            AppIcons.replace(btnHome, "home-hover");
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            AppIcons.replace(btnHome, "home");
        }
    }
}
