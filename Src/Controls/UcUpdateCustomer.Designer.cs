namespace CRM_Project.Src.Controls
{
    partial class UcUpdateCustomer
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lbladress = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pbName = new System.Windows.Forms.PictureBox();
            this.pbEmail = new System.Windows.Forms.PictureBox();
            this.pbTelephone = new System.Windows.Forms.PictureBox();
            this.pbAdress = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTelephone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdress)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.tbName.ForeColor = System.Drawing.Color.Black;
            this.tbName.Location = new System.Drawing.Point(20, 60);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(400, 33);
            this.tbName.TabIndex = 0;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            this.tbName.Validated += new System.EventHandler(this.tbName_Validated);
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmail.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.tbEmail.ForeColor = System.Drawing.Color.Black;
            this.tbEmail.Location = new System.Drawing.Point(464, 60);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(400, 33);
            this.tbEmail.TabIndex = 1;
            this.tbEmail.Validated += new System.EventHandler(this.tbEmail_Validated);
            // 
            // tbTelephone
            // 
            this.tbTelephone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.tbTelephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTelephone.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.tbTelephone.ForeColor = System.Drawing.Color.Black;
            this.tbTelephone.Location = new System.Drawing.Point(20, 150);
            this.tbTelephone.MaxLength = 9;
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(400, 33);
            this.tbTelephone.TabIndex = 2;
            this.tbTelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelephone_KeyPress);
            this.tbTelephone.Validated += new System.EventHandler(this.tbTelephone_Validated);
            // 
            // tbAdress
            // 
            this.tbAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.tbAdress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAdress.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.tbAdress.ForeColor = System.Drawing.Color.Black;
            this.tbAdress.Location = new System.Drawing.Point(464, 150);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(400, 33);
            this.tbAdress.TabIndex = 3;
            this.tbAdress.Validated += new System.EventHandler(this.tbAdress_Validated);
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDescription.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.tbDescription.ForeColor = System.Drawing.Color.Black;
            this.tbDescription.Location = new System.Drawing.Point(20, 250);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(844, 162);
            this.tbDescription.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.btnUpdate.Image = global::CRM_Project.Properties.Resources.sm_btn_green;
            this.btnUpdate.Location = new System.Drawing.Point(784, 440);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 35);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Popraw";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(91)))), ((int)(((byte)(112)))));
            this.lblName.Location = new System.Drawing.Point(20, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(114, 19);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Imię i Nazwisko";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(91)))), ((int)(((byte)(112)))));
            this.lblEmail.Location = new System.Drawing.Point(464, 35);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(94, 19);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Adres E-mail";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblTelephone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(91)))), ((int)(((byte)(112)))));
            this.lblTelephone.Location = new System.Drawing.Point(20, 125);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(119, 19);
            this.lblTelephone.TabIndex = 8;
            this.lblTelephone.Text = "Numer Telefonu";
            // 
            // lbladress
            // 
            this.lbladress.AutoSize = true;
            this.lbladress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbladress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(91)))), ((int)(((byte)(112)))));
            this.lbladress.Location = new System.Drawing.Point(464, 125);
            this.lbladress.Name = "lbladress";
            this.lbladress.Size = new System.Drawing.Size(142, 19);
            this.lbladress.TabIndex = 9;
            this.lbladress.Text = "Adres Zamieszkania";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(91)))), ((int)(((byte)(112)))));
            this.lblDescription.Location = new System.Drawing.Point(20, 225);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(255, 19);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Dodatkowe Informacje (opcjonalne)";
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.btnDelete.Image = global::CRM_Project.Properties.Resources.sm_btn_pink;
            this.btnDelete.Location = new System.Drawing.Point(20, 440);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 35);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pbName
            // 
            this.pbName.Location = new System.Drawing.Point(400, 35);
            this.pbName.Name = "pbName";
            this.pbName.Size = new System.Drawing.Size(16, 16);
            this.pbName.TabIndex = 12;
            this.pbName.TabStop = false;
            // 
            // pbEmail
            // 
            this.pbEmail.Location = new System.Drawing.Point(844, 35);
            this.pbEmail.Name = "pbEmail";
            this.pbEmail.Size = new System.Drawing.Size(16, 16);
            this.pbEmail.TabIndex = 13;
            this.pbEmail.TabStop = false;
            // 
            // pbTelephone
            // 
            this.pbTelephone.Location = new System.Drawing.Point(400, 125);
            this.pbTelephone.Name = "pbTelephone";
            this.pbTelephone.Size = new System.Drawing.Size(16, 16);
            this.pbTelephone.TabIndex = 14;
            this.pbTelephone.TabStop = false;
            // 
            // pbAdress
            // 
            this.pbAdress.Location = new System.Drawing.Point(844, 125);
            this.pbAdress.Name = "pbAdress";
            this.pbAdress.Size = new System.Drawing.Size(16, 16);
            this.pbAdress.TabIndex = 15;
            this.pbAdress.TabStop = false;
            // 
            // UcUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.pbAdress);
            this.Controls.Add(this.pbTelephone);
            this.Controls.Add(this.pbEmail);
            this.Controls.Add(this.pbName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lbladress);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbAdress);
            this.Controls.Add(this.tbTelephone);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbName);
            this.Name = "UcUpdateCustomer";
            this.Size = new System.Drawing.Size(884, 501);
            this.Load += new System.EventHandler(this.UcUpdateCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTelephone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lbladress;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pbName;
        private System.Windows.Forms.PictureBox pbEmail;
        private System.Windows.Forms.PictureBox pbTelephone;
        private System.Windows.Forms.PictureBox pbAdress;
    }
}
