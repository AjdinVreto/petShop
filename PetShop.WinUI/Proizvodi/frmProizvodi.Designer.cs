
namespace PetShop.WinUI.Proizvodi
{
    partial class frmProizvodi
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
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbProizvodjac = new System.Windows.Forms.ComboBox();
            this.pbxSlika = new System.Windows.Forms.PictureBox();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.gbxProizvodi = new System.Windows.Forms.GroupBox();
            this.dgvProizvodi = new System.Windows.Forms.DataGridView();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategorija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proizvodjac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSacuvajProizvod = new System.Windows.Forms.Button();
            this.ofdSlika = new System.Windows.Forms.OpenFileDialog();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSlika)).BeginInit();
            this.gbxProizvodi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.lblNavigacija);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 45);
            this.panel1.TabIndex = 36;
            // 
            // lblNavigacija
            // 
            this.lblNavigacija.AutoSize = true;
            this.lblNavigacija.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblNavigacija.Location = new System.Drawing.Point(311, 9);
            this.lblNavigacija.Name = "lblNavigacija";
            this.lblNavigacija.Size = new System.Drawing.Size(357, 32);
            this.lblNavigacija.TabIndex = 19;
            this.lblNavigacija.Text = "UPRAVLJANJE PROIZVODIMA";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtNaziv.Location = new System.Drawing.Point(146, 87);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(174, 33);
            this.txtNaziv.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(211, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 21);
            this.label7.TabIndex = 38;
            this.label7.Text = "Naziv";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(445, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 21);
            this.label8.TabIndex = 40;
            this.label8.Text = "Opis";
            // 
            // txtOpis
            // 
            this.txtOpis.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtOpis.Location = new System.Drawing.Point(376, 149);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(174, 103);
            this.txtOpis.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(441, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 21);
            this.label9.TabIndex = 42;
            this.label9.Text = "Cijena";
            // 
            // txtCijena
            // 
            this.txtCijena.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtCijena.Location = new System.Drawing.Point(376, 83);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(174, 33);
            this.txtCijena.TabIndex = 41;
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(146, 149);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(174, 33);
            this.cmbKategorija.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(197, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 21);
            this.label10.TabIndex = 44;
            this.label10.Text = "Kategorija";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(192, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 21);
            this.label11.TabIndex = 46;
            this.label11.Text = "Proizvođač";
            // 
            // cmbProizvodjac
            // 
            this.cmbProizvodjac.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cmbProizvodjac.FormattingEnabled = true;
            this.cmbProizvodjac.Location = new System.Drawing.Point(146, 223);
            this.cmbProizvodjac.Name = "cmbProizvodjac";
            this.cmbProizvodjac.Size = new System.Drawing.Size(174, 33);
            this.cmbProizvodjac.TabIndex = 45;
            // 
            // pbxSlika
            // 
            this.pbxSlika.Location = new System.Drawing.Point(593, 84);
            this.pbxSlika.Name = "pbxSlika";
            this.pbxSlika.Size = new System.Drawing.Size(179, 133);
            this.pbxSlika.TabIndex = 47;
            this.pbxSlika.TabStop = false;
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajSliku.Location = new System.Drawing.Point(644, 223);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(82, 44);
            this.btnDodajSliku.TabIndex = 48;
            this.btnDodajSliku.Text = "...";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // gbxProizvodi
            // 
            this.gbxProizvodi.Controls.Add(this.dgvProizvodi);
            this.gbxProizvodi.Location = new System.Drawing.Point(9, 316);
            this.gbxProizvodi.Name = "gbxProizvodi";
            this.gbxProizvodi.Size = new System.Drawing.Size(871, 324);
            this.gbxProizvodi.TabIndex = 49;
            this.gbxProizvodi.TabStop = false;
            this.gbxProizvodi.Text = "Proizvodi";
            // 
            // dgvProizvodi
            // 
            this.dgvProizvodi.AllowUserToAddRows = false;
            this.dgvProizvodi.AllowUserToDeleteRows = false;
            this.dgvProizvodi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.Slika,
            this.Cijena,
            this.Opis,
            this.Kategorija,
            this.Proizvodjac,
            this.Obrisi});
            this.dgvProizvodi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProizvodi.Location = new System.Drawing.Point(3, 16);
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.ReadOnly = true;
            this.dgvProizvodi.RowTemplate.Height = 25;
            this.dgvProizvodi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProizvodi.Size = new System.Drawing.Size(865, 305);
            this.dgvProizvodi.TabIndex = 0;
            this.dgvProizvodi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProizvodi_CellContentClick);
            this.dgvProizvodi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProizvodi_CellDoubleClick);
            this.dgvProizvodi.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvProizvodi_DataError);
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Slika
            // 
            this.Slika.DataPropertyName = "Slika";
            this.Slika.HeaderText = "Slika";
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            this.Slika.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Slika.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // Kategorija
            // 
            this.Kategorija.DataPropertyName = "KategorijaNaziv";
            this.Kategorija.HeaderText = "Kategorija";
            this.Kategorija.Name = "Kategorija";
            this.Kategorija.ReadOnly = true;
            // 
            // Proizvodjac
            // 
            this.Proizvodjac.DataPropertyName = "ProizvodjacNaziv";
            this.Proizvodjac.HeaderText = "Proizvodjac";
            this.Proizvodjac.Name = "Proizvodjac";
            this.Proizvodjac.ReadOnly = true;
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
            // btnSacuvajProizvod
            // 
            this.btnSacuvajProizvod.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSacuvajProizvod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSacuvajProizvod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSacuvajProizvod.Location = new System.Drawing.Point(376, 265);
            this.btnSacuvajProizvod.Name = "btnSacuvajProizvod";
            this.btnSacuvajProizvod.Size = new System.Drawing.Size(163, 45);
            this.btnSacuvajProizvod.TabIndex = 1;
            this.btnSacuvajProizvod.Text = "Sačuvaj proizvod";
            this.btnSacuvajProizvod.UseVisualStyleBackColor = false;
            this.btnSacuvajProizvod.Click += new System.EventHandler(this.btnSacuvajProizvod_Click);
            // 
            // ofdSlika
            // 
            this.ofdSlika.FileName = "ofdSlika";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(666, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 21);
            this.label12.TabIndex = 50;
            this.label12.Text = "Slika";
            // 
            // frmProizvodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 648);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnSacuvajProizvod);
            this.Controls.Add(this.gbxProizvodi);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.pbxSlika);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbProizvodjac);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.panel1);
            this.Name = "frmProizvodi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProizvodi";
            this.Load += new System.EventHandler(this.frmProizvodi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSlika)).EndInit();
            this.gbxProizvodi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNavigacija;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbProizvodjac;
        private System.Windows.Forms.PictureBox pbxSlika;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.GroupBox gbxProizvodi;
        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.Button btnSacuvajProizvod;
        private System.Windows.Forms.OpenFileDialog ofdSlika;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategorija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proizvodjac;
        private System.Windows.Forms.DataGridViewButtonColumn Obrisi;
    }
}