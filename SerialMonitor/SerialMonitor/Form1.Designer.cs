namespace SerialMonitor
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aarchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarPuertosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SendBox = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.ReceiveBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aarchivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(300, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aarchivoToolStripMenuItem
            // 
            this.aarchivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarToolStripMenuItem,
            this.terminarToolStripMenuItem,
            this.listarPuertosToolStripMenuItem});
            this.aarchivoToolStripMenuItem.Name = "aarchivoToolStripMenuItem";
            this.aarchivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.aarchivoToolStripMenuItem.Text = "Archivo";
            // 
            // conectarToolStripMenuItem
            // 
            this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            this.conectarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.conectarToolStripMenuItem.Text = "&Conectar";
            this.conectarToolStripMenuItem.Click += new System.EventHandler(this.conectarToolStripMenuItem_Click);
            // 
            // terminarToolStripMenuItem
            // 
            this.terminarToolStripMenuItem.Name = "terminarToolStripMenuItem";
            this.terminarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.terminarToolStripMenuItem.Text = "&Terminar";
            this.terminarToolStripMenuItem.Click += new System.EventHandler(this.terminarToolStripMenuItem_Click);
            // 
            // listarPuertosToolStripMenuItem
            // 
            this.listarPuertosToolStripMenuItem.Name = "listarPuertosToolStripMenuItem";
            this.listarPuertosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listarPuertosToolStripMenuItem.Text = "&Listar Puertos";
            // 
            // SendBox
            // 
            this.SendBox.Location = new System.Drawing.Point(12, 35);
            this.SendBox.Name = "SendBox";
            this.SendBox.Size = new System.Drawing.Size(187, 20);
            this.SendBox.TabIndex = 1;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(213, 33);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 2;
            this.Send.Text = "Enviar";
            this.Send.UseVisualStyleBackColor = true;
            // 
            // ReceiveBox
            // 
            this.ReceiveBox.Location = new System.Drawing.Point(12, 62);
            this.ReceiveBox.Multiline = true;
            this.ReceiveBox.Name = "ReceiveBox";
            this.ReceiveBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ReceiveBox.Size = new System.Drawing.Size(276, 175);
            this.ReceiveBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 261);
            this.Controls.Add(this.ReceiveBox);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.SendBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Monitor Serial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aarchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarPuertosToolStripMenuItem;
        private System.Windows.Forms.TextBox SendBox;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.TextBox ReceiveBox;
    }
}

