
namespace NewWare_Soft.Forms.Reportes
{
    partial class ReporteListadoEtapas
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
            this.ReportListEtapas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ReportListEtapas
            // 
            this.ReportListEtapas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportListEtapas.LocalReport.ReportEmbeddedResource = "NewWare_Soft.Reporte_Etapas.rdlc";
            this.ReportListEtapas.Location = new System.Drawing.Point(0, 0);
            this.ReportListEtapas.Name = "ReportListEtapas";
            this.ReportListEtapas.ServerReport.BearerToken = null;
            this.ReportListEtapas.Size = new System.Drawing.Size(587, 450);
            this.ReportListEtapas.TabIndex = 0;
            this.ReportListEtapas.Load += new System.EventHandler(this.ReportListEtapas_Load);
            // 
            // ReporteListadoEtapas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 450);
            this.Controls.Add(this.ReportListEtapas);
            this.Name = "ReporteListadoEtapas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de etapas";
            this.Load += new System.EventHandler(this.ReporteListadoEtapas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportListEtapas;
    }
}