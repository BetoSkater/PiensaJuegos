using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.Models
{
    class LetraL: RealmObject
    {
        //IdPregunta
        public int idLetraL { get; set; }

        //Pregunta
        public String preguntaL { get; set; }

        //Respuesta
        public String respuestaL { get; set; }

        public LetraL()
        {
        }

    }
}
