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

    public partial class Calculadora : Form
    {
        public double num1 = 0;
        public double num2 = 0;
        public String sign;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void zero_Click(object sender, EventArgs e)
        {
            consoleBox.Text += "0";
        }

        private void one_Click(object sender, EventArgs e)
        {
            consoleBox.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            consoleBox.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            consoleBox.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            consoleBox.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            consoleBox.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            consoleBox.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            consoleBox.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            consoleBox.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            consoleBox.Text += "9";
        }

        private void sumSing_Click(object sender, EventArgs e)
        {
            if (consoleBox.Text != "")
            {
                num1 = double.Parse(consoleBox.Text);
                consoleBox.Text = "";
                sign = "+";  
            }
        }

        private void resSign_Click(object sender, EventArgs e)
        {
            if (consoleBox.Text != "")
            {
                num1 = double.Parse(consoleBox.Text);
                consoleBox.Text = "";
                sign = "-";
            }
        }

        private void multSign_Click(object sender, EventArgs e)
        {
            if (consoleBox.Text != "")
            {
                num1 = double.Parse(consoleBox.Text);
                consoleBox.Text = "";
                sign = "*";
            }
        }

        private void divSign_Click(object sender, EventArgs e)
        {
            if (consoleBox.Text != "")
            {
                num1 = double.Parse(consoleBox.Text);
                consoleBox.Text = "";
                sign = "/";
            }

        }

        private void calc_Click(object sender, EventArgs e)
        {
            if (consoleBox.Text != "")
            {
                num2 = double.Parse(consoleBox.Text);
                switch (sign)
                {
                    case "+": consoleBox.Text = (num1 + num2).ToString(); break;
                    case "-": consoleBox.Text = (num1 - num2).ToString(); break;
                    case "*": consoleBox.Text = (num1 * num2).ToString(); break;
                    case "/": consoleBox.Text = (num1 / num2).ToString(); break;
                }
            }
           
        }

        private void consoleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void del_Click(object sender, EventArgs e)
        {
            consoleBox.Text = "";
            sign = "";
        }

        private void del1_Click(object sender, EventArgs e)
        {
            int num = consoleBox.Text.Length;
            if (num == 0)
            {
            }
            else if (num == 1)
            {
                consoleBox.Text = "";
            }
            else
            {
                consoleBox.Text = consoleBox.Text.Substring(0, (num - 1));
            }
        }
    }
}
