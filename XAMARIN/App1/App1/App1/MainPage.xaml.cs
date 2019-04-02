using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        int i = 0;
        public MainPage()
        {
            InitializeComponent();
            this.btn1.Clicked += Btn1_Clicked;
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            i++;
            if(i >= 0 && i <= 30)
            {
                this.lb1.FontSize = 15;
                this.lb1.Text = "Hola Has pulsado " + i + " veces el botón.";
            }else if (i >= 31 && i<=80)
            {
                this.lb1.TextColor = Color.Yellow;
                this.lb1.FontSize = 25;
                this.lb1.Text = "Hola Has pulsado " + i + " veces el botón.";
            }else if (i >= 81 && i<=150)
            {
                this.lb1.TextColor = Color.Orange;
                this.lb1.FontSize = 35;
                this.lb1.Text = "Hola Has pulsado " + i + " veces el botón.";
            }
            else if (i >= 151)
            {
                this.lb1.TextColor = Color.Red;
                this.lb1.FontSize = 45;
                this.lb1.Text = "Hola Has pulsado " + i + " veces el botón.";
            }

        }
    }
}
