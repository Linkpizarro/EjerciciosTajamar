using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiposAlert
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegularModalView : ContentPage
	{
		public RegularModalView ()
		{
			InitializeComponent ();  
            this.btnclose.Clicked += async (sender, args) =>
            {     
                await Navigation.PopModalAsync();
            };
		}
	}
}