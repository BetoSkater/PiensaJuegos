using PiensaJuegos.Models;
using PiensaJuegos.Repositories;
using PiensaJuegos.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.ViewModels
{
    class LetraKModel : ViewModelBase
    {
        RepositoryK repoK;

        public LetraKModel()
        {


            this.repoK = new RepositoryK();
            this.letraK = new LetraK();
        }//Fin


        //Propiedad para realizar los bindings sobre las vistas:
        private LetraK _letraK;

        public LetraK letraK
        {
            get { return this._letraK; }
            set
            {
                this._letraK = value;
                OnPropertyChanged("letraK");
            }
        }


        //Método para insertar datos:

        public void InsertarPreguntaKDB(LetraK auxLetraK)
        {
            this.repoK.InsertarPreguntaK(auxLetraK);

        }


    }
}
