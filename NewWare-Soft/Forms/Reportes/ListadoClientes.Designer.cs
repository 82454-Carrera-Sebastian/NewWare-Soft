
namespace NewWare_Soft.Forms.Reportes
{
    partial class ListadoClientes
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
            this.reportViewer_Clientes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer_Clientes
            // 
            this.reportViewer_Clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer_Clientes.LocalReport.ReportEmbeddedResource = "NewWare_Soft.Report_Clientes.rdlc";
            this.reportViewer_Clientes.Location = new System.Drawing.Point(0, 0);
            this.reportViewer_Clientes.Name = "reportViewer_Clientes";
            this.reportViewer_Clientes.ServerReport.BearerToken = null;
            this.reportViewer_Clientes.Size = new System.Drawing.Size(1169, 732);
            this.reportViewer_Clientes.TabIndex = 0;
            this.reportViewer_Clientes.Load += new System.EventHandler(this.reportViewer_Clientes_Load);
            // 
            // ListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 732);
            this.Controls.Add(this.reportViewer_Clientes);
            this.Name = "ListadoClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Clientes";
            this.Load += new System.EventHandler(this.ListadoClientes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_Clientes;
    }
}