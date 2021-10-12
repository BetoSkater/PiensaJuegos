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
            this.letraPregunta = new Letra();
        }




        //Propiedad para realizar los bindings sobre las vistas:
        private Letra _letraPregunta;

        public Letra letraPregunta
        {
            get { return this._letraPregunta; }
            set
            {
                this._letraPregunta = value;
                OnPropertyChanged("letraPregunta");
            }
        }






    }
}
