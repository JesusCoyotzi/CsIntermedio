using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIeditor
{
    public partial class padre : Form
    {
        public padre()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hijocs nuevoDocumento = new hijocs();
          
            nuevoDocumento.Show();
        }

        private void padre_Load(object sender, EventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "archivos rtf (*.rtf)| *.rtf | archivos de texto (*.txt) | *.txt";

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                string ruta=null;
                RichTextBoxStreamType formato = RichTextBoxStreamType.PlainText;
                if (guardar.FilterIndex == 1)
                {
                    formato = RichTextBoxStreamType.RichText;
                     ruta = guardar.FileName;
                    richTextBox1.SaveFile(ruta,formato);
                }
                if (guardar.FilterIndex == 2)
                {
                    formato = RichTextBoxStreamType.PlainText;
                     ruta = guardar.FileName;
                    richTextBox1.SaveFile(ruta, formato);
                }


                this.Text = ruta.Substring(ruta.LastIndexOf("\\") + 1);
            }
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter="archivos rtf (*.rtf)| *.rtf | archivos de texto (*.txt) | *.txt";
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                string ruta= "";
                ruta = abrir.FileName;
                
                RichTextBoxStreamType formato = RichTextBoxStreamType.RichText;
                if (abrir.FilterIndex == 1)
                {
                    formato = RichTextBoxStreamType.RichText;
                    ruta = abrir.FileName;
                    richTextBox1.LoadFile(ruta, formato);
                }
                if (abrir.FilterIndex == 2)
                {
                    formato = RichTextBoxStreamType.PlainText;
                    ruta = abrir.FileName;
                    richTextBox1.LoadFile(ruta, formato);
                }

                this.Text = ruta.Substring(ruta.LastIndexOf("\\") + 1);
            }
                
        }
    }
}
