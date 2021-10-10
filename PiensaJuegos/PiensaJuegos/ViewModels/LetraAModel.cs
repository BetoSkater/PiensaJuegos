using PiensaJuegos.Models;
using PiensaJuegos.Repositories;
using PiensaJuegos.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.ViewModels
{
     public class LetraAModel : ViewModelBase
    {
        RepositoryA repoA;

        public LetraAModel()
        {
            this.repoA = new RepositoryA();
            this.letraA = new LetraA();
        }//Fin


        //Propiedad para realizar los bindings sobre las vistas:
        private LetraA _letraA;

        public LetraA letraA
        {
            get { return this._letraA; }
            set
            {
                this._letraA = value;
                OnPropertyChanged("letraA");
            }
        }


        //Método para insertar datos:

        public void InsertarPreguntaADB(LetraA auxLetraA)
        {
            this.repoA.InsertarPreguntaA(auxLetraA);

        }

     }
    }
