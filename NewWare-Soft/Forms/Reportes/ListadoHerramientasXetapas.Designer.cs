
namespace NewWare_Soft.Forms.Reportes
{
    partial class ListadoHerramientasXetapas
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
            this.reportViewerHerramientasXetapas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerHerramientasXetapas
            // 
            this.reportViewerHerramientasXetapas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerHerramientasXetapas.LocalReport.ReportEmbeddedResource = "NewWare_Soft.Reporte_HerramientasXetapas.rdlc";
            this.reportViewerHerramientasXetapas.Location = new System.Drawing.Point(0, 0);
            this.reportViewerHerramientasXetapas.Name = "reportViewerHerramientasXetapas";
            this.reportViewerHerramientasXetapas.ServerReport.BearerToken = null;
            this.reportViewerHerramientasXetapas.Size = new System.Drawing.Size(734, 461);
            this.reportViewerHerramientasXetapas.TabIndex = 0;
            this.reportViewerHerramientasXetapas.Load += new System.EventHandler(this.reportViewerHerramientasXetapas_Load);
            // 
            // ListadoHerramientasXetapas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.reportViewerHerramientasXetapas);
            this.Name = "ListadoHerramientasXetapas";
            this.Text = "ListadoHerramientasXetapas";
            this.Load += new System.EventHandler(this.ListadoHerramientasXetapas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerHerramientasXetapas;
    }
}