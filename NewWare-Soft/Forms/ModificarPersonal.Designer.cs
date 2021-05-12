﻿namespace NewWare_Soft.Forms
{
    partial class ModificarPersonal
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
            this.lblTitleMod = new System.Windows.Forms.Label();
            this.btMenu = new System.Windows.Forms.Button();
            this.cmbBarrio = new System.Windows.Forms.ComboBox();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.cmbEgreso = new System.Windows.Forms.ComboBox();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btActualizar = new System.Windows.Forms.Button();
            this.gdrPersonal = new System.Windows.Forms.DataGridView();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.txtNroDoc = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaEgreso = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaIngreso = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblIdBarrio = new System.Windows.Forms.Label();
            this.txtNroCalle = new System.Windows.Forms.TextBox();
            this.lblNroCalle = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblIdCargo = new System.Windows.Forms.Label();
            this.lblIdEgreso = new System.Windows.Forms.Label();
            this.lblFechaEgreso = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNroDoc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdrPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleMod
            // 
            this.lblTitleMod.AutoSize = true;
            this.lblTitleMod.Location = new System.Drawing.Point(410, 37);
            this.lblTitleMod.Name = "lblTitleMod";
            this.lblTitleMod.Size = new System.Drawing.Size(289, 13);
            this.lblTitleMod.TabIndex = 94;
            this.lblTitleMod.Text = "Seleccione un empleado existente para modificar sus datos:";
            // 
            // btMenu
            // 
            this.btMenu.Location = new System.Drawing.Point(916, 14);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(67, 37);
            this.btMenu.TabIndex = 93;
            this.btMenu.Text = "Volver a Menu";
            this.btMenu.UseVisualStyleBackColor = true;
            this.btMenu.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // cmbBarrio
            // 
            this.cmbBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBarrio.FormattingEnabled = true;
            this.cmbBarrio.Location = new System.Drawing.Point(154, 525);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(217, 21);
            this.cmbBarrio.TabIndex = 75;
            // 
            // cmbCargo
            // 
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(154, 413);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(217, 21);
            this.cmbCargo.TabIndex = 72;
            // 
            // cmbEgreso
            // 
            this.cmbEgreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEgreso.FormattingEnabled = true;
            this.cmbEgreso.Location = new System.Drawing.Point(154, 376);
            this.cmbEgreso.Name = "cmbEgreso";
            this.cmbEgreso.Size = new System.Drawing.Size(217, 21);
            this.cmbEgreso.TabIndex = 71;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(154, 216);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(217, 21);
            this.cmbUsuario.TabIndex = 67;
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(733, 517);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(250, 28);
            this.btLimpiar.TabIndex = 77;
            this.btLimpiar.Text = "Limpiar Campos";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btActualizar
            // 
            this.btActualizar.Location = new System.Drawing.Point(410, 517);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(250, 28);
            this.btActualizar.TabIndex = 76;
            this.btActualizar.Text = "Actualizar Datos";
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // gdrPersonal
            // 
            this.gdrPersonal.AllowUserToAddRows = false;
            this.gdrPersonal.AllowUserToDeleteRows = false;
            this.gdrPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Legajo,
            this.NroDocumento,
            this.Apellido,
            this.Nombre,
            this.FechaNacimiento});
            this.gdrPersonal.Location = new System.Drawing.Point(410, 66);
            this.gdrPersonal.Name = "gdrPersonal";
            this.gdrPersonal.ReadOnly = true;
            this.gdrPersonal.Size = new System.Drawing.Size(573, 437);
            this.gdrPersonal.TabIndex = 92;
            this.gdrPersonal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrPersonal_CellClick);
            // 
            // Legajo
            // 
            this.Legajo.DataPropertyName = "Legajo";
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            this.Legajo.Width = 80;
            // 
            // NroDocumento
            // 
            this.NroDocumento.DataPropertyName = "NroDni";
            this.NroDocumento.HeaderText = "NroDocumento";
            this.NroDocumento.Name = "NroDocumento";
            this.NroDocumento.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 115;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 115;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.DataPropertyName = "FechaNacimiento";
            this.FechaNacimiento.HeaderText = "FechaNacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            this.FechaNacimiento.Width = 120;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(154, 66);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.ReadOnly = true;
            this.txtLegajo.Size = new System.Drawing.Size(217, 20);
            this.txtLegajo.TabIndex = 91;
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(92, 69);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(42, 13);
            this.lblLegajo.TabIndex = 90;
            this.lblLegajo.Text = "Legajo:";
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Location = new System.Drawing.Point(154, 104);
            this.txtNroDoc.Mask = "99999999";
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Size = new System.Drawing.Size(217, 20);
            this.txtNroDoc.TabIndex = 64;
            // 
            // txtFechaEgreso
            // 
            this.txtFechaEgreso.Location = new System.Drawing.Point(154, 334);
            this.txtFechaEgreso.Mask = "00/00/0000";
            this.txtFechaEgreso.Name = "txtFechaEgreso";
            this.txtFechaEgreso.Size = new System.Drawing.Size(217, 20);
            this.txtFechaEgreso.TabIndex = 70;
            this.txtFechaEgreso.ValidatingType = typeof(System.DateTime);
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.Location = new System.Drawing.Point(154, 295);
            this.txtFechaIngreso.Mask = "00/00/0000";
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(217, 20);
            this.txtFechaIngreso.TabIndex = 69;
            this.txtFechaIngreso.ValidatingType = typeof(System.DateTime);
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(154, 256);
            this.txtFechaNacimiento.Mask = "00/00/0000";
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(217, 20);
            this.txtFechaNacimiento.TabIndex = 68;
            this.txtFechaNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(28, 259);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(111, 13);
            this.lblFechaNacimiento.TabIndex = 89;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lblIdBarrio
            // 
            this.lblIdBarrio.AutoSize = true;
            this.lblIdBarrio.Location = new System.Drawing.Point(93, 528);
            this.lblIdBarrio.Name = "lblIdBarrio";
            this.lblIdBarrio.Size = new System.Drawing.Size(46, 13);
            this.lblIdBarrio.TabIndex = 88;
            this.lblIdBarrio.Text = "IdBarrio:";
            // 
            // txtNroCalle
            // 
            this.txtNroCalle.Location = new System.Drawing.Point(154, 487);
            this.txtNroCalle.Name = "txtNroCalle";
            this.txtNroCalle.Size = new System.Drawing.Size(217, 20);
            this.txtNroCalle.TabIndex = 74;
            // 
            // lblNroCalle
            // 
            this.lblNroCalle.AutoSize = true;
            this.lblNroCalle.Location = new System.Drawing.Point(51, 490);
            this.lblNroCalle.Name = "lblNroCalle";
            this.lblNroCalle.Size = new System.Drawing.Size(88, 13);
            this.lblNroCalle.TabIndex = 87;
            this.lblNroCalle.Text = "Numero de Calle:";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(154, 450);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(217, 20);
            this.txtCalle.TabIndex = 73;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(106, 453);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(33, 13);
            this.lblCalle.TabIndex = 86;
            this.lblCalle.Text = "Calle:";
            // 
            // lblIdCargo
            // 
            this.lblIdCargo.AutoSize = true;
            this.lblIdCargo.Location = new System.Drawing.Point(92, 416);
            this.lblIdCargo.Name = "lblIdCargo";
            this.lblIdCargo.Size = new System.Drawing.Size(47, 13);
            this.lblIdCargo.TabIndex = 85;
            this.lblIdCargo.Text = "IdCargo:";
            // 
            // lblIdEgreso
            // 
            this.lblIdEgreso.AutoSize = true;
            this.lblIdEgreso.Location = new System.Drawing.Point(46, 379);
            this.lblIdEgreso.Name = "lblIdEgreso";
            this.lblIdEgreso.Size = new System.Drawing.Size(93, 13);
            this.lblIdEgreso.TabIndex = 84;
            this.lblIdEgreso.Text = "Motivo de Egreso:";
            // 
            // lblFechaEgreso
            // 
            this.lblFechaEgreso.AutoSize = true;
            this.lblFechaEgreso.Location = new System.Drawing.Point(48, 337);
            this.lblFechaEgreso.Name = "lblFechaEgreso";
            this.lblFechaEgreso.Size = new System.Drawing.Size(91, 13);
            this.lblFechaEgreso.TabIndex = 83;
            this.lblFechaEgreso.Text = "Fecha de Egreso:";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(46, 298);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(93, 13);
            this.lblFechaIngreso.TabIndex = 82;
            this.lblFechaIngreso.Text = "Fecha de Ingreso:";
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Location = new System.Drawing.Point(84, 219);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(55, 13);
            this.lblIdUsuario.TabIndex = 81;
            this.lblIdUsuario.Text = "IdUsuario:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(154, 180);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(217, 20);
            this.txtApellido.TabIndex = 66;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(92, 183);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 80;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(154, 143);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(217, 20);
            this.txtNombre.TabIndex = 65;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(92, 146);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 79;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Location = new System.Drawing.Point(16, 107);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(123, 13);
            this.lblNroDoc.TabIndex = 78;
            this.lblNroDoc.Text = "Numero de Documento: ";
            // 
            // ModificarPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 567);
            this.Controls.Add(this.lblTitleMod);
            this.Controls.Add(this.btMenu);
            this.Controls.Add(this.cmbBarrio);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.cmbEgreso);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.gdrPersonal);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.txtNroDoc);
            this.Controls.Add(this.txtFechaEgreso);
            this.Controls.Add(this.txtFechaIngreso);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblIdBarrio);
            this.Controls.Add(this.txtNroCalle);
            this.Controls.Add(this.lblNroCalle);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.lblIdCargo);
            this.Controls.Add(this.lblIdEgreso);
            this.Controls.Add(this.lblFechaEgreso);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.lblIdUsuario);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNroDoc);
            this.Name = "ModificarPersonal";
            this.Text = "ModificarPersonal";
            this.Load += new System.EventHandler(this.ModificarPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleMod;
        private System.Windows.Forms.Button btMenu;
        private System.Windows.Forms.ComboBox cmbBarrio;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.ComboBox cmbEgreso;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.DataGridView gdrPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.MaskedTextBox txtNroDoc;
        private System.Windows.Forms.MaskedTextBox txtFechaEgreso;
        private System.Windows.Forms.MaskedTextBox txtFechaIngreso;
        private System.Windows.Forms.MaskedTextBox txtFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblIdBarrio;
        private System.Windows.Forms.TextBox txtNroCalle;
        private System.Windows.Forms.Label lblNroCalle;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblIdCargo;
        private System.Windows.Forms.Label lblIdEgreso;
        private System.Windows.Forms.Label lblFechaEgreso;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNroDoc;
    }
}