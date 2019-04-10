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
	public partial class PickerListBox : ContentPage
	{
		public PickerListBox ()
		{
			InitializeComponent ();
            this.list.Items.Add("Tu madre");
            this.list.Items.Add("Esta");
            this.list.Items.Add("En");
            this.list.Items.Add("El");
            this.list.Items.Add("Sotano");
        }
	}
}