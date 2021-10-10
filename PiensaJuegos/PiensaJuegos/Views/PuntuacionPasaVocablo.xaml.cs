using PiensaJuegos.Models;
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
    public partial class PuntuacionPasaVocablo : ContentPage
    {
        public PuntuacionPasaVocablo()
        {
            InitializeComponent();

            //List<PuntosPasaVocablo> listaObtenida = GenerarPuntuacionesPrueba();
            //this.lstTopPuntusciones.ItemsSource = listaObtenida;
            //this.lstTopPuntusciones.BindingContext = listaObtenida;


        }

        //Método de prueba que contiene el listado de las 10 puntuaciones mas altas:

        public List<PuntosPasaVocablo> GenerarPuntuacionesPrueba()
        {

            List<PuntosPasaVocablo> listaPuntuaciones = new List<PuntosPasaVocablo>();


            listaPuntuaciones.Add(new PuntosPasaVocablo(1, 9876, "Ana", "Experto", 27, 269));
            listaPuntuaciones.Add(new PuntosPasaVocablo(2, 8765, "Juan", "Experto", 27, 269));
            listaPuntuaciones.Add(new PuntosPasaVocablo(3, 7986, "Paco", "Experto", 27, 269));
            listaPuntuaciones.Add(new PuntosPasaVocablo(4, 6776, "Elena", "Experto", 27, 269));
            listaPuntuaciones.Add(new PuntosPasaVocablo(5, 5976, "Pedro", "Experto", 27, 269));
            listaPuntuaciones.Add(new PuntosPasaVocablo(6, 4776, "Petronila", "Experto", 27, 269));
            listaPuntuaciones.Add(new PuntosPasaVocablo(7, 4676, "Carlos", "Experto", 27, 269));
            listaPuntuaciones.Add(new PuntosPasaVocablo(8, 3576, "Judith", "Experto", 27, 269));
            listaPuntuaciones.Add(new PuntosPasaVocablo(9, 2976, "Sara", "Experto", 27, 269));
            listaPuntuaciones.Add(new PuntosPasaVocablo(10, 1276, "Cristian", "Experto", 27, 269));

            return listaPuntuaciones;
        }

    }
}