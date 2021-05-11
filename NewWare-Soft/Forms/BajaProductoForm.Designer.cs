
namespace NewWare_Soft.Forms
{
    partial class BajaProductoForm
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
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grdProductos = new System.Windows.Forms.DataGridView();
            this.denominacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinalizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrecio = new System.Windows.Forms.MaskedTextBox();
            this.txtFinalizacion = new System.Windows.Forms.MaskedTextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtDenominacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Enabled = false;
            this.btnEliminarProducto.Location = new System.Drawing.Point(12, 364);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(102, 29);
            this.btnEliminarProducto.TabIndex = 16;
            this.btnEliminarProducto.Text = "Eliminar Producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(12, 409);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(102, 29);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
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
            this.precioVenta});
            this.grdProductos.Location = new System.Drawing.Point(458, 12);
            this.grdProductos.Name = "grdProductos";
            this.grdProductos.ReadOnly = true;
            this.grdProductos.Size = new System.Drawing.Size(445, 426);
            this.grdProductos.TabIndex = 22;
            this.grdProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProductos_CellClick);
            // 
            // denominacion
            // 
            this.denominacion.DataPropertyName = "Denominacion";
            this.denominacion.HeaderText = "Denominación";
            this.denominacion.Name = "denominacion";
            this.denominacion.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "Descripcion";
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // fechaFinalizacion
            // 
            this.fechaFinalizacion.DataPropertyName = "FechaFinalizacion";
            this.fechaFinalizacion.HeaderText = "Fecha de Finalización";
            this.fechaFinalizacion.Name = "fechaFinalizacion";
            this.fechaFinalizacion.ReadOnly = true;
            // 
            // precioVenta
            // 
            this.precioVenta.DataPropertyName = "PrecioVenta";
            this.precioVenta.HeaderText = "Precio de Venta";
            this.precioVenta.Name = "precioVenta";
            this.precioVenta.ReadOnly = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(165, 137);
            this.txtPrecio.Mask = "999999999";
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(67, 20);
            this.txtPrecio.TabIndex = 15;
            this.txtPrecio.ValidatingType = typeof(int);
            // 
            // txtFinalizacion
            // 
            this.txtFinalizacion.Enabled = false;
            this.txtFinalizacion.Location = new System.Drawing.Point(165, 93);
            this.txtFinalizacion.Mask = "00/00/0000";
            this.txtFinalizacion.Name = "txtFinalizacion";
            this.txtFinalizacion.Size = new System.Drawing.Size(67, 20);
            this.txtFinalizacion.TabIndex = 14;
            this.txtFinalizacion.ValidatingType = typeof(System.DateTime);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AcceptsTab = true;
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(165, 50);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(287, 20);
            this.txtDescripcion.TabIndex = 13;
            // 
            // txtDenominacion
            // 
            this.txtDenominacion.AcceptsTab = true;
            this.txtDenominacion.Enabled = false;
            this.txtDenominacion.Location = new System.Drawing.Point(165, 10);
            this.txtDenominacion.Name = "txtDenominacion";
            this.txtDenominacion.Size = new System.Drawing.Size(287, 20);
            this.txtDenominacion.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Precio de venta ($):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Fecha de finalización:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Denominacion:";
            // 
            // BajaProductoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 454);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.grdProductos);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtFinalizacion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtDenominacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BajaProductoForm";
            this.Text = "BajaProductoForm";
            this.Load += new System.EventHandler(this.BajaProductoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView grdProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn denominacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinalizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVenta;
        private System.Windows.Forms.MaskedTextBox txtPrecio;
        private System.Windows.Forms.MaskedTextBox txtFinalizacion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtDenominacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}