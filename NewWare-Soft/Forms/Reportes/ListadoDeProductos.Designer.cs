
namespace NewWare_Soft.Forms.Reportes
{
    partial class ListadoDeProductos
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
            this.listadoProductos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // listadoProductos
            // 
            this.listadoProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listadoProductos.LocalReport.ReportEmbeddedResource = "NewWare_Soft.ListadoDeProductos.rdlc";
            this.listadoProductos.Location = new System.Drawing.Point(0, 0);
            this.listadoProductos.Name = "listadoProductos";
            this.listadoProductos.ServerReport.BearerToken = null;
            this.listadoProductos.Size = new System.Drawing.Size(800, 450);
            this.listadoProductos.TabIndex = 0;
            this.listadoProductos.Load += new System.EventHandler(this.listadoProductos_Load);
            // 
            // ListadoDeProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listadoProductos);
            this.Name = "ListadoDeProductos";
            this.Text = "ListadoDeProductos";
            this.Load += new System.EventHandler(this.ListadoDeProductos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer listadoProductos;
    }
}