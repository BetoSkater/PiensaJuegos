using PiensaJuegos.Models;
using PiensaJuegos.Repositories;
using PiensaJuegos.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.ViewModels
{
    public class LetraVModel : ViewModelBase
    {

        RepositoryV repoV;

        public LetraVModel()
        {

            this.repoV = new RepositoryV();
            this.letraV = new LetraV();
        }//Fin


        //Propiedad para realizar los bindings sobre las vistas:
        private LetraV _letraV;

        public LetraV letraV
        {
            get { return this._letraV; }
            set
            {
                this._letraV = value;
                OnPropertyChanged("letraV");
            }
        }


        //Método para insertar datos:

        public void InsertarPreguntaVDB(LetraV auxLetraV)
        {
            this.repoV.InsertarPreguntaV(auxLetraV);

        }


    }
}
