
namespace PetShop.WinUI.Ostalo
{
    partial class frmPoslovnica
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPoslovnice = new System.Windows.Forms.DataGridView();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojTelefona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNavigacija = new System.Windows.Forms.Label();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnProfil = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtBrojtelefona = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.cmbGrad = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSacuvajPoslovnicu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoslovnice)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlNavigacija.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPoslovnice);
            this.groupBox1.Location = new System.Drawing.Point(293, 348);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 459);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Poslovnice";
            // 
            // dgvPoslovnice
            // 
            this.dgvPoslovnice.AllowUserToAddRows = false;
            this.dgvPoslovnice.AllowUserToDeleteRows = false;
            this.dgvPoslovnice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPoslovnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoslovnice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Adresa,
            this.GradNaziv,
            this.BrojTelefona});
            this.dgvPoslovnice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPoslovnice.Location = new System.Drawing.Point(3, 19);
            this.dgvPoslovnice.Name = "dgvPoslovnice";
            this.dgvPoslovnice.ReadOnly = true;
            this.dgvPoslovnice.RowTemplate.Height = 25;
            this.dgvPoslovnice.Size = new System.Drawing.Size(769, 437);
            this.dgvPoslovnice.TabIndex = 0;
            this.dgvPoslovnice.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPoslovnice_CellDoubleClick);
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
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
            this.BrojTelefona.HeaderText = "Broj Telefona";
            this.BrojTelefona.Name = "BrojTelefona";
            this.BrojTelefona.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(12, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 42);
            this.panel3.TabIndex = 56;
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
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(12, 688);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 42);
            this.panel6.TabIndex = 53;
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
            this.panel5.Location = new System.Drawing.Point(12, 502);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 42);
            this.panel5.TabIndex = 54;
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
            this.panel4.Location = new System.Drawing.Point(12, 222);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 42);
            this.panel4.TabIndex = 55;
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
            this.pnlNavigacija.Location = new System.Drawing.Point(12, 14);
            this.pnlNavigacija.Name = "pnlNavigacija";
            this.pnlNavigacija.Size = new System.Drawing.Size(265, 793);
            this.pnlNavigacija.TabIndex = 52;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.lblNavigacija);
            this.panel1.Controls.Add(this.btnOdjava);
            this.panel1.Controls.Add(this.btnProfil);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(283, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 79);
            this.panel1.TabIndex = 51;
            // 
            // lblNavigacija
            // 
            this.lblNavigacija.AutoSize = true;
            this.lblNavigacija.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNavigacija.Location = new System.Drawing.Point(3, 30);
            this.lblNavigacija.Name = "lblNavigacija";
            this.lblNavigacija.Size = new System.Drawing.Size(218, 25);
            this.lblNavigacija.TabIndex = 19;
            this.lblNavigacija.Text = "Korisnici >> Poslovnica";
            // 
            // btnOdjava
            // 
            this.btnOdjava.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOdjava.Location = new System.Drawing.Point(695, 18);
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
            this.btnProfil.Location = new System.Drawing.Point(366, 29);
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
            this.label6.Location = new System.Drawing.Point(382, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Ime Prezime";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrezime.Location = new System.Drawing.Point(793, 132);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(109, 21);
            this.lblPrezime.TabIndex = 61;
            this.lblPrezime.Text = "Broj telefona";
            // 
            // txtBrojtelefona
            // 
            this.txtBrojtelefona.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBrojtelefona.Location = new System.Drawing.Point(757, 156);
            this.txtBrojtelefona.Name = "txtBrojtelefona";
            this.txtBrojtelefona.Size = new System.Drawing.Size(178, 29);
            this.txtBrojtelefona.TabIndex = 60;
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdresa.Location = new System.Drawing.Point(425, 132);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(62, 21);
            this.lblAdresa.TabIndex = 59;
            this.lblAdresa.Text = "Adresa";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAdresa.Location = new System.Drawing.Point(368, 156);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(178, 29);
            this.txtAdresa.TabIndex = 58;
            // 
            // cmbGrad
            // 
            this.cmbGrad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbGrad.FormattingEnabled = true;
            this.cmbGrad.Location = new System.Drawing.Point(368, 235);
            this.cmbGrad.Name = "cmbGrad";
            this.cmbGrad.Size = new System.Drawing.Size(178, 29);
            this.cmbGrad.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(425, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 21);
            this.label7.TabIndex = 63;
            this.label7.Text = "Grad";
            // 
            // btnSacuvajPoslovnicu
            // 
            this.btnSacuvajPoslovnicu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSacuvajPoslovnicu.Location = new System.Drawing.Point(586, 295);
            this.btnSacuvajPoslovnicu.Name = "btnSacuvajPoslovnicu";
            this.btnSacuvajPoslovnicu.Size = new System.Drawing.Size(140, 47);
            this.btnSacuvajPoslovnicu.TabIndex = 64;
            this.btnSacuvajPoslovnicu.Text = "Sačuvaj poslovnicu";
            this.btnSacuvajPoslovnicu.UseVisualStyleBackColor = true;
            this.btnSacuvajPoslovnicu.Click += new System.EventHandler(this.btnSacuvajPoslovnicu_Click);
            // 
            // frmPoslovnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 821);
            this.Controls.Add(this.btnSacuvajPoslovnicu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbGrad);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.txtBrojtelefona);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlNavigacija);
            this.Controls.Add(this.panel1);
            this.Name = "frmPoslovnica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPoslovnica";
            this.Load += new System.EventHandler(this.frmPoslovnica_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoslovnice)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPoslovnice;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNavigacija;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtBrojtelefona;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojTelefona;
        private System.Windows.Forms.ComboBox cmbGrad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSacuvajPoslovnicu;
    }
}