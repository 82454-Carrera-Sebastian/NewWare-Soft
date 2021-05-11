
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
            this.txtConfirm2Pass = new System.Windows.Forms.TextBox();
            this.lblConfirm2Pass = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblModifUser = new System.Windows.Forms.Label();
            this.txtModifUser = new System.Windows.Forms.TextBox();
            this.txtModifPass = new System.Windows.Forms.TextBox();
            this.lblModifPass = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.txtConfirm2Pass);
            this.groupBox1.Controls.Add(this.lblConfirm2Pass);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.lblModifUser);
            this.groupBox1.Controls.Add(this.txtModifUser);
            this.groupBox1.Controls.Add(this.txtModifPass);
            this.groupBox1.Controls.Add(this.lblModifPass);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 202);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actualizar contraseña";
            // 
            // txtConfirm2Pass
            // 
            this.txtConfirm2Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirm2Pass.Location = new System.Drawing.Point(197, 107);
            this.txtConfirm2Pass.Name = "txtConfirm2Pass";
            this.txtConfirm2Pass.PasswordChar = '*';
            this.txtConfirm2Pass.Size = new System.Drawing.Size(100, 23);
            this.txtConfirm2Pass.TabIndex = 9;
            // 
            // lblConfirm2Pass
            // 
            this.lblConfirm2Pass.AutoSize = true;
            this.lblConfirm2Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm2Pass.Location = new System.Drawing.Point(8, 113);
            this.lblConfirm2Pass.Name = "lblConfirm2Pass";
            this.lblConfirm2Pass.Size = new System.Drawing.Size(171, 17);
            this.lblConfirm2Pass.TabIndex = 8;
            this.lblConfirm2Pass.Text = "Confirmar Contraseña:";
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
            // lblModifUser
            // 
            this.lblModifUser.AutoSize = true;
            this.lblModifUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifUser.Location = new System.Drawing.Point(28, 38);
            this.lblModifUser.Name = "lblModifUser";
            this.lblModifUser.Size = new System.Drawing.Size(151, 17);
            this.lblModifUser.TabIndex = 0;
            this.lblModifUser.Text = "Nombre de usuario:";
            // 
            // txtModifUser
            // 
            this.txtModifUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModifUser.Location = new System.Drawing.Point(197, 32);
            this.txtModifUser.Name = "txtModifUser";
            this.txtModifUser.Size = new System.Drawing.Size(100, 23);
            this.txtModifUser.TabIndex = 3;
            // 
            // txtModifPass
            // 
            this.txtModifPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModifPass.Location = new System.Drawing.Point(197, 70);
            this.txtModifPass.Name = "txtModifPass";
            this.txtModifPass.PasswordChar = '*';
            this.txtModifPass.Size = new System.Drawing.Size(100, 23);
            this.txtModifPass.TabIndex = 4;
            // 
            // lblModifPass
            // 
            this.lblModifPass.AutoSize = true;
            this.lblModifPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifPass.Location = new System.Drawing.Point(83, 76);
            this.lblModifPass.Name = "lblModifPass";
            this.lblModifPass.Size = new System.Drawing.Size(96, 17);
            this.lblModifPass.TabIndex = 1;
            this.lblModifPass.Text = "Contraseña:";
            // 
            // GrillaUsers
            // 
            this.GrillaUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.User,
            this.Password});
            this.GrillaUsers.Location = new System.Drawing.Point(12, 230);
            this.GrillaUsers.Name = "GrillaUsers";
            this.GrillaUsers.Size = new System.Drawing.Size(444, 264);
            this.GrillaUsers.TabIndex = 9;
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
            this.ClientSize = new System.Drawing.Size(497, 506);
            this.Controls.Add(this.GrillaUsers);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModifUser";
            this.Text = "ModifUser";
            this.Load += new System.EventHandler(this.ModifUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtConfirm2Pass;
        private System.Windows.Forms.Label lblConfirm2Pass;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblModifUser;
        private System.Windows.Forms.TextBox txtModifUser;
        private System.Windows.Forms.TextBox txtModifPass;
        private System.Windows.Forms.Label lblModifPass;
        private System.Windows.Forms.DataGridView GrillaUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
    }
}