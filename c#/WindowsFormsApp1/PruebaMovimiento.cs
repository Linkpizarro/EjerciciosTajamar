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
    public partial class PruebaMovimiento : Form
    {
        Graphics lienzo;
        int x = 0;
        int y = 0;
        Image imagen = Image.FromFile("steam.jpg");
        public PruebaMovimiento()
        {
            InitializeComponent();
            lienzo = pictureBox1.CreateGraphics();
            
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Down:
                    if(y + imagen.Height + 10 < pictureBox1.Height)
                    {
                        y += 10;
                    }
                    break;
                case Keys.Up:
                    if (y - 10 > 0)
                    {
                        y -= 10;
                    }
                    break;
                case Keys.Left:
                    if (x - 10 > 0)
                    {
                        x -= 10;
                    }
                    break;
                case Keys.Right:
                    if (x + imagen.Width + 10 < pictureBox1.Width)
                    {
                        x += 10;
                    }
                    break;
                default:
                    break;

            }
            lienzo.Clear(pictureBox1.BackColor);
            lienzo.DrawImage(imagen, x, y);
        }

        private void Game_Load(object sender, EventArgs e)
        {
          
        }

        
    }
}
