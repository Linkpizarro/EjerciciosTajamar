using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class BuscaMinas : Form
    {
        int hw,b;
        List<int> bombers = new List<int>();

        public BuscaMinas()
        {
            InitializeComponent();
        }

        private void GenerateBombs()
        {
            Random rnd = new Random();
            for (int i = 0; i < b; i++)
            {
                int aux = rnd.Next(0, ((hw * hw) + 1));
                foreach (int bomber in bombers)
                {
                    if (aux == bomber)
                    {
                        i--;
                    }
                }
                bombers.Add(aux);
            }
        }

        private void GeneratePanel()
        {
            this.panel.Controls.Clear();
            int x = 20;
            int y = 20;
            int index = 0;
            for (int i = 0; i < hw; i++)
            {

                for (int z = 0; z < hw; z++)
                {
                    Label cel = new Label();
                    cel.AutoSize = false;
                    cel.BackColor = Color.LightGray;
                    cel.Cursor = Cursors.Hand;
                    cel.TextAlign = ContentAlignment.MiddleCenter;
                    cel.BorderStyle = BorderStyle.FixedSingle;
                    cel.Margin = new Padding(0);
                    cel.Name = index.ToString();
                    cel.Location = new Point(x, y);
                    cel.Size = new Size(20,20);
                    this.panel.Controls.Add(cel);
                    x += 20;
                    index++;
                }
                y += 20;
                x = 20;
            }
        }

        private void ApllyBombs()
        {
            for (int i = 0; i < this.panel.Controls.Count; i++)
            {
                foreach (int bomber in bombers)
                {
                    if (i == bomber)
                    {
                        this.panel.Controls[i].Tag = "b";
                    }
                }
                if (this.panel.Controls[i].Tag is null)
                { 
                    this.panel.Controls[i].Click += NormalCel;
                }
                else
                {
                    this.panel.Controls[i].Click += BombCel;
                }
            }
        }

        private void PrintNumBombs(int index)
        {
            
            int x = 0;
            int flag = 0;

            x = (index - hw) - 1;

            if (x >= 0)
            {
                if (!(this.panel.Controls[x].Tag is null))
                {
                    flag++;
                }
                else
                {
                    this.panel.Controls[x].BackColor = Color.White;
                    
                }
            }
            

            if (x >= 0)
            {
                if (!(this.panel.Controls[x].Tag is null))
                {
                    flag++;
                }
                else
                {
                    this.panel.Controls[x].BackColor = Color.White;
                   
                }
            }

            x = index - hw;

            if (x >= 0)
            {
                if (!(this.panel.Controls[x].Tag is null))
                {
                    flag++;
                }
                else
                {
                    this.panel.Controls[x].BackColor = Color.White;
                   
                }
            }

            x = (index - hw) + 1;

            if (x >= 0)
            {
                if (!(this.panel.Controls[x].Tag is null))
                {
                    flag++;
                }
                else
                {
                    this.panel.Controls[x].BackColor = Color.White;
                   
                }
            }

            x = index - 1;

            if (x >= 0 && x/hw != 0)
            {
                if (!(this.panel.Controls[x].Tag is null))
                {
                    flag++;
                }
                else
                {
                    this.panel.Controls[x].BackColor = Color.White;
                   
                }
            }

            x = index + 1;

            if (x >= 0 && x < (hw * hw))
            {
                if (!(this.panel.Controls[x].Tag is null))
                {
                    flag++;
                }
                else
                {
                    this.panel.Controls[x].BackColor = Color.White;
                    
                }
            }

            x = (index + hw) - 1;

            if (x < (hw * hw) && x/hw != 0)
            {
                if (!(this.panel.Controls[x].Tag is null))
                {
                    flag++;
                }
                else
                {
                    this.panel.Controls[x].BackColor = Color.White;
                   
                }
            }

            x = (index + hw) + 1;

            if (x < (hw*hw))
            {
                if (!(this.panel.Controls[x].Tag is null))
                {
                    flag++;
                }
                else
                {
                    this.panel.Controls[x].BackColor = Color.White;
                   
                }
            }

            x = index + hw;

            if (x < (hw * hw))
            {
                if (!(this.panel.Controls[x].Tag is null))
                {
                    flag++;
                }
                else
                {
                    this.panel.Controls[x].BackColor = Color.White;
                 
                }
            }

            if (flag > 0 )
            {
                this.panel.Controls[index].Text = flag.ToString();
            }

        }



        private void NormalCel(Object sender,EventArgs e)
        {
            for (int i = 0; i < this.panel.Controls.Count; i++)
            {
                if (this.panel.Controls[i].Name == ((Label)sender).Name)
                {
                    PrintNumBombs(i);
                }
            }

            ((Label)sender).BackColor = Color.White;
        }

        private void ShowAllBombs()
        {
            foreach (Label item in this.panel.Controls)
            {
                if (!(item.Tag is null))
                {
                    item.BackColor = Color.Red;
                }
                else
                {
                    item.BackColor = Color.White;
                }
            }
        }

        private void BombCel(Object sender, EventArgs e)
        {
            ShowAllBombs();
            MessageBox.Show("Fin del Juego", "FIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            BuscaMinasSize s = new BuscaMinasSize();
            s.ShowDialog();
            hw = s.hw;
            b = s.b;
            bombers.Clear();
            GenerateBombs();
            GeneratePanel();
            ApllyBombs();
        }
    }
}
