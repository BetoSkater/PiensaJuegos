using PiensaJuegos.Models;
using PiensaJuegos.Repositories;
using PiensaJuegos.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.ViewModels
{
    public class LetraTModel : ViewModelBase
    {

        RepositoryT repoT;

        public LetraTModel()
        {

            this.repoT = new RepositoryT();
            this.letraT = new LetraT();
        }//Fin


        //Propiedad para realizar los bindings sobre las vistas:
        private LetraT _letraT;

        public LetraT letraT
        {
            get { return this._letraT; }
            set
            {
                this._letraT = value;
                OnPropertyChanged("letraT");
            }
        }


        //Método para insertar datos:

        public void InsertarPreguntaADB(LetraT auxLetraT)
        {
            this.repoT.InsertarPreguntaT(auxLetraT);

        }


    }
}
