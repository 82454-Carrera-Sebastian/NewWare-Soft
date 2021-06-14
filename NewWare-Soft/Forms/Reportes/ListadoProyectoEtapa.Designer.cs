namespace NewWare_Soft.Forms.Reportes
{
    partial class ListadoProyectoEtapa
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_SeleccPatron = new System.Windows.Forms.Button();
            this.lbl_Patron = new System.Windows.Forms.Label();
            this.cmbEtapas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btConf = new System.Windows.Forms.Button();
            this.rbCli = new System.Windows.Forms.RadioButton();
            this.rbMes = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "NewWare_Soft.ReporteProyectoEtapa.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 126);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 377);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Visible = false;
            // 
            // btn_SeleccPatron
            // 
            this.btn_SeleccPatron.Enabled = false;
            this.btn_SeleccPatron.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SeleccPatron.Location = new System.Drawing.Point(596, 85);
            this.btn_SeleccPatron.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SeleccPatron.Name = "btn_SeleccPatron";
            this.btn_SeleccPatron.Size = new System.Drawing.Size(173, 27);
            this.btn_SeleccPatron.TabIndex = 42;
            this.btn_SeleccPatron.Text = "Buscar";
            this.btn_SeleccPatron.UseVisualStyleBackColor = true;
            this.btn_SeleccPatron.Click += new System.EventHandler(this.btn_SeleccPatron_Click);
            // 
            // lbl_Patron
            // 
            this.lbl_Patron.AutoSize = true;
            this.lbl_Patron.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Patron.Location = new System.Drawing.Point(433, 60);
            this.lbl_Patron.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Patron.Name = "lbl_Patron";
            this.lbl_Patron.Size = new System.Drawing.Size(136, 17);
            this.lbl_Patron.TabIndex = 41;
            this.lbl_Patron.Text = "Seleccione la etapa:";
            // 
            // cmbEtapas
            // 
            this.cmbEtapas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEtapas.Enabled = false;
            this.cmbEtapas.FormattingEnabled = true;
            this.cmbEtapas.Location = new System.Drawing.Point(574, 59);
            this.cmbEtapas.Name = "cmbEtapas";
            this.cmbEtapas.Size = new System.Drawing.Size(195, 21);
            this.cmbEtapas.TabIndex = 44;
            this.cmbEtapas.SelectedIndexChanged += new System.EventHandler(this.cmbEtapas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Ingrese una fecha:";
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(574, 28);
            this.txtFecha.Mask = "00/00/0000";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(195, 20);
            this.txtFecha.TabIndex = 46;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btConf);
            this.groupBox1.Controls.Add(this.rbCli);
            this.groupBox1.Controls.Add(this.rbMes);
            this.groupBox1.Location = new System.Drawing.Point(22, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 105);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione los filtros para generar su informe";
            // 
            // btConf
            // 
            this.btConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConf.Location = new System.Drawing.Point(162, 69);
            this.btConf.Margin = new System.Windows.Forms.Padding(2);
            this.btConf.Name = "btConf";
            this.btConf.Size = new System.Drawing.Size(173, 27);
            this.btConf.TabIndex = 44;
            this.btConf.Text = "Seleccionar";
            this.btConf.UseVisualStyleBackColor = true;
            this.btConf.Click += new System.EventHandler(this.btConf_Click_1);
            // 
            // rbCli
            // 
            this.rbCli.AutoSize = true;
            this.rbCli.Location = new System.Drawing.Point(36, 41);
            this.rbCli.Name = "rbCli";
            this.rbCli.Size = new System.Drawing.Size(178, 17);
            this.rbCli.TabIndex = 43;
            this.rbCli.TabStop = true;
            this.rbCli.Text = "Filtrar por etapa y fecha de inicio";
            this.rbCli.UseVisualStyleBackColor = true;
            // 
            // rbMes
            // 
            this.rbMes.AutoSize = true;
            this.rbMes.Location = new System.Drawing.Point(36, 19);
            this.rbMes.Name = "rbMes";
            this.rbMes.Size = new System.Drawing.Size(98, 17);
            this.rbMes.TabIndex = 42;
            this.rbMes.TabStop = true;
            this.rbMes.Text = "Filtrar por etapa";
            this.rbMes.UseVisualStyleBackColor = true;
            // 
            // ListadoProyectoEtapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEtapas);
            this.Controls.Add(this.btn_SeleccPatron);
            this.Controls.Add(this.lbl_Patron);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ListadoProyectoEtapa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Proyectos por Etapa";
            this.Load += new System.EventHandler(this.ListadoProyectoEtapa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btn_SeleccPatron;
        private System.Windows.Forms.Label lbl_Patron;
        private System.Windows.Forms.ComboBox cmbEtapas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btConf;
        private System.Windows.Forms.RadioButton rbCli;
        private System.Windows.Forms.RadioButton rbMes;
    }
}