
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNavigacija = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtBrojtelefona = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.cmbGrad = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSacuvajPoslovnicu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoslovnice)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPoslovnice);
            this.groupBox1.Location = new System.Drawing.Point(10, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 398);
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
            this.dgvPoslovnice.Location = new System.Drawing.Point(3, 16);
            this.dgvPoslovnice.Name = "dgvPoslovnice";
            this.dgvPoslovnice.ReadOnly = true;
            this.dgvPoslovnice.RowTemplate.Height = 25;
            this.dgvPoslovnice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPoslovnice.Size = new System.Drawing.Size(661, 379);
            this.dgvPoslovnice.TabIndex = 0;
            this.dgvPoslovnice.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPoslovnice_CellDoubleClick);
            this.dgvPoslovnice.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvPoslovnice_DataError);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.lblNavigacija);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 46);
            this.panel1.TabIndex = 51;
            // 
            // lblNavigacija
            // 
            this.lblNavigacija.AutoSize = true;
            this.lblNavigacija.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblNavigacija.Location = new System.Drawing.Point(278, 9);
            this.lblNavigacija.Name = "lblNavigacija";
            this.lblNavigacija.Size = new System.Drawing.Size(161, 32);
            this.lblNavigacija.TabIndex = 19;
            this.lblNavigacija.Text = "POSLOVNICE";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPrezime.Location = new System.Drawing.Point(449, 67);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(109, 21);
            this.lblPrezime.TabIndex = 61;
            this.lblPrezime.Text = "Broj telefona";
            // 
            // txtBrojtelefona
            // 
            this.txtBrojtelefona.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtBrojtelefona.Location = new System.Drawing.Point(393, 88);
            this.txtBrojtelefona.Name = "txtBrojtelefona";
            this.txtBrojtelefona.Size = new System.Drawing.Size(205, 33);
            this.txtBrojtelefona.TabIndex = 60;
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAdresa.Location = new System.Drawing.Point(143, 67);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(62, 21);
            this.lblAdresa.TabIndex = 59;
            this.lblAdresa.Text = "Adresa";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtAdresa.Location = new System.Drawing.Point(69, 88);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(194, 33);
            this.txtAdresa.TabIndex = 58;
            // 
            // cmbGrad
            // 
            this.cmbGrad.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cmbGrad.FormattingEnabled = true;
            this.cmbGrad.Location = new System.Drawing.Point(69, 156);
            this.cmbGrad.Name = "cmbGrad";
            this.cmbGrad.Size = new System.Drawing.Size(194, 33);
            this.cmbGrad.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(143, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 21);
            this.label7.TabIndex = 63;
            this.label7.Text = "Grad";
            // 
            // btnSacuvajPoslovnicu
            // 
            this.btnSacuvajPoslovnicu.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSacuvajPoslovnicu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSacuvajPoslovnicu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSacuvajPoslovnicu.Location = new System.Drawing.Point(271, 200);
            this.btnSacuvajPoslovnicu.Name = "btnSacuvajPoslovnicu";
            this.btnSacuvajPoslovnicu.Size = new System.Drawing.Size(166, 49);
            this.btnSacuvajPoslovnicu.TabIndex = 64;
            this.btnSacuvajPoslovnicu.Text = "Sačuvaj poslovnicu";
            this.btnSacuvajPoslovnicu.UseVisualStyleBackColor = false;
            this.btnSacuvajPoslovnicu.Click += new System.EventHandler(this.btnSacuvajPoslovnicu_Click);
            // 
            // frmPoslovnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 654);
            this.Controls.Add(this.btnSacuvajPoslovnicu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbGrad);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.txtBrojtelefona);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmPoslovnica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPoslovnica";
            this.Load += new System.EventHandler(this.frmPoslovnica_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoslovnice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPoslovnice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNavigacija;
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