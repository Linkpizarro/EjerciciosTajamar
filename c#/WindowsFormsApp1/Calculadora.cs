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
            foreach (Button btn in this.keyBoard.Controls)
            {
                int auxNum;
                if (int.TryParse(btn.Text,out auxNum) || btn.Text == ",")
                {
                    btn.Click += PrintNumber;
                }
                else{
                    if (btn.Text == "+" || btn.Text == "-" || btn.Text == "/" || btn.Text == "*")
                    {
                        btn.Click += Operate;
                    }
                }
            }
        }

        private void PrintNumber(Object sender,EventArgs e)
        {
            consoleBox.Text += ((Button)sender).Text;
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
                num1 = 0;
                num2 = 0;
            }
           
        }

        private void Operate(Object sender , EventArgs e)
        {
            if (consoleBox.Text != "")
            {
                if (num1 != 0)
                {
                    this.calc.PerformClick();
                }
                else
                {
                    num1 = double.Parse(consoleBox.Text);
                    consoleBox.Text = "";
                    sign = ((Button)sender).Text;
                }
            }
            else
            {
                sign = ((Button)sender).Text;
            }
        }

        private void consoleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void del_Click(object sender, EventArgs e)
        {
            consoleBox.Text = "";
            sign = "";
            num1 = 0;
            num2 = 0;
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
