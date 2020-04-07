namespace CRM_Project.Src.Controls
{
    partial class UcAddCustomer
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
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.pbName = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.pbEmail = new System.Windows.Forms.PictureBox();
            this.pbTelephone = new System.Windows.Forms.PictureBox();
            this.pbAdress = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTelephone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdress)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbEmail.ForeColor = System.Drawing.Color.Black;
            this.tbEmail.Location = new System.Drawing.Point(464, 60);
            this.tbEmail.MaxLength = 50;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(400, 26);
            this.tbEmail.TabIndex = 1;
            this.tbEmail.Validated += new System.EventHandler(this.tbEmail_Validated);
            // 
            // tbAdress
            // 
            this.tbAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.tbAdress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAdress.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbAdress.ForeColor = System.Drawing.Color.Black;
            this.tbAdress.Location = new System.Drawing.Point(464, 130);
            this.tbAdress.MaxLength = 100;
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(400, 26);
            this.tbAdress.TabIndex = 2;
            this.tbAdress.Validated += new System.EventHandler(this.tbAdress_Validated);
            // 
            // tbTelephone
            // 
            this.tbTelephone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.tbTelephone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTelephone.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbTelephone.ForeColor = System.Drawing.Color.Black;
            this.tbTelephone.Location = new System.Drawing.Point(20, 130);
            this.tbTelephone.MaxLength = 9;
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(400, 26);
            this.tbTelephone.TabIndex = 3;
            this.tbTelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelephone_KeyPress);
            this.tbTelephone.Validated += new System.EventHandler(this.tbTelephone_Validated);
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescription.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDescription.ForeColor = System.Drawing.Color.Black;
            this.tbDescription.Location = new System.Drawing.Point(20, 200);
            this.tbDescription.MaxLength = 300;
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescription.Size = new System.Drawing.Size(844, 150);
            this.tbDescription.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
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
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(91)))), ((int)(((byte)(112)))));
            this.lblEmail.Location = new System.Drawing.Point(464, 35);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(94, 19);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Adres E-mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(91)))), ((int)(((byte)(112)))));
            this.label1.Location = new System.Drawing.Point(20, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Numer Telefonu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(91)))), ((int)(((byte)(112)))));
            this.label2.Location = new System.Drawing.Point(464, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Adres Zamieszkania";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(91)))), ((int)(((byte)(112)))));
            this.label3.Location = new System.Drawing.Point(20, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Dodatkowe Informacje (opcjonalne)";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbName.ForeColor = System.Drawing.Color.Black;
            this.tbName.Location = new System.Drawing.Point(20, 60);
            this.tbName.MaxLength = 50;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(400, 26);
            this.tbName.TabIndex = 12;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            this.tbName.Validated += new System.EventHandler(this.tbName_Validated);
            // 
            // pbName
            // 
            this.pbName.Location = new System.Drawing.Point(400, 35);
            this.pbName.Name = "pbName";
            this.pbName.Size = new System.Drawing.Size(16, 16);
            this.pbName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbName.TabIndex = 13;
            this.pbName.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.btnClear.Image = global::CRM_Project.Properties.Resources.sm_btn_pink;
            this.btnClear.Location = new System.Drawing.Point(20, 395);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 35);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Wyczyść";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.btnInsert.Image = global::CRM_Project.Properties.Resources.sm_btn_green;
            this.btnInsert.Location = new System.Drawing.Point(784, 395);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(80, 35);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Dodaj";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // pbEmail
            // 
            this.pbEmail.Location = new System.Drawing.Point(844, 35);
            this.pbEmail.Name = "pbEmail";
            this.pbEmail.Size = new System.Drawing.Size(16, 16);
            this.pbEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbEmail.TabIndex = 14;
            this.pbEmail.TabStop = false;
            // 
            // pbTelephone
            // 
            this.pbTelephone.Location = new System.Drawing.Point(400, 105);
            this.pbTelephone.Name = "pbTelephone";
            this.pbTelephone.Size = new System.Drawing.Size(16, 16);
            this.pbTelephone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbTelephone.TabIndex = 15;
            this.pbTelephone.TabStop = false;
            // 
            // pbAdress
            // 
            this.pbAdress.Location = new System.Drawing.Point(844, 105);
            this.pbAdress.Name = "pbAdress";
            this.pbAdress.Size = new System.Drawing.Size(16, 16);
            this.pbAdress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAdress.TabIndex = 16;
            this.pbAdress.TabStop = false;
            // 
            // UcAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.pbAdress);
            this.Controls.Add(this.pbTelephone);
            this.Controls.Add(this.pbEmail);
            this.Controls.Add(this.pbName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.tbTelephone);
            this.Controls.Add(this.tbAdress);
            this.Controls.Add(this.tbEmail);
            this.Name = "UcAddCustomer";
            this.Size = new System.Drawing.Size(884, 450);
            ((System.ComponentModel.ISupportInitialize)(this.pbName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTelephone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.PictureBox pbName;
        private System.Windows.Forms.PictureBox pbEmail;
        private System.Windows.Forms.PictureBox pbTelephone;
        private System.Windows.Forms.PictureBox pbAdress;
    }
}
