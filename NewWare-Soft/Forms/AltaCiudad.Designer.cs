
namespace NewWare_Soft.Forms
{
    partial class AltaCiudad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaCiudad));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreCiudad = new System.Windows.Forms.TextBox();
            this.btnLimiarCampos = new System.Windows.Forms.Button();
            this.grillaCiudades = new System.Windows.Forms.DataGridView();
            this.btnAgregarCiudad = new System.Windows.Forms.Button();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCiudades)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombreCiudad);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(7, 54);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(137, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre Ciudad:";
            // 
            // txtNombreCiudad
            // 
            this.txtNombreCiudad.Location = new System.Drawing.Point(150, 54);
            this.txtNombreCiudad.Name = "txtNombreCiudad";
            this.txtNombreCiudad.Size = new System.Drawing.Size(199, 29);
            this.txtNombreCiudad.TabIndex = 4;
            // 
            // btnLimiarCampos
            // 
            this.btnLimiarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLimiarCampos.Location = new System.Drawing.Point(398, 279);
            this.btnLimiarCampos.Name = "btnLimiarCampos";
            this.btnLimiarCampos.Size = new System.Drawing.Size(104, 23);
            this.btnLimiarCampos.TabIndex = 1;
            this.btnLimiarCampos.Text = "Limpiar Campos";
            this.btnLimiarCampos.UseVisualStyleBackColor = false;
            this.btnLimiarCampos.Click += new System.EventHandler(this.btnLimiarCampos_Click);
            // 
            // grillaCiudades
            // 
            this.grillaCiudades.AllowUserToAddRows = false;
            this.grillaCiudades.AllowUserToDeleteRows = false;
            this.grillaCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaCiudades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Nombre,
            this.Pais});
            this.grillaCiudades.Location = new System.Drawing.Point(373, 12);
            this.grillaCiudades.Name = "grillaCiudades";
            this.grillaCiudades.ReadOnly = true;
            this.grillaCiudades.Size = new System.Drawing.Size(246, 243);
            this.grillaCiudades.TabIndex = 2;
            // 
            // btnAgregarCiudad
            // 
            this.btnAgregarCiudad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregarCiudad.Location = new System.Drawing.Point(508, 279);
            this.btnAgregarCiudad.Name = "btnAgregarCiudad";
            this.btnAgregarCiudad.Size = new System.Drawing.Size(104, 23);
            this.btnAgregarCiudad.TabIndex = 3;
            this.btnAgregarCiudad.Text = "Agregar Ciudad";
            this.btnAgregarCiudad.UseVisualStyleBackColor = false;
            this.btnAgregarCiudad.Click += new System.EventHandler(this.btnAgregarCiudad_Click);
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "IdCiudad";
            this.Numero.HeaderText = "Id";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "NombreCiudad";
            this.Nombre.HeaderText = "Nombre Ciudad";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Pais
            // 
            this.Pais.HeaderText = "Pais";
            this.Pais.Name = "Pais";
            this.Pais.ReadOnly = true;
            this.Pais.Width = 200;
            // 
            // AltaCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 314);
            this.Controls.Add(this.btnAgregarCiudad);
            this.Controls.Add(this.grillaCiudades);
            this.Controls.Add(this.btnLimiarCampos);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AltaCiudad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaCiudad";
            this.Load += new System.EventHandler(this.AltaCiudad_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCiudades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombreCiudad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnLimiarCampos;
        private System.Windows.Forms.DataGridView grillaCiudades;
        private System.Windows.Forms.Button btnAgregarCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pais;
    }
}