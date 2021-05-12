namespace NewWare_Soft.Forms
{
    partial class BajaPersonal
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
            this.lblTitleBaja = new System.Windows.Forms.Label();
            this.gdrBaja = new System.Windows.Forms.DataGridView();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdrBaja)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleBaja
            // 
            this.lblTitleBaja.AutoSize = true;
            this.lblTitleBaja.Location = new System.Drawing.Point(12, 9);
            this.lblTitleBaja.Name = "lblTitleBaja";
            this.lblTitleBaja.Size = new System.Drawing.Size(288, 13);
            this.lblTitleBaja.TabIndex = 4;
            this.lblTitleBaja.Text = "Seleccione un empleado para eliminar de la Base de Datos:";
            // 
            // gdrBaja
            // 
            this.gdrBaja.AllowUserToAddRows = false;
            this.gdrBaja.AllowUserToDeleteRows = false;
            this.gdrBaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrBaja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Legajo,
            this.NroDocumento,
            this.Apellido,
            this.Nombre,
            this.Cargo,
            this.FechaIngreso,
            this.Barrio});
            this.gdrBaja.Location = new System.Drawing.Point(12, 29);
            this.gdrBaja.Name = "gdrBaja";
            this.gdrBaja.ReadOnly = true;
            this.gdrBaja.Size = new System.Drawing.Size(776, 412);
            this.gdrBaja.TabIndex = 3;
            this.gdrBaja.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrBaja_CellClick);
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
            this.Apellido.Width = 110;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 110;
            // 
            // Cargo
            // 
            this.Cargo.DataPropertyName = "IdCargo";
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.DataPropertyName = "FechaIngreso";
            this.FechaIngreso.HeaderText = "FechaIngreso";
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.ReadOnly = true;
            this.FechaIngreso.Width = 120;
            // 
            // Barrio
            // 
            this.Barrio.DataPropertyName = "IdBarrio";
            this.Barrio.HeaderText = "Barrio";
            this.Barrio.Name = "Barrio";
            this.Barrio.ReadOnly = true;
            this.Barrio.Width = 110;
            // 
            // BajaPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitleBaja);
            this.Controls.Add(this.gdrBaja);
            this.Name = "BajaPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BajaPersonal";
            this.Load += new System.EventHandler(this.BajaPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrBaja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleBaja;
        private System.Windows.Forms.DataGridView gdrBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barrio;
    }
}