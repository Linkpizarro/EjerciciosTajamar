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
    public partial class Colecciones : Form
    {
        
        public Colecciones()
        {
            InitializeComponent();
        }

        private void element_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            this.myList.Items.Add(this.element.Text);
            this.element.Text = "";
        }

        private void remove_Click(object sender, EventArgs e)
        {
            this.myList.Items.Remove(this.element.Text);
            this.element.Text = "";
        }

        private void removeAll_Click(object sender, EventArgs e)
        {
            this.myList.Items.Clear();
        }

        private void myList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void removeSelect_Click(object sender, EventArgs e)
        {
            for (int i = this.myList.SelectedIndices.Count - 1; i >= 0 ; i --)
            { 
                this.myList.Items.RemoveAt(this.myList.SelectedIndices[i]);
            }
        }

        private void numList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void total_TextChanged(object sender, EventArgs e)
        {

        }

        private void evens_TextChanged(object sender, EventArgs e)
        {

        }

        private void odds_TextChanged(object sender, EventArgs e)
        {

        }

        private void generate_Click(object sender, EventArgs e)
        {
            this.numList.Items.Clear();
            Random rnd = new Random();
            for (int i = 0; i < 9; i++)
            {
                this.numList.Items.Add(rnd.Next(1, 50));
            }
        }

        private void operate_Click(object sender, EventArgs e)
        {
            int total = 0;
            int odd = 0;
            int even = 0;
            for (int i = 0; i < this.numList.Items.Count; i++)
            {
                total = total + int.Parse(this.numList.Items[i].ToString());
                if (int.Parse(this.numList.Items[i].ToString())%2 == 0)
                {
                    even = even + int.Parse(this.numList.Items[i].ToString());
                }
                else
                {
                    odd = odd + int.Parse(this.numList.Items[i].ToString());
                }
            }

            this.total.Text = total.ToString();
            this.odds.Text = odd.ToString();
            this.evens.Text = even.ToString();
        }
    }
}
