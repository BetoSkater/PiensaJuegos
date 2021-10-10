using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.Models
{
    class LetraN:RealmObject
    {

        //IdPregunta
        public int idLetraN { get; set; }

        //Pregunta
        public String preguntaN { get; set; }

        //Respuesta
        public String respuestaN { get; set; }

        public LetraN()
        {
        }

    }
}
