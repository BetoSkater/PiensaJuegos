using PiensaJuegos.Models;
using PiensaJuegos.Repositories;
using PiensaJuegos.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.ViewModels
{
    public class LetraFModel : ViewModelBase
    {
        RepositoryF repoF;

        public LetraFModel()
        {


            this.repoF = new RepositoryF();
            this.letraF = new LetraF();
        }//Fin


        //Propiedad para realizar los bindings sobre las vistas:
        private LetraF _letraF;

        public LetraF letraF
        {
            get { return this._letraF; }
            set
            {
                this._letraF = value;
                OnPropertyChanged("letraF");
            }
        }


        //Método para insertar datos:

        public void InsertarPreguntaFDB(LetraF auxLetraF)
        {
            this.repoF.InsertarPreguntaF(auxLetraF);

        }




    }
}
