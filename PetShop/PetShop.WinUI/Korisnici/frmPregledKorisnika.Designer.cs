
namespace PetShop.WinUI.Korisnici
{
    partial class frmPregledKorisnika
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
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnProfil = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlNavigacija = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpravljanjeKorisnicima = new System.Windows.Forms.Button();
            this.btnIzvjestaji = new System.Windows.Forms.Button();
            this.btnNovosti = new System.Windows.Forms.Button();
            this.btnKomentari = new System.Windows.Forms.Button();
            this.btnPoslovnice = new System.Windows.Forms.Button();
            this.btnPoruke = new System.Windows.Forms.Button();
            this.btnKategorije = new System.Windows.Forms.Button();
            this.btnProizvodjaci = new System.Windows.Forms.Button();
            this.btnUpravljanjeProizvodima = new System.Windows.Forms.Button();
            this.btnUpravljanjeUposlenicima = new System.Windows.Forms.Button();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojTelefona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNoviKorisnik = new System.Windows.Forms.Button();
            this.btnPrikaz = new System.Windows.Forms.Button();
            this.lblUnos = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlNavigacija.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.lblNavigacija);
            this.panel1.Controls.Add(this.btnOdjava);
            this.panel1.Controls.Add(this.btnProfil);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(293, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 79);
            this.panel1.TabIndex = 28;
            // 
            // lblNavigacija
            // 
            this.lblNavigacija.AutoSize = true;
            this.lblNavigacija.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNavigacija.Location = new System.Drawing.Point(10, 29);
            this.lblNavigacija.Name = "lblNavigacija";
            this.lblNavigacija.Size = new System.Drawing.Size(332, 25);
            this.lblNavigacija.TabIndex = 19;
            this.lblNavigacija.Text = "Korisnici >> Upravljanje korisnicima";
            // 
            // btnOdjava
            // 
            this.btnOdjava.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOdjava.Location = new System.Drawing.Point(682, 18);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(90, 41);
            this.btnOdjava.TabIndex = 19;
            this.btnOdjava.Text = "Odjavi se";
            this.btnOdjava.UseVisualStyleBackColor = true;
            // 
            // btnProfil
            // 
            this.btnProfil.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProfil.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProfil.Location = new System.Drawing.Point(378, 29);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(150, 47);
            this.btnProfil.TabIndex = 19;
            this.btnProfil.Text = "Moj profil";
            this.btnProfil.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(394, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Ime Prezime";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(12, 686);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 42);
            this.panel6.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(47, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 27);
            this.label5.TabIndex = 2;
            this.label5.Text = "IZVJEŠTAJI";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(12, 500);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 42);
            this.panel5.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(47, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "OSTALO";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(12, 220);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 42);
            this.panel4.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(47, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "PROIZVODI";
            // 
            // pnlNavigacija
            // 
            this.pnlNavigacija.BackColor = System.Drawing.Color.DarkMagenta;
            this.pnlNavigacija.Controls.Add(this.panel2);
            this.pnlNavigacija.Controls.Add(this.btnUpravljanjeKorisnicima);
            this.pnlNavigacija.Controls.Add(this.btnIzvjestaji);
            this.pnlNavigacija.Controls.Add(this.btnNovosti);
            this.pnlNavigacija.Controls.Add(this.btnKomentari);
            this.pnlNavigacija.Controls.Add(this.btnPoslovnice);
            this.pnlNavigacija.Controls.Add(this.btnPoruke);
            this.pnlNavigacija.Controls.Add(this.btnKategorije);
            this.pnlNavigacija.Controls.Add(this.btnProizvodjaci);
            this.pnlNavigacija.Controls.Add(this.btnUpravljanjeProizvodima);
            this.pnlNavigacija.Controls.Add(this.btnUpravljanjeUposlenicima);
            this.pnlNavigacija.Controls.Add(this.lblNaslov);
            this.pnlNavigacija.Location = new System.Drawing.Point(12, 12);
            this.pnlNavigacija.Name = "pnlNavigacija";
            this.pnlNavigacija.Size = new System.Drawing.Size(265, 793);
            this.pnlNavigacija.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 394);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 42);
            this.panel2.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(47, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "KONTAKT";
            // 
            // btnUpravljanjeKorisnicima
            // 
            this.btnUpravljanjeKorisnicima.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpravljanjeKorisnicima.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpravljanjeKorisnicima.Location = new System.Drawing.Point(47, 116);
            this.btnUpravljanjeKorisnicima.Name = "btnUpravljanjeKorisnicima";
            this.btnUpravljanjeKorisnicima.Size = new System.Drawing.Size(218, 40);
            this.btnUpravljanjeKorisnicima.TabIndex = 16;
            this.btnUpravljanjeKorisnicima.Text = "Upravljanje korisnicima";
            this.btnUpravljanjeKorisnicima.UseVisualStyleBackColor = false;
            // 
            // btnIzvjestaji
            // 
            this.btnIzvjestaji.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIzvjestaji.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIzvjestaji.Location = new System.Drawing.Point(47, 722);
            this.btnIzvjestaji.Name = "btnIzvjestaji";
            this.btnIzvjestaji.Size = new System.Drawing.Size(218, 40);
            this.btnIzvjestaji.TabIndex = 15;
            this.btnIzvjestaji.Text = "Pregled izvještaja";
            this.btnIzvjestaji.UseVisualStyleBackColor = false;
            // 
            // btnNovosti
            // 
            this.btnNovosti.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNovosti.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNovosti.Location = new System.Drawing.Point(47, 582);
            this.btnNovosti.Name = "btnNovosti";
            this.btnNovosti.Size = new System.Drawing.Size(218, 40);
            this.btnNovosti.TabIndex = 13;
            this.btnNovosti.Text = "Novosti";
            this.btnNovosti.UseVisualStyleBackColor = false;
            this.btnNovosti.Click += new System.EventHandler(this.btnNovosti_Click);
            // 
            // btnKomentari
            // 
            this.btnKomentari.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKomentari.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKomentari.Location = new System.Drawing.Point(47, 628);
            this.btnKomentari.Name = "btnKomentari";
            this.btnKomentari.Size = new System.Drawing.Size(218, 40);
            this.btnKomentari.TabIndex = 12;
            this.btnKomentari.Text = "Komentari";
            this.btnKomentari.UseVisualStyleBackColor = false;
            this.btnKomentari.Click += new System.EventHandler(this.btnKomentari_Click);
            // 
            // btnPoslovnice
            // 
            this.btnPoslovnice.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPoslovnice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPoslovnice.Location = new System.Drawing.Point(47, 536);
            this.btnPoslovnice.Name = "btnPoslovnice";
            this.btnPoslovnice.Size = new System.Drawing.Size(218, 40);
            this.btnPoslovnice.TabIndex = 11;
            this.btnPoslovnice.Text = "Poslovnice";
            this.btnPoslovnice.UseVisualStyleBackColor = false;
            this.btnPoslovnice.Click += new System.EventHandler(this.btnPoslovnice_Click);
            // 
            // btnPoruke
            // 
            this.btnPoruke.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPoruke.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPoruke.Location = new System.Drawing.Point(47, 442);
            this.btnPoruke.Name = "btnPoruke";
            this.btnPoruke.Size = new System.Drawing.Size(218, 40);
            this.btnPoruke.TabIndex = 10;
            this.btnPoruke.Text = "Poruke";
            this.btnPoruke.UseVisualStyleBackColor = false;
            this.btnPoruke.Click += new System.EventHandler(this.btnPoruke_Click);
            // 
            // btnKategorije
            // 
            this.btnKategorije.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKategorije.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKategorije.Location = new System.Drawing.Point(47, 302);
            this.btnKategorije.Name = "btnKategorije";
            this.btnKategorije.Size = new System.Drawing.Size(218, 40);
            this.btnKategorije.TabIndex = 8;
            this.btnKategorije.Text = "Kategorije";
            this.btnKategorije.UseVisualStyleBackColor = false;
            this.btnKategorije.Click += new System.EventHandler(this.btnKategorije_Click);
            // 
            // btnProizvodjaci
            // 
            this.btnProizvodjaci.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProizvodjaci.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProizvodjaci.Location = new System.Drawing.Point(47, 348);
            this.btnProizvodjaci.Name = "btnProizvodjaci";
            this.btnProizvodjaci.Size = new System.Drawing.Size(218, 40);
            this.btnProizvodjaci.TabIndex = 6;
            this.btnProizvodjaci.Text = "Proizvođači";
            this.btnProizvodjaci.UseVisualStyleBackColor = false;
            this.btnProizvodjaci.Click += new System.EventHandler(this.btnProizvodjaci_Click);
            // 
            // btnUpravljanjeProizvodima
            // 
            this.btnUpravljanjeProizvodima.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpravljanjeProizvodima.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpravljanjeProizvodima.Location = new System.Drawing.Point(47, 256);
            this.btnUpravljanjeProizvodima.Name = "btnUpravljanjeProizvodima";
            this.btnUpravljanjeProizvodima.Size = new System.Drawing.Size(218, 40);
            this.btnUpravljanjeProizvodima.TabIndex = 5;
            this.btnUpravljanjeProizvodima.Text = "Upravljanje proizvodima";
            this.btnUpravljanjeProizvodima.UseVisualStyleBackColor = false;
            this.btnUpravljanjeProizvodima.Click += new System.EventHandler(this.btnUpravljanjeProizvodima_Click);
            // 
            // btnUpravljanjeUposlenicima
            // 
            this.btnUpravljanjeUposlenicima.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpravljanjeUposlenicima.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpravljanjeUposlenicima.Location = new System.Drawing.Point(47, 162);
            this.btnUpravljanjeUposlenicima.Name = "btnUpravljanjeUposlenicima";
            this.btnUpravljanjeUposlenicima.Size = new System.Drawing.Size(218, 40);
            this.btnUpravljanjeUposlenicima.TabIndex = 4;
            this.btnUpravljanjeUposlenicima.Text = "Upravljanje uposlenicima";
            this.btnUpravljanjeUposlenicima.UseVisualStyleBackColor = false;
            this.btnUpravljanjeUposlenicima.Click += new System.EventHandler(this.btnUpravljanjeUposlenicima_Click);
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNaslov.ForeColor = System.Drawing.Color.Gold;
            this.lblNaslov.Location = new System.Drawing.Point(0, 0);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(275, 55);
            this.lblNaslov.TabIndex = 1;
            this.lblNaslov.Text = "PET SHOP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKorisnici);
            this.groupBox1.Location = new System.Drawing.Point(293, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 560);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Korisnici";
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AllowUserToAddRows = false;
            this.dgvKorisnici.AllowUserToDeleteRows = false;
            this.dgvKorisnici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ime,
            this.Prezime,
            this.Spol,
            this.DatumRodjenja,
            this.GradNaziv,
            this.BrojTelefona,
            this.Email,
            this.KorisnickoIme});
            this.dgvKorisnici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKorisnici.Location = new System.Drawing.Point(3, 19);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.ReadOnly = true;
            this.dgvKorisnici.RowTemplate.Height = 25;
            this.dgvKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKorisnici.Size = new System.Drawing.Size(769, 538);
            this.dgvKorisnici.TabIndex = 0;
            this.dgvKorisnici.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKorisnici_CellDoubleClick);
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Spol
            // 
            this.Spol.DataPropertyName = "SpolNaziv";
            this.Spol.HeaderText = "Spol";
            this.Spol.Name = "Spol";
            this.Spol.ReadOnly = true;
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.DataPropertyName = "DatumRodjenja";
            this.DatumRodjenja.HeaderText = "Datum rodjenja";
            this.DatumRodjenja.Name = "DatumRodjenja";
            this.DatumRodjenja.ReadOnly = true;
            // 
            // GradNaziv
            // 
            this.GradNaziv.DataPropertyName = "GradNaziv";
            this.GradNaziv.HeaderText = "Grad";
            this.GradNaziv.Name = "GradNaziv";
            this.GradNaziv.ReadOnly = true;
            // 
            // BrojTelefona
            // 
            this.BrojTelefona.DataPropertyName = "BrojTelefona";
            this.BrojTelefona.HeaderText = "Broj telefona";
            this.BrojTelefona.Name = "BrojTelefona";
            this.BrojTelefona.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "Korisnicko ime";
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNoviKorisnik);
            this.groupBox2.Controls.Add(this.btnPrikaz);
            this.groupBox2.Controls.Add(this.lblUnos);
            this.groupBox2.Controls.Add(this.txtPretraga);
            this.groupBox2.Location = new System.Drawing.Point(293, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(772, 126);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga";
            // 
            // btnNoviKorisnik
            // 
            this.btnNoviKorisnik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNoviKorisnik.Location = new System.Drawing.Point(611, 47);
            this.btnNoviKorisnik.Name = "btnNoviKorisnik";
            this.btnNoviKorisnik.Size = new System.Drawing.Size(120, 44);
            this.btnNoviKorisnik.TabIndex = 3;
            this.btnNoviKorisnik.Text = "Novi korisnik";
            this.btnNoviKorisnik.UseVisualStyleBackColor = true;
            this.btnNoviKorisnik.Click += new System.EventHandler(this.btnNoviKorisnik_Click);
            // 
            // btnPrikaz
            // 
            this.btnPrikaz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrikaz.Location = new System.Drawing.Point(456, 47);
            this.btnPrikaz.Name = "btnPrikaz";
            this.btnPrikaz.Size = new System.Drawing.Size(120, 44);
            this.btnPrikaz.TabIndex = 2;
            this.btnPrikaz.Text = "Prikaži";
            this.btnPrikaz.UseVisualStyleBackColor = true;
            this.btnPrikaz.Click += new System.EventHandler(this.btnPrikaz_Click);
            // 
            // lblUnos
            // 
            this.lblUnos.AutoSize = true;
            this.lblUnos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUnos.Location = new System.Drawing.Point(46, 38);
            this.lblUnos.Name = "lblUnos";
            this.lblUnos.Size = new System.Drawing.Size(207, 17);
            this.lblUnos.TabIndex = 1;
            this.lblUnos.Text = "Unesite korisničko ime ili e-mail";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPretraga.Location = new System.Drawing.Point(55, 58);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(198, 33);
            this.txtPretraga.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(12, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 42);
            this.panel3.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "KORISNICI";
            // 
            // frmPregledKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 821);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlNavigacija);
            this.Name = "frmPregledKorisnika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPregledKorisnika";
            this.Load += new System.EventHandler(this.frmPregledKorisnika_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlNavigacija.ResumeLayout(false);
            this.pnlNavigacija.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNavigacija;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlNavigacija;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpravljanjeKorisnicima;
        private System.Windows.Forms.Button btnIzvjestaji;
        private System.Windows.Forms.Button btnNovosti;
        private System.Windows.Forms.Button btnKomentari;
        private System.Windows.Forms.Button btnPoslovnice;
        private System.Windows.Forms.Button btnPoruke;
        private System.Windows.Forms.Button btnKategorije;
        private System.Windows.Forms.Button btnProizvodjaci;
        private System.Windows.Forms.Button btnUpravljanjeProizvodima;
        private System.Windows.Forms.Button btnUpravljanjeUposlenicima;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPrikaz;
        private System.Windows.Forms.Label lblUnos;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnNoviKorisnik;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodjenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojTelefona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
    }
}