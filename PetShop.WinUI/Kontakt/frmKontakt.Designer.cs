
namespace PetShop.WinUI.Kontakt
{
    partial class frmKontakt
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNavigacija = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKontakt = new System.Windows.Forms.DataGridView();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tekst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odgovoreno = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Obris = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtOdgovor = new System.Windows.Forms.TextBox();
            this.lblGrad = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOdgovor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKontakt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.lblNavigacija);
            this.panel1.Location = new System.Drawing.Point(8, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 44);
            this.panel1.TabIndex = 36;
            // 
            // lblNavigacija
            // 
            this.lblNavigacija.AutoSize = true;
            this.lblNavigacija.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblNavigacija.Location = new System.Drawing.Point(285, 9);
            this.lblNavigacija.Name = "lblNavigacija";
            this.lblNavigacija.Size = new System.Drawing.Size(126, 32);
            this.lblNavigacija.TabIndex = 19;
            this.lblNavigacija.Text = "KONTAKT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKontakt);
            this.groupBox1.Location = new System.Drawing.Point(11, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 386);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kontakt poruke";
            // 
            // dgvKontakt
            // 
            this.dgvKontakt.AllowUserToAddRows = false;
            this.dgvKontakt.AllowUserToDeleteRows = false;
            this.dgvKontakt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKontakt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKontakt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePrezime,
            this.Email,
            this.Tekst,
            this.Odgovoreno,
            this.Obris});
            this.dgvKontakt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKontakt.Location = new System.Drawing.Point(3, 16);
            this.dgvKontakt.Name = "dgvKontakt";
            this.dgvKontakt.ReadOnly = true;
            this.dgvKontakt.RowTemplate.Height = 25;
            this.dgvKontakt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKontakt.Size = new System.Drawing.Size(661, 367);
            this.dgvKontakt.TabIndex = 0;
            this.dgvKontakt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKontakt_CellContentClick);
            this.dgvKontakt.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKontakt_CellDoubleClick);
            this.dgvKontakt.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvKontakt_DataError);
            // 
            // ImePrezime
            // 
            this.ImePrezime.DataPropertyName = "ImePrezime";
            this.ImePrezime.HeaderText = "Ime i prezime";
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Tekst
            // 
            this.Tekst.DataPropertyName = "Tekst";
            this.Tekst.HeaderText = "Tekst poruke";
            this.Tekst.Name = "Tekst";
            this.Tekst.ReadOnly = true;
            // 
            // Odgovoreno
            // 
            this.Odgovoreno.DataPropertyName = "Odgovoreno";
            this.Odgovoreno.HeaderText = "Odgovoreno";
            this.Odgovoreno.Name = "Odgovoreno";
            this.Odgovoreno.ReadOnly = true;
            // 
            // Obris
            // 
            this.Obris.DataPropertyName = "Obrisi";
            this.Obris.HeaderText = "Obrisi";
            this.Obris.Name = "Obris";
            this.Obris.ReadOnly = true;
            this.Obris.Text = "Obrisi";
            this.Obris.UseColumnTextForButtonValue = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtEmail.Location = new System.Drawing.Point(242, 83);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(193, 33);
            this.txtEmail.TabIndex = 38;
            // 
            // txtOdgovor
            // 
            this.txtOdgovor.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtOdgovor.Location = new System.Drawing.Point(120, 144);
            this.txtOdgovor.Multiline = true;
            this.txtOdgovor.Name = "txtOdgovor";
            this.txtOdgovor.Size = new System.Drawing.Size(444, 88);
            this.txtOdgovor.TabIndex = 39;
            // 
            // lblGrad
            // 
            this.lblGrad.AutoSize = true;
            this.lblGrad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGrad.Location = new System.Drawing.Point(312, 62);
            this.lblGrad.Name = "lblGrad";
            this.lblGrad.Size = new System.Drawing.Size(53, 21);
            this.lblGrad.TabIndex = 40;
            this.lblGrad.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(303, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 21);
            this.label7.TabIndex = 41;
            this.label7.Text = "Odgovor";
            // 
            // btnOdgovor
            // 
            this.btnOdgovor.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOdgovor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdgovor.ForeColor = System.Drawing.Color.White;
            this.btnOdgovor.Location = new System.Drawing.Point(281, 238);
            this.btnOdgovor.Name = "btnOdgovor";
            this.btnOdgovor.Size = new System.Drawing.Size(120, 50);
            this.btnOdgovor.TabIndex = 42;
            this.btnOdgovor.Text = "Odgovori";
            this.btnOdgovor.UseVisualStyleBackColor = false;
            this.btnOdgovor.Click += new System.EventHandler(this.btnOdgovor_Click);
            // 
            // frmKontakt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 679);
            this.Controls.Add(this.btnOdgovor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblGrad);
            this.Controls.Add(this.txtOdgovor);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmKontakt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKontakt";
            this.Load += new System.EventHandler(this.frmKontakt_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKontakt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNavigacija;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKontakt;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtOdgovor;
        private System.Windows.Forms.Label lblGrad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOdgovor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tekst;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Odgovoreno;
        private System.Windows.Forms.DataGridViewButtonColumn Obris;
    }
}