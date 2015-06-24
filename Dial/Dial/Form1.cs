using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dial
{
    public partial class formOwner : Form
    {
        public formOwner()
        {
            InitializeComponent();
        }

        private void formOwner_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormHijo Cuadro = new FormHijo(this);
            Cuadro.ShowDialog();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    }
}
