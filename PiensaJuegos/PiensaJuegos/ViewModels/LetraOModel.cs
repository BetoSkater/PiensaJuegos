using PiensaJuegos.Models;
using PiensaJuegos.Repositories;
using PiensaJuegos.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.ViewModels
{
    public class LetraOModel : ViewModelBase
    {
        RepositoryO repoO;

        public LetraOModel()
        {

            this.repoO = new RepositoryO();
            this.letraO = new LetraO();
        }//Fin


        //Propiedad para realizar los bindings sobre las vistas:
        private LetraO _letraO;

        public LetraO letraO
        {
            get { return this._letraO; }
            set
            {
                this._letraO = value;
                OnPropertyChanged("letraO");
            }
        }


        //Método para insertar datos:

        public void InsertarPreguntaODB(LetraO auxLetraO)
        {
            this.repoO.InsertarPreguntaO(auxLetraO);

        }


    }
}
