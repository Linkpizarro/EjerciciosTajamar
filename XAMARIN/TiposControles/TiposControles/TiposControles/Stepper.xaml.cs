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
	public partial class Stepper : ContentPage
	{
		public Stepper ()
		{
			InitializeComponent ();
            this.lb.Text= "Stepper: " + this.stepper.Value;
            this.stepper.ValueChanged += Stepper_ValueChange;
		}

        private void Stepper_ValueChange(object sender, ValueChangedEventArgs e)
        {
            this.lb.Text = "Stepper: " + e.NewValue; 
        }
    }
}