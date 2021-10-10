using PiensaJuegos.Models;
using PiensaJuegos.Repositories;
using PiensaJuegos.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.ViewModels
{
    class LetraYModel : ViewModelBase
    {

        RepositoryY repoY;

        public LetraYModel()
        {

            this.repoY = new RepositoryY();
            this.letraY = new LetraY();
        }//Fin


        //Propiedad para realizar los bindings sobre las vistas:
        private LetraY _letraY;

        public LetraY letraY
        {
            get { return this._letraY; }
            set
            {
                this._letraY = value;
                OnPropertyChanged("letraY");
            }
        }


        //Método para insertar datos:

        public void InsertarPreguntaYDB(LetraY auxLetraY)
        {
            this.repoY.InsertarPreguntaY(auxLetraY);

        }


    }
}
