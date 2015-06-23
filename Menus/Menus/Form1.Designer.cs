namespace Menus
{
    partial class Editor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpt = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optTam = new System.Windows.Forms.ToolStripMenuItem();
            this.optFont = new System.Windows.Forms.ToolStripMenuItem();
            this.opt14 = new System.Windows.Forms.ToolStripMenuItem();
            this.opt18 = new System.Windows.Forms.ToolStripMenuItem();
            this.opt20 = new System.Windows.Forms.ToolStripMenuItem();
            this.optCourier = new System.Windows.Forms.ToolStripMenuItem();
            this.optComic = new System.Windows.Forms.ToolStripMenuItem();
            this.optDef4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tbEditor = new System.Windows.Forms.TextBox();
            this.menuEdicion = new System.Windows.Forms.ToolStripMenuItem();
            this.btCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.btCut = new System.Windows.Forms.ToolStripMenuItem();
            this.btPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(375, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuArchivo
            // 
            this.menuArchivo.Name = "menuArchivo";
            this.menuArchivo.Size = new System.Drawing.Size(60, 20);
            this.menuArchivo.Text = "Archivo";
            // 
            // menuOpt
            // 
            this.menuOpt.Name = "menuOpt";
            this.menuOpt.Size = new System.Drawing.Size(69, 20);
            this.menuOpt.Text = "Opciones";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // optTam
            // 
            this.optTam.Name = "optTam";
            this.optTam.Size = new System.Drawing.Size(152, 22);
            this.optTam.Text = "&Tamaño";
            // 
            // optFont
            // 
            this.optFont.Name = "optFont";
            this.optFont.Size = new System.Drawing.Size(152, 22);
            this.optFont.Text = "&Fuente";
            // 
            // opt14
            // 
            this.opt14.Name = "opt14";
            this.opt14.Size = new System.Drawing.Size(152, 22);
            this.opt14.Text = "14";
            // 
            // opt18
            // 
            this.opt18.Name = "opt18";
            this.opt18.Size = new System.Drawing.Size(152, 22);
            this.opt18.Text = "18";
            // 
            // opt20
            // 
            this.opt20.Name = "opt20";
            this.opt20.Size = new System.Drawing.Size(152, 22);
            this.opt20.Text = "20";
            // 
            // optCourier
            // 
            this.optCourier.Name = "optCourier";
            this.optCourier.Size = new System.Drawing.Size(152, 22);
            this.optCourier.Text = "Courier";
            // 
            // optComic
            // 
            this.optComic.Name = "optComic";
            this.optComic.Size = new System.Drawing.Size(152, 22);
            this.optComic.Text = "Comic Sans";
            // 
            // optDef4
            // 
            this.optDef4.Name = "optDef4";
            this.optDef4.Size = new System.Drawing.Size(152, 22);
            this.optDef4.Text = "Default";
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
            this.tbEditor.Size = new System.Drawing.Size(375, 270);
            this.tbEditor.TabIndex = 1;
            // 
            // menuEdicion
            // 
            this.menuEdicion.Name = "menuEdicion";
            this.menuEdicion.Size = new System.Drawing.Size(58, 20);
            this.menuEdicion.Text = "Edicion";
            // 
            // btCopy
            // 
            this.btCopy.Name = "btCopy";
            this.btCopy.Size = new System.Drawing.Size(152, 22);
            this.btCopy.Text = "&Copiar";
            // 
            // btCut
            // 
            this.btCut.Name = "btCut";
            this.btCut.Size = new System.Drawing.Size(152, 22);
            this.btCut.Text = "C&ortar";
            // 
            // btPaste
            // 
            this.btPaste.Name = "btPaste";
            this.btPaste.Size = new System.Drawing.Size(152, 22);
            this.btPaste.Text = "&Pegar";
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 294);
            this.Controls.Add(this.tbEditor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Editor";
            this.Text = "Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuArchivo;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuOpt;
        private System.Windows.Forms.ToolStripMenuItem optTam;
        private System.Windows.Forms.ToolStripMenuItem opt14;
        private System.Windows.Forms.ToolStripMenuItem opt18;
        private System.Windows.Forms.ToolStripMenuItem opt20;
        private System.Windows.Forms.ToolStripMenuItem optFont;
        private System.Windows.Forms.ToolStripMenuItem optCourier;
        private System.Windows.Forms.ToolStripMenuItem optComic;
        private System.Windows.Forms.ToolStripMenuItem optDef4;
        private System.Windows.Forms.TextBox tbEditor;
        private System.Windows.Forms.ToolStripMenuItem menuEdicion;
        private System.Windows.Forms.ToolStripMenuItem btCopy;
        private System.Windows.Forms.ToolStripMenuItem btCut;
        private System.Windows.Forms.ToolStripMenuItem btPaste;
    }
}

