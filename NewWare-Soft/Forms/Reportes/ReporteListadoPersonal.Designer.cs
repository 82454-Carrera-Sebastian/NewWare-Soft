
namespace NewWare_Soft.Forms.Reportes
{
    partial class ReporteListadoPersonal
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
            this.ReportListPersonal = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ReportListPersonal
            // 
            this.ReportListPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportListPersonal.LocalReport.ReportEmbeddedResource = "NewWare_Soft.Reporte_Personal.rdlc";
            this.ReportListPersonal.Location = new System.Drawing.Point(0, 0);
            this.ReportListPersonal.Name = "ReportListPersonal";
            this.ReportListPersonal.ServerReport.BearerToken = null;
            this.ReportListPersonal.Size = new System.Drawing.Size(1107, 450);
            this.ReportListPersonal.TabIndex = 0;
            this.ReportListPersonal.Load += new System.EventHandler(this.ReportListPersonal_Load);
            // 
            // ReporteListadoPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 450);
            this.Controls.Add(this.ReportListPersonal);
            this.Name = "ReporteListadoPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de personal";
            this.Load += new System.EventHandler(this.ReporteListadoPersonal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportListPersonal;
    }
}