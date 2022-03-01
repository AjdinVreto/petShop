
namespace PetShop.WinUI.Izvjestaji
{
    partial class frmOdabirIzvjestaja
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnProdajaPoDatumu = new System.Windows.Forms.Button();
            this.btnTopKorisnici = new System.Windows.Forms.Button();
            this.btnPorastPadKupovine = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.lblNavigacija);
            this.panel1.Location = new System.Drawing.Point(30, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 47);
            this.panel1.TabIndex = 57;
            // 
            // lblNavigacija
            // 
            this.lblNavigacija.AutoSize = true;
            this.lblNavigacija.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblNavigacija.Location = new System.Drawing.Point(309, 12);
            this.lblNavigacija.Name = "lblNavigacija";
            this.lblNavigacija.Size = new System.Drawing.Size(139, 32);
            this.lblNavigacija.TabIndex = 19;
            this.lblNavigacija.Text = "IZVJESTAJI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 29);
            this.label1.TabIndex = 58;
            this.label1.Text = "Odaberite izvjestaj koji zelite prikazati";
            // 
            // btnProdajaPoDatumu
            // 
            this.btnProdajaPoDatumu.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnProdajaPoDatumu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnProdajaPoDatumu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProdajaPoDatumu.Location = new System.Drawing.Point(30, 136);
            this.btnProdajaPoDatumu.Name = "btnProdajaPoDatumu";
            this.btnProdajaPoDatumu.Size = new System.Drawing.Size(207, 66);
            this.btnProdajaPoDatumu.TabIndex = 61;
            this.btnProdajaPoDatumu.Text = "Prodaja izmedju dva datuma";
            this.btnProdajaPoDatumu.UseVisualStyleBackColor = false;
            this.btnProdajaPoDatumu.Click += new System.EventHandler(this.btnProdajaPoDatumu_Click);
            // 
            // btnTopKorisnici
            // 
            this.btnTopKorisnici.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTopKorisnici.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnTopKorisnici.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTopKorisnici.Location = new System.Drawing.Point(306, 136);
            this.btnTopKorisnici.Name = "btnTopKorisnici";
            this.btnTopKorisnici.Size = new System.Drawing.Size(207, 66);
            this.btnTopKorisnici.TabIndex = 62;
            this.btnTopKorisnici.Text = "Prikaz top korisnika";
            this.btnTopKorisnici.UseVisualStyleBackColor = false;
            this.btnTopKorisnici.Click += new System.EventHandler(this.btnTopKorisnici_Click);
            // 
            // btnPorastPadKupovine
            // 
            this.btnPorastPadKupovine.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPorastPadKupovine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPorastPadKupovine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPorastPadKupovine.Location = new System.Drawing.Point(567, 136);
            this.btnPorastPadKupovine.Name = "btnPorastPadKupovine";
            this.btnPorastPadKupovine.Size = new System.Drawing.Size(207, 66);
            this.btnPorastPadKupovine.TabIndex = 63;
            this.btnPorastPadKupovine.Text = "Izvjestaj o porastu/padu kupovine";
            this.btnPorastPadKupovine.UseVisualStyleBackColor = false;
            this.btnPorastPadKupovine.Click += new System.EventHandler(this.btnPorastPadKupovine_Click);
            // 
            // frmOdabirIzvjestaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 308);
            this.Controls.Add(this.btnPorastPadKupovine);
            this.Controls.Add(this.btnTopKorisnici);
            this.Controls.Add(this.btnProdajaPoDatumu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frmOdabirIzvjestaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmOdabirIzvjestaja";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNavigacija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProdajaPoDatumu;
        private System.Windows.Forms.Button btnTopKorisnici;
        private System.Windows.Forms.Button btnPorastPadKupovine;
    }
}