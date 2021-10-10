using PiensaJuegos.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.ViewModels
{
    class TemporizadorModel : ViewModelBase
    {
        public TemporizadorModel()
        {
            // this.segundosRestantes = segundosRestantes;
            //  this.segundosRestantes = segundosRestantes;
        }

        //Propiedad para realizar los bindings sobre las vistas:
        private int _segundosRestantes;

        public int segundosRestantes
        {
            get
            {
                return this._segundosRestantes;
            }
            set
            {
                this._segundosRestantes = value;
                OnPropertyChanged("segundosRestantes"); //TODO aqui tengo dudas
            }
        }


    }
}
