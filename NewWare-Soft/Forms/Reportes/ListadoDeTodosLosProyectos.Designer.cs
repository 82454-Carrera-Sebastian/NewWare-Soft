
namespace NewWare_Soft.Forms.Reportes
{
    partial class ListadoDeTodosLosProyectos
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
            this.reportProyectos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportProyectos
            // 
            this.reportProyectos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportProyectos.LocalReport.ReportEmbeddedResource = "NewWare_Soft.Reporte_Todos_Proyectos.rdlc";
            this.reportProyectos.Location = new System.Drawing.Point(0, 0);
            this.reportProyectos.Name = "reportProyectos";
            this.reportProyectos.ServerReport.BearerToken = null;
            this.reportProyectos.Size = new System.Drawing.Size(800, 450);
            this.reportProyectos.TabIndex = 0;
            this.reportProyectos.Load += new System.EventHandler(this.reportProyectos_Load);
            // 
            // ListadoDeTodosLosProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportProyectos);
            this.Name = "ListadoDeTodosLosProyectos";
            this.Text = "ListadoDeTodosLosProyectos";
            this.Load += new System.EventHandler(this.ListadoDeTodosLosProyectos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportProyectos;
    }
}