﻿namespace CRM_Project
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnGithub = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblAppName = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.leftPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.leftPanel.Controls.Add(this.btnCustomers);
            this.leftPanel.Controls.Add(this.btnHome);
            this.leftPanel.Controls.Add(this.btnGithub);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(100, 561);
            this.leftPanel.TabIndex = 0;
            // 
            // btnCustomers
            // 
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Image = global::CRM_Project.Properties.Resources.customers;
            this.btnCustomers.Location = new System.Drawing.Point(0, 180);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(100, 32);
            this.btnCustomers.TabIndex = 2;
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            this.btnCustomers.MouseLeave += new System.EventHandler(this.btnCustomers_MouseLeave);
            this.btnCustomers.MouseHover += new System.EventHandler(this.btnCustomers_MouseHover);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = global::CRM_Project.Properties.Resources.home;
            this.btnHome.Location = new System.Drawing.Point(0, 120);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(100, 32);
            this.btnHome.TabIndex = 1;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave);
            this.btnHome.MouseHover += new System.EventHandler(this.btnHome_MouseHover);
            // 
            // btnGithub
            // 
            this.btnGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGithub.FlatAppearance.BorderSize = 0;
            this.btnGithub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGithub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGithub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGithub.Image = global::CRM_Project.Properties.Resources.github;
            this.btnGithub.Location = new System.Drawing.Point(0, 20);
            this.btnGithub.Name = "btnGithub";
            this.btnGithub.Size = new System.Drawing.Size(100, 45);
            this.btnGithub.TabIndex = 0;
            this.btnGithub.UseVisualStyleBackColor = true;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.topPanel.Controls.Add(this.btnClose);
            this.topPanel.Controls.Add(this.btnMinimize);
            this.topPanel.Controls.Add(this.lblAppName);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(100, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(884, 60);
            this.topPanel.TabIndex = 1;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::CRM_Project.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(848, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 60);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::CRM_Project.Properties.Resources.minimize;
            this.btnMinimize.Location = new System.Drawing.Point(808, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(16, 60);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnMinimize_MouseLeave);
            this.btnMinimize.MouseHover += new System.EventHandler(this.btnMinimize_MouseHover);
            // 
            // lblAppName
            // 
            this.lblAppName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.lblAppName.Location = new System.Drawing.Point(17, 0);
            this.lblAppName.Margin = new System.Windows.Forms.Padding(0);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(117, 60);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "CRM Project";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(100, 60);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(884, 501);
            this.contentPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRM Project";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.leftPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button btnGithub;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Button btnCustomers;
    }
}

