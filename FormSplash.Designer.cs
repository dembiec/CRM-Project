namespace CRM_Project
{
    partial class FormSplash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSplash));
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.label1.Location = new System.Drawing.Point(253, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "CRM Project";
            this.label1.UseWaitCursor = true;
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(195)))), ((int)(((byte)(93)))));
            this.progressBar.Location = new System.Drawing.Point(20, 360);
            this.progressBar.MarqueeAnimationSpeed = 1000;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(660, 20);
            this.progressBar.TabIndex = 1;
            this.progressBar.UseWaitCursor = true;
            this.progressBar.Value = 100;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRM Project";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.FormSplash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer;
    }
}