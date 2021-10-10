using PiensaJuegos.Models;
using PiensaJuegos.Repositories;
using PiensaJuegos.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.ViewModels
{
    class LetraXModel : ViewModelBase
    {
        RepositoryX repoX;

        public LetraXModel()
        {

            this.repoX = new RepositoryX();
            this.letraX = new LetraX();
        }//Fin


        //Propiedad para realizar los bindings sobre las vistas:
        private LetraX _letraX;

        public LetraX letraX
        {
            get { return this._letraX; }
            set
            {
                this._letraX = value;
                OnPropertyChanged("letraX");
            }
        }


        //Método para insertar datos:

        public void InsertarPreguntaXDB(LetraX auxLetraX)
        {
            this.repoX.InsertarPreguntaX(auxLetraX);

        }


    }
}
