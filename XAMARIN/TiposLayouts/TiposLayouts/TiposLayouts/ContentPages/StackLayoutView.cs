using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TiposLayouts.ContentPages
{
	public class StackLayoutView : ContentPage
	{
		public StackLayoutView ()
		{

            StackLayout stackprincipal = new StackLayout();
            stackprincipal.Margin = new Thickness(0, 40, 0, 0);
            Label header = new Label()
            {
                FontSize = 40,
                TextColor = Color.Black,
                HorizontalOptions=LayoutOptions.CenterAndExpand,
                Text = "Hola soy un texto..."
            };
            stackprincipal.Children.Add(header);
            Button btn = new Button()
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                WidthRequest = 200,
                BorderWidth = 2,
                BorderColor = Color.Red,
                Text="soy un boton"  
            };
            stackprincipal.Children.Add(btn);
            this.Content = stackprincipal;
		}
	}
}