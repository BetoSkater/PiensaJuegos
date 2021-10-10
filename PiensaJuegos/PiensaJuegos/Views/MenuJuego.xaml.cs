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
    public partial class MenuJuego : ContentPage
    {
        //Array dificultad:

        String[] opcionesDificultad = new String[3] { "Principiante", "General", "Experto" };

        public MenuJuego()
        {
            InitializeComponent();

            this.btnIniciarPasoVocablo.Clicked += IniciarPasoVocablo;

        }//Fin Constructor




        void lblDificultad_PropertyChanged(System.Object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {

            //double opcion = double.Parse(lblDificultad.Text); Esto da error, no se puede hacer así
            int opcionInt = Convert.ToInt32(Math.Round(selectorDificultad.Value));
            lblDificultad.Text = opcionesDificultad[opcionInt];
            //double dato = double.Parse("1.98777");
        }

        //Método para ir al juego:

        public async void IniciarPasoVocablo(Object sender, EventArgs e)
        {
            String dificultad = lblDificultad.Text;

            await Navigation.PushAsync(new JuegoPasoVocablo(dificultad));


        }


    }
}