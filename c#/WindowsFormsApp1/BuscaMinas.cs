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
    public partial class BuscaMinas : Form
    {

        public BuscaMinas()
        {
            InitializeComponent();
        }

        private void GeneratePanel(int hw)
        {
            Random rnd = new Random();
            List<int> bombers = new List<int>();
  
            int x = 40;
            int y = 40;
            for (int i = 0; i < hw; i++)
            {

                for (int z = 0; z < hw; z++)
                {
                    Label cel = new Label();
                    cel.AutoSize = false;
                    cel.BackColor = Color.White;
                    cel.Cursor = Cursors.Hand;
                    cel.TextAlign = ContentAlignment.MiddleCenter;
                    cel.BorderStyle = BorderStyle.FixedSingle;
                    cel.Margin = new Padding(0);
                    cel.Location = new Point(x, y);
                    cel.Size = new Size(40,40);
                    this.panel.Controls.Add(cel);
                    x += 40;
                }
                y += 40;
                x = 40;
            }

        }

        private void PutBombs() {
          
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            BuscaMinasSize s = new BuscaMinasSize();
            s.ShowDialog();
            if (s.hw > 0){
                GeneratePanel(s.hw);
            }

        }
    }
}
