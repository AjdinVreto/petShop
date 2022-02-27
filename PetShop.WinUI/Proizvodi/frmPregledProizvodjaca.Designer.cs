
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNavigacija = new System.Windows.Forms.Label();
            this.cmbDrzave = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodjaci)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDodajProizvodjaca
            // 
            this.btnDodajProizvodjaca.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDodajProizvodjaca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDodajProizvodjaca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDodajProizvodjaca.Location = new System.Drawing.Point(259, 200);
            this.btnDodajProizvodjaca.Name = "btnDodajProizvodjaca";
            this.btnDodajProizvodjaca.Size = new System.Drawing.Size(179, 49);
            this.btnDodajProizvodjaca.TabIndex = 70;
            this.btnDodajProizvodjaca.Text = "Dodaj proizvođača";
            this.btnDodajProizvodjaca.UseVisualStyleBackColor = false;
            this.btnDodajProizvodjaca.Click += new System.EventHandler(this.btnDodajProizvodjaca_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(279, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 21);
            this.label7.TabIndex = 69;
            this.label7.Text = "Naziv proizvođača";
            // 
            // txtNazivProizvodjaca
            // 
            this.txtNazivProizvodjaca.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtNazivProizvodjaca.Location = new System.Drawing.Point(232, 84);
            this.txtNazivProizvodjaca.Name = "txtNazivProizvodjaca";
            this.txtNazivProizvodjaca.Size = new System.Drawing.Size(225, 33);
            this.txtNazivProizvodjaca.TabIndex = 68;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProizvodjaci);
            this.groupBox1.Location = new System.Drawing.Point(63, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 386);
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
            this.dgvProizvodjaci.Location = new System.Drawing.Point(3, 16);
            this.dgvProizvodjaci.Name = "dgvProizvodjaci";
            this.dgvProizvodjaci.ReadOnly = true;
            this.dgvProizvodjaci.RowTemplate.Height = 25;
            this.dgvProizvodjaci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProizvodjaci.Size = new System.Drawing.Size(577, 367);
            this.dgvProizvodjaci.TabIndex = 0;
            this.dgvProizvodjaci.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvProizvodjaci_DataError);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.lblNavigacija);
            this.panel1.Location = new System.Drawing.Point(5, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 44);
            this.panel1.TabIndex = 66;
            // 
            // lblNavigacija
            // 
            this.lblNavigacija.AutoSize = true;
            this.lblNavigacija.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblNavigacija.Location = new System.Drawing.Point(273, 8);
            this.lblNavigacija.Name = "lblNavigacija";
            this.lblNavigacija.Size = new System.Drawing.Size(179, 32);
            this.lblNavigacija.TabIndex = 19;
            this.lblNavigacija.Text = "PROIZVOĐAČI";
            // 
            // cmbDrzave
            // 
            this.cmbDrzave.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cmbDrzave.FormattingEnabled = true;
            this.cmbDrzave.Location = new System.Drawing.Point(232, 145);
            this.cmbDrzave.Name = "cmbDrzave";
            this.cmbDrzave.Size = new System.Drawing.Size(225, 33);
            this.cmbDrzave.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(320, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 21);
            this.label8.TabIndex = 72;
            this.label8.Text = "Drzava";
            // 
            // frmPregledProizvodjaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbDrzave);
            this.Controls.Add(this.btnDodajProizvodjaca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNazivProizvodjaca);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmPregledProizvodjaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPregledProizvodjaca";
            this.Load += new System.EventHandler(this.frmPregledProizvodjaca_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodjaci)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajProizvodjaca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNazivProizvodjaca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProizvodjaci;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNavigacija;
        private System.Windows.Forms.ComboBox cmbDrzave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drzava;
    }
}