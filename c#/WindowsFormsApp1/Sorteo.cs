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
    public partial class Sorteo : Form
    {
        int ocur = 0;
        int n = 0;
        int m = 0;
        public Sorteo()
        {
            InitializeComponent();
        }

        private void Sorteo_Load(object sender, EventArgs e)
        {
            
        }

        private void GenerateNumbers()
        {
            this.create.Enabled = false;
            for (int i = 0; i < n; i++)
            {
                Label num = new Label();
                num.Text = (i + 1).ToString();
                num.Click += CheckNumber;
                num.AutoSize = false;
                num.BackColor = Color.White;
                num.Cursor = Cursors.Hand;
                num.TextAlign = ContentAlignment.MiddleCenter;
                num.Size = new Size(40, 40);
                num.Margin = new Padding(10, 10, 10, 10);
                this.boleto.Controls.Add(num);
            }
        }

        private void CheckNumber(Object sender , EventArgs e)
        {
            foreach (Label item in this.boleto.Controls)
            {
                if (item.BackColor == Color.Yellow)
                {
                    ocur++;
                }
            }
            if (((Label)sender).BackColor == Color.White && ocur < m)
            {
                ((Label)sender).BackColor = Color.Yellow;
            }
            else
            {
                ((Label)sender).BackColor = Color.White;
            }
            ocur = 0;
        }

        private void Play()
        {
            this.create.Enabled = true;
            this.btnStart.Enabled = false;
            Random rnd = new Random();
            List<int> numbers = new List<int>();
            int flag = 0;
            for (int i = 0; i < m; i++)
            {
                int numrnd = rnd.Next(1, n+1);
                for (int x = 0; x < numbers.Count; x++)
                {
                    if (numrnd == numbers[x])
                    {
                        flag++;
                    }
                }
                if(flag == 1)
                {
                    i--;
                    flag = 0;
                }
                else
                {
                    numbers.Add(numrnd);
                }
            }
            PrintResult(numbers);
            CompareNumbers(numbers);
        }

        private void CompareNumbers(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                foreach (Label num in this.boleto.Controls)
                {
                    if (num.BackColor == Color.Yellow && num.Text == list[i].ToString())
                    {
                        num.BackColor = Color.Green;
                        this.winners.SetSelected(i, true);
                    }
                    else if (num.BackColor == Color.White && num.Text == list[i].ToString())
                    {
                        num.BackColor = Color.Red;
                    }
                    num.Click -= CheckNumber;
                }
            }
            
              
            
        }

        private void PrintResult(List<int> list)
        {
            foreach (int item in list)
            {
                this.winners.Items.Add(item);
            }
        }

        private void Reset()
        {
            ocur = 0;
            this.winners.Items.Clear();
            this.create.Enabled = false;
            this.btnStart.Enabled = true;
            this.boleto.Controls.Clear();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Play();
        }

        private void create_Click(object sender, EventArgs e)
        {
            SorteoIniciar s = new SorteoIniciar();
            s.ShowDialog();
            if (!(s.nWins is null) && !(s.nLabels is null))
            {
                n = int.Parse(s.nLabels);
                m = int.Parse(s.nWins);
                Reset();
                GenerateNumbers();
            }
        }
    }
}
