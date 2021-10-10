using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.Models
{
    class LetraO:RealmObject
    {
        //IdPregunta
        public int idLetraO { get; set; }

        //Pregunta
        public String preguntaO { get; set; }

        //Respuesta
        public String respuestaO { get; set; }

        public LetraO()
        {
        }

    }
}
