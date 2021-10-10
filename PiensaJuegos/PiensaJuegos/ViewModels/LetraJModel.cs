using PiensaJuegos.Models;
using PiensaJuegos.Repositories;
using PiensaJuegos.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.ViewModels
{
    class LetraJModel : ViewModelBase
    {
        RepositoryJ repoJ;

        public LetraJModel()
        {

            this.repoJ = new RepositoryJ();
            this.letraJ = new LetraJ();
        }//Fin


        //Propiedad para realizar los bindings sobre las vistas:
        private LetraJ _letraJ;

        public LetraJ letraJ
        {
            get { return this._letraJ; }
            set
            {
                this._letraJ = value;
                OnPropertyChanged("letraJ");
            }
        }


        //Método para insertar datos:

        public void InsertarPreguntaJDB(LetraJ auxLetraJ)
        {
            this.repoJ.InsertarPreguntaJ(auxLetraJ);

        }
    }

}
