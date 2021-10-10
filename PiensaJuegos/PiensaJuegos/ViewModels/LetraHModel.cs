using PiensaJuegos.Models;
using PiensaJuegos.Repositories;
using PiensaJuegos.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.ViewModels
{
    public class LetraHModel : ViewModelBase
    {
        RepositoryH repoH;

        public LetraHModel()
        {


            this.repoH = new RepositoryH();
            this.letraH = new LetraH();
        }//Fin


        //Propiedad para realizar los bindings sobre las vistas:
        private LetraH _letraH;

        public LetraH letraH
        {
            get { return this._letraH; }
            set
            {
                this._letraH = value;
                OnPropertyChanged("letraH");
            }
        }


        //Método para insertar datos:

        public void InsertarPreguntaHDB(LetraH auxLetraH)
        {
            this.repoH.InsertarPreguntaH(auxLetraH);

        }



    }
}
