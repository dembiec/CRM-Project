namespace CRM_Project.Src.Controls
{
    partial class UcSettingsAccess
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
            this.lblAccessPin = new System.Windows.Forms.Label();
            this.tbAccessPin = new System.Windows.Forms.TextBox();
            this.cbAccesLock = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAccessPin
            // 
            this.lblAccessPin.AutoSize = true;
            this.lblAccessPin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblAccessPin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(91)))), ((int)(((byte)(112)))));
            this.lblAccessPin.Location = new System.Drawing.Point(20, 200);
            this.lblAccessPin.Name = "lblAccessPin";
            this.lblAccessPin.Size = new System.Drawing.Size(274, 19);
            this.lblAccessPin.TabIndex = 0;
            this.lblAccessPin.Text = "Pin zabezpieczający dostęp do aplikacji";
            // 
            // tbAccessPin
            // 
            this.tbAccessPin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.tbAccessPin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAccessPin.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.tbAccessPin.ForeColor = System.Drawing.Color.Black;
            this.tbAccessPin.Location = new System.Drawing.Point(20, 225);
            this.tbAccessPin.MaxLength = 16;
            this.tbAccessPin.Name = "tbAccessPin";
            this.tbAccessPin.PasswordChar = '*';
            this.tbAccessPin.Size = new System.Drawing.Size(300, 33);
            this.tbAccessPin.TabIndex = 1;
            this.tbAccessPin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAccessPin_KeyPress);
            // 
            // cbAccesLock
            // 
            this.cbAccesLock.AutoSize = true;
            this.cbAccesLock.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.cbAccesLock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(91)))), ((int)(((byte)(112)))));
            this.cbAccesLock.Location = new System.Drawing.Point(24, 135);
            this.cbAccesLock.Name = "cbAccesLock";
            this.cbAccesLock.Size = new System.Drawing.Size(138, 23);
            this.cbAccesLock.TabIndex = 2;
            this.cbAccesLock.Text = "Zablokuj dostęp";
            this.cbAccesLock.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(195)))), ((int)(((byte)(93)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(195)))), ((int)(((byte)(93)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(176)))), ((int)(((byte)(81)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.btnSave.Location = new System.Drawing.Point(714, 395);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 35);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Zapisz Ustawienia";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // UcSettingsAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbAccesLock);
            this.Controls.Add(this.tbAccessPin);
            this.Controls.Add(this.lblAccessPin);
            this.Name = "UcSettingsAccess";
            this.Size = new System.Drawing.Size(884, 450);
            this.Load += new System.EventHandler(this.UcSettingsAccess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccessPin;
        private System.Windows.Forms.TextBox tbAccessPin;
        private System.Windows.Forms.CheckBox cbAccesLock;
        private System.Windows.Forms.Button btnSave;
    }
}
