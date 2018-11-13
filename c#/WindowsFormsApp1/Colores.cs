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
    public partial class Colores : Form
    {
        public Colores()
        {
            InitializeComponent();
        }

        private void red_TextChanged(object sender, EventArgs e)
        {

        }

        private void green_TextChanged(object sender, EventArgs e)
        {

        }

        private void blue_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
          
            int rojo = int.Parse(this.red.Text);
            int verde = int.Parse(this.green.Text);
            int azul = int.Parse(this.blue.Text);
            if ((rojo >= 0 && rojo <= 255) && (verde >= 0 && verde <= 255) && (azul >= 0 && azul <= 255))
            {
                this.BackColor = Color.FromArgb(rojo, verde, azul);
                this.red.BackColor = Color.FromArgb(rojo, 0, 0);
                this.green.BackColor = Color.FromArgb(0, verde, 0);
                this.blue.BackColor = Color.FromArgb(0, 0, azul);
            }
            else
            {
                MessageBox.Show("Número máximo 255 en cada campo."
                , "Error de datos"
                , MessageBoxButtons.AbortRetryIgnore
                , MessageBoxIcon.Stop);
            }

        }
    }
}
