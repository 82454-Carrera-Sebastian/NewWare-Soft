
namespace NewWare_Soft.Forms
{
    partial class BajaCiudad
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
            this.txtIdCiudad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCiudad = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grillaCiudades = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimiarCampos = new System.Windows.Forms.Button();
            this.btnBajaCiudad = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCiudades)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdCiudad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombreCiudad);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 166);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            // 
            // txtIdCiudad
            // 
            this.txtIdCiudad.Enabled = false;
            this.txtIdCiudad.Location = new System.Drawing.Point(107, 113);
            this.txtIdCiudad.Name = "txtIdCiudad";
            this.txtIdCiudad.Size = new System.Drawing.Size(44, 29);
            this.txtIdCiudad.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Ciudad:";
            // 
            // txtNombreCiudad
            // 
            this.txtNombreCiudad.Enabled = false;
            this.txtNombreCiudad.Location = new System.Drawing.Point(150, 53);
            this.txtNombreCiudad.Name = "txtNombreCiudad";
            this.txtNombreCiudad.Size = new System.Drawing.Size(199, 29);
            this.txtNombreCiudad.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(7, 53);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(137, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre Ciudad:";
            // 
            // grillaCiudades
            // 
            this.grillaCiudades.AllowUserToAddRows = false;
            this.grillaCiudades.AllowUserToDeleteRows = false;
            this.grillaCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaCiudades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Nombre});
            this.grillaCiudades.Location = new System.Drawing.Point(373, 12);
            this.grillaCiudades.Name = "grillaCiudades";
            this.grillaCiudades.ReadOnly = true;
            this.grillaCiudades.Size = new System.Drawing.Size(246, 243);
            this.grillaCiudades.TabIndex = 4;
            this.grillaCiudades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaCiudades_CellClick);
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "IdCiudad";
            this.Numero.HeaderText = "Nro";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "NombreCiudad";
            this.Nombre.HeaderText = "NombreCiudad";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // btnLimiarCampos
            // 
            this.btnLimiarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLimiarCampos.Location = new System.Drawing.Point(396, 279);
            this.btnLimiarCampos.Name = "btnLimiarCampos";
            this.btnLimiarCampos.Size = new System.Drawing.Size(104, 23);
            this.btnLimiarCampos.TabIndex = 5;
            this.btnLimiarCampos.Text = "Limpiar Campos";
            this.btnLimiarCampos.UseVisualStyleBackColor = false;
            this.btnLimiarCampos.Click += new System.EventHandler(this.btnLimiarCampos_Click);
            // 
            // btnBajaCiudad
            // 
            this.btnBajaCiudad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBajaCiudad.Enabled = false;
            this.btnBajaCiudad.Location = new System.Drawing.Point(515, 279);
            this.btnBajaCiudad.Name = "btnBajaCiudad";
            this.btnBajaCiudad.Size = new System.Drawing.Size(104, 23);
            this.btnBajaCiudad.TabIndex = 6;
            this.btnBajaCiudad.TabStop = false;
            this.btnBajaCiudad.Text = "Borrar Ciudad";
            this.btnBajaCiudad.UseVisualStyleBackColor = false;
            this.btnBajaCiudad.Click += new System.EventHandler(this.btnBajaCiudad_Click);
            // 
            // BajaCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 333);
            this.Controls.Add(this.btnBajaCiudad);
            this.Controls.Add(this.btnLimiarCampos);
            this.Controls.Add(this.grillaCiudades);
            this.Controls.Add(this.groupBox1);
            this.Name = "BajaCiudad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BajaCiudad";
            this.Load += new System.EventHandler(this.BajaCiudad_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCiudades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIdCiudad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreCiudad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView grillaCiudades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Button btnLimiarCampos;
        private System.Windows.Forms.Button btnBajaCiudad;
    }
}