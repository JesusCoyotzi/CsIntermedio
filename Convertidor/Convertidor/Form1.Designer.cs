namespace Convertidor
{
    partial class Convertidor
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbGC = new System.Windows.Forms.TextBox();
            this.tbGF = new System.Windows.Forms.TextBox();
            this.btConvertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Celsius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Farenheit";
            // 
            // tbGC
            // 
            this.tbGC.Location = new System.Drawing.Point(132, 31);
            this.tbGC.Name = "tbGC";
            this.tbGC.Size = new System.Drawing.Size(100, 20);
            this.tbGC.TabIndex = 0;
            this.tbGC.Text = "0.0";
            this.tbGC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbGC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGC_KeyPress);
            // 
            // tbGF
            // 
            this.tbGF.Location = new System.Drawing.Point(132, 72);
            this.tbGF.Name = "tbGF";
            this.tbGF.Size = new System.Drawing.Size(100, 20);
            this.tbGF.TabIndex = 1;
            this.tbGF.Text = "32.0";
            this.tbGF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbGF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGC_KeyPress);
            // 
            // btConvertir
            // 
            this.btConvertir.Location = new System.Drawing.Point(101, 127);
            this.btConvertir.Name = "btConvertir";
            this.btConvertir.Size = new System.Drawing.Size(75, 23);
            this.btConvertir.TabIndex = 3;
            this.btConvertir.Text = "Convertir";
            this.btConvertir.UseVisualStyleBackColor = true;
            this.btConvertir.Click += new System.EventHandler(this.btConvertir_Click);
            // 
            // Convertidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 170);
            this.Controls.Add(this.btConvertir);
            this.Controls.Add(this.tbGF);
            this.Controls.Add(this.tbGC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Convertidor";
            this.Text = "Convertidor";
            this.Load += new System.EventHandler(this.Convertidor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbGC;
        private System.Windows.Forms.TextBox tbGF;
        private System.Windows.Forms.Button btConvertir;
    }
}

