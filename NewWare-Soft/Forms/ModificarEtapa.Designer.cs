
namespace NewWare_Soft.Forms
{
    partial class ModificarEtapa
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvEtapas = new System.Windows.Forms.DataGridView();
            this.NroEtapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEtapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(24, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(563, 78);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Modificar Etapa";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvEtapas
            // 
            this.dgvEtapas.AllowUserToAddRows = false;
            this.dgvEtapas.AllowUserToDeleteRows = false;
            this.dgvEtapas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtapas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroEtapa,
            this.NombreEtapa});
            this.dgvEtapas.Location = new System.Drawing.Point(37, 217);
            this.dgvEtapas.Name = "dgvEtapas";
            this.dgvEtapas.ReadOnly = true;
            this.dgvEtapas.Size = new System.Drawing.Size(544, 139);
            this.dgvEtapas.TabIndex = 5;
            this.dgvEtapas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEtapas_CellClick);
            // 
            // NroEtapa
            // 
            this.NroEtapa.DataPropertyName = "IdEtapa";
            this.NroEtapa.HeaderText = "Nro Etapa";
            this.NroEtapa.Name = "NroEtapa";
            this.NroEtapa.ReadOnly = true;
            this.NroEtapa.Width = 200;
            // 
            // NombreEtapa
            // 
            this.NombreEtapa.DataPropertyName = "NombreEtapa";
            this.NombreEtapa.HeaderText = "Nombre Etapa";
            this.NombreEtapa.Name = "NombreEtapa";
            this.NombreEtapa.ReadOnly = true;
            this.NombreEtapa.Width = 300;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(248, 381);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(97, 30);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(84, 141);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(88, 29);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(218, 141);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(217, 29);
            this.txtNombre.TabIndex = 8;
            // 
            // ModificarEtapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 450);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvEtapas);
            this.Controls.Add(this.lblTitle);
            this.Name = "ModificarEtapa";
            this.Text = "ModificarEtapa";
            this.Load += new System.EventHandler(this.ModificarEtapa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvEtapas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroEtapa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEtapa;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
    }
}