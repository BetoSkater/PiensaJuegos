using PiensaJuegos.Models;
using PiensaJuegos.Repositories;
using PiensaJuegos.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.ViewModels
{
    public class LetraRModel : ViewModelBase
    {
        RepositoryR repoR;

        public LetraRModel()
        {

            this.repoR = new RepositoryR();
            this.letraR = new LetraR();
        }//Fin


        //Propiedad para realizar los bindings sobre las vistas:
        private LetraR _letraR;

        public LetraR letraR
        {
            get { return this._letraR; }
            set
            {
                this._letraR = value;
                OnPropertyChanged("letraR");
            }
        }


        //Método para insertar datos:

        public void InsertarPreguntaRDB(LetraR auxLetraR)
        {
            this.repoR.InsertarPreguntaR(auxLetraR);

        }


    }
}
