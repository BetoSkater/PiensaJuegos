using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.Models
{
    class LetraW:RealmObject
    {
        //IdPregunta
        public int idLetraW { get; set; }

        //Pregunta
        public String preguntaW { get; set; }

        //Respuesta
        public String respuestaW { get; set; }


        public LetraW()
        {
        }
    }
}
