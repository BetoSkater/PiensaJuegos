using PiensaJuegos.Models;
using PiensaJuegos.Repositories;
using PiensaJuegos.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.ViewModels
{
    public class LetraCModel : ViewModelBase
    {

        RepositoryC repoC;

        public LetraCModel()
        {

            this.repoC = new RepositoryC();
            this.letraC = new LetraC();
        }


        //Propiedad para realizar los bindings sobre las vistas:
        private LetraC _letraC;

        public LetraC letraC
        {
            get { return this._letraC; }
            set
            {
                this._letraC = value;
                OnPropertyChanged("letraC");
            }
        }


        //Método para insertar datos:

        public void InsertarPreguntaCDB(LetraC auxLetraC)
        {
            this.repoC.InsertarPreguntaC(auxLetraC);

        }


    }
}
