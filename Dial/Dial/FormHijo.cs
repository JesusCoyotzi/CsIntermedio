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
    public partial class FormHijo : Form
    {
        private formOwner mainFrame;
 
        public FormHijo()
        {
            
            InitializeComponent();

        }


        public FormHijo(formOwner frame)
        {
            this.mainFrame = frame;
            InitializeComponent();

        }

        private void FormHijo_Load(object sender, EventArgs e)
        {

        }

        private void addList_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                string[] texto;
                if (mainFrame.radioButton1.Checked)
                {
                    texto = textBox1.Lines;
                    mainFrame.listBox1.Items.AddRange(texto);
                }
                else if (mainFrame.radioButton2.Checked)
                {
                    texto = textBox1.Lines;
                    mainFrame.listBox2.Items.AddRange(texto);
                }
                
            }
            this.Close();
        }
    }
}
