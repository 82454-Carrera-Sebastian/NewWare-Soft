namespace NewWare_Soft.Forms
{
    partial class BajaCliente
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
            this.groupBox_confirmacion = new System.Windows.Forms.GroupBox();
            this.button_SI = new System.Windows.Forms.Button();
            this.button_NO = new System.Windows.Forms.Button();
            this.label_consulta = new System.Windows.Forms.Label();
            this.button_Eliminar = new System.Windows.Forms.Button();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label_Seleccion = new System.Windows.Forms.Label();
            this.dataGridView_Clientes = new System.Windows.Forms.DataGridView();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_confirmacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_confirmacion
            // 
            this.groupBox_confirmacion.Controls.Add(this.button_SI);
            this.groupBox_confirmacion.Controls.Add(this.button_NO);
            this.groupBox_confirmacion.Controls.Add(this.label_consulta);
            this.groupBox_confirmacion.Enabled = false;
            this.groupBox_confirmacion.Location = new System.Drawing.Point(243, 104);
            this.groupBox_confirmacion.Name = "groupBox_confirmacion";
            this.groupBox_confirmacion.Size = new System.Drawing.Size(360, 136);
            this.groupBox_confirmacion.TabIndex = 13;
            this.groupBox_confirmacion.TabStop = false;
            this.groupBox_confirmacion.Text = "Confirmacion";
            this.groupBox_confirmacion.Visible = false;
            // 
            // button_SI
            // 
            this.button_SI.Location = new System.Drawing.Point(279, 71);
            this.button_SI.Name = "button_SI";
            this.button_SI.Size = new System.Drawing.Size(75, 32);
            this.button_SI.TabIndex = 2;
            this.button_SI.Text = "SI";
            this.button_SI.UseVisualStyleBackColor = true;
            this.button_SI.Click += new System.EventHandler(this.button_SI_Click);
            // 
            // button_NO
            // 
            this.button_NO.Location = new System.Drawing.Point(10, 71);
            this.button_NO.Name = "button_NO";
            this.button_NO.Size = new System.Drawing.Size(75, 32);
            this.button_NO.TabIndex = 1;
            this.button_NO.Text = "NO";
            this.button_NO.UseVisualStyleBackColor = true;
            this.button_NO.Click += new System.EventHandler(this.button_NO_Click);
            // 
            // label_consulta
            // 
            this.label_consulta.AutoSize = true;
            this.label_consulta.Location = new System.Drawing.Point(6, 22);
            this.label_consulta.Name = "label_consulta";
            this.label_consulta.Size = new System.Drawing.Size(348, 20);
            this.label_consulta.TabIndex = 0;
            this.label_consulta.Text = "¿Esta seguro que desea eliminar a este cliente?";
            // 
            // button_Eliminar
            // 
            this.button_Eliminar.Enabled = false;
            this.button_Eliminar.Location = new System.Drawing.Point(619, 419);
            this.button_Eliminar.Name = "button_Eliminar";
            this.button_Eliminar.Size = new System.Drawing.Size(114, 46);
            this.button_Eliminar.TabIndex = 12;
            this.button_Eliminar.Text = "Eliminar";
            this.button_Eliminar.UseVisualStyleBackColor = true;
            this.button_Eliminar.Click += new System.EventHandler(this.button_Eliminar_Click);
            // 
            // textBox_Email
            // 
            this.textBox_Email.Enabled = false;
            this.textBox_Email.Location = new System.Drawing.Point(339, 368);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(394, 26);
            this.textBox_Email.TabIndex = 11;
            // 
            // label_Seleccion
            // 
            this.label_Seleccion.AutoSize = true;
            this.label_Seleccion.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Seleccion.Location = new System.Drawing.Point(68, 371);
            this.label_Seleccion.Name = "label_Seleccion";
            this.label_Seleccion.Size = new System.Drawing.Size(276, 24);
            this.label_Seleccion.TabIndex = 10;
            this.label_Seleccion.Text = "Ha seleccionado a: ";
            // 
            // dataGridView_Clientes
            // 
            this.dataGridView_Clientes.AllowUserToAddRows = false;
            this.dataGridView_Clientes.AllowUserToDeleteRows = false;
            this.dataGridView_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Email,
            this.nombre_cliente,
            this.apellido_cliente});
            this.dataGridView_Clientes.Location = new System.Drawing.Point(68, 12);
            this.dataGridView_Clientes.Name = "dataGridView_Clientes";
            this.dataGridView_Clientes.ReadOnly = true;
            this.dataGridView_Clientes.RowHeadersWidth = 62;
            this.dataGridView_Clientes.RowTemplate.Height = 28;
            this.dataGridView_Clientes.Size = new System.Drawing.Size(665, 339);
            this.dataGridView_Clientes.TabIndex = 9;
            this.dataGridView_Clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_ClienteBorrar_CellClick);
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 200;
            // 
            // nombre_cliente
            // 
            this.nombre_cliente.DataPropertyName = "Nombre";
            this.nombre_cliente.HeaderText = "Nombre";
            this.nombre_cliente.MinimumWidth = 8;
            this.nombre_cliente.Name = "nombre_cliente";
            this.nombre_cliente.ReadOnly = true;
            this.nombre_cliente.Width = 200;
            // 
            // apellido_cliente
            // 
            this.apellido_cliente.DataPropertyName = "Apellido";
            this.apellido_cliente.HeaderText = "Apellido";
            this.apellido_cliente.MinimumWidth = 8;
            this.apellido_cliente.Name = "apellido_cliente";
            this.apellido_cliente.ReadOnly = true;
            this.apellido_cliente.Width = 200;
            // 
            // BajaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.groupBox_confirmacion);
            this.Controls.Add(this.button_Eliminar);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label_Seleccion);
            this.Controls.Add(this.dataGridView_Clientes);
            this.Name = "BajaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja de cliente";
            this.Load += new System.EventHandler(this.BajaCliente_Load);
            this.groupBox_confirmacion.ResumeLayout(false);
            this.groupBox_confirmacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_confirmacion;
        private System.Windows.Forms.Button button_SI;
        private System.Windows.Forms.Button button_NO;
        private System.Windows.Forms.Label label_consulta;
        private System.Windows.Forms.Button button_Eliminar;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label_Seleccion;
        private System.Windows.Forms.DataGridView dataGridView_Clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_cliente;
    }
}