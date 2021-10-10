using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PiensaJuegos.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VentanaSeleccion : ContentPage
    {
        public VentanaSeleccion()
        {
            InitializeComponent();
            this.btnIrPasaVocablo.Clicked += botonPasoVocablo;


        }


        //Metodos botónes:

        public async void botonPasoVocablo(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.MenuJuego());

        }
    }
}