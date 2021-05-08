
namespace NewWare_Soft
{
    partial class Producto
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
            this.btnHola = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHola
            // 
            this.btnHola.Location = new System.Drawing.Point(478, 210);
            this.btnHola.Name = "btnHola";
            this.btnHola.Size = new System.Drawing.Size(75, 23);
            this.btnHola.TabIndex = 0;
            this.btnHola.Text = "Hola!";
            this.btnHola.UseVisualStyleBackColor = true;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Location = new System.Drawing.Point(245, 147);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(33, 13);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "Titulo";
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.btnHola);
            this.Name = "Producto";
            this.Text = "Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHola;
        private System.Windows.Forms.Label Titulo;
    }
}