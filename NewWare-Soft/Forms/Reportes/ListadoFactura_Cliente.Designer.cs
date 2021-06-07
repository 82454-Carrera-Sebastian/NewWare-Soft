
namespace NewWare_Soft.Forms.Reportes
{
    partial class Listado_Factura_Cliente
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
            this.reportViewer_Factura_Cliente = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer_Factura_Cliente
            // 
            this.reportViewer_Factura_Cliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer_Factura_Cliente.LocalReport.ReportEmbeddedResource = "NewWare_Soft.Report_Facturas_Por_Cliente.rdlc";
            this.reportViewer_Factura_Cliente.Location = new System.Drawing.Point(0, 0);
            this.reportViewer_Factura_Cliente.Name = "reportViewer_Factura_Cliente";
            this.reportViewer_Factura_Cliente.ServerReport.BearerToken = null;
            this.reportViewer_Factura_Cliente.Size = new System.Drawing.Size(1244, 648);
            this.reportViewer_Factura_Cliente.TabIndex = 0;
            this.reportViewer_Factura_Cliente.Load += new System.EventHandler(this.reportViewer_Factura_Cliente_Load);
            // 
            // Listado_Factura_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 648);
            this.Controls.Add(this.reportViewer_Factura_Cliente);
            this.Name = "Listado_Factura_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de facturas por cliente";
            this.Load += new System.EventHandler(this.Listado_Factura_Cliente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_Factura_Cliente;
    }
}