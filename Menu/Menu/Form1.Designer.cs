namespace Menu
{
    partial class editor
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
            this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.btSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tbEditor = new System.Windows.Forms.TextBox();
            this.menuEdicion = new System.Windows.Forms.ToolStripMenuItem();
            this.btCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.btCortar = new System.Windows.Forms.ToolStripMenuItem();
            this.btPegar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpt = new System.Windows.Forms.ToolStripMenuItem();
            this.btFont = new System.Windows.Forms.ToolStripMenuItem();
            this.btTam = new System.Windows.Forms.ToolStripMenuItem();
            this.optCourier = new System.Windows.Forms.ToolStripMenuItem();
            this.optComic = new System.Windows.Forms.ToolStripMenuItem();
            this.optDef = new System.Windows.Forms.ToolStripMenuItem();
            this.opt14 = new System.Windows.Forms.ToolStripMenuItem();
            this.opt18 = new System.Windows.Forms.ToolStripMenuItem();
            this.opt24 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo,
            this.menuEdicion,
            this.menuOpt});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuArchivo
            // 
            this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btSalir});
            this.menuArchivo.Name = "menuArchivo";
            this.menuArchivo.Size = new System.Drawing.Size(60, 20);
            this.menuArchivo.Text = "&Archivo";
            // 
            // btSalir
            // 
            this.btSalir.Name = "btSalir";
            this.btSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.btSalir.Size = new System.Drawing.Size(152, 22);
            this.btSalir.Text = "&salir";
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // tbEditor
            // 
            this.tbEditor.AcceptsReturn = true;
            this.tbEditor.AcceptsTab = true;
            this.tbEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbEditor.Location = new System.Drawing.Point(0, 24);
            this.tbEditor.Multiline = true;
            this.tbEditor.Name = "tbEditor";
            this.tbEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbEditor.Size = new System.Drawing.Size(384, 237);
            this.tbEditor.TabIndex = 1;
            // 
            // menuEdicion
            // 
            this.menuEdicion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btCopy,
            this.btCortar,
            this.btPegar});
            this.menuEdicion.Name = "menuEdicion";
            this.menuEdicion.Size = new System.Drawing.Size(58, 20);
            this.menuEdicion.Text = "Edición";
            // 
            // btCopy
            // 
            this.btCopy.Name = "btCopy";
            this.btCopy.Size = new System.Drawing.Size(152, 22);
            this.btCopy.Text = "&Copiar";
            this.btCopy.Click += new System.EventHandler(this.btCopy_Click);
            // 
            // btCortar
            // 
            this.btCortar.Name = "btCortar";
            this.btCortar.Size = new System.Drawing.Size(152, 22);
            this.btCortar.Text = "Cortar";
            this.btCortar.Click += new System.EventHandler(this.btCortar_Click);
            // 
            // btPegar
            // 
            this.btPegar.Name = "btPegar";
            this.btPegar.Size = new System.Drawing.Size(152, 22);
            this.btPegar.Text = "&Pegar";
            this.btPegar.Click += new System.EventHandler(this.btPegar_Click);
            // 
            // menuOpt
            // 
            this.menuOpt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btFont,
            this.btTam});
            this.menuOpt.Name = "menuOpt";
            this.menuOpt.Size = new System.Drawing.Size(69, 20);
            this.menuOpt.Text = "Opciones";
            // 
            // btFont
            // 
            this.btFont.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optCourier,
            this.optComic,
            this.optDef});
            this.btFont.Name = "btFont";
            this.btFont.Size = new System.Drawing.Size(152, 22);
            this.btFont.Text = "Fuente";
            // 
            // btTam
            // 
            this.btTam.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opt14,
            this.opt18,
            this.opt24});
            this.btTam.Name = "btTam";
            this.btTam.Size = new System.Drawing.Size(152, 22);
            this.btTam.Text = "Tamaño";
            // 
            // optCourier
            // 
            this.optCourier.Name = "optCourier";
            this.optCourier.Size = new System.Drawing.Size(152, 22);
            this.optCourier.Text = "Courier";
            this.optCourier.Click += new System.EventHandler(this.optCourier_Click);
            // 
            // optComic
            // 
            this.optComic.Name = "optComic";
            this.optComic.Size = new System.Drawing.Size(152, 22);
            this.optComic.Text = "Comic Sans";
            this.optComic.Click += new System.EventHandler(this.optComic_Click);
            // 
            // optDef
            // 
            this.optDef.Name = "optDef";
            this.optDef.Size = new System.Drawing.Size(152, 22);
            this.optDef.Text = "Defeault";
            this.optDef.Click += new System.EventHandler(this.optDef_Click);
            // 
            // opt14
            // 
            this.opt14.Name = "opt14";
            this.opt14.Size = new System.Drawing.Size(152, 22);
            this.opt14.Text = "14";
            this.opt14.Click += new System.EventHandler(this.opt14_Click);
            // 
            // opt18
            // 
            this.opt18.Name = "opt18";
            this.opt18.Size = new System.Drawing.Size(152, 22);
            this.opt18.Text = "18";
            this.opt18.Click += new System.EventHandler(this.opt18_Click);
            // 
            // opt24
            // 
            this.opt24.Name = "opt24";
            this.opt24.Size = new System.Drawing.Size(152, 22);
            this.opt24.Text = "24";
            this.opt24.Click += new System.EventHandler(this.opt24_Click);
            // 
            // editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.tbEditor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "editor";
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.editor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuArchivo;
        private System.Windows.Forms.ToolStripMenuItem btSalir;
        private System.Windows.Forms.TextBox tbEditor;
        private System.Windows.Forms.ToolStripMenuItem menuEdicion;
        private System.Windows.Forms.ToolStripMenuItem btCopy;
        private System.Windows.Forms.ToolStripMenuItem btCortar;
        private System.Windows.Forms.ToolStripMenuItem btPegar;
        private System.Windows.Forms.ToolStripMenuItem menuOpt;
        private System.Windows.Forms.ToolStripMenuItem btFont;
        private System.Windows.Forms.ToolStripMenuItem optCourier;
        private System.Windows.Forms.ToolStripMenuItem optComic;
        private System.Windows.Forms.ToolStripMenuItem optDef;
        private System.Windows.Forms.ToolStripMenuItem btTam;
        private System.Windows.Forms.ToolStripMenuItem opt14;
        private System.Windows.Forms.ToolStripMenuItem opt18;
        private System.Windows.Forms.ToolStripMenuItem opt24;
    }
}

