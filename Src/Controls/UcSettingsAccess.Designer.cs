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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.tbAccessPin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(91)))), ((int)(((byte)(112)))));
            this.checkBox1.Location = new System.Drawing.Point(24, 135);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(138, 23);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Zablokuj dostęp";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(195)))), ((int)(((byte)(93)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(195)))), ((int)(((byte)(93)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(176)))), ((int)(((byte)(81)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.button1.Location = new System.Drawing.Point(714, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Zapisz Ustawienia";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // UcSettingsAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tbAccessPin);
            this.Controls.Add(this.lblAccessPin);
            this.Name = "UcSettingsAccess";
            this.Size = new System.Drawing.Size(884, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccessPin;
        private System.Windows.Forms.TextBox tbAccessPin;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
    }
}
