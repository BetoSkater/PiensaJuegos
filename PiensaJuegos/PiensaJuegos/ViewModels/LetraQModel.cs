using PiensaJuegos.Models;
using PiensaJuegos.Repositories;
using PiensaJuegos.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.ViewModels
{
    class LetraQModel : ViewModelBase
    {
        RepositoryQ repoQ;

        public LetraQModel()
        {


            this.repoQ = new RepositoryQ();
            this.letraQ = new LetraQ();
        }//Fin


        //Propiedad para realizar los bindings sobre las vistas:
        private LetraQ _letraQ;

        public LetraQ letraQ
        {
            get { return this._letraQ; }
            set
            {
                this._letraQ = value;
                OnPropertyChanged("letraQ");
            }
        }


        //Método para insertar datos:

        public void InsertarPreguntaQDB(LetraQ auxLetraQ)
        {
            this.repoQ.InsertarPreguntaQ(auxLetraQ);

        }


    }
}
