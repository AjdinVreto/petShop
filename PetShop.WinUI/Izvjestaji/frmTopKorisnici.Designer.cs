
namespace PetShop.WinUI.Izvjestaji
{
    partial class frmTopKorisnici
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TopKorisniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTopKorisnici = new PetShop.WinUI.Izvjestaji.dsTopKorisnici();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TopKorisniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTopKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // TopKorisniciBindingSource
            // 
            this.TopKorisniciBindingSource.DataMember = "TopKorisnici";
            this.TopKorisniciBindingSource.DataSource = this.dsTopKorisnici;
            // 
            // dsTopKorisnici
            // 
            this.dsTopKorisnici.DataSetName = "dsTopKorisnici";
            this.dsTopKorisnici.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsKorisnici";
            reportDataSource1.Value = this.TopKorisniciBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PetShop.WinUI.Izvjestaji.rptTopKorisnici.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 81);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 369);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "TOP 3 KORISNIKA";
            // 
            // frmTopKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmTopKorisnici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTopKorisnici";
            this.Load += new System.EventHandler(this.frmTopKorisnici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TopKorisniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTopKorisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TopKorisniciBindingSource;
        private dsTopKorisnici dsTopKorisnici;
        private System.Windows.Forms.Label label1;
    }
}