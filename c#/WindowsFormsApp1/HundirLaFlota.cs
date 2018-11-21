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
    public partial class HundirLaFlota : Form
    {
        int clicks = 0;
        int ship = 0;
        public HundirLaFlota()
        {
            InitializeComponent();
        }

        private void HundirLaFlota_Load(object sender, EventArgs e)
        {
            AddClick();
            
        }

        private void AddClick()
        {
            foreach (Label cel in this.panelPlayer.Controls)
            {
                if (cel.BackColor != Color.Peru && cel.BackColor != Color.Red)
                {
                    cel.Click += PutShip;
                }
                
            }
        }

        private void DelClick()
        {
            foreach (Label cel in this.panelPlayer.Controls)
            {
                if (cel.BackColor != Color.Yellow && cel.BackColor != Color.Green)
                {
                    cel.Click -= PutShip;
                }

            }
        }

        private void PutShip(Object sender,EventArgs e)
        {
            //Aplica los barcos correspondientes
             ValidateUnconfirmedShip(((Label)sender));
        }

        //private void ValidateUnconfirmedShip1(Label cel)
        //{
        //    if (cel.BackColor == Color.DeepSkyBlue)
        //    {
        //        cel.BackColor = Color.Yellow;
        //        DelClick();
        //        btnContinue.Enabled = true;
        //    }
        //    else
        //    {
        //        cel.BackColor = Color.DeepSkyBlue;
        //        AddClick();
        //        btnContinue.Enabled = false;
        //    }
        //}



        private void ValidateUnconfirmedShip(Label cel)
        {
            if (cel.BackColor == Color.DeepSkyBlue)
            {
                cel.BackColor = Color.Yellow;
                CheckYesClick();
                DelClick();
                clicks++;
            }
            else if (cel.BackColor == Color.Yellow && clicks < ship+1)
            {
                cel.BackColor = Color.DeepSkyBlue;
                DelGreen();
                AddClick();
                clicks--;
            }

            else if (cel.BackColor == Color.Green && clicks < ship+1)
            {
                cel.BackColor = Color.Yellow;
                btnContinue.Enabled = true;
                DelClick();
                clicks++;
            }
            else if (cel.BackColor == Color.Yellow && clicks == ship+1)
            {
                cel.BackColor = Color.Green;
                btnContinue.Enabled = false;
                CheckYesClick();
                AddClick();
                clicks--;
            }
            if (clicks == ship+1)
            {
                DelGreen();
                btnContinue.Enabled = true;
            }
        }
            private void CheckNoClick()
        {
            foreach (Label item in this.panelPlayer.Controls)
            {
                if (item.BackColor == Color.Peru)
                {
                    PutRed(item.TabIndex);
                }
            }
        }


        private void CheckYesClick()
        {
            foreach (Label item in this.panelPlayer.Controls)
            {
                if (item.BackColor == Color.Yellow)
                {
                    PutGreen(item.TabIndex);
                }
            }
        }

        private void PutGreen(int index)
        {
            int aux = ship;
            for (int i = 0; i < ship; i++)
            {
                int row = 10 * aux;
                //arriba
                if ((index - row) >= 0)
                {
                    if (this.panelPlayer.Controls[(index - row)].BackColor != Color.Red)
                    {
                        this.panelPlayer.Controls[(index - row)].BackColor = Color.Green;
                    }
                }

                //izquierda
                if ((index - aux) >= 0 && (index % 10) != 0)
                {
                    if (this.panelPlayer.Controls[(index - aux)].BackColor != Color.Red)
                    {
                        this.panelPlayer.Controls[(index - aux)].BackColor = Color.Green;
                    }
                }

                //derecha
                if ((index + aux) >= 0 && (index + ship) <= 99 && ((index - 9) % 10) != 0)
                {
                    if (this.panelPlayer.Controls[(index + aux)].BackColor != Color.Red)
                    {
                        this.panelPlayer.Controls[(index + aux)].BackColor = Color.Green;
                    }
                }

                //abajo
                if ((index + row) >= 0 && (index + row) <= 99)
                {
                    if (this.panelPlayer.Controls[(index + row)].BackColor != Color.Red)
                    {
                        this.panelPlayer.Controls[(index + row)].BackColor = Color.Green;
                    }

                }
                aux--;
            }
        }

        private void DelGreen()
        {
            foreach (Label item in this.panelPlayer.Controls)
            {
                if (item.BackColor == Color.Green )
                {
                    item.BackColor = Color.DeepSkyBlue;
                }
            }
        }

        private void PutRed(int index)
        {
            //diagonal arriba izquierda
            if (((index - 10) - 1) >= 0 && (index % 10) != 0 )
            {
                if (this.panelPlayer.Controls[((index - 10) - 1)].BackColor != Color.Peru)
                {
                    this.panelPlayer.Controls[((index - 10) - 1)].BackColor = Color.Red;
                }
            }
            //arriba
            if ((index - 10) >= 0)
            {
                if (this.panelPlayer.Controls[(index - 10)].BackColor != Color.Peru)
                {
                    this.panelPlayer.Controls[(index - 10)].BackColor = Color.Red;
                }
            }
            //diagonal arriba derecha
            if (((index - 10) + 1) >= 0 && ((index - 10) + 1) <= 99 && ((index-9) % 10) != 0 )
            {
                if (this.panelPlayer.Controls[((index - 10) + 1)].BackColor != Color.Peru)
                {
                    this.panelPlayer.Controls[((index - 10) + 1)].BackColor = Color.Red;
                }
            }
            //izquierda
            if ((index - 1) >= 0 && (index % 10) != 0)
            {
                if (this.panelPlayer.Controls[(index - 1)].BackColor != Color.Peru)
                {
                    this.panelPlayer.Controls[(index - 1)].BackColor = Color.Red;
                }
            }

            //derecha
            if ((index + 1) >= 0 && (index + 1) <= 99 && ((index - 9) % 10) != 0)
            {
                if (this.panelPlayer.Controls[(index + 1)].BackColor != Color.Peru)
                {
                    this.panelPlayer.Controls[(index + 1)].BackColor = Color.Red;
                }
            }
            //diagonal abajo izquierda
            if (((index + 10) - 1) >= 0 && ((index + 10) - 1) <= 99 && (index % 10) != 0)
            {
                if (this.panelPlayer.Controls[((index + 10) - 1)].BackColor != Color.Peru)
                {
                    this.panelPlayer.Controls[((index + 10) - 1)].BackColor = Color.Red;
                }
            }
            //abajo
            if ((index + 10) >= 0 && (index + 10) <= 99)
            {
                if (this.panelPlayer.Controls[(index + 10)].BackColor != Color.Peru)
                {
                    this.panelPlayer.Controls[(index + 10)].BackColor = Color.Red;
                }
            }
            //diagonal arriba derecha
            if (((index + 10) + 1) >= 0 && ((index + 10) + 1) <= 99 && ((index - 9) % 10) != 0)
            {
                if (this.panelPlayer.Controls[((index + 10) + 1)].BackColor != Color.Peru)
                {
                    this.panelPlayer.Controls[((index + 10) + 1)].BackColor = Color.Red;
                }
            }
        }

        private int CountShip()
        {
            int count = 0;
            foreach (Label cel in this.panelPlayer.Controls)
            {
                if (cel.BackColor == Color.Peru)
                {
                    count++;
                }
            }
            return count;
        }

        private void ConfirmShip()
        {
            foreach (Label cel in this.panelPlayer.Controls)
            {
                if (cel.BackColor == Color.Yellow)
                {
                    cel.BackColor = Color.Peru;
                }
            }
        }

        private void CurrentShip()
        {
            switch (ship)
            {
                case 0: ship = 1;break;
                case 1: ship = 2; ; break;
                case 2: ship = 3; break;
                case 3: ship = 4; break;
                case 4: ship = 5; break;  
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            ConfirmShip();
            CheckNoClick();
            CurrentShip();
            clicks = 0;
            AddClick();
            btnContinue.Enabled = false;
        }
    }
}
