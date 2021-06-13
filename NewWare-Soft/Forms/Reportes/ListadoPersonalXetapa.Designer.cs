
namespace NewWare_Soft.Forms.Reportes
{
    partial class ListadoPersonalXetapa
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
            this.reportViewerPersonalXetapa = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox_tipoReporte = new System.Windows.Forms.GroupBox();
            this.button_Siguiente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoReporte = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox_Hasta = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_Desde = new System.Windows.Forms.MaskedTextBox();
            this.label_Hasta = new System.Windows.Forms.Label();
            this.label_Desde = new System.Windows.Forms.Label();
            this.lblIdEtapa = new System.Windows.Forms.Label();
            this.txtGeneral = new System.Windows.Forms.TextBox();
            this.groupBox_tipoReporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewerPersonalXetapa
            // 
            this.reportViewerPersonalXetapa.LocalReport.ReportEmbeddedResource = "NewWare_Soft.Reporte_PersonalXetapa.rdlc";
            this.reportViewerPersonalXetapa.Location = new System.Drawing.Point(0, 137);
            this.reportViewerPersonalXetapa.Name = "reportViewerPersonalXetapa";
            this.reportViewerPersonalXetapa.ServerReport.BearerToken = null;
            this.reportViewerPersonalXetapa.Size = new System.Drawing.Size(632, 292);
            this.reportViewerPersonalXetapa.TabIndex = 0;
            this.reportViewerPersonalXetapa.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // groupBox_tipoReporte
            // 
            this.groupBox_tipoReporte.Controls.Add(this.button_Siguiente);
            this.groupBox_tipoReporte.Controls.Add(this.label1);
            this.groupBox_tipoReporte.Controls.Add(this.cmbTipoReporte);
            this.groupBox_tipoReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_tipoReporte.Location = new System.Drawing.Point(0, 2);
            this.groupBox_tipoReporte.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_tipoReporte.Name = "groupBox_tipoReporte";
            this.groupBox_tipoReporte.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_tipoReporte.Size = new System.Drawing.Size(757, 51);
            this.groupBox_tipoReporte.TabIndex = 12;
            this.groupBox_tipoReporte.TabStop = false;
            this.groupBox_tipoReporte.Text = "Eleccion Reporte";
            // 
            // button_Siguiente
            // 
            this.button_Siguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Siguiente.Location = new System.Drawing.Point(522, 14);
            this.button_Siguiente.Margin = new System.Windows.Forms.Padding(2);
            this.button_Siguiente.Name = "button_Siguiente";
            this.button_Siguiente.Size = new System.Drawing.Size(99, 27);
            this.button_Siguiente.TabIndex = 7;
            this.button_Siguiente.Text = "Siguiente";
            this.button_Siguiente.UseVisualStyleBackColor = true;
            this.button_Siguiente.Click += new System.EventHandler(this.button_Siguiente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo de Reporte";
            // 
            // cmbTipoReporte
            // 
            this.cmbTipoReporte.FormattingEnabled = true;
            this.cmbTipoReporte.Location = new System.Drawing.Point(132, 17);
            this.cmbTipoReporte.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoReporte.Name = "cmbTipoReporte";
            this.cmbTipoReporte.Size = new System.Drawing.Size(342, 24);
            this.cmbTipoReporte.TabIndex = 12;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(525, 97);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 27);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Formato: DD/MM/AAAA";
            this.label2.Visible = false;
            // 
            // maskedTextBox_Hasta
            // 
            this.maskedTextBox_Hasta.Enabled = false;
            this.maskedTextBox_Hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_Hasta.Location = new System.Drawing.Point(405, 80);
            this.maskedTextBox_Hasta.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox_Hasta.Mask = "00/00/0000";
            this.maskedTextBox_Hasta.Name = "maskedTextBox_Hasta";
            this.maskedTextBox_Hasta.Size = new System.Drawing.Size(69, 23);
            this.maskedTextBox_Hasta.TabIndex = 29;
            this.maskedTextBox_Hasta.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox_Hasta.Visible = false;
            // 
            // maskedTextBox_Desde
            // 
            this.maskedTextBox_Desde.Enabled = false;
            this.maskedTextBox_Desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_Desde.Location = new System.Drawing.Point(275, 80);
            this.maskedTextBox_Desde.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox_Desde.Mask = "00/00/0000";
            this.maskedTextBox_Desde.Name = "maskedTextBox_Desde";
            this.maskedTextBox_Desde.Size = new System.Drawing.Size(71, 23);
            this.maskedTextBox_Desde.TabIndex = 28;
            this.maskedTextBox_Desde.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox_Desde.Visible = false;
            // 
            // label_Hasta
            // 
            this.label_Hasta.AutoSize = true;
            this.label_Hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Hasta.Location = new System.Drawing.Point(360, 83);
            this.label_Hasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Hasta.Name = "label_Hasta";
            this.label_Hasta.Size = new System.Drawing.Size(45, 17);
            this.label_Hasta.TabIndex = 27;
            this.label_Hasta.Text = "Hasta";
            this.label_Hasta.Visible = false;
            // 
            // label_Desde
            // 
            this.label_Desde.AutoSize = true;
            this.label_Desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Desde.Location = new System.Drawing.Point(225, 83);
            this.label_Desde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Desde.Name = "label_Desde";
            this.label_Desde.Size = new System.Drawing.Size(49, 17);
            this.label_Desde.TabIndex = 25;
            this.label_Desde.Text = "Desde";
            this.label_Desde.Visible = false;
            // 
            // lblIdEtapa
            // 
            this.lblIdEtapa.AutoSize = true;
            this.lblIdEtapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEtapa.Location = new System.Drawing.Point(107, 60);
            this.lblIdEtapa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdEtapa.Name = "lblIdEtapa";
            this.lblIdEtapa.Size = new System.Drawing.Size(19, 17);
            this.lblIdEtapa.TabIndex = 23;
            this.lblIdEtapa.Text = "Id";
            this.lblIdEtapa.Visible = false;
            // 
            // txtGeneral
            // 
            this.txtGeneral.Location = new System.Drawing.Point(132, 59);
            this.txtGeneral.Name = "txtGeneral";
            this.txtGeneral.Size = new System.Drawing.Size(68, 20);
            this.txtGeneral.TabIndex = 31;
            this.txtGeneral.Visible = false;
            // 
            // ListadoPersonalXetapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 425);
            this.Controls.Add(this.txtGeneral);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBox_Hasta);
            this.Controls.Add(this.maskedTextBox_Desde);
            this.Controls.Add(this.label_Hasta);
            this.Controls.Add(this.label_Desde);
            this.Controls.Add(this.lblIdEtapa);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox_tipoReporte);
            this.Controls.Add(this.reportViewerPersonalXetapa);
            this.Name = "ListadoPersonalXetapa";
            this.Text = "ListadoPersonalXetapa";
            this.Load += new System.EventHandler(this.ListadoPersonalXetapa_Load);
            this.groupBox_tipoReporte.ResumeLayout(false);
            this.groupBox_tipoReporte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPersonalXetapa;
        private System.Windows.Forms.GroupBox groupBox_tipoReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Hasta;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Desde;
        private System.Windows.Forms.Label label_Hasta;
        private System.Windows.Forms.Label label_Desde;
        private System.Windows.Forms.Label lblIdEtapa;
        private System.Windows.Forms.Button button_Siguiente;
        private System.Windows.Forms.TextBox txtGeneral;
        private System.Windows.Forms.ComboBox cmbTipoReporte;
    }
}