﻿namespace NewWare_Soft.Forms
{
    partial class ProductoForm
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
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDenominacion = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtFinalizacion = new System.Windows.Forms.MaskedTextBox();
            this.txtPrecio = new System.Windows.Forms.MaskedTextBox();
            this.grdProductos = new System.Windows.Forms.DataGridView();
            this.denominacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinalizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(12, 298);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(101, 32);
            this.btnAgregarProducto.TabIndex = 4;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Denominación:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(12, 336);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(101, 32);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha de Finalización:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Precio de venta:";
            // 
            // txtDenominacion
            // 
            this.txtDenominacion.Location = new System.Drawing.Point(173, 10);
            this.txtDenominacion.Name = "txtDenominacion";
            this.txtDenominacion.Size = new System.Drawing.Size(241, 20);
            this.txtDenominacion.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(173, 41);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(241, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // txtFinalizacion
            // 
            this.txtFinalizacion.Location = new System.Drawing.Point(173, 75);
            this.txtFinalizacion.Mask = "00/00/0000";
            this.txtFinalizacion.Name = "txtFinalizacion";
            this.txtFinalizacion.Size = new System.Drawing.Size(66, 20);
            this.txtFinalizacion.TabIndex = 2;
            this.txtFinalizacion.ValidatingType = typeof(System.DateTime);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(173, 112);
            this.txtPrecio.Mask = "999999999";
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(61, 20);
            this.txtPrecio.TabIndex = 3;
            this.txtPrecio.ValidatingType = typeof(int);
            // 
            // grdProductos
            // 
            this.grdProductos.AllowUserToAddRows = false;
            this.grdProductos.AllowUserToDeleteRows = false;
            this.grdProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.denominacion,
            this.descripcion,
            this.fechaFinalizacion,
            this.precio});
            this.grdProductos.Location = new System.Drawing.Point(420, 9);
            this.grdProductos.Name = "grdProductos";
            this.grdProductos.ReadOnly = true;
            this.grdProductos.Size = new System.Drawing.Size(520, 361);
            this.grdProductos.TabIndex = 15;
            // 
            // denominacion
            // 
            this.denominacion.DataPropertyName = "Denominacion";
            this.denominacion.HeaderText = "Denominacion";
            this.denominacion.Name = "denominacion";
            this.denominacion.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "Descripcion";
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 125;
            // 
            // fechaFinalizacion
            // 
            this.fechaFinalizacion.DataPropertyName = "FechaFinalizacion";
            this.fechaFinalizacion.HeaderText = "Fecha finalizacion";
            this.fechaFinalizacion.Name = "fechaFinalizacion";
            this.fechaFinalizacion.ReadOnly = true;
            this.fechaFinalizacion.Width = 150;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "PrecioVenta";
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // ProductoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 379);
            this.Controls.Add(this.grdProductos);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtFinalizacion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtDenominacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarProducto);
            this.Name = "ProductoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductoForm";
            this.Load += new System.EventHandler(this.ProductoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDenominacion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.MaskedTextBox txtFinalizacion;
        private System.Windows.Forms.MaskedTextBox txtPrecio;
        private System.Windows.Forms.DataGridView grdProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn denominacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinalizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
    }
}