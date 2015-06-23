namespace Converter
{
    partial class Conversor
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
            this.laGC = new System.Windows.Forms.Label();
            this.laGF = new System.Windows.Forms.Label();
            this.tbCelsius = new System.Windows.Forms.TextBox();
            this.tbFar = new System.Windows.Forms.TextBox();
            this.btConverter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // laGC
            // 
            this.laGC.AutoSize = true;
            this.laGC.Location = new System.Drawing.Point(24, 40);
            this.laGC.Name = "laGC";
            this.laGC.Size = new System.Drawing.Size(100, 13);
            this.laGC.TabIndex = 3;
            this.laGC.Text = "Grados Centigrados";
            // 
            // laGF
            // 
            this.laGF.AutoSize = true;
            this.laGF.Location = new System.Drawing.Point(24, 72);
            this.laGF.Name = "laGF";
            this.laGF.Size = new System.Drawing.Size(88, 13);
            this.laGF.TabIndex = 4;
            this.laGF.Text = "Grados Farenheit";
            // 
            // tbCelsius
            // 
            this.tbCelsius.Location = new System.Drawing.Point(160, 40);
            this.tbCelsius.Name = "tbCelsius";
            this.tbCelsius.Size = new System.Drawing.Size(136, 20);
            this.tbCelsius.TabIndex = 0;
            this.tbCelsius.Text = "0.0";
            this.tbCelsius.TextChanged += new System.EventHandler(this.tbCelsius_TextChanged);
            this.tbCelsius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCelsius_KeyPress);
            // 
            // tbFar
            // 
            this.tbFar.Location = new System.Drawing.Point(160, 72);
            this.tbFar.Name = "tbFar";
            this.tbFar.Size = new System.Drawing.Size(136, 20);
            this.tbFar.TabIndex = 1;
            this.tbFar.Text = "32.0";
            this.tbFar.TextChanged += new System.EventHandler(this.tbFar_TextChanged);
            this.tbFar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCelsius_KeyPress);
            // 
            // btConverter
            // 
            this.btConverter.Location = new System.Drawing.Point(87, 120);
            this.btConverter.Name = "btConverter";
            this.btConverter.Size = new System.Drawing.Size(152, 32);
            this.btConverter.TabIndex = 2;
            this.btConverter.Text = "Calcular";
            this.btConverter.UseVisualStyleBackColor = true;
            this.btConverter.Click += new System.EventHandler(this.btConverter_Click);
            // 
            // Conversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 183);
            this.Controls.Add(this.btConverter);
            this.Controls.Add(this.tbFar);
            this.Controls.Add(this.tbCelsius);
            this.Controls.Add(this.laGF);
            this.Controls.Add(this.laGC);
            this.Name = "Conversor";
            this.Text = "Convertidor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laGC;
        private System.Windows.Forms.Label laGF;
        private System.Windows.Forms.TextBox tbCelsius;
        private System.Windows.Forms.TextBox tbFar;
        private System.Windows.Forms.Button btConverter;
    }
}

