using PiensaJuegos.Models;
using PiensaJuegos.Repositories;
using PiensaJuegos.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.ViewModels
{
    public class LetraZModel : ViewModelBase
    {

        RepositoryZ repoZ;

        public LetraZModel()
        {

            this.repoZ = new RepositoryZ();
            this.letraZ = new LetraZ();
        }//Fin


        //Propiedad para realizar los bindings sobre las vistas:
        private LetraZ _letraZ;

        public LetraZ letraZ
        {
            get { return this._letraZ; }
            set
            {
                this._letraZ = value;
                OnPropertyChanged("letraZ");
            }
        }


        //Método para insertar datos:

        public void InsertarPreguntaZDB(LetraZ auxLetraZ)
        {
            this.repoZ.InsertarPreguntaZ(auxLetraZ);

        }

    }
}
