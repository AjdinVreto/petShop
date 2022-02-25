
namespace PetShop.WinUI.Korisnici
{
    partial class frmPregledUposlenika
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
            this.dgvUposlenici = new System.Windows.Forms.DataGridView();
            this.KorisnikIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnikPrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnikEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumZaposlenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PoslovnicaAdresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblDatumZaposlenja = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.dtpDatumZaposlenja = new System.Windows.Forms.DateTimePicker();
            this.cbAktivan = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbPoslovnice = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSacuvajUposlenika = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUposlenici)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.lblNavigacija);
            this.panel1.Location = new System.Drawing.Point(9, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 56);
            this.panel1.TabIndex = 34;
            // 
            // lblNavigacija
            // 
            this.lblNavigacija.AutoSize = true;
            this.lblNavigacija.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNavigacija.Location = new System.Drawing.Point(225, 12);
            this.lblNavigacija.Name = "lblNavigacija";
            this.lblNavigacija.Size = new System.Drawing.Size(362, 32);
            this.lblNavigacija.TabIndex = 20;
            this.lblNavigacija.Text = "UPRAVLJANJE UPOSLENICIMA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvUposlenici);
            this.groupBox1.Location = new System.Drawing.Point(15, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(857, 459);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uposlenici";
            // 
            // dgvUposlenici
            // 
            this.dgvUposlenici.AllowUserToAddRows = false;
            this.dgvUposlenici.AllowUserToDeleteRows = false;
            this.dgvUposlenici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUposlenici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KorisnikIme,
            this.KorisnikPrezime,
            this.KorisnikEmail,
            this.DatumZaposlenja,
            this.PoslovnicaAdresa,
            this.Aktivan});
            this.dgvUposlenici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUposlenici.Location = new System.Drawing.Point(3, 19);
            this.dgvUposlenici.Name = "dgvUposlenici";
            this.dgvUposlenici.ReadOnly = true;
            this.dgvUposlenici.RowTemplate.Height = 25;
            this.dgvUposlenici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUposlenici.Size = new System.Drawing.Size(851, 437);
            this.dgvUposlenici.TabIndex = 0;
            this.dgvUposlenici.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUposlenici_CellDoubleClick);
            this.dgvUposlenici.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvUposlenici_DataError);
            // 
            // KorisnikIme
            // 
            this.KorisnikIme.DataPropertyName = "KorisnikIme";
            this.KorisnikIme.HeaderText = "Ime";
            this.KorisnikIme.Name = "KorisnikIme";
            this.KorisnikIme.ReadOnly = true;
            // 
            // KorisnikPrezime
            // 
            this.KorisnikPrezime.DataPropertyName = "KorisnikPrezime";
            this.KorisnikPrezime.HeaderText = "Prezime";
            this.KorisnikPrezime.Name = "KorisnikPrezime";
            this.KorisnikPrezime.ReadOnly = true;
            // 
            // KorisnikEmail
            // 
            this.KorisnikEmail.DataPropertyName = "KorisnikEmail";
            this.KorisnikEmail.HeaderText = "Email";
            this.KorisnikEmail.Name = "KorisnikEmail";
            this.KorisnikEmail.ReadOnly = true;
            // 
            // DatumZaposlenja
            // 
            this.DatumZaposlenja.DataPropertyName = "DatumZaposlenja";
            this.DatumZaposlenja.HeaderText = "Datum Zaposlenja";
            this.DatumZaposlenja.Name = "DatumZaposlenja";
            this.DatumZaposlenja.ReadOnly = true;
            // 
            // PoslovnicaAdresa
            // 
            this.PoslovnicaAdresa.DataPropertyName = "PoslovnicaAdresa";
            this.PoslovnicaAdresa.HeaderText = "Adresa poslovnice";
            this.PoslovnicaAdresa.Name = "PoslovnicaAdresa";
            this.PoslovnicaAdresa.ReadOnly = true;
            // 
            // Aktivan
            // 
            this.Aktivan.DataPropertyName = "Aktivan";
            this.Aktivan.HeaderText = "Aktivan";
            this.Aktivan.Name = "Aktivan";
            this.Aktivan.ReadOnly = true;
            // 
            // lblDatumZaposlenja
            // 
            this.lblDatumZaposlenja.AutoSize = true;
            this.lblDatumZaposlenja.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDatumZaposlenja.Location = new System.Drawing.Point(177, 83);
            this.lblDatumZaposlenja.Name = "lblDatumZaposlenja";
            this.lblDatumZaposlenja.Size = new System.Drawing.Size(164, 25);
            this.lblDatumZaposlenja.TabIndex = 42;
            this.lblDatumZaposlenja.Text = "Datum zaposlenja";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKorisnickoIme.Location = new System.Drawing.Point(559, 192);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(244, 29);
            this.txtKorisnickoIme.TabIndex = 41;
            // 
            // dtpDatumZaposlenja
            // 
            this.dtpDatumZaposlenja.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDatumZaposlenja.Location = new System.Drawing.Point(116, 111);
            this.dtpDatumZaposlenja.Name = "dtpDatumZaposlenja";
            this.dtpDatumZaposlenja.Size = new System.Drawing.Size(270, 29);
            this.dtpDatumZaposlenja.TabIndex = 45;
            // 
            // cbAktivan
            // 
            this.cbAktivan.AutoSize = true;
            this.cbAktivan.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbAktivan.Location = new System.Drawing.Point(193, 187);
            this.cbAktivan.Name = "cbAktivan";
            this.cbAktivan.Size = new System.Drawing.Size(99, 29);
            this.cbAktivan.TabIndex = 46;
            this.cbAktivan.Text = "Aktivan";
            this.cbAktivan.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(559, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 25);
            this.label7.TabIndex = 47;
            this.label7.Text = "Korisničko ime uposlenika";
            // 
            // cmbPoslovnice
            // 
            this.cmbPoslovnice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbPoslovnice.FormattingEnabled = true;
            this.cmbPoslovnice.Location = new System.Drawing.Point(559, 111);
            this.cmbPoslovnice.Name = "cmbPoslovnice";
            this.cmbPoslovnice.Size = new System.Drawing.Size(244, 29);
            this.cmbPoslovnice.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(630, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 25);
            this.label8.TabIndex = 49;
            this.label8.Text = "Poslovnica";
            // 
            // btnSacuvajUposlenika
            // 
            this.btnSacuvajUposlenika.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSacuvajUposlenika.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSacuvajUposlenika.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSacuvajUposlenika.Location = new System.Drawing.Point(377, 239);
            this.btnSacuvajUposlenika.Name = "btnSacuvajUposlenika";
            this.btnSacuvajUposlenika.Size = new System.Drawing.Size(152, 53);
            this.btnSacuvajUposlenika.TabIndex = 50;
            this.btnSacuvajUposlenika.Text = "Sačuvaj uposlenika";
            this.btnSacuvajUposlenika.UseVisualStyleBackColor = false;
            this.btnSacuvajUposlenika.Click += new System.EventHandler(this.btnSacuvajUposlenika_Click);
            // 
            // frmPregledUposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 775);
            this.Controls.Add(this.btnSacuvajUposlenika);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbPoslovnice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbAktivan);
            this.Controls.Add(this.dtpDatumZaposlenja);
            this.Controls.Add(this.lblDatumZaposlenja);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmPregledUposlenika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPregledUposlenika";
            this.Load += new System.EventHandler(this.frmPregledUposlenika_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUposlenici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUposlenici;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikPrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumZaposlenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoslovnicaAdresa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aktivan;
        private System.Windows.Forms.Label lblDatumZaposlenja;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.DateTimePicker dtpDatumZaposlenja;
        private System.Windows.Forms.CheckBox cbAktivan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPoslovnice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSacuvajUposlenika;
        private System.Windows.Forms.Label lblNavigacija;
    }
}