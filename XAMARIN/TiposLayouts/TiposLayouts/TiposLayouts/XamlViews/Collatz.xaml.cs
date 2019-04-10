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
	public partial class Collatz : ContentPage
	{
		public Collatz ()
		{
			InitializeComponent ();
            this.btnshow.Clicked += Button_Clicked;
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.result.Children.Clear();
            int num = int.Parse(this.num.Text);
            while(num != 1)
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