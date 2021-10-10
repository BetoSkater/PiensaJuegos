using PiensaJuegos.Models;
using PiensaJuegos.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.ViewModels
{
    public class PreguntaModel : ViewModelBase
    {

        public PreguntaModel()
        {
            this.Letra = new Letra();
        }




        //Propiedad para realizar los bindings sobre las vistas:
        private Letra _Letra;

        public Letra Letra
        {
            get { return this._Letra; }
            set
            {
                this._Letra = value;
                OnPropertyChanged("Letra");
            }
        }






    }
}
