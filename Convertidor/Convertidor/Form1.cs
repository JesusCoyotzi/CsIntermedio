using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertidor
{
    public partial class Convertidor : Form
    {
        private TextBox SelTextBox;

        public Convertidor()
        {
            InitializeComponent();
        }

        private void Convertidor_Load(object sender, EventArgs e)
        {
           
        }

        private void tbGC_KeyPress(object sender, KeyPressEventArgs e)
        {
            SelTextBox = (TextBox)sender;
            if (e.KeyChar == Convert.ToChar(13))
            {
                e.Handled = true;
                convertir();
            }

        }

        private void btConvertir_Click(object sender, EventArgs e)
        {
            convertir();
        }

        public void convertir()
        {
            try
            {
                double grados;
                //Si seleciono Celsius
                if (SelTextBox == tbGC)
                {
                    grados = Convert.ToDouble(tbGC.Text) * 9.0 / 5.0 + 32.0;
                    tbGF.Text = String.Format("{0:F2}", grados);
                }
                if (SelTextBox == tbGF)
                {
                    grados = (Convert.ToDouble(tbGF.Text) - 32) * 5.0 / 9.0;
                    tbGC.Text = String.Format("{0:F2}", grados);
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Solo números por favor");
            }
        }


    }
}
