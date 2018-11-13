using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ClaseChar : Form
    {
        public ClaseChar()
        {
            InitializeComponent();
        }

        private void let_TextChanged(object sender, EventArgs e)
        {

        }

        private void num_TextChanged(object sender, EventArgs e)
        {

        }

        private void punt_TextChanged(object sender, EventArgs e)
        {

        }

        private void simb_TextChanged(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 255; i++)
            {
                char letra = (char)i;
                if (char.IsLetter(letra))
                {
                    this.let.Text += letra;
                }else if (char.IsNumber(letra))
                {
                    this.num.Text += letra;
                }else if (char.IsPunctuation(letra))
                {
                    this.punt.Text += letra;
                }else if (char.IsSymbol(letra))
                {
                    this.simb.Text += letra;
                }
            }
        }
    }
}
