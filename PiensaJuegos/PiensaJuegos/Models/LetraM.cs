using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.Models
{
    public class LetraM:RealmObject
    {
        //IdPregunta
        public int idLetraM { get; set; }

        //Pregunta
        public String preguntaM { get; set; }

        //Respuesta
        public String respuestaM { get; set; }

        public LetraM()
        {
        }
    }
}
