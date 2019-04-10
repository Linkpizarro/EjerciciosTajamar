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
	public partial class OtrosControles : ContentPage
	{
        bool isActiveWindow;
		public OtrosControles ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            isActiveWindow = true;
            Device.StartTimer(TimeSpan.FromSeconds(0.1), TimerCallBack);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            isActiveWindow = false;    
        }

        bool TimerCallBack()
        {
            this.timerbar.Progress += 0.01;
            return isActiveWindow || this.timerbar.Progress == 1;
         }       
    }
}