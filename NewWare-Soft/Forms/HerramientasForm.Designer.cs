
namespace NewWare_Soft.Forms
{
    partial class HerramientasForm
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblDescripcionHerramienta = new System.Windows.Forms.Label();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblNomHerramienta = new System.Windows.Forms.Label();
            this.btnAgregarHerramienta = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NombreHerramienta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionHerramienta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificarHerramienta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(250, 111);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(316, 54);
            this.txtPassword.TabIndex = 2;
            // 
            // lblDescripcionHerramienta
            // 
            this.lblDescripcionHerramienta.AutoSize = true;
            this.lblDescripcionHerramienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionHerramienta.Location = new System.Drawing.Point(13, 111);
            this.lblDescripcionHerramienta.Name = "lblDescripcionHerramienta";
            this.lblDescripcionHerramienta.Size = new System.Drawing.Size(231, 20);
            this.lblDescripcionHerramienta.TabIndex = 10;
            this.lblDescripcionHerramienta.Text = "Descripcion de Heramienta:";
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(24, 185);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(79, 63);
            this.btnLimpiarCampos.TabIndex = 4;
            this.btnLimpiarCampos.Text = "Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(250, 79);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(316, 20);
            this.txtUser.TabIndex = 1;
            // 
            // lblNomHerramienta
            // 
            this.lblNomHerramienta.AutoSize = true;
            this.lblNomHerramienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomHerramienta.Location = new System.Drawing.Point(20, 77);
            this.lblNomHerramienta.Name = "lblNomHerramienta";
            this.lblNomHerramienta.Size = new System.Drawing.Size(224, 20);
            this.lblNomHerramienta.TabIndex = 7;
            this.lblNomHerramienta.Text = "Nombre de la Herramienta:";
            // 
            // btnAgregarHerramienta
            // 
            this.btnAgregarHerramienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarHerramienta.Location = new System.Drawing.Point(301, 185);
            this.btnAgregarHerramienta.Name = "btnAgregarHerramienta";
            this.btnAgregarHerramienta.Size = new System.Drawing.Size(212, 63);
            this.btnAgregarHerramienta.TabIndex = 3;
            this.btnAgregarHerramienta.Text = "Agregar Herramienta";
            this.btnAgregarHerramienta.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreHerramienta,
            this.DescripcionHerramienta});
            this.dataGridView1.Location = new System.Drawing.Point(24, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // NombreHerramienta
            // 
            this.NombreHerramienta.HeaderText = "Nombre";
            this.NombreHerramienta.Name = "NombreHerramienta";
            this.NombreHerramienta.Width = 150;
            // 
            // DescripcionHerramienta
            // 
            this.DescripcionHerramienta.HeaderText = "Descripción";
            this.DescripcionHerramienta.Name = "DescripcionHerramienta";
            this.DescripcionHerramienta.Width = 300;
            // 
            // btnModificarHerramienta
            // 
            this.btnModificarHerramienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarHerramienta.Location = new System.Drawing.Point(301, 185);
            this.btnModificarHerramienta.Name = "btnModificarHerramienta";
            this.btnModificarHerramienta.Size = new System.Drawing.Size(212, 63);
            this.btnModificarHerramienta.TabIndex = 12;
            this.btnModificarHerramienta.Text = "Modificar Herramienta";
            this.btnModificarHerramienta.UseVisualStyleBackColor = true;
            // 
            // HerramientasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.btnAgregarHerramienta);
            this.Controls.Add(this.btnModificarHerramienta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblDescripcionHerramienta);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblNomHerramienta);
            this.Name = "HerramientasForm";
            this.Text = "HerramientasForm";
            this.Load += new System.EventHandler(this.HerramientasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblDescripcionHerramienta;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblNomHerramienta;
        private System.Windows.Forms.Button btnAgregarHerramienta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreHerramienta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionHerramienta;
        private System.Windows.Forms.Button btnModificarHerramienta;
    }
}