using PiensaJuegos.Models;
using PiensaJuegos.Repositories;
using PiensaJuegos.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.ViewModels
{
    public class LetraNieModel : ViewModelBase
    {

        RepositoryNie repoNie;

        public LetraNieModel()
        {


            this.repoNie = new RepositoryNie();
            this.letraNie = new LetraNie();
        }//Fin


        //Propiedad para realizar los bindings sobre las vistas:
        private LetraNie _letraNie;

        public LetraNie letraNie
        {
            get { return this._letraNie; }
            set
            {
                this._letraNie = value;
                OnPropertyChanged("letraNie");
            }
        }


        //Método para insertar datos:

        public void InsertarPreguntaNieDB(LetraNie auxLetraNie)
        {
            this.repoNie.InsertarPreguntaNie(auxLetraNie);

        }


    }
}
