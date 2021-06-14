namespace NewWare_Soft.Forms.Reportes
{
    partial class ListadoProyectoMes
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
            this.lblMes = new System.Windows.Forms.Label();
            this.meses = new System.Windows.Forms.ComboBox();
            this.lblCli = new System.Windows.Forms.Label();
            this.rbMes = new System.Windows.Forms.RadioButton();
            this.rbCli = new System.Windows.Forms.RadioButton();
            this.btConf = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCli = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "NewWare_Soft.ReporteProyectoMes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 127);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 374);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Visible = false;
            // 
            // btn_SeleccPatron
            // 
            this.btn_SeleccPatron.Enabled = false;
            this.btn_SeleccPatron.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SeleccPatron.Location = new System.Drawing.Point(573, 81);
            this.btn_SeleccPatron.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SeleccPatron.Name = "btn_SeleccPatron";
            this.btn_SeleccPatron.Size = new System.Drawing.Size(173, 27);
            this.btn_SeleccPatron.TabIndex = 39;
            this.btn_SeleccPatron.Text = "Buscar";
            this.btn_SeleccPatron.UseVisualStyleBackColor = true;
            this.btn_SeleccPatron.Click += new System.EventHandler(this.btn_SeleccPatron_Click);
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(416, 56);
            this.lblMes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(152, 17);
            this.lblMes.TabIndex = 37;
            this.lblMes.Text = "Ingrese el mes a filtrar:";
            // 
            // meses
            // 
            this.meses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.meses.Enabled = false;
            this.meses.FormattingEnabled = true;
            this.meses.Location = new System.Drawing.Point(573, 55);
            this.meses.Name = "meses";
            this.meses.Size = new System.Drawing.Size(173, 21);
            this.meses.TabIndex = 40;
            // 
            // lblCli
            // 
            this.lblCli.AutoSize = true;
            this.lblCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCli.Location = new System.Drawing.Point(404, 31);
            this.lblCli.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCli.Name = "lblCli";
            this.lblCli.Size = new System.Drawing.Size(164, 17);
            this.lblCli.TabIndex = 41;
            this.lblCli.Text = "Ingrese el nro de cliente:";
            // 
            // rbMes
            // 
            this.rbMes.AutoSize = true;
            this.rbMes.Location = new System.Drawing.Point(36, 19);
            this.rbMes.Name = "rbMes";
            this.rbMes.Size = new System.Drawing.Size(90, 17);
            this.rbMes.TabIndex = 42;
            this.rbMes.TabStop = true;
            this.rbMes.Text = "Filtrar por mes";
            this.rbMes.UseVisualStyleBackColor = true;
            // 
            // rbCli
            // 
            this.rbCli.AutoSize = true;
            this.rbCli.Location = new System.Drawing.Point(36, 41);
            this.rbCli.Name = "rbCli";
            this.rbCli.Size = new System.Drawing.Size(132, 17);
            this.rbCli.TabIndex = 43;
            this.rbCli.TabStop = true;
            this.rbCli.Text = "Filtrar por mes y cliente";
            this.rbCli.UseVisualStyleBackColor = true;
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
            this.btConf.Click += new System.EventHandler(this.btConf_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btConf);
            this.groupBox1.Controls.Add(this.rbCli);
            this.groupBox1.Controls.Add(this.rbMes);
            this.groupBox1.Location = new System.Drawing.Point(32, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 105);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione los filtros para generar su informe";
            // 
            // txtCli
            // 
            this.txtCli.Enabled = false;
            this.txtCli.Location = new System.Drawing.Point(573, 30);
            this.txtCli.Name = "txtCli";
            this.txtCli.Size = new System.Drawing.Size(173, 20);
            this.txtCli.TabIndex = 46;
            // 
            // ListadoProyectoMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.txtCli);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCli);
            this.Controls.Add(this.meses);
            this.Controls.Add(this.btn_SeleccPatron);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ListadoProyectoMes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Proyectos por Mes";
            this.Load += new System.EventHandler(this.ListadoProyectoMes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btn_SeleccPatron;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.ComboBox meses;
        private System.Windows.Forms.Label lblCli;
        private System.Windows.Forms.RadioButton rbMes;
        private System.Windows.Forms.RadioButton rbCli;
        private System.Windows.Forms.Button btConf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCli;
    }
}