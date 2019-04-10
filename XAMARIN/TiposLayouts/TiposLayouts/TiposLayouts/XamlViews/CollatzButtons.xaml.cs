using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiposLayouts.XamlViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CollatzButtons : ContentPage
	{
		public CollatzButtons ()
		{
			InitializeComponent ();
            this.btnstart.Clicked += Start_Clicked;
		}

        private void Start_Clicked(object sender, EventArgs e)
        {
            this.result.Children.Clear();
            this.buttons.Children.Clear();
            Random rnd = new Random();           
            for (int i = 0; i < 10; i++)
            {
                int num = rnd.Next(1, 100);
                Button btn = new Button()
                {
                    Text = num.ToString(),
                    FontSize = 18,
                    BackgroundColor = Color.Black,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    WidthRequest = 80,
                    TextColor = Color.White,
                    HeightRequest = 80,
                    Margin = new Thickness(0,0,40,0)
                };
                btn.Clicked += Number_Clicker;
                this.buttons.Children.Add(btn);
            }
            
        }

        private void Number_Clicker(object sender, EventArgs e)
        {
            this.result.Children.Clear();
            int num = int.Parse(((Button)sender).Text);
            while (num != 1)
            {
                Label lb = new Label()
                {
                    Text = num.ToString(),
                    FontSize = 40,
                    TextColor = Color.Black
                };
                this.result.Children.Add(lb);
                if (num % 2 == 0)
                {
                    num = num / 2;
                }
                else
                {
                    num = (num * 3) + 1;
                }
            }
            Label lbone = new Label()
            {
                Text = "1",
                FontSize = 40,
                TextColor = Color.Black
            };
            this.result.Children.Add(lbone);
        }
    }
}