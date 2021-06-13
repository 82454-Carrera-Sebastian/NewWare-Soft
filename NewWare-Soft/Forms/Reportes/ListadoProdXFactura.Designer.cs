
namespace NewWare_Soft.Forms.Reportes
{
    partial class ListadoProdXFactura
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
            this.rptProducto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptProducto
            // 
            this.rptProducto.LocalReport.ReportEmbeddedResource = "NewWare_Soft.ReporteProdXFact.rdlc";
            this.rptProducto.Location = new System.Drawing.Point(-3, -1);
            this.rptProducto.Name = "rptProducto";
            this.rptProducto.ServerReport.BearerToken = null;
            this.rptProducto.Size = new System.Drawing.Size(803, 451);
            this.rptProducto.TabIndex = 0;
            this.rptProducto.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ListadoProdXFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 449);
            this.Controls.Add(this.rptProducto);
            this.Name = "ListadoProdXFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoProdXFactura";
            this.Load += new System.EventHandler(this.ListadoProdXFactura_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptProducto;
    }
}