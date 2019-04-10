using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using TiposLayouts.XamlViews;
namespace TiposLayouts
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.btnstack.Clicked += async (Sender, args) =>
              await Navigation.PushAsync(new ContentPages.StackLayoutView());
            this.btnframe.Clicked += async (Sender, args) =>
             await Navigation.PushAsync(new FrameView());
            this.btnscroll.Clicked += async (Sender, args) =>
             await Navigation.PushAsync(new ScrollLayoutView());
            this.btnflex.Clicked += async (Sender, args) =>
             await Navigation.PushAsync(new FlexLayoutView());
            this.btnabsolute.Clicked += async (Sender, args) =>
            await Navigation.PushAsync(new AbsoluteLayoutView());
            this.btncollatz.Clicked += async (Sender, args) =>
             await Navigation.PushAsync(new Collatz());
            this.btncollatzbtn.Clicked += async (Sender, args) =>
                await Navigation.PushAsync(new CollatzButtons());
        }
    }
}
