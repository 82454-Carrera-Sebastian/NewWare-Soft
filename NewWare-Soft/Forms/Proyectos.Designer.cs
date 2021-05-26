
namespace NewWare_Soft.Forms
{
    partial class Proyectos
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
            this.lblFinReal = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblFinProbable = new System.Windows.Forms.Label();
            this.fechaInicial = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnAgregarProyecto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNombreEtapa = new System.Windows.Forms.Label();
            this.cmbEtapas = new System.Windows.Forms.ComboBox();
            this.btnAgregarEtapa = new System.Windows.Forms.Button();
            this.grdEtapas = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblIDProyecto = new System.Windows.Forms.Label();
            this.txtIDProyecto = new System.Windows.Forms.TextBox();
            this.txtFin = new System.Windows.Forms.MaskedTextBox();
            this.txtFinReal = new System.Windows.Forms.MaskedTextBox();
            this.txtInicio = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEtapas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFinReal
            // 
            this.lblFinReal.AutoSize = true;
            this.lblFinReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinReal.Location = new System.Drawing.Point(12, 162);
            this.lblFinReal.Name = "lblFinReal";
            this.lblFinReal.Size = new System.Drawing.Size(100, 18);
            this.lblFinReal.TabIndex = 24;
            this.lblFinReal.Text = "Fecha fin real:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(173, 52);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(241, 20);
            this.txtDescripcion.TabIndex = 15;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(173, 21);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(61, 20);
            this.txtCliente.TabIndex = 14;
            // 
            // lblFinProbable
            // 
            this.lblFinProbable.AutoSize = true;
            this.lblFinProbable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinProbable.Location = new System.Drawing.Point(12, 122);
            this.lblFinProbable.Name = "lblFinProbable";
            this.lblFinProbable.Size = new System.Drawing.Size(133, 18);
            this.lblFinProbable.TabIndex = 23;
            this.lblFinProbable.Text = "Fecha fin probable:";
            // 
            // fechaInicial
            // 
            this.fechaInicial.AutoSize = true;
            this.fechaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaInicial.Location = new System.Drawing.Point(12, 85);
            this.fechaInicial.Name = "fechaInicial";
            this.fechaInicial.Size = new System.Drawing.Size(111, 18);
            this.fechaInicial.TabIndex = 22;
            this.fechaInicial.Text = "Fecha de inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Descripción:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(12, 347);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(101, 32);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(12, 20);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(57, 18);
            this.lblCliente.TabIndex = 20;
            this.lblCliente.Text = "Cliente:";
            // 
            // btnAgregarProyecto
            // 
            this.btnAgregarProyecto.Enabled = false;
            this.btnAgregarProyecto.Location = new System.Drawing.Point(12, 309);
            this.btnAgregarProyecto.Name = "btnAgregarProyecto";
            this.btnAgregarProyecto.Size = new System.Drawing.Size(101, 32);
            this.btnAgregarProyecto.TabIndex = 18;
            this.btnAgregarProyecto.Text = "Agregar Proyecto";
            this.btnAgregarProyecto.UseVisualStyleBackColor = true;
            this.btnAgregarProyecto.Click += new System.EventHandler(this.btnAgregarProyecto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNombreEtapa);
            this.groupBox1.Controls.Add(this.cmbEtapas);
            this.groupBox1.Controls.Add(this.btnAgregarEtapa);
            this.groupBox1.Controls.Add(this.grdEtapas);
            this.groupBox1.Location = new System.Drawing.Point(436, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 358);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Etapas del proyecto";
            // 
            // lblNombreEtapa
            // 
            this.lblNombreEtapa.AutoSize = true;
            this.lblNombreEtapa.Location = new System.Drawing.Point(15, 55);
            this.lblNombreEtapa.Name = "lblNombreEtapa";
            this.lblNombreEtapa.Size = new System.Drawing.Size(75, 13);
            this.lblNombreEtapa.TabIndex = 17;
            this.lblNombreEtapa.Text = "NombreEtapa:";
            // 
            // cmbEtapas
            // 
            this.cmbEtapas.FormattingEnabled = true;
            this.cmbEtapas.Location = new System.Drawing.Point(121, 47);
            this.cmbEtapas.Name = "cmbEtapas";
            this.cmbEtapas.Size = new System.Drawing.Size(121, 21);
            this.cmbEtapas.TabIndex = 16;
            // 
            // btnAgregarEtapa
            // 
            this.btnAgregarEtapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEtapa.Location = new System.Drawing.Point(207, 83);
            this.btnAgregarEtapa.Name = "btnAgregarEtapa";
            this.btnAgregarEtapa.Size = new System.Drawing.Size(118, 27);
            this.btnAgregarEtapa.TabIndex = 9;
            this.btnAgregarEtapa.Text = "Agregar Etapa";
            this.btnAgregarEtapa.UseVisualStyleBackColor = true;
            this.btnAgregarEtapa.Click += new System.EventHandler(this.btnAgregarEtapa_Click);
            // 
            // grdEtapas
            // 
            this.grdEtapas.AllowUserToAddRows = false;
            this.grdEtapas.AllowUserToDeleteRows = false;
            this.grdEtapas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEtapas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre});
            this.grdEtapas.Location = new System.Drawing.Point(18, 128);
            this.grdEtapas.Name = "grdEtapas";
            this.grdEtapas.ReadOnly = true;
            this.grdEtapas.Size = new System.Drawing.Size(245, 224);
            this.grdEtapas.TabIndex = 15;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // lblIDProyecto
            // 
            this.lblIDProyecto.AutoSize = true;
            this.lblIDProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDProyecto.Location = new System.Drawing.Point(13, 205);
            this.lblIDProyecto.Name = "lblIDProyecto";
            this.lblIDProyecto.Size = new System.Drawing.Size(92, 18);
            this.lblIDProyecto.TabIndex = 27;
            this.lblIDProyecto.Text = "ID proyecto: ";
            // 
            // txtIDProyecto
            // 
            this.txtIDProyecto.Enabled = false;
            this.txtIDProyecto.Location = new System.Drawing.Point(173, 203);
            this.txtIDProyecto.Name = "txtIDProyecto";
            this.txtIDProyecto.Size = new System.Drawing.Size(61, 20);
            this.txtIDProyecto.TabIndex = 28;
            // 
            // txtFin
            // 
            this.txtFin.Location = new System.Drawing.Point(173, 120);
            this.txtFin.Mask = "00/00/0000";
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(66, 20);
            this.txtFin.TabIndex = 29;
            this.txtFin.ValidatingType = typeof(System.DateTime);
            // 
            // txtFinReal
            // 
            this.txtFinReal.Location = new System.Drawing.Point(173, 160);
            this.txtFinReal.Mask = "00/00/0000";
            this.txtFinReal.Name = "txtFinReal";
            this.txtFinReal.Size = new System.Drawing.Size(66, 20);
            this.txtFinReal.TabIndex = 30;
            this.txtFinReal.ValidatingType = typeof(System.DateTime);
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(173, 86);
            this.txtInicio.Mask = "00/00/0000";
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(66, 20);
            this.txtInicio.TabIndex = 16;
            this.txtInicio.ValidatingType = typeof(System.DateTime);
            // 
            // Proyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 460);
            this.Controls.Add(this.txtFinReal);
            this.Controls.Add(this.txtFin);
            this.Controls.Add(this.txtIDProyecto);
            this.Controls.Add(this.lblIDProyecto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFinReal);
            this.Controls.Add(this.txtInicio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblFinProbable);
            this.Controls.Add(this.fechaInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnAgregarProyecto);
            this.Name = "Proyectos";
            this.Text = "Proyectos";
            this.Load += new System.EventHandler(this.Proyectos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEtapas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFinReal;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblFinProbable;
        private System.Windows.Forms.Label fechaInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnAgregarProyecto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNombreEtapa;
        private System.Windows.Forms.ComboBox cmbEtapas;
        private System.Windows.Forms.Button btnAgregarEtapa;
        private System.Windows.Forms.DataGridView grdEtapas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.Label lblIDProyecto;
        private System.Windows.Forms.TextBox txtIDProyecto;
        private System.Windows.Forms.MaskedTextBox txtFin;
        private System.Windows.Forms.MaskedTextBox txtFinReal;
        private System.Windows.Forms.MaskedTextBox txtInicio;
    }
}