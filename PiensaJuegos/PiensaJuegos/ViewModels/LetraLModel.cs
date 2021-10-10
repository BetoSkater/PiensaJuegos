using PiensaJuegos.Models;
using PiensaJuegos.Repositories;
using PiensaJuegos.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.ViewModels
{
    class LetraLModel : ViewModelBase
    {
        RepositoryL repoL;

        public LetraLModel()
        {

            this.repoL = new RepositoryL();
            this.letraL = new LetraL();
        }//Fin


        //Propiedad para realizar los bindings sobre las vistas:
        private LetraL _letraL;

        public LetraL letraL
        {
            get { return this._letraL; }
            set
            {
                this._letraL = value;
                OnPropertyChanged("letraL");
            }
        }


        //Método para insertar datos:

        public void InsertarPreguntaLDB(LetraL auxLetraL)
        {
            this.repoL.InsertarPreguntaL(auxLetraL);

        }

    }
}
