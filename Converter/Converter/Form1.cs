using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class Conversor : Form
    {
        private TextBox SelTextBox = null;

        public Conversor()
        {
            InitializeComponent();
        }

        private void btConverter_Click(object sender, EventArgs e)
        {
            convertir();
            
        }

        private void tbCelsius_TextChanged(object sender, EventArgs e)
        {
            
            SelTextBox = (TextBox)sender;
        }

        private void tbFar_TextChanged(object sender, EventArgs e)
        {
            SelTextBox = (TextBox)sender;
        }

        private void tbCelsius_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                e.Handled = true;
                convertir();
                
            }
        }

        public void convertir(){
            try
            {

                double grados;
                if (SelTextBox == tbCelsius)
                {
                    grados = Convert.ToDouble(tbCelsius.Text) * 9.0 / 5.0 + 32.0;
                    tbFar.Text = String.Format("{0:F2}", grados);

                }
                if (SelTextBox == tbFar)
                {
                    grados = (Convert.ToDouble(tbFar.Text) - 32) * 5.0 / 9.0;
                    tbCelsius.Text = String.Format("{0:F2}", grados);

                }
            }
            catch (FormatException)
            {
                tbFar.Text = "32.0";
                tbCelsius.Text = "0.0";
            }
        }

      
    }
}
