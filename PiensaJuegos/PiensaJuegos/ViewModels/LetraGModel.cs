using PiensaJuegos.Models;
using PiensaJuegos.Repositories;
using PiensaJuegos.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.ViewModels
{
    public class LetraGModel : ViewModelBase
    {
        RepositoryG repoG;

        public LetraGModel()
        {



            this.repoG = new RepositoryG();
            this.letraG = new LetraG();
        }//Fin


        //Propiedad para realizar los bindings sobre las vistas:
        private LetraG _letraG;

        public LetraG letraG
        {
            get { return this._letraG; }
            set
            {
                this._letraG = value;
                OnPropertyChanged("letraG");
            }
        }


        //Método para insertar datos:

        public void InsertarPreguntaGDB(LetraG auxLetraG)
        {
            this.repoG.InsertarPreguntaG(auxLetraG);

        }



    }
}
