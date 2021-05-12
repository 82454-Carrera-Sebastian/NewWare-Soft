
namespace NewWare_Soft.Forms
{
    partial class Alta_Banco
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreBanco = new System.Windows.Forms.TextBox();
            this.lblNombreBanco = new System.Windows.Forms.Label();
            this.btnAgregarBanco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nuevo banco";
            // 
            // txtNombreBanco
            // 
            this.txtNombreBanco.Location = new System.Drawing.Point(156, 51);
            this.txtNombreBanco.Name = "txtNombreBanco";
            this.txtNombreBanco.Size = new System.Drawing.Size(235, 20);
            this.txtNombreBanco.TabIndex = 4;
            // 
            // lblNombreBanco
            // 
            this.lblNombreBanco.AutoSize = true;
            this.lblNombreBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreBanco.Location = new System.Drawing.Point(12, 51);
            this.lblNombreBanco.Name = "lblNombreBanco";
            this.lblNombreBanco.Size = new System.Drawing.Size(134, 18);
            this.lblNombreBanco.TabIndex = 3;
            this.lblNombreBanco.Text = "Nombre del banco:";
            // 
            // btnAgregarBanco
            // 
            this.btnAgregarBanco.Location = new System.Drawing.Point(263, 97);
            this.btnAgregarBanco.Name = "btnAgregarBanco";
            this.btnAgregarBanco.Size = new System.Drawing.Size(128, 23);
            this.btnAgregarBanco.TabIndex = 5;
            this.btnAgregarBanco.Text = "Agregar banco";
            this.btnAgregarBanco.UseVisualStyleBackColor = true;
            this.btnAgregarBanco.Click += new System.EventHandler(this.btnAgregarBanco_Click);
            // 
            // Alta_Banco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 144);
            this.Controls.Add(this.btnAgregarBanco);
            this.Controls.Add(this.txtNombreBanco);
            this.Controls.Add(this.lblNombreBanco);
            this.Controls.Add(this.label1);
            this.Name = "Alta_Banco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta_Banco";
            this.Load += new System.EventHandler(this.Alta_Banco_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreBanco;
        private System.Windows.Forms.Label lblNombreBanco;
        private System.Windows.Forms.Button btnAgregarBanco;
    }
}