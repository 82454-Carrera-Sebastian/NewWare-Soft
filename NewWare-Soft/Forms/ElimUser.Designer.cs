
namespace NewWare_Soft.Forms
{
    partial class ElimUser
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
            this.GrillaUsers2 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblElimUser = new System.Windows.Forms.Label();
            this.txtElimUser = new System.Windows.Forms.TextBox();
            this.txtElimPass = new System.Windows.Forms.TextBox();
            this.lblElimPass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaUsers2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrillaUsers2
            // 
            this.GrillaUsers2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaUsers2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.User,
            this.Password});
            this.GrillaUsers2.Location = new System.Drawing.Point(12, 237);
            this.GrillaUsers2.Name = "GrillaUsers2";
            this.GrillaUsers2.Size = new System.Drawing.Size(444, 264);
            this.GrillaUsers2.TabIndex = 11;
            this.GrillaUsers2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaUsers2_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "IdUsuario";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 50;
            // 
            // User
            // 
            this.User.DataPropertyName = "NombreUsuario";
            this.User.HeaderText = "User";
            this.User.Name = "User";
            this.User.Width = 200;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.lblElimUser);
            this.groupBox1.Controls.Add(this.txtElimUser);
            this.groupBox1.Controls.Add(this.txtElimPass);
            this.groupBox1.Controls.Add(this.lblElimPass);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Sienna;
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 202);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eliminar Usuario";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(210, 123);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 46);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar usuario";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblElimUser
            // 
            this.lblElimUser.AutoSize = true;
            this.lblElimUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElimUser.Location = new System.Drawing.Point(28, 38);
            this.lblElimUser.Name = "lblElimUser";
            this.lblElimUser.Size = new System.Drawing.Size(151, 17);
            this.lblElimUser.TabIndex = 0;
            this.lblElimUser.Text = "Nombre de usuario:";
            // 
            // txtElimUser
            // 
            this.txtElimUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElimUser.Location = new System.Drawing.Point(197, 32);
            this.txtElimUser.Name = "txtElimUser";
            this.txtElimUser.Size = new System.Drawing.Size(100, 23);
            this.txtElimUser.TabIndex = 3;
            // 
            // txtElimPass
            // 
            this.txtElimPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElimPass.Location = new System.Drawing.Point(197, 70);
            this.txtElimPass.Name = "txtElimPass";
            this.txtElimPass.PasswordChar = '*';
            this.txtElimPass.Size = new System.Drawing.Size(100, 23);
            this.txtElimPass.TabIndex = 4;
            // 
            // lblElimPass
            // 
            this.lblElimPass.AutoSize = true;
            this.lblElimPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElimPass.Location = new System.Drawing.Point(83, 76);
            this.lblElimPass.Name = "lblElimPass";
            this.lblElimPass.Size = new System.Drawing.Size(96, 17);
            this.lblElimPass.TabIndex = 1;
            this.lblElimPass.Text = "Contraseña:";
            // 
            // ElimUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 513);
            this.Controls.Add(this.GrillaUsers2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ElimUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElimUser";
            this.Load += new System.EventHandler(this.ElimUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaUsers2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GrillaUsers2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblElimUser;
        private System.Windows.Forms.TextBox txtElimUser;
        private System.Windows.Forms.TextBox txtElimPass;
        private System.Windows.Forms.Label lblElimPass;
    }
}