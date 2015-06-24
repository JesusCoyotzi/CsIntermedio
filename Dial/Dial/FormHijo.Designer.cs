namespace Dial
{
    partial class FormHijo
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
            this.addList = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addList
            // 
            this.addList.Location = new System.Drawing.Point(106, 106);
            this.addList.Name = "addList";
            this.addList.Size = new System.Drawing.Size(75, 23);
            this.addList.TabIndex = 0;
            this.addList.Text = "Ok";
            this.addList.UseVisualStyleBackColor = true;
            this.addList.Click += new System.EventHandler(this.addList_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 88);
            this.textBox1.TabIndex = 1;
            // 
            // FormHijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.addList);
            this.Name = "FormHijo";
            this.Text = "FormHijo";
            this.Load += new System.EventHandler(this.FormHijo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addList;
        private System.Windows.Forms.TextBox textBox1;
    }
}