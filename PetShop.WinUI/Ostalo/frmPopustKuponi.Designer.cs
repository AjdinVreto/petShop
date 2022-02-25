
namespace PetShop.WinUI.Ostalo
{
    partial class frmPopustKuponi
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
            this.btnDodajPopustKupon = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNavigacija = new System.Windows.Forms.Label();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPopustKuponi = new System.Windows.Forms.DataGridView();
            this.Iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopustKuponi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajPopustKupon
            // 
            this.btnDodajPopustKupon.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDodajPopustKupon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDodajPopustKupon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDodajPopustKupon.Location = new System.Drawing.Point(293, 217);
            this.btnDodajPopustKupon.Name = "btnDodajPopustKupon";
            this.btnDodajPopustKupon.Size = new System.Drawing.Size(202, 46);
            this.btnDodajPopustKupon.TabIndex = 53;
            this.btnDodajPopustKupon.Text = "Sacuvaj popust kupon";
            this.btnDodajPopustKupon.UseVisualStyleBackColor = false;
            this.btnDodajPopustKupon.Click += new System.EventHandler(this.btnDodajPopustKupon_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(378, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 21);
            this.label7.TabIndex = 50;
            this.label7.Text = "Kod";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIme.Location = new System.Drawing.Point(368, 70);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(50, 21);
            this.lblIme.TabIndex = 48;
            this.lblIme.Text = "Iznos";
            // 
            // txtIznos
            // 
            this.txtIznos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIznos.Location = new System.Drawing.Point(293, 94);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(202, 33);
            this.txtIznos.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.lblNavigacija);
            this.panel1.Location = new System.Drawing.Point(10, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 51);
            this.panel1.TabIndex = 46;
            // 
            // lblNavigacija
            // 
            this.lblNavigacija.AutoSize = true;
            this.lblNavigacija.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNavigacija.Location = new System.Drawing.Point(283, 9);
            this.lblNavigacija.Name = "lblNavigacija";
            this.lblNavigacija.Size = new System.Drawing.Size(206, 32);
            this.lblNavigacija.TabIndex = 19;
            this.lblNavigacija.Text = "POPUST KUPONI";
            // 
            // txtKod
            // 
            this.txtKod.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKod.Location = new System.Drawing.Point(293, 156);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(202, 33);
            this.txtKod.TabIndex = 54;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPopustKuponi);
            this.groupBox1.Location = new System.Drawing.Point(193, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 298);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Popust kuponi";
            // 
            // dgvPopustKuponi
            // 
            this.dgvPopustKuponi.AllowUserToAddRows = false;
            this.dgvPopustKuponi.AllowUserToDeleteRows = false;
            this.dgvPopustKuponi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPopustKuponi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopustKuponi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Iznos,
            this.Kod});
            this.dgvPopustKuponi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPopustKuponi.Location = new System.Drawing.Point(3, 19);
            this.dgvPopustKuponi.Name = "dgvPopustKuponi";
            this.dgvPopustKuponi.ReadOnly = true;
            this.dgvPopustKuponi.RowTemplate.Height = 25;
            this.dgvPopustKuponi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopustKuponi.Size = new System.Drawing.Size(399, 276);
            this.dgvPopustKuponi.TabIndex = 0;
            this.dgvPopustKuponi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPopustKuponi_CellDoubleClick);
            this.dgvPopustKuponi.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvPopustKuponi_DataError);
            // 
            // Iznos
            // 
            this.Iznos.DataPropertyName = "Iznos";
            this.Iznos.HeaderText = "Iznos";
            this.Iznos.Name = "Iznos";
            this.Iznos.ReadOnly = true;
            // 
            // Kod
            // 
            this.Kod.DataPropertyName = "Kod";
            this.Kod.HeaderText = "Kod";
            this.Kod.Name = "Kod";
            this.Kod.ReadOnly = true;
            // 
            // frmPopustKuponi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 590);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.btnDodajPopustKupon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.panel1);
            this.Name = "frmPopustKuponi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPopustKuponi";
            this.Load += new System.EventHandler(this.frmPopustKuponi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopustKuponi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDodajPopustKupon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNavigacija;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPopustKuponi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iznos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kod;
    }
}