﻿
namespace NewWare_Soft.Forms
{
    partial class NuevaVenta
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
            this.label_Empresa = new System.Windows.Forms.Label();
            this.comboBox_Producto = new System.Windows.Forms.ComboBox();
            this.label_producto = new System.Windows.Forms.Label();
            this.label_NroFactura = new System.Windows.Forms.Label();
            this.textBox_NroFactura = new System.Windows.Forms.TextBox();
            this.label_Fecha = new System.Windows.Forms.Label();
            this.textBox_Fecha = new System.Windows.Forms.TextBox();
            this.label_Email1 = new System.Windows.Forms.Label();
            this.textBox_Email1 = new System.Windows.Forms.TextBox();
            this.groupBox_Cliente = new System.Windows.Forms.GroupBox();
            this.label_nombre = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.label_apellido = new System.Windows.Forms.Label();
            this.textBox_apellido = new System.Windows.Forms.TextBox();
            this.button_EncontrarCliente = new System.Windows.Forms.Button();
            this.button_AgregarProducto = new System.Windows.Forms.Button();
            this.textBox_Precio = new System.Windows.Forms.TextBox();
            this.label_Precio = new System.Windows.Forms.Label();
            this.button_BorrarCampos = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Denominacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Confirmar = new System.Windows.Forms.Button();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.groupBox_Alta = new System.Windows.Forms.GroupBox();
            this.button_No = new System.Windows.Forms.Button();
            this.button_Si = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_buscar_precio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Total = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox_Cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBox_Alta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Empresa
            // 
            this.label_Empresa.AutoSize = true;
            this.label_Empresa.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold);
            this.label_Empresa.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_Empresa.Location = new System.Drawing.Point(25, 17);
            this.label_Empresa.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_Empresa.Name = "label_Empresa";
            this.label_Empresa.Size = new System.Drawing.Size(190, 24);
            this.label_Empresa.TabIndex = 0;
            this.label_Empresa.Text = "NewWare-Soft";
            // 
            // comboBox_Producto
            // 
            this.comboBox_Producto.FormattingEnabled = true;
            this.comboBox_Producto.Location = new System.Drawing.Point(11, 53);
            this.comboBox_Producto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBox_Producto.Name = "comboBox_Producto";
            this.comboBox_Producto.Size = new System.Drawing.Size(511, 24);
            this.comboBox_Producto.TabIndex = 1;
            // 
            // label_producto
            // 
            this.label_producto.AutoSize = true;
            this.label_producto.Location = new System.Drawing.Point(8, 30);
            this.label_producto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_producto.Name = "label_producto";
            this.label_producto.Size = new System.Drawing.Size(88, 16);
            this.label_producto.TabIndex = 2;
            this.label_producto.Text = "Producto";
            // 
            // label_NroFactura
            // 
            this.label_NroFactura.AutoSize = true;
            this.label_NroFactura.Location = new System.Drawing.Point(865, 17);
            this.label_NroFactura.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_NroFactura.Name = "label_NroFactura";
            this.label_NroFactura.Size = new System.Drawing.Size(128, 16);
            this.label_NroFactura.TabIndex = 3;
            this.label_NroFactura.Text = "Nro Factura:";
            // 
            // textBox_NroFactura
            // 
            this.textBox_NroFactura.Location = new System.Drawing.Point(993, 17);
            this.textBox_NroFactura.Name = "textBox_NroFactura";
            this.textBox_NroFactura.Size = new System.Drawing.Size(203, 23);
            this.textBox_NroFactura.TabIndex = 4;
            // 
            // label_Fecha
            // 
            this.label_Fecha.AutoSize = true;
            this.label_Fecha.Location = new System.Drawing.Point(847, 53);
            this.label_Fecha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_Fecha.Name = "label_Fecha";
            this.label_Fecha.Size = new System.Drawing.Size(138, 16);
            this.label_Fecha.TabIndex = 5;
            this.label_Fecha.Text = "Fecha y Hora:";
            // 
            // textBox_Fecha
            // 
            this.textBox_Fecha.Location = new System.Drawing.Point(993, 46);
            this.textBox_Fecha.Name = "textBox_Fecha";
            this.textBox_Fecha.Size = new System.Drawing.Size(203, 23);
            this.textBox_Fecha.TabIndex = 6;
            this.textBox_Fecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_Email1
            // 
            this.label_Email1.AutoSize = true;
            this.label_Email1.Location = new System.Drawing.Point(26, 66);
            this.label_Email1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_Email1.Name = "label_Email1";
            this.label_Email1.Size = new System.Drawing.Size(138, 16);
            this.label_Email1.TabIndex = 7;
            this.label_Email1.Text = "Email cliente";
            // 
            // textBox_Email1
            // 
            this.textBox_Email1.Location = new System.Drawing.Point(29, 87);
            this.textBox_Email1.Name = "textBox_Email1";
            this.textBox_Email1.Size = new System.Drawing.Size(369, 23);
            this.textBox_Email1.TabIndex = 8;
            // 
            // groupBox_Cliente
            // 
            this.groupBox_Cliente.Controls.Add(this.label_nombre);
            this.groupBox_Cliente.Controls.Add(this.textBox_nombre);
            this.groupBox_Cliente.Controls.Add(this.label_apellido);
            this.groupBox_Cliente.Controls.Add(this.textBox_apellido);
            this.groupBox_Cliente.Location = new System.Drawing.Point(29, 135);
            this.groupBox_Cliente.Name = "groupBox_Cliente";
            this.groupBox_Cliente.Size = new System.Drawing.Size(540, 179);
            this.groupBox_Cliente.TabIndex = 9;
            this.groupBox_Cliente.TabStop = false;
            this.groupBox_Cliente.Text = "Datos Cliente";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre.Location = new System.Drawing.Point(6, 27);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(68, 16);
            this.label_nombre.TabIndex = 54;
            this.label_nombre.Text = "Nombre";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Enabled = false;
            this.textBox_nombre.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nombre.Location = new System.Drawing.Point(11, 54);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(511, 23);
            this.textBox_nombre.TabIndex = 49;
            // 
            // label_apellido
            // 
            this.label_apellido.AutoSize = true;
            this.label_apellido.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_apellido.Location = new System.Drawing.Point(7, 98);
            this.label_apellido.Name = "label_apellido";
            this.label_apellido.Size = new System.Drawing.Size(88, 16);
            this.label_apellido.TabIndex = 53;
            this.label_apellido.Text = "Apellido";
            // 
            // textBox_apellido
            // 
            this.textBox_apellido.Enabled = false;
            this.textBox_apellido.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_apellido.Location = new System.Drawing.Point(11, 125);
            this.textBox_apellido.Name = "textBox_apellido";
            this.textBox_apellido.Size = new System.Drawing.Size(511, 23);
            this.textBox_apellido.TabIndex = 50;
            // 
            // button_EncontrarCliente
            // 
            this.button_EncontrarCliente.Location = new System.Drawing.Point(418, 81);
            this.button_EncontrarCliente.Name = "button_EncontrarCliente";
            this.button_EncontrarCliente.Size = new System.Drawing.Size(151, 34);
            this.button_EncontrarCliente.TabIndex = 64;
            this.button_EncontrarCliente.Text = "Buscar";
            this.button_EncontrarCliente.UseVisualStyleBackColor = true;
            this.button_EncontrarCliente.Click += new System.EventHandler(this.button_EncontrarCliente_Click);
            // 
            // button_AgregarProducto
            // 
            this.button_AgregarProducto.Location = new System.Drawing.Point(29, 529);
            this.button_AgregarProducto.Name = "button_AgregarProducto";
            this.button_AgregarProducto.Size = new System.Drawing.Size(177, 37);
            this.button_AgregarProducto.TabIndex = 65;
            this.button_AgregarProducto.Text = "Agregar";
            this.button_AgregarProducto.UseVisualStyleBackColor = true;
            this.button_AgregarProducto.Click += new System.EventHandler(this.button_AgregarProducto_Click);
            // 
            // textBox_Precio
            // 
            this.textBox_Precio.Location = new System.Drawing.Point(11, 117);
            this.textBox_Precio.Name = "textBox_Precio";
            this.textBox_Precio.Size = new System.Drawing.Size(335, 23);
            this.textBox_Precio.TabIndex = 67;
            // 
            // label_Precio
            // 
            this.label_Precio.AutoSize = true;
            this.label_Precio.Location = new System.Drawing.Point(8, 88);
            this.label_Precio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_Precio.Name = "label_Precio";
            this.label_Precio.Size = new System.Drawing.Size(68, 16);
            this.label_Precio.TabIndex = 66;
            this.label_Precio.Text = "Precio";
            // 
            // button_BorrarCampos
            // 
            this.button_BorrarCampos.Location = new System.Drawing.Point(360, 531);
            this.button_BorrarCampos.Name = "button_BorrarCampos";
            this.button_BorrarCampos.Size = new System.Drawing.Size(209, 35);
            this.button_BorrarCampos.TabIndex = 68;
            this.button_BorrarCampos.Text = "Borrar campos";
            this.button_BorrarCampos.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Denominacion,
            this.PrecioVenta});
            this.dgvProductos.Location = new System.Drawing.Point(636, 87);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 62;
            this.dgvProductos.RowTemplate.Height = 28;
            this.dgvProductos.Size = new System.Drawing.Size(564, 370);
            this.dgvProductos.TabIndex = 69;
            // 
            // IdProducto
            // 
            this.IdProducto.DataPropertyName = "IdProducto";
            this.IdProducto.HeaderText = "Id";
            this.IdProducto.MinimumWidth = 8;
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            // 
            // Denominacion
            // 
            this.Denominacion.DataPropertyName = "Denominacion";
            this.Denominacion.HeaderText = "Nombre";
            this.Denominacion.MinimumWidth = 8;
            this.Denominacion.Name = "Denominacion";
            this.Denominacion.ReadOnly = true;
            this.Denominacion.Width = 250;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.DataPropertyName = "PrecioVenta";
            this.PrecioVenta.HeaderText = "Precio";
            this.PrecioVenta.MinimumWidth = 8;
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Width = 150;
            // 
            // button_Confirmar
            // 
            this.button_Confirmar.Location = new System.Drawing.Point(636, 531);
            this.button_Confirmar.Name = "button_Confirmar";
            this.button_Confirmar.Size = new System.Drawing.Size(177, 36);
            this.button_Confirmar.TabIndex = 70;
            this.button_Confirmar.Text = "Confirmar";
            this.button_Confirmar.UseVisualStyleBackColor = true;
            this.button_Confirmar.Click += new System.EventHandler(this.button_Confirmar_Click);
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Location = new System.Drawing.Point(1023, 530);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(177, 36);
            this.button_Cancelar.TabIndex = 71;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox_Alta
            // 
            this.groupBox_Alta.Controls.Add(this.button_No);
            this.groupBox_Alta.Controls.Add(this.button_Si);
            this.groupBox_Alta.Enabled = false;
            this.groupBox_Alta.Location = new System.Drawing.Point(697, 135);
            this.groupBox_Alta.Name = "groupBox_Alta";
            this.groupBox_Alta.Size = new System.Drawing.Size(464, 146);
            this.groupBox_Alta.TabIndex = 56;
            this.groupBox_Alta.TabStop = false;
            this.groupBox_Alta.Text = "¿Desea dar de alta al cliente?";
            this.groupBox_Alta.Visible = false;
            // 
            // button_No
            // 
            this.button_No.Location = new System.Drawing.Point(308, 52);
            this.button_No.Name = "button_No";
            this.button_No.Size = new System.Drawing.Size(121, 41);
            this.button_No.TabIndex = 1;
            this.button_No.Text = "No";
            this.button_No.UseVisualStyleBackColor = true;
            this.button_No.Click += new System.EventHandler(this.button_No_Click);
            // 
            // button_Si
            // 
            this.button_Si.Location = new System.Drawing.Point(24, 57);
            this.button_Si.Name = "button_Si";
            this.button_Si.Size = new System.Drawing.Size(121, 41);
            this.button_Si.TabIndex = 0;
            this.button_Si.Text = "Si";
            this.button_Si.UseVisualStyleBackColor = true;
            this.button_Si.Click += new System.EventHandler(this.button_Si_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_buscar_precio);
            this.groupBox1.Controls.Add(this.label_producto);
            this.groupBox1.Controls.Add(this.comboBox_Producto);
            this.groupBox1.Controls.Add(this.label_Precio);
            this.groupBox1.Controls.Add(this.textBox_Precio);
            this.groupBox1.Location = new System.Drawing.Point(29, 353);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 161);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Producto";
            // 
            // button_buscar_precio
            // 
            this.button_buscar_precio.Location = new System.Drawing.Point(374, 111);
            this.button_buscar_precio.Name = "button_buscar_precio";
            this.button_buscar_precio.Size = new System.Drawing.Size(148, 34);
            this.button_buscar_precio.TabIndex = 74;
            this.button_buscar_precio.Text = "Buscar Precio";
            this.button_buscar_precio.UseVisualStyleBackColor = true;
            this.button_buscar_precio.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(965, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 72;
            this.label1.Text = "Total: $";
            // 
            // textBox_Total
            // 
            this.textBox_Total.Enabled = false;
            this.textBox_Total.Location = new System.Drawing.Point(1059, 465);
            this.textBox_Total.Name = "textBox_Total";
            this.textBox_Total.Size = new System.Drawing.Size(141, 23);
            this.textBox_Total.TabIndex = 73;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(636, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 36);
            this.button1.TabIndex = 74;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // NuevaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 578);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_Alta);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.button_Confirmar);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.button_BorrarCampos);
            this.Controls.Add(this.button_AgregarProducto);
            this.Controls.Add(this.button_EncontrarCliente);
            this.Controls.Add(this.groupBox_Cliente);
            this.Controls.Add(this.textBox_Email1);
            this.Controls.Add(this.label_Email1);
            this.Controls.Add(this.textBox_Fecha);
            this.Controls.Add(this.label_Fecha);
            this.Controls.Add(this.textBox_NroFactura);
            this.Controls.Add(this.label_NroFactura);
            this.Controls.Add(this.label_Empresa);
            this.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "NuevaVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva venta";
            this.Load += new System.EventHandler(this.NuevaVenta_Load);
            this.groupBox_Cliente.ResumeLayout(false);
            this.groupBox_Cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBox_Alta.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Empresa;
        private System.Windows.Forms.ComboBox comboBox_Producto;
        private System.Windows.Forms.Label label_producto;
        private System.Windows.Forms.Label label_NroFactura;
        private System.Windows.Forms.TextBox textBox_NroFactura;
        private System.Windows.Forms.Label label_Fecha;
        private System.Windows.Forms.TextBox textBox_Fecha;
        private System.Windows.Forms.Label label_Email1;
        private System.Windows.Forms.TextBox textBox_Email1;
        private System.Windows.Forms.GroupBox groupBox_Cliente;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Label label_apellido;
        private System.Windows.Forms.TextBox textBox_apellido;
        private System.Windows.Forms.Button button_EncontrarCliente;
        private System.Windows.Forms.Button button_AgregarProducto;
        private System.Windows.Forms.TextBox textBox_Precio;
        private System.Windows.Forms.Label label_Precio;
        private System.Windows.Forms.Button button_BorrarCampos;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button button_Confirmar;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.GroupBox groupBox_Alta;
        private System.Windows.Forms.Button button_No;
        private System.Windows.Forms.Button button_Si;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_buscar_precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Denominacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Total;
        private System.Windows.Forms.Button button1;
    }
}