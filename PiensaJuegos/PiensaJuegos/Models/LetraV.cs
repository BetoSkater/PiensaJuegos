using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.Models
{
    class LetraV:RealmObject
    {
        //IdPregunta
        public int idLetraV { get; set; }

        //Pregunta
        public String preguntaV { get; set; }

        //Respuesta
        public String respuestaV { get; set; }


        public LetraV()
        {
        }
    }
}
