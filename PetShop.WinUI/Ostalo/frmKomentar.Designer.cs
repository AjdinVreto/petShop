
namespace PetShop.WinUI.Ostalo
{
    partial class frmKomentar
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
            this.dgvKomentari = new System.Windows.Forms.DataGridView();
            this.Tekst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProizvodNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnikKorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomentari)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.lblNavigacija);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 51);
            this.panel1.TabIndex = 65;
            // 
            // lblNavigacija
            // 
            this.lblNavigacija.AutoSize = true;
            this.lblNavigacija.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNavigacija.Location = new System.Drawing.Point(419, 12);
            this.lblNavigacija.Name = "lblNavigacija";
            this.lblNavigacija.Size = new System.Drawing.Size(155, 32);
            this.lblNavigacija.TabIndex = 19;
            this.lblNavigacija.Text = "KOMENTARI";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKomentari);
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(944, 537);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Komentari";
            // 
            // dgvKomentari
            // 
            this.dgvKomentari.AllowUserToAddRows = false;
            this.dgvKomentari.AllowUserToDeleteRows = false;
            this.dgvKomentari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKomentari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKomentari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tekst,
            this.Datum,
            this.ProizvodNaziv,
            this.KorisnikKorisnickoIme,
            this.Obrisi});
            this.dgvKomentari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKomentari.Location = new System.Drawing.Point(3, 19);
            this.dgvKomentari.Name = "dgvKomentari";
            this.dgvKomentari.ReadOnly = true;
            this.dgvKomentari.RowTemplate.Height = 25;
            this.dgvKomentari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKomentari.Size = new System.Drawing.Size(938, 515);
            this.dgvKomentari.TabIndex = 0;
            this.dgvKomentari.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKomentari_CellContentClick);
            this.dgvKomentari.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvKomentari_DataError);
            // 
            // Tekst
            // 
            this.Tekst.DataPropertyName = "Tekst";
            this.Tekst.HeaderText = "Tekst";
            this.Tekst.Name = "Tekst";
            this.Tekst.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // ProizvodNaziv
            // 
            this.ProizvodNaziv.DataPropertyName = "ProizvodNaziv";
            this.ProizvodNaziv.HeaderText = "Proizvod";
            this.ProizvodNaziv.Name = "ProizvodNaziv";
            this.ProizvodNaziv.ReadOnly = true;
            // 
            // KorisnikKorisnickoIme
            // 
            this.KorisnikKorisnickoIme.DataPropertyName = "KorisnikKorisnickoIme";
            this.KorisnikKorisnickoIme.HeaderText = "Korisnik";
            this.KorisnikKorisnickoIme.Name = "KorisnikKorisnickoIme";
            this.KorisnikKorisnickoIme.ReadOnly = true;
            // 
            // Obrisi
            // 
            this.Obrisi.DataPropertyName = "Obrisi";
            this.Obrisi.HeaderText = "Obrisi";
            this.Obrisi.Name = "Obrisi";
            this.Obrisi.ReadOnly = true;
            this.Obrisi.Text = "Obrisi";
            this.Obrisi.UseColumnTextForButtonValue = true;
            // 
            // frmKomentar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 628);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmKomentar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKomentar";
            this.Load += new System.EventHandler(this.frmKomentar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomentari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNavigacija;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKomentari;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tekst;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProizvodNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikKorisnickoIme;
        private System.Windows.Forms.DataGridViewButtonColumn Obrisi;
    }
}