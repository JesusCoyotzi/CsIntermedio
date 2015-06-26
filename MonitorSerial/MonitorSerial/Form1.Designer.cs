namespace MonitorSerial
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
            this.Mandar = new System.Windows.Forms.Button();
            this.SendBox = new System.Windows.Forms.TextBox();
            this.ReceiveBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarPuertosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mandar
            // 
            this.Mandar.Location = new System.Drawing.Point(221, 27);
            this.Mandar.Name = "Mandar";
            this.Mandar.Size = new System.Drawing.Size(51, 23);
            this.Mandar.TabIndex = 0;
            this.Mandar.Text = "Mandar";
            this.Mandar.UseVisualStyleBackColor = true;
            this.Mandar.Click += new System.EventHandler(this.Mandar_Click);
            // 
            // SendBox
            // 
            this.SendBox.Location = new System.Drawing.Point(9, 30);
            this.SendBox.Name = "SendBox";
            this.SendBox.Size = new System.Drawing.Size(194, 20);
            this.SendBox.TabIndex = 1;
            // 
            // ReceiveBox
            // 
            this.ReceiveBox.Location = new System.Drawing.Point(9, 74);
            this.ReceiveBox.Multiline = true;
            this.ReceiveBox.Name = "ReceiveBox";
            this.ReceiveBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ReceiveBox.Size = new System.Drawing.Size(315, 218);
            this.ReceiveBox.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(336, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarToolStripMenuItem,
            this.listarPuertosToolStripMenuItem,
            this.terminarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // conectarToolStripMenuItem
            // 
            this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            this.conectarToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.conectarToolStripMenuItem.Text = "Conectar";
            this.conectarToolStripMenuItem.Click += new System.EventHandler(this.conectarToolStripMenuItem_Click);
            // 
            // listarPuertosToolStripMenuItem
            // 
            this.listarPuertosToolStripMenuItem.Name = "listarPuertosToolStripMenuItem";
            this.listarPuertosToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.listarPuertosToolStripMenuItem.Text = "Listar Puertos";
            this.listarPuertosToolStripMenuItem.Click += new System.EventHandler(this.listarPuertosToolStripMenuItem_Click);
            // 
            // terminarToolStripMenuItem
            // 
            this.terminarToolStripMenuItem.Name = "terminarToolStripMenuItem";
            this.terminarToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.terminarToolStripMenuItem.Text = "Terminar";
            this.terminarToolStripMenuItem.Click += new System.EventHandler(this.terminarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 304);
            this.Controls.Add(this.ReceiveBox);
            this.Controls.Add(this.SendBox);
            this.Controls.Add(this.Mandar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Monitor Serial";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Mandar;
        private System.Windows.Forms.TextBox SendBox;
        private System.Windows.Forms.TextBox ReceiveBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarPuertosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminarToolStripMenuItem;
    }
}

