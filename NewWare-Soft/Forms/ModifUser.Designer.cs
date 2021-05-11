
namespace NewWare_Soft.Forms
{
    partial class ModifUser
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
            this.txtConfirmPass2 = new System.Windows.Forms.TextBox();
            this.lblConfirmNewPass2 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblNewUser2 = new System.Windows.Forms.Label();
            this.txtNewUser2 = new System.Windows.Forms.TextBox();
            this.txtNewPass2 = new System.Windows.Forms.TextBox();
            this.lblNewPass2 = new System.Windows.Forms.Label();
            this.GrillaUsers = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtConfirmPass2);
            this.groupBox1.Controls.Add(this.lblConfirmNewPass2);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.lblNewUser2);
            this.groupBox1.Controls.Add(this.txtNewUser2);
            this.groupBox1.Controls.Add(this.txtNewPass2);
            this.groupBox1.Controls.Add(this.lblNewPass2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 202);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actualizar contraseña/Eliminar Usuario";
            // 
            // txtConfirmPass2
            // 
            this.txtConfirmPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPass2.Location = new System.Drawing.Point(197, 107);
            this.txtConfirmPass2.Name = "txtConfirmPass2";
            this.txtConfirmPass2.PasswordChar = '*';
            this.txtConfirmPass2.Size = new System.Drawing.Size(100, 23);
            this.txtConfirmPass2.TabIndex = 9;
            // 
            // lblConfirmNewPass2
            // 
            this.lblConfirmNewPass2.AutoSize = true;
            this.lblConfirmNewPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmNewPass2.Location = new System.Drawing.Point(8, 113);
            this.lblConfirmNewPass2.Name = "lblConfirmNewPass2";
            this.lblConfirmNewPass2.Size = new System.Drawing.Size(171, 17);
            this.lblConfirmNewPass2.TabIndex = 8;
            this.lblConfirmNewPass2.Text = "Confirmar Contraseña:";
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Location = new System.Drawing.Point(210, 150);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 46);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar Usuario";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(65, 150);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 46);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar usuario";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblNewUser2
            // 
            this.lblNewUser2.AutoSize = true;
            this.lblNewUser2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewUser2.Location = new System.Drawing.Point(28, 38);
            this.lblNewUser2.Name = "lblNewUser2";
            this.lblNewUser2.Size = new System.Drawing.Size(151, 17);
            this.lblNewUser2.TabIndex = 0;
            this.lblNewUser2.Text = "Nombre de usuario:";
            // 
            // txtNewUser2
            // 
            this.txtNewUser2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewUser2.Location = new System.Drawing.Point(197, 32);
            this.txtNewUser2.Name = "txtNewUser2";
            this.txtNewUser2.Size = new System.Drawing.Size(100, 23);
            this.txtNewUser2.TabIndex = 3;
            // 
            // txtNewPass2
            // 
            this.txtNewPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass2.Location = new System.Drawing.Point(197, 70);
            this.txtNewPass2.Name = "txtNewPass2";
            this.txtNewPass2.PasswordChar = '*';
            this.txtNewPass2.Size = new System.Drawing.Size(100, 23);
            this.txtNewPass2.TabIndex = 4;
            // 
            // lblNewPass2
            // 
            this.lblNewPass2.AutoSize = true;
            this.lblNewPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPass2.Location = new System.Drawing.Point(83, 76);
            this.lblNewPass2.Name = "lblNewPass2";
            this.lblNewPass2.Size = new System.Drawing.Size(96, 17);
            this.lblNewPass2.TabIndex = 1;
            this.lblNewPass2.Text = "Contraseña:";
            // 
            // GrillaUsers
            // 
            this.GrillaUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.User,
            this.Password});
            this.GrillaUsers.Location = new System.Drawing.Point(12, 220);
            this.GrillaUsers.Name = "GrillaUsers";
            this.GrillaUsers.Size = new System.Drawing.Size(444, 264);
            this.GrillaUsers.TabIndex = 8;
            this.GrillaUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaUsers_CellClick);
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
            // ModifUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 496);
            this.Controls.Add(this.GrillaUsers);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModifUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificación de usuario";
            this.Load += new System.EventHandler(this.ModifUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblNewUser2;
        private System.Windows.Forms.TextBox txtNewUser2;
        private System.Windows.Forms.TextBox txtNewPass2;
        private System.Windows.Forms.Label lblNewPass2;
        private System.Windows.Forms.DataGridView GrillaUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.Label lblConfirmNewPass2;
        private System.Windows.Forms.TextBox txtConfirmPass2;
    }
}