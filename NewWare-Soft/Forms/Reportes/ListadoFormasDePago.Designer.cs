﻿
namespace NewWare_Soft.Forms.Reportes
{
    partial class ListadoFormasDePago
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
            this.report_FormasdePago = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // report_FormasdePago
            // 
            this.report_FormasdePago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.report_FormasdePago.LocalReport.ReportEmbeddedResource = "NewWare_Soft.ListadoFormasDePago.rdlc";
            this.report_FormasdePago.Location = new System.Drawing.Point(0, 0);
            this.report_FormasdePago.Name = "report_FormasdePago";
            this.report_FormasdePago.ServerReport.BearerToken = null;
            this.report_FormasdePago.Size = new System.Drawing.Size(800, 450);
            this.report_FormasdePago.TabIndex = 0;
            this.report_FormasdePago.Load += new System.EventHandler(this.report_FormasdePago_Load);
            // 
            // ListadoFormasDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.report_FormasdePago);
            this.Name = "ListadoFormasDePago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoFormasDePago";
            this.Load += new System.EventHandler(this.ListadoFormasDePago_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer report_FormasdePago;
    }
}