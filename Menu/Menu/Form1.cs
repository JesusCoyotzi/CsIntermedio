using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class editor : Form
    {


        public editor()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btCopy_Click(object sender, EventArgs e)
        {
            tbEditor.Copy();
        }

        private void btCortar_Click(object sender, EventArgs e)
        {
            tbEditor.Cut();
        }

        private void btPegar_Click(object sender, EventArgs e)
        {
            tbEditor.Paste();
        }

        private void optCourier_Click(object sender, EventArgs e)
        {
            Font f = tbEditor.Font;
            tbEditor.Font = new Font("Courier New", f.Size, f.Style);
        }



        private Font DefFont;
        private void editor_Load(object sender, EventArgs e)
        {
            DefFont = tbEditor.Font;
        }

        private void optComic_Click(object sender, EventArgs e)
        {
            Font f = tbEditor.Font;
            tbEditor.Font = new Font("Comic Sans MS", f.Size, f.Style);
        }

        private void optDef_Click(object sender, EventArgs e)
        {
            Font f = DefFont;
            tbEditor.Font = new Font(f.FontFamily, f.Size, f.Style);
        }

        private void opt14_Click(object sender, EventArgs e)
        {
            Font f = tbEditor.Font;
            tbEditor.Font = new Font(f.FontFamily, 14.0F, f.Style);
        }

        private void opt18_Click(object sender, EventArgs e)
        {
            Font f = tbEditor.Font;
            tbEditor.Font = new Font(f.FontFamily, 18.0F, f.Style);
        }

        private void opt24_Click(object sender, EventArgs e)
        {
            Font f = tbEditor.Font;
            tbEditor.Font = new Font(f.FontFamily, 24.0F, f.Style);
        }


    }
}
