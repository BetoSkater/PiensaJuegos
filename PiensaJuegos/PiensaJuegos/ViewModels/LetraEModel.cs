using PiensaJuegos.Models;
using PiensaJuegos.Repositories;
using PiensaJuegos.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.ViewModels
{
    public class LetraEModel : ViewModelBase
    {
        RepositoryE repoE;

        public LetraEModel()
        {

            this.repoE = new RepositoryE();
            this.letraE = new LetraE();

        }


        //Propiedad para realizar los bindings sobre las vistas:
        private LetraE _letraE;

        public LetraE letraE
        {
            get { return this._letraE; }
            set
            {
                this._letraE = value;
                OnPropertyChanged("letraE");
            }
        }


        //Método para insertar datos:

        public void InsertarPreguntaEDB(LetraE auxLetraE)
        {
            this.repoE.InsertarPreguntaE(auxLetraE);

        }


    }
}
