namespace Hithere
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.etSaludo = new System.Windows.Forms.Label();
            this.btSaludo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // etSaludo
            // 
            this.etSaludo.AutoSize = true;
            this.etSaludo.BackColor = System.Drawing.SystemColors.Control;
            this.etSaludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etSaludo.Location = new System.Drawing.Point(105, 65);
            this.etSaludo.Name = "etSaludo";
            this.etSaludo.Size = new System.Drawing.Size(75, 20);
            this.etSaludo.TabIndex = 0;
            this.etSaludo.Text = "etiqueta";
            this.etSaludo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btSaludo
            // 
            this.btSaludo.Location = new System.Drawing.Point(105, 122);
            this.btSaludo.Name = "btSaludo";
            this.btSaludo.Size = new System.Drawing.Size(75, 23);
            this.btSaludo.TabIndex = 1;
            this.btSaludo.Text = "Haga clicl aquí";
            this.btSaludo.UseVisualStyleBackColor = true;
            this.btSaludo.Click += new System.EventHandler(this.btSaludo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btSaludo);
            this.Controls.Add(this.etSaludo);
            this.Name = "Form1";
            this.Text = "Saludo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etSaludo;
        private System.Windows.Forms.Button btSaludo;
    }
}

