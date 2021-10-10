using PiensaJuegos.Models;
using PiensaJuegos.Repositories;
using PiensaJuegos.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.ViewModels
{
    public class LetraMModel : ViewModelBase
    {

        RepositoryM repoM;

        public LetraMModel()
        {

            this.repoM = new RepositoryM();
            this.letraM = new LetraM();
        }//Fin


        //Propiedad para realizar los bindings sobre las vistas:
        private LetraM _letraM;

        public LetraM letraM
        {
            get { return this._letraM; }
            set
            {
                this._letraM = value;
                OnPropertyChanged("letraM");
            }
        }


        //Método para insertar datos:

        public void InsertarPreguntaMDB(LetraM auxLetraM)
        {
            this.repoM.InsertarPreguntaM(auxLetraM);

        }



    }
}
