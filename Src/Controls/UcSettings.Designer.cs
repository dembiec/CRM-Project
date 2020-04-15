namespace CRM_Project.Src.Controls
{
    partial class UcSettings
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.contentPanel = new System.Windows.Forms.Panel();
            this.btnDataBase = new System.Windows.Forms.Button();
            this.btnAccess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Location = new System.Drawing.Point(0, 50);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(884, 450);
            this.contentPanel.TabIndex = 0;
            // 
            // btnDataBase
            // 
            this.btnDataBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(195)))), ((int)(((byte)(93)))));
            this.btnDataBase.FlatAppearance.BorderSize = 0;
            this.btnDataBase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(195)))), ((int)(((byte)(93)))));
            this.btnDataBase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(176)))), ((int)(((byte)(81)))));
            this.btnDataBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataBase.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnDataBase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.btnDataBase.Location = new System.Drawing.Point(20, 15);
            this.btnDataBase.Name = "btnDataBase";
            this.btnDataBase.Size = new System.Drawing.Size(110, 33);
            this.btnDataBase.TabIndex = 1;
            this.btnDataBase.Text = "Baza Danych";
            this.btnDataBase.UseVisualStyleBackColor = false;
            this.btnDataBase.Click += new System.EventHandler(this.btnDataBase_Click);
            // 
            // btnAccess
            // 
            this.btnAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(195)))), ((int)(((byte)(93)))));
            this.btnAccess.FlatAppearance.BorderSize = 0;
            this.btnAccess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(195)))), ((int)(((byte)(93)))));
            this.btnAccess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(176)))), ((int)(((byte)(81)))));
            this.btnAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccess.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnAccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.btnAccess.Location = new System.Drawing.Point(150, 15);
            this.btnAccess.Name = "btnAccess";
            this.btnAccess.Size = new System.Drawing.Size(70, 33);
            this.btnAccess.TabIndex = 2;
            this.btnAccess.Text = "Dostęp";
            this.btnAccess.UseVisualStyleBackColor = false;
            this.btnAccess.Click += new System.EventHandler(this.btnAccess_Click);
            // 
            // UcSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.btnAccess);
            this.Controls.Add(this.btnDataBase);
            this.Controls.Add(this.contentPanel);
            this.Name = "UcSettings";
            this.Size = new System.Drawing.Size(884, 501);
            this.Load += new System.EventHandler(this.UcSettings_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Button btnDataBase;
        private System.Windows.Forms.Button btnAccess;
    }
}
