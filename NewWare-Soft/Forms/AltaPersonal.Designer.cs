namespace NewWare_Soft.Forms
{
    partial class AltaPersonal
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
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.btAddPersonal = new System.Windows.Forms.Button();
            this.btLimpiarPersonal = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblFechaEgreso = new System.Windows.Forms.Label();
            this.lblIdEgreso = new System.Windows.Forms.Label();
            this.lblIdCargo = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.txtNroCalle = new System.Windows.Forms.TextBox();
            this.lblNroCalle = new System.Windows.Forms.Label();
            this.lblIdBarrio = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.txtFechaNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaIngreso = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaEgreso = new System.Windows.Forms.MaskedTextBox();
            this.txtNroDoc = new System.Windows.Forms.MaskedTextBox();
            this.btMenu = new System.Windows.Forms.Button();
            this.cmbBarrio = new System.Windows.Forms.ComboBox();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.cmbEgreso = new System.Windows.Forms.ComboBox();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.lblTitleAdd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Location = new System.Drawing.Point(40, 79);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(123, 13);
            this.lblNroDoc.TabIndex = 0;
            this.lblNroDoc.Text = "Numero de Documento: ";
            // 
            // btAddPersonal
            // 
            this.btAddPersonal.Location = new System.Drawing.Point(21, 549);
            this.btAddPersonal.Name = "btAddPersonal";
            this.btAddPersonal.Size = new System.Drawing.Size(185, 37);
            this.btAddPersonal.TabIndex = 13;
            this.btAddPersonal.Text = "Guardar Datos";
            this.btAddPersonal.UseVisualStyleBackColor = true;
            this.btAddPersonal.Click += new System.EventHandler(this.btAddPersonal_Click);
            // 
            // btLimpiarPersonal
            // 
            this.btLimpiarPersonal.Location = new System.Drawing.Point(235, 549);
            this.btLimpiarPersonal.Name = "btLimpiarPersonal";
            this.btLimpiarPersonal.Size = new System.Drawing.Size(185, 37);
            this.btLimpiarPersonal.TabIndex = 14;
            this.btLimpiarPersonal.Text = "Limpiar Datos";
            this.btLimpiarPersonal.UseVisualStyleBackColor = true;
            this.btLimpiarPersonal.Click += new System.EventHandler(this.btLimpiarPersonal_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(178, 115);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(217, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(116, 118);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(178, 152);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(217, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(116, 155);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Location = new System.Drawing.Point(108, 191);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(55, 13);
            this.lblIdUsuario.TabIndex = 8;
            this.lblIdUsuario.Text = "IdUsuario:";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(70, 270);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(93, 13);
            this.lblFechaIngreso.TabIndex = 10;
            this.lblFechaIngreso.Text = "Fecha de Ingreso:";
            // 
            // lblFechaEgreso
            // 
            this.lblFechaEgreso.AutoSize = true;
            this.lblFechaEgreso.Location = new System.Drawing.Point(72, 309);
            this.lblFechaEgreso.Name = "lblFechaEgreso";
            this.lblFechaEgreso.Size = new System.Drawing.Size(91, 13);
            this.lblFechaEgreso.TabIndex = 12;
            this.lblFechaEgreso.Text = "Fecha de Egreso:";
            // 
            // lblIdEgreso
            // 
            this.lblIdEgreso.AutoSize = true;
            this.lblIdEgreso.Location = new System.Drawing.Point(70, 351);
            this.lblIdEgreso.Name = "lblIdEgreso";
            this.lblIdEgreso.Size = new System.Drawing.Size(93, 13);
            this.lblIdEgreso.TabIndex = 14;
            this.lblIdEgreso.Text = "Motivo de Egreso:";
            // 
            // lblIdCargo
            // 
            this.lblIdCargo.AutoSize = true;
            this.lblIdCargo.Location = new System.Drawing.Point(116, 388);
            this.lblIdCargo.Name = "lblIdCargo";
            this.lblIdCargo.Size = new System.Drawing.Size(47, 13);
            this.lblIdCargo.TabIndex = 16;
            this.lblIdCargo.Text = "IdCargo:";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(178, 422);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(217, 20);
            this.txtCalle.TabIndex = 10;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(130, 425);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(33, 13);
            this.lblCalle.TabIndex = 18;
            this.lblCalle.Text = "Calle:";
            // 
            // txtNroCalle
            // 
            this.txtNroCalle.Location = new System.Drawing.Point(178, 459);
            this.txtNroCalle.Name = "txtNroCalle";
            this.txtNroCalle.Size = new System.Drawing.Size(217, 20);
            this.txtNroCalle.TabIndex = 11;
            // 
            // lblNroCalle
            // 
            this.lblNroCalle.AutoSize = true;
            this.lblNroCalle.Location = new System.Drawing.Point(75, 462);
            this.lblNroCalle.Name = "lblNroCalle";
            this.lblNroCalle.Size = new System.Drawing.Size(88, 13);
            this.lblNroCalle.TabIndex = 20;
            this.lblNroCalle.Text = "Numero de Calle:";
            // 
            // lblIdBarrio
            // 
            this.lblIdBarrio.AutoSize = true;
            this.lblIdBarrio.Location = new System.Drawing.Point(117, 500);
            this.lblIdBarrio.Name = "lblIdBarrio";
            this.lblIdBarrio.Size = new System.Drawing.Size(46, 13);
            this.lblIdBarrio.TabIndex = 22;
            this.lblIdBarrio.Text = "IdBarrio:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(52, 231);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(111, 13);
            this.lblFechaNacimiento.TabIndex = 24;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(178, 228);
            this.txtFechaNacimiento.Mask = "00/00/0000";
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(217, 20);
            this.txtFechaNacimiento.TabIndex = 5;
            this.txtFechaNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.Location = new System.Drawing.Point(178, 267);
            this.txtFechaIngreso.Mask = "00/00/0000";
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(217, 20);
            this.txtFechaIngreso.TabIndex = 6;
            this.txtFechaIngreso.ValidatingType = typeof(System.DateTime);
            // 
            // txtFechaEgreso
            // 
            this.txtFechaEgreso.Location = new System.Drawing.Point(178, 306);
            this.txtFechaEgreso.Mask = "00/00/0000";
            this.txtFechaEgreso.Name = "txtFechaEgreso";
            this.txtFechaEgreso.Size = new System.Drawing.Size(217, 20);
            this.txtFechaEgreso.TabIndex = 7;
            this.txtFechaEgreso.ValidatingType = typeof(System.DateTime);
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Location = new System.Drawing.Point(178, 76);
            this.txtNroDoc.Mask = "99999999";
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Size = new System.Drawing.Size(217, 20);
            this.txtNroDoc.TabIndex = 1;
            // 
            // btMenu
            // 
            this.btMenu.Location = new System.Drawing.Point(364, 12);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(67, 37);
            this.btMenu.TabIndex = 15;
            this.btMenu.Text = "Volver a Menu";
            this.btMenu.UseVisualStyleBackColor = true;
            this.btMenu.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // cmbBarrio
            // 
            this.cmbBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBarrio.FormattingEnabled = true;
            this.cmbBarrio.Location = new System.Drawing.Point(178, 497);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(217, 21);
            this.cmbBarrio.TabIndex = 12;
            // 
            // cmbCargo
            // 
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(178, 385);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(217, 21);
            this.cmbCargo.TabIndex = 9;
            // 
            // cmbEgreso
            // 
            this.cmbEgreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEgreso.FormattingEnabled = true;
            this.cmbEgreso.Location = new System.Drawing.Point(178, 348);
            this.cmbEgreso.Name = "cmbEgreso";
            this.cmbEgreso.Size = new System.Drawing.Size(217, 21);
            this.cmbEgreso.TabIndex = 8;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.ItemHeight = 13;
            this.cmbUsuario.Location = new System.Drawing.Point(178, 188);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(217, 21);
            this.cmbUsuario.TabIndex = 4;
            // 
            // lblTitleAdd
            // 
            this.lblTitleAdd.AutoSize = true;
            this.lblTitleAdd.Cursor = System.Windows.Forms.Cursors.No;
            this.lblTitleAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleAdd.Location = new System.Drawing.Point(18, 31);
            this.lblTitleAdd.Name = "lblTitleAdd";
            this.lblTitleAdd.Size = new System.Drawing.Size(298, 18);
            this.lblTitleAdd.TabIndex = 25;
            this.lblTitleAdd.Text = "Ingrese los datos del nuevo empleado:";
            // 
            // AltaPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 602);
            this.Controls.Add(this.lblTitleAdd);
            this.Controls.Add(this.cmbBarrio);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.cmbEgreso);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.btMenu);
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
            this.Controls.Add(this.btLimpiarPersonal);
            this.Controls.Add(this.btAddPersonal);
            this.Controls.Add(this.lblNroDoc);
            this.Name = "AltaPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaPersonal";
            this.Load += new System.EventHandler(this.AltaPersonal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.Button btAddPersonal;
        private System.Windows.Forms.Button btLimpiarPersonal;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblFechaEgreso;
        private System.Windows.Forms.Label lblIdEgreso;
        private System.Windows.Forms.Label lblIdCargo;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox txtNroCalle;
        private System.Windows.Forms.Label lblNroCalle;
        private System.Windows.Forms.Label lblIdBarrio;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.MaskedTextBox txtFechaNacimiento;
        private System.Windows.Forms.MaskedTextBox txtFechaIngreso;
        private System.Windows.Forms.MaskedTextBox txtFechaEgreso;
        private System.Windows.Forms.MaskedTextBox txtNroDoc;
        private System.Windows.Forms.Button btMenu;
        private System.Windows.Forms.ComboBox cmbBarrio;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.ComboBox cmbEgreso;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label lblTitleAdd;
    }
}