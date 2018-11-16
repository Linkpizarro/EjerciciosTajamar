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
    public partial class TablaMultiplicar : Form
    {
        List<Label> boxes = new List<Label>();
        List<Label> labels = new List<Label>();

        public TablaMultiplicar()
        {
            InitializeComponent();
        }

        private void num_TextChanged(object sender, EventArgs e)
        {

        }

        private void TablaMultiplicar_Load(object sender, EventArgs e)
        {
            foreach (Label box in this.groupBox.Controls)
            {
               boxes.Add(box);
            }
            boxes.Reverse();

            foreach (Label box in this.results.Controls)
            {
               labels.Add(box); 
            }
            labels.Reverse();
            Random rnd = new Random();
            for (int x = 0; x < this.buttonsList.Controls.Count; x++)
            {
                this.buttonsList.Controls[x].Text = (rnd.Next(1,100)).ToString();
                this.buttonsList.Controls[x].Click += Calcular;

            }
        }

        private void Calcular(object sender, EventArgs e)
        {
            for (int i = 0; i < labels.Count; i++)
            {
                int op = int.Parse(((Button)sender).Text) * (i + 1);
                labels[i].Text = op.ToString();
            }
        }

        private void num_KeyPress(object sender, KeyPressEventArgs e)
        {       
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    if (this.num.Text.Length > 0 && this.num.Text.Length <= 5)
                    {
                        for (int i = 0; i < boxes.Count; i++)
                        {                          
                            int op = int.Parse(this.num.Text) * (i + 1);
                            boxes[i].Text = op.ToString();
                        }
                    }
                    else
                    {
                        for (int i = 0; i < boxes.Count; i++)
                        {
                            boxes[i].Text = "";
                        }
                    }
                }
            }
            else
            {
                e.Handled = true;
            } 
           
        }

        private void calculator_Click(object sender, EventArgs e)
        {
            Calculadora c = new Calculadora();
            c.ShowDialog();
        }
    }
}
