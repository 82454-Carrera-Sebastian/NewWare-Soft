﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificacionBarrio));
            this.txtIdBarrio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.txtNombreBarrio = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.grillaBarrios = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnModificarBarrio = new System.Windows.Forms.Button();
            this.label_Empresa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaBarrios)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdBarrio
            // 
            this.txtIdBarrio.Enabled = false;
            this.txtIdBarrio.Location = new System.Drawing.Point(131, 152);
            this.txtIdBarrio.Name = "txtIdBarrio";
            this.txtIdBarrio.Size = new System.Drawing.Size(40, 20);
            this.txtIdBarrio.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id Barrio:";
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.DropDownHeight = 100;
            this.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudad.DropDownWidth = 100;
            this.cmbCiudad.Enabled = false;
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.IntegralHeight = false;
            this.cmbCiudad.ItemHeight = 13;
            this.cmbCiudad.Location = new System.Drawing.Point(131, 120);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(199, 21);
            this.cmbCiudad.TabIndex = 5;
            // 
            // txtNombreBarrio
            // 
            this.txtNombreBarrio.Enabled = false;
            this.txtNombreBarrio.Location = new System.Drawing.Point(131, 87);
            this.txtNombreBarrio.Name = "txtNombreBarrio";
            this.txtNombreBarrio.Size = new System.Drawing.Size(199, 20);
            this.txtNombreBarrio.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(15, 86);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(110, 18);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre Barrio:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(67, 119);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(58, 18);
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
            this.grillaBarrios.Location = new System.Drawing.Point(355, 87);
            this.grillaBarrios.Name = "grillaBarrios";
            this.grillaBarrios.ReadOnly = true;
            this.grillaBarrios.Size = new System.Drawing.Size(246, 243);
            this.grillaBarrios.TabIndex = 6;
            this.grillaBarrios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaBarrios_CellClick);
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
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(18, 200);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(137, 38);
            this.btnLimpiarCampos.TabIndex = 8;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimiarCampos_Click);
            // 
            // btnModificarBarrio
            // 
            this.btnModificarBarrio.Enabled = false;
            this.btnModificarBarrio.Location = new System.Drawing.Point(193, 200);
            this.btnModificarBarrio.Name = "btnModificarBarrio";
            this.btnModificarBarrio.Size = new System.Drawing.Size(137, 38);
            this.btnModificarBarrio.TabIndex = 9;
            this.btnModificarBarrio.Text = "Modificar Barrio";
            this.btnModificarBarrio.UseVisualStyleBackColor = true;
            this.btnModificarBarrio.Click += new System.EventHandler(this.btnModificarBarrio_Click);
            // 
            // label_Empresa
            // 
            this.label_Empresa.AutoSize = true;
            this.label_Empresa.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold);
            this.label_Empresa.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_Empresa.Location = new System.Drawing.Point(14, 9);
            this.label_Empresa.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_Empresa.Name = "label_Empresa";
            this.label_Empresa.Size = new System.Drawing.Size(190, 24);
            this.label_Empresa.TabIndex = 35;
            this.label_Empresa.Text = "NewWare-Soft";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(231, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Modificar un Barrio";
            // 
            // ModificacionBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 341);
            this.Controls.Add(this.label_Empresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdBarrio);
            this.Controls.Add(this.btnModificarBarrio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.grillaBarrios);
            this.Controls.Add(this.txtNombreBarrio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCiudad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificacionBarrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificacion Barrio";
            this.Load += new System.EventHandler(this.ModificacionBarrio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaBarrios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label label_Empresa;
        private System.Windows.Forms.Label label2;
    }
}