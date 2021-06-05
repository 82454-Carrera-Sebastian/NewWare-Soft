
namespace NewWare_Soft.Forms
{
    partial class ListadoDeUsuarios
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
            this.reportUsuarios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportUsuarios
            // 
            this.reportUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportUsuarios.LocalReport.ReportEmbeddedResource = "NewWare_Soft.Reporte_Usuarios.rdlc";
            this.reportUsuarios.Location = new System.Drawing.Point(0, 0);
            this.reportUsuarios.Name = "reportUsuarios";
            this.reportUsuarios.ServerReport.BearerToken = null;
            this.reportUsuarios.Size = new System.Drawing.Size(800, 450);
            this.reportUsuarios.TabIndex = 0;
            this.reportUsuarios.Load += new System.EventHandler(this.reportUsuarios_Load);
            // 
            // ListadoDeUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportUsuarios);
            this.Name = "ListadoDeUsuarios";
            this.Text = "ListadoDeUsuarios";
            this.Load += new System.EventHandler(this.ListadoDeUsuarios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportUsuarios;
    }
}