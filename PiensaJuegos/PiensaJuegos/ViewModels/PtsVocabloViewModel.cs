using PiensaJuegos.Models;
using PiensaJuegos.Repositories;
using PiensaJuegos.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PiensaJuegos.ViewModels
{
    class PtsVocabloViewModel : ViewModelBase
    {

        RepositorPuntosPasaVocablo repoPuntos;

        public PtsVocabloViewModel()
        {
            this.repoPuntos = new RepositorPuntosPasaVocablo();
            List<PuntosPasaVocablo> lista = this.repoPuntos.GetPuntuaciones();
            this.puntuaciones = new ObservableCollection<PuntosPasaVocablo>(lista);

        }//Fin


        //Propiedad para realizar los bindings sobre las vistas:
        private ObservableCollection<PuntosPasaVocablo> _puntuaciones;

        public ObservableCollection<PuntosPasaVocablo> puntuaciones
        {
            get { return this._puntuaciones; }
            set
            {
                this._puntuaciones = value;
                OnPropertyChanged("puntuaciones");
            }
        }


        //Método para insertar datos:

        public void InsertarPuntuacionDB(PuntosPasaVocablo auxPuntos)
        {
            this.repoPuntos.InsertarPuntuacion(auxPuntos);

        }

    }
}
