
namespace PetShop.WinUI.Korisnici
{
    partial class frmDetaljiKorisnika
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
            this.clbRole = new System.Windows.Forms.CheckedListBox();
            this.txtDatumRodjenja = new System.Windows.Forms.TextBox();
            this.cmbDrzava = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbGrad = new System.Windows.Forms.ComboBox();
            this.cmbSpol = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblGrad = new System.Windows.Forms.Label();
            this.lblDatumRodjenja = new System.Windows.Forms.Label();
            this.lblJmbg = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtBrojTelefona = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPasswordPotvrda = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.btnSacuvajKorisnika = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clbRole);
            this.groupBox1.Controls.Add(this.txtDatumRodjenja);
            this.groupBox1.Controls.Add(this.cmbDrzava);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbGrad);
            this.groupBox1.Controls.Add(this.cmbSpol);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblGrad);
            this.groupBox1.Controls.Add(this.lblDatumRodjenja);
            this.groupBox1.Controls.Add(this.lblJmbg);
            this.groupBox1.Controls.Add(this.lblPrezime);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(this.txtBrojTelefona);
            this.groupBox1.Controls.Add(this.lblIme);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 402);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnovni podaci";
            // 
            // clbRole
            // 
            this.clbRole.CheckOnClick = true;
            this.clbRole.FormattingEnabled = true;
            this.clbRole.Location = new System.Drawing.Point(354, 248);
            this.clbRole.Name = "clbRole";
            this.clbRole.Size = new System.Drawing.Size(178, 130);
            this.clbRole.TabIndex = 16;
            // 
            // txtDatumRodjenja
            // 
            this.txtDatumRodjenja.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDatumRodjenja.Location = new System.Drawing.Point(354, 118);
            this.txtDatumRodjenja.Name = "txtDatumRodjenja";
            this.txtDatumRodjenja.Size = new System.Drawing.Size(178, 29);
            this.txtDatumRodjenja.TabIndex = 15;
            // 
            // cmbDrzava
            // 
            this.cmbDrzava.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbDrzava.FormattingEnabled = true;
            this.cmbDrzava.Location = new System.Drawing.Point(35, 199);
            this.cmbDrzava.Name = "cmbDrzava";
            this.cmbDrzava.Size = new System.Drawing.Size(178, 29);
            this.cmbDrzava.TabIndex = 14;
            this.cmbDrzava.SelectedIndexChanged += new System.EventHandler(this.cmbDrzava_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(102, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 21);
            this.label10.TabIndex = 13;
            this.label10.Text = "Grad";
            // 
            // cmbGrad
            // 
            this.cmbGrad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbGrad.FormattingEnabled = true;
            this.cmbGrad.Location = new System.Drawing.Point(35, 285);
            this.cmbGrad.Name = "cmbGrad";
            this.cmbGrad.Size = new System.Drawing.Size(178, 29);
            this.cmbGrad.TabIndex = 12;
            // 
            // cmbSpol
            // 
            this.cmbSpol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbSpol.FormattingEnabled = true;
            this.cmbSpol.Location = new System.Drawing.Point(354, 42);
            this.cmbSpol.Name = "cmbSpol";
            this.cmbSpol.Size = new System.Drawing.Size(178, 29);
            this.cmbSpol.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(421, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "Spol";
            // 
            // lblGrad
            // 
            this.lblGrad.AutoSize = true;
            this.lblGrad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGrad.Location = new System.Drawing.Point(91, 175);
            this.lblGrad.Name = "lblGrad";
            this.lblGrad.Size = new System.Drawing.Size(63, 21);
            this.lblGrad.TabIndex = 9;
            this.lblGrad.Text = "Država";
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDatumRodjenja.Location = new System.Drawing.Point(380, 94);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(125, 21);
            this.lblDatumRodjenja.TabIndex = 7;
            this.lblDatumRodjenja.Text = "Datum rođenja";
            // 
            // lblJmbg
            // 
            this.lblJmbg.AutoSize = true;
            this.lblJmbg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJmbg.Location = new System.Drawing.Point(394, 173);
            this.lblJmbg.Name = "lblJmbg";
            this.lblJmbg.Size = new System.Drawing.Size(111, 21);
            this.lblJmbg.TabIndex = 5;
            this.lblJmbg.Text = "Broj Telefona";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrezime.Location = new System.Drawing.Point(82, 94);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(72, 21);
            this.lblPrezime.TabIndex = 3;
            this.lblPrezime.Text = "Prezime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrezime.Location = new System.Drawing.Point(35, 118);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(178, 29);
            this.txtPrezime.TabIndex = 2;
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBrojTelefona.Location = new System.Drawing.Point(354, 197);
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.Size = new System.Drawing.Size(178, 29);
            this.txtBrojTelefona.TabIndex = 4;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIme.Location = new System.Drawing.Point(100, 18);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(39, 21);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "Ime";
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIme.Location = new System.Drawing.Point(35, 42);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(178, 29);
            this.txtIme.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtPasswordPotvrda);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtKorisnickoIme);
            this.groupBox2.Location = new System.Drawing.Point(597, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 402);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Korisnički podaci";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(368, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 21);
            this.label11.TabIndex = 17;
            this.label11.Text = "Potvrda passworda";
            // 
            // txtPasswordPotvrda
            // 
            this.txtPasswordPotvrda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPasswordPotvrda.Location = new System.Drawing.Point(354, 179);
            this.txtPasswordPotvrda.Name = "txtPasswordPotvrda";
            this.txtPasswordPotvrda.Size = new System.Drawing.Size(178, 29);
            this.txtPasswordPotvrda.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(404, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 21);
            this.label12.TabIndex = 15;
            this.label12.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(354, 101);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(178, 29);
            this.txtPassword.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(95, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "E-Mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(35, 179);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(178, 29);
            this.txtEmail.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(66, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 21);
            this.label9.TabIndex = 11;
            this.label9.Text = "Korisničko ime";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKorisnickoIme.Location = new System.Drawing.Point(35, 101);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(178, 29);
            this.txtKorisnickoIme.TabIndex = 10;
            // 
            // btnSacuvajKorisnika
            // 
            this.btnSacuvajKorisnika.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSacuvajKorisnika.Location = new System.Drawing.Point(506, 443);
            this.btnSacuvajKorisnika.Name = "btnSacuvajKorisnika";
            this.btnSacuvajKorisnika.Size = new System.Drawing.Size(152, 57);
            this.btnSacuvajKorisnika.TabIndex = 38;
            this.btnSacuvajKorisnika.Text = "Sačuvaj korisnika";
            this.btnSacuvajKorisnika.UseVisualStyleBackColor = true;
            this.btnSacuvajKorisnika.Click += new System.EventHandler(this.btnSacuvajKorisnika_Click);
            // 
            // frmDetaljiKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 524);
            this.Controls.Add(this.btnSacuvajKorisnika);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDetaljiKorisnika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetaljiKorisnika";
            this.Load += new System.EventHandler(this.frmDetaljiKorisnika_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblJmbg;
        private System.Windows.Forms.TextBox txtBrojTelefona;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblDatumRodjenja;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblGrad;
        private System.Windows.Forms.ComboBox cmbSpol;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.ComboBox cmbDrzava;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbGrad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPasswordPotvrda;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtDatumRodjenja;
        private System.Windows.Forms.CheckedListBox clbRole;
        private System.Windows.Forms.Button btnSacuvajKorisnika;
    }
}