
namespace PetShop.WinUI.Ostalo
{
    partial class frmNovosti
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
            this.dgvNovosti = new System.Windows.Forms.DataGridView();
            this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tekst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.txtTekst = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pbxSlika = new System.Windows.Forms.PictureBox();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.btnDodajNovost = new System.Windows.Forms.Button();
            this.ofdSlika = new System.Windows.Forms.OpenFileDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNovosti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.lblNavigacija);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 43);
            this.panel1.TabIndex = 36;
            // 
            // lblNavigacija
            // 
            this.lblNavigacija.AutoSize = true;
            this.lblNavigacija.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblNavigacija.Location = new System.Drawing.Point(287, 8);
            this.lblNavigacija.Name = "lblNavigacija";
            this.lblNavigacija.Size = new System.Drawing.Size(121, 32);
            this.lblNavigacija.TabIndex = 19;
            this.lblNavigacija.Text = "NOVOSTI";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvNovosti);
            this.groupBox1.Location = new System.Drawing.Point(10, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 346);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novosti";
            // 
            // dgvNovosti
            // 
            this.dgvNovosti.AllowUserToAddRows = false;
            this.dgvNovosti.AllowUserToDeleteRows = false;
            this.dgvNovosti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNovosti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNovosti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naslov,
            this.Tekst,
            this.Slika,
            this.Datum});
            this.dgvNovosti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNovosti.Location = new System.Drawing.Point(3, 16);
            this.dgvNovosti.Name = "dgvNovosti";
            this.dgvNovosti.ReadOnly = true;
            this.dgvNovosti.RowTemplate.Height = 25;
            this.dgvNovosti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNovosti.Size = new System.Drawing.Size(661, 327);
            this.dgvNovosti.TabIndex = 0;
            this.dgvNovosti.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNovosti_CellDoubleClick);
            this.dgvNovosti.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvNovosti_DataError);
            // 
            // Naslov
            // 
            this.Naslov.DataPropertyName = "Naslov";
            this.Naslov.HeaderText = "Naslov";
            this.Naslov.Name = "Naslov";
            this.Naslov.ReadOnly = true;
            // 
            // Tekst
            // 
            this.Tekst.DataPropertyName = "Tekst";
            this.Tekst.HeaderText = "Tekst";
            this.Tekst.Name = "Tekst";
            this.Tekst.ReadOnly = true;
            // 
            // Slika
            // 
            this.Slika.DataPropertyName = "Slika";
            this.Slika.HeaderText = "Slika";
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblIme.Location = new System.Drawing.Point(190, 60);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(63, 21);
            this.lblIme.TabIndex = 39;
            this.lblIme.Text = "Naslov";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtNaslov.Location = new System.Drawing.Point(56, 81);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(331, 33);
            this.txtNaslov.TabIndex = 38;
            // 
            // txtTekst
            // 
            this.txtTekst.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTekst.Location = new System.Drawing.Point(56, 144);
            this.txtTekst.Multiline = true;
            this.txtTekst.Name = "txtTekst";
            this.txtTekst.Size = new System.Drawing.Size(331, 98);
            this.txtTekst.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(195, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 21);
            this.label7.TabIndex = 41;
            this.label7.Text = "Tekst";
            // 
            // pbxSlika
            // 
            this.pbxSlika.Location = new System.Drawing.Point(416, 80);
            this.pbxSlika.Name = "pbxSlika";
            this.pbxSlika.Size = new System.Drawing.Size(255, 144);
            this.pbxSlika.TabIndex = 42;
            this.pbxSlika.TabStop = false;
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDodajSliku.Location = new System.Drawing.Point(492, 236);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(99, 40);
            this.btnDodajSliku.TabIndex = 43;
            this.btnDodajSliku.Text = "...";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // btnDodajNovost
            // 
            this.btnDodajNovost.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDodajNovost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDodajNovost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDodajNovost.Location = new System.Drawing.Point(276, 259);
            this.btnDodajNovost.Name = "btnDodajNovost";
            this.btnDodajNovost.Size = new System.Drawing.Size(156, 47);
            this.btnDodajNovost.TabIndex = 44;
            this.btnDodajNovost.Text = "Sačuvaj novost";
            this.btnDodajNovost.UseVisualStyleBackColor = false;
            this.btnDodajNovost.Click += new System.EventHandler(this.btnDodajNovost_Click);
            // 
            // ofdSlika
            // 
            this.ofdSlika.FileName = "openFileDialog1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(528, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 21);
            this.label8.TabIndex = 45;
            this.label8.Text = "Slika";
            // 
            // frmNovosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 666);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDodajNovost);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.pbxSlika);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTekst);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmNovosti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNovosti";
            this.Load += new System.EventHandler(this.frmNovosti_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNovosti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNavigacija;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNovosti;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.TextBox txtTekst;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbxSlika;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.Button btnDodajNovost;
        private System.Windows.Forms.OpenFileDialog ofdSlika;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tekst;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.Label label8;
    }
}