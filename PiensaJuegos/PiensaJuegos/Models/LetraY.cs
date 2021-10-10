using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.Models
{
    class LetraY:RealmObject
    {
        //IdPregunta
        public int idLetraY { get; set; }

        //Pregunta
        public String preguntaY { get; set; }

        //Respuesta
        public String respuestaY { get; set; }


        public LetraY()
        {
        }
    }
}
