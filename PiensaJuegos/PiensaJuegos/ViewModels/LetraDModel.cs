using PiensaJuegos.Models;
using PiensaJuegos.Repositories;
using PiensaJuegos.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.ViewModels
{
    class LetraDModel : ViewModelBase
    {
        RepositoryD repoD;

        public LetraDModel()
        {

            this.repoD = new RepositoryD();
            this.letraD = new LetraD();
        }

        //Propiedad para realizar los bindings sobre las vistas:
        private LetraD _letraD;

        public LetraD letraD
        {
            get { return this._letraD; }
            set
            {
                this._letraD = value;
                OnPropertyChanged("letraD");
            }
        }


        //Método para insertar datos:

        public void InsertarPreguntaDDB(LetraD auxLetraD)
        {
            this.repoD.InsertarPreguntaD(auxLetraD);

        }
    }
}
