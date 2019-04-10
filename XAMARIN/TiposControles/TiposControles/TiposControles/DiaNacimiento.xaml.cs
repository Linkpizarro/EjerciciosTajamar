using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiposControles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DiaNacimiento : ContentPage
	{
		public DiaNacimiento ()
		{
			InitializeComponent ();
            Days();
            Months();
            Years();
            this.btn.Clicked += Button_Clicked;
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Calc(
                int.Parse(this.day.SelectedItem.ToString()),
                int.Parse(this.month.SelectedItem.ToString()),
                int.Parse(this.year.SelectedItem.ToString())
                );
        }

        void Days()
        {
            for (int i = 1; i < 32; i++)
            {
                this.day.Items.Add(i.ToString());
            }
        }
        void Months()
        {
            for (int i = 1; i < 13; i++)
            {
                this.month.Items.Add(i.ToString());
            }
        }
        void Years()
        {
            for (int i = 1900; i < 2020; i++)
            {
                this.year.Items.Add(i.ToString());
            }
        }
        String DayWeek(int x)
        {
            switch (x)
            {
                case 0:
                    return "Sabado";   
                case 1:
                    return "Domingo";
                case 2:
                    return "Lunes";
                case 3:
                    return "Martes";
                case 4:
                    return "Miercoles";
                case 5:
                    return "Jueves";  
                case 6:
                    return "Viernes";
            }
            return null;
        }
        void Calc(int day,int month,int year)
        {
            if (month == 1)
            {
                month = 13;
                year = year - 1;
            }
            else if (month == 2)
            {
                month = 14;
                year = year - 1;
            }
            int op1 = ((month + 1) * 3) / 5;
            int op2 = year / 4;
            int op3 = year / 100;
            int op4 = year / 400;
            int op5 = day + (month * 2) + year + op1 + op2 - op3 + op4 + 2;
            int op6 = op5 / 7;
            int op7 = op5 - (op6 * 7);
            this.result.Text = "Tu nacimiento fue un " + DayWeek(op7);
        }
    }
}