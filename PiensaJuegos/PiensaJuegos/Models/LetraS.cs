using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.Models
{
    class LetraS:RealmObject
    {
        //IdPregunta
        public int idLetraS { get; set; }

        //Pregunta
        public String preguntaS { get; set; }

        //Respuesta
        public String respuestaS { get; set; }


        public LetraS()
        {
        }
    }
}
