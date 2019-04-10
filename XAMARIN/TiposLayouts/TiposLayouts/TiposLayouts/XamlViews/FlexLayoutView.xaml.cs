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
	public partial class FlexLayoutView : ContentPage
	{
		public FlexLayoutView ()
		{
			InitializeComponent ();
		}
	}
}