using PiensaJuegos.Models;
using PiensaJuegos.Repositories;
using PiensaJuegos.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.ViewModels
{
    class LetraSModel : ViewModelBase
    {

        RepositoryS repoS;

        public LetraSModel()
        {

            this.repoS = new RepositoryS();
            this.letraS = new LetraS();
        }//Fin


        //Propiedad para realizar los bindings sobre las vistas:
        private LetraS _letraS;

        public LetraS letraS
        {
            get { return this._letraS; }
            set
            {
                this._letraS = value;
                OnPropertyChanged("letraS");
            }
        }


        //Método para insertar datos:

        public void InsertarPreguntaSDB(LetraS auxLetraS)
        {
            this.repoS.InsertarPreguntaS(auxLetraS);

        }


    }
}
