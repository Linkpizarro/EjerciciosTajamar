using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TiposAlert
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.btnsimple.Clicked += async (sender, args) =>
            {
                await DisplayAlert("Soy un Título Simple","Soy un mensaje Simple","cancelar");
            };
            this.btncancel.Clicked += ButtonOkCancel_Clicked;
            this.btnoptions.Clicked += ButtonOptions_Clicked;
            this.btnmodal.Clicked += async (sender, args) =>
            {
                RegularModalView modal = new RegularModalView();
                await Navigation.PushModalAsync(modal);
            };
        }


        private async void ButtonOptions_Clicked(object sender, EventArgs e)
        {
            String request = await DisplayActionSheet("Título Opciones","Cancelar",null,"Opción 1","Opción 2","Opción 3");
            this.result.Text = request;
        }

        private async void ButtonOkCancel_Clicked(object sender, EventArgs e)
        {
            bool request = await DisplayAlert("Título", "¿Tienes un poco de ASP.GER?", "Si", "No");
            if(request == true)
            {
                this.result.Text = "Has pulsado Si. Muchas gracias";
            }
            else
            {
                this.result.Text = "¿Cómo que No?";
            }
        }
    }
}
