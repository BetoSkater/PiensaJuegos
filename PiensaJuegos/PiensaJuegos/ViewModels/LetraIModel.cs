using PiensaJuegos.Models;
using PiensaJuegos.Repositories;
using PiensaJuegos.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.ViewModels
{
    public class LetraIModel : ViewModelBase
    {
        RepositoryI repoI;

        public LetraIModel()
        {


            this.repoI = new RepositoryI();
            this.letraI = new LetraI();
        }//Fin


        //Propiedad para realizar los bindings sobre las vistas:
        private LetraI _letraI;

        public LetraI letraI
        {
            get { return this._letraI; }
            set
            {
                this._letraI = value;
                OnPropertyChanged("letraI");
            }
        }


        //Método para insertar datos:

        public void InsertarPreguntaIDB(LetraI auxLetraI)
        {
            this.repoI.InsertarPreguntaI(auxLetraI);

        }


    }
}
