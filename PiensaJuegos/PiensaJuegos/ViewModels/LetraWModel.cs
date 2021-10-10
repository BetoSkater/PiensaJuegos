using PiensaJuegos.Models;
using PiensaJuegos.Repositories;
using PiensaJuegos.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.ViewModels
{
    public class LetraWModel : ViewModelBase
    {

        RepositoryW repoW;

        public LetraWModel()
        {

            this.repoW = new RepositoryW();
            this.letraW = new LetraW();
        }//Fin


        //Propiedad para realizar los bindings sobre las vistas:
        private LetraW _letraW;

        public LetraW letraW
        {
            get { return this._letraW; }
            set
            {
                this._letraW = value;
                OnPropertyChanged("letraW");
            }
        }


        //Método para insertar datos:

        public void InsertarPreguntaWDB(LetraW auxLetraW)
        {
            this.repoW.InsertarPreguntaW(auxLetraW);

        }


    }
}
