using PiensaJuegos.Models;
using PiensaJuegos.Repositories;
using PiensaJuegos.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.ViewModels
{
    public class LetraPModel : ViewModelBase
    {
        RepositoryP repoP;

        public LetraPModel()
        {

            this.repoP = new RepositoryP();
            this.letraP = new LetraP();
        }//Fin


        //Propiedad para realizar los bindings sobre las vistas:
        private LetraP _letraP;

        public LetraP letraP
        {
            get { return this._letraP; }
            set
            {
                this._letraP = value;
                OnPropertyChanged("letraP");
            }
        }


        //Método para insertar datos:

        public void InsertarPreguntaPDB(LetraP auxLetraP)
        {
            this.repoP.InsertarPreguntaP(auxLetraP);

        }

    }
}
