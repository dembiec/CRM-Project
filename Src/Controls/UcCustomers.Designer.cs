namespace CRM_Project.Src.Controls
{
    partial class UcCustomers
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
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.FlatAppearance.BorderSize = 0;
            this.btnAddCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.btnAddCustomer.Image = global::CRM_Project.Properties.Resources.btn_green;
            this.btnAddCustomer.Location = new System.Drawing.Point(20, 10);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(120, 40);
            this.btnAddCustomer.TabIndex = 0;
            this.btnAddCustomer.Text = " Dodaj Klienta";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // UcCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.btnAddCustomer);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "UcCustomers";
            this.Size = new System.Drawing.Size(884, 501);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddCustomer;
    }
}
