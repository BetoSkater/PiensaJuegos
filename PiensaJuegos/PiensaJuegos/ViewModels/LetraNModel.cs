using PiensaJuegos.Models;
using PiensaJuegos.Repositories;
using PiensaJuegos.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.ViewModels
{
    public class LetraNModel : ViewModelBase
    {
        RepositoryN repoN;

        public LetraNModel()
        {

            this.repoN = new RepositoryN();
            this.letraN = new LetraN();
        }//Fin


        //Propiedad para realizar los bindings sobre las vistas:
        private LetraN _letraN;

        public LetraN letraN
        {
            get { return this._letraN; }
            set
            {
                this._letraN = value;
                OnPropertyChanged("letraN");
            }
        }


        //Método para insertar datos:

        public void InsertarPreguntaNDB(LetraN auxLetraN)
        {
            this.repoN.InsertarPreguntaN(auxLetraN);

        }

    }
}
