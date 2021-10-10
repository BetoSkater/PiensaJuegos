using PiensaJuegos.Models;
using PiensaJuegos.Repositories;
using PiensaJuegos.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.ViewModels
{
    class LetraUModel : ViewModelBase
    {

        RepositoryU repoU;

        public LetraUModel()
        {

            this.repoU = new RepositoryU();
            this.letraU = new LetraU();
        }//Fin


        //Propiedad para realizar los bindings sobre las vistas:
        private LetraU _letraU;

        public LetraU letraU
        {
            get { return this._letraU; }
            set
            {
                this._letraU = value;
                OnPropertyChanged("letraU");
            }
        }


        //Método para insertar datos:

        public void InsertarPreguntaUDB(LetraU auxLetraU)
        {
            this.repoU.InsertarPreguntaU(auxLetraU);

        }


    }
}
