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
            this.btnAcierto.Clicked += SuenaAcierto;
            this.btnFallo.Clicked += SuenaFallo;

        }


        //Metodos botónes:

        public async void botonPasoVocablo(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.MenuJuego());

        }


        //Métodos para probar los sonidos:

        public void SuenaAcierto(Object sender, EventArgs e)
        {
            var melodiaAcierto = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            melodiaAcierto.Load("sonidoacierto.mp3");
            melodiaAcierto.Play();
        }//Fin método SuenaAcierto

        public void SuenaFallo(Object sender, EventArgs e)
        {
            var melodiaFallo = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            melodiaFallo.Load("sonidofallo.mp3");
            melodiaFallo.Play();
        }//Fin método SuenaFallo
    }
}