﻿
namespace PetShop.WinUI.Proizvodi
{
    partial class frmPregledProizvodjaca
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
            this.btnDodajProizvodjaca = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNazivProizvodjaca = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProizvodjaci = new System.Windows.Forms.DataGridView();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drzava = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.cmbDrzave = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodjaci)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlNavigacija.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDodajProizvodjaca
            // 
            this.btnDodajProizvodjaca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDodajProizvodjaca.Location = new System.Drawing.Point(611, 299);
            this.btnDodajProizvodjaca.Name = "btnDodajProizvodjaca";
            this.btnDodajProizvodjaca.Size = new System.Drawing.Size(178, 44);
            this.btnDodajProizvodjaca.TabIndex = 70;
            this.btnDodajProizvodjaca.Text = "Dodaj proizvođača";
            this.btnDodajProizvodjaca.UseVisualStyleBackColor = true;
            this.btnDodajProizvodjaca.Click += new System.EventHandler(this.btnDodajProizvodjaca_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(621, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 21);
            this.label7.TabIndex = 69;
            this.label7.Text = "Naziv proizvođača";
            // 
            // txtNazivProizvodjaca
            // 
            this.txtNazivProizvodjaca.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNazivProizvodjaca.Location = new System.Drawing.Point(559, 157);
            this.txtNazivProizvodjaca.Name = "txtNazivProizvodjaca";
            this.txtNazivProizvodjaca.Size = new System.Drawing.Size(262, 33);
            this.txtNazivProizvodjaca.TabIndex = 68;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProizvodjaci);
            this.groupBox1.Location = new System.Drawing.Point(473, 362);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 445);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proizvodjaci";
            // 
            // dgvProizvodjaci
            // 
            this.dgvProizvodjaci.AllowUserToAddRows = false;
            this.dgvProizvodjaci.AllowUserToDeleteRows = false;
            this.dgvProizvodjaci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProizvodjaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodjaci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.Drzava});
            this.dgvProizvodjaci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProizvodjaci.Location = new System.Drawing.Point(3, 19);
            this.dgvProizvodjaci.Name = "dgvProizvodjaci";
            this.dgvProizvodjaci.ReadOnly = true;
            this.dgvProizvodjaci.RowTemplate.Height = 25;
            this.dgvProizvodjaci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProizvodjaci.Size = new System.Drawing.Size(447, 423);
            this.dgvProizvodjaci.TabIndex = 0;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv proizvodjaca";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Drzava
            // 
            this.Drzava.DataPropertyName = "DrzavaNaziv";
            this.Drzava.HeaderText = "Drzava";
            this.Drzava.Name = "Drzava";
            this.Drzava.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(12, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 42);
            this.panel3.TabIndex = 65;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.lblNavigacija);
            this.panel1.Controls.Add(this.btnOdjava);
            this.panel1.Controls.Add(this.btnProfil);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(293, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 79);
            this.panel1.TabIndex = 66;
            // 
            // lblNavigacija
            // 
            this.lblNavigacija.AutoSize = true;
            this.lblNavigacija.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNavigacija.Location = new System.Drawing.Point(10, 29);
            this.lblNavigacija.Name = "lblNavigacija";
            this.lblNavigacija.Size = new System.Drawing.Size(242, 25);
            this.lblNavigacija.TabIndex = 19;
            this.lblNavigacija.Text = "Proizvodi >> Proizvodjaci";
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
            this.panel6.Location = new System.Drawing.Point(12, 688);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 42);
            this.panel6.TabIndex = 62;
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
            this.panel5.TabIndex = 63;
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
            this.panel4.TabIndex = 64;
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
            this.pnlNavigacija.TabIndex = 61;
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
            // cmbDrzave
            // 
            this.cmbDrzave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbDrzave.FormattingEnabled = true;
            this.cmbDrzave.Location = new System.Drawing.Point(559, 222);
            this.cmbDrzave.Name = "cmbDrzave";
            this.cmbDrzave.Size = new System.Drawing.Size(262, 33);
            this.cmbDrzave.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(662, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 21);
            this.label8.TabIndex = 72;
            this.label8.Text = "Drzava";
            // 
            // frmPregledProizvodjaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 821);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbDrzave);
            this.Controls.Add(this.btnDodajProizvodjaca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNazivProizvodjaca);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlNavigacija);
            this.Name = "frmPregledProizvodjaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPregledProizvodjaca";
            this.Load += new System.EventHandler(this.frmPregledProizvodjaca_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodjaci)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajProizvodjaca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNazivProizvodjaca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProizvodjaci;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.ComboBox cmbDrzave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drzava;
    }
}