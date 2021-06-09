
namespace NewWare_Soft.Forms.Reportes
{
    partial class ListadoBarrios
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
            this.reporte_barrios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reporte_barrios
            // 
            this.reporte_barrios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reporte_barrios.LocalReport.ReportEmbeddedResource = "NewWare_Soft.ReporteBarrios.rdlc";
            this.reporte_barrios.Location = new System.Drawing.Point(0, 0);
            this.reporte_barrios.Name = "reporte_barrios";
            this.reporte_barrios.ServerReport.BearerToken = null;
            this.reporte_barrios.Size = new System.Drawing.Size(800, 450);
            this.reporte_barrios.TabIndex = 0;
            this.reporte_barrios.Load += new System.EventHandler(this.reporte_barrios_Load);
            // 
            // ListadoBarrios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reporte_barrios);
            this.Name = "ListadoBarrios";
            this.Text = "ListadoBarrios";
            this.Load += new System.EventHandler(this.ListadoBarrios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporte_barrios;
    }
}