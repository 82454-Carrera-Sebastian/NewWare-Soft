
namespace NewWare_Soft.Forms
{
    partial class ModificacionBarrio
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.txtNombreBarrio = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.grillaBarrios = new System.Windows.Forms.DataGridView();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnModificarBarrio = new System.Windows.Forms.Button();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdBarrio = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaBarrios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdBarrio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbCiudad);
            this.groupBox1.Controls.Add(this.txtNombreBarrio);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblCiudad);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 209);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.DropDownHeight = 100;
            this.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudad.DropDownWidth = 100;
            this.cmbCiudad.Enabled = false;
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.IntegralHeight = false;
            this.cmbCiudad.ItemHeight = 24;
            this.cmbCiudad.Location = new System.Drawing.Point(83, 113);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(150, 32);
            this.cmbCiudad.TabIndex = 5;
            // 
            // txtNombreBarrio
            // 
            this.txtNombreBarrio.Enabled = false;
            this.txtNombreBarrio.Location = new System.Drawing.Point(150, 53);
            this.txtNombreBarrio.Name = "txtNombreBarrio";
            this.txtNombreBarrio.Size = new System.Drawing.Size(199, 29);
            this.txtNombreBarrio.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(7, 59);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(129, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre Barrio:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(7, 119);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(70, 20);
            this.lblCiudad.TabIndex = 2;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // grillaBarrios
            // 
            this.grillaBarrios.AllowUserToAddRows = false;
            this.grillaBarrios.AllowUserToDeleteRows = false;
            this.grillaBarrios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaBarrios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Nombre,
            this.Ciudad});
            this.grillaBarrios.Location = new System.Drawing.Point(373, 12);
            this.grillaBarrios.Name = "grillaBarrios";
            this.grillaBarrios.ReadOnly = true;
            this.grillaBarrios.Size = new System.Drawing.Size(246, 243);
            this.grillaBarrios.TabIndex = 6;
            this.grillaBarrios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaBarrios_CellClick);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(410, 277);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(97, 23);
            this.btnLimpiarCampos.TabIndex = 8;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimiarCampos_Click);
            // 
            // btnModificarBarrio
            // 
            this.btnModificarBarrio.Enabled = false;
            this.btnModificarBarrio.Location = new System.Drawing.Point(513, 277);
            this.btnModificarBarrio.Name = "btnModificarBarrio";
            this.btnModificarBarrio.Size = new System.Drawing.Size(97, 23);
            this.btnModificarBarrio.TabIndex = 9;
            this.btnModificarBarrio.Text = "Modificar Barrio";
            this.btnModificarBarrio.UseVisualStyleBackColor = true;
            this.btnModificarBarrio.Click += new System.EventHandler(this.btnModificarBarrio_Click);
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "IdBarrio";
            this.Numero.HeaderText = "Nro";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "NombreBarrio";
            this.Nombre.HeaderText = "NombreBarrio";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Ciudad
            // 
            this.Ciudad.DataPropertyName = "IdCiudad";
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id Barrio:";
            // 
            // txtIdBarrio
            // 
            this.txtIdBarrio.Enabled = false;
            this.txtIdBarrio.Location = new System.Drawing.Point(96, 168);
            this.txtIdBarrio.Name = "txtIdBarrio";
            this.txtIdBarrio.Size = new System.Drawing.Size(40, 29);
            this.txtIdBarrio.TabIndex = 7;
            // 
            // ModificacionBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 324);
            this.Controls.Add(this.btnModificarBarrio);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.grillaBarrios);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModificacionBarrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificacionBarrio";
            this.Load += new System.EventHandler(this.ModificacionBarrio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaBarrios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.TextBox txtNombreBarrio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.DataGridView grillaBarrios;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnModificarBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.TextBox txtIdBarrio;
        private System.Windows.Forms.Label label1;
    }
}