using PiensaJuegos.Models;
using PiensaJuegos.Repositories;
using PiensaJuegos.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.ViewModels
{
    class LetraBModel : ViewModelBase
    {
        RepositoryB repoB;

        public LetraBModel()
        {

            this.repoB = new RepositoryB();
            this.letraB = new LetraB();
        }

        //Propiedad para realizar los bindings sobre las vistas:
        private LetraB _letraB;

        public LetraB letraB
        {
            get { return this._letraB; }
            set
            {
                this._letraB = value;
                OnPropertyChanged("letraB");
            }
        }


        //Método para insertar datos:

        public void InsertarPreguntaBDB(LetraB auxLetraB)
        {
            this.repoB.InsertarPreguntaB(auxLetraB);

        }

    }
}
