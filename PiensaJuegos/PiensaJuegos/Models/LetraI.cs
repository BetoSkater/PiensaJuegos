using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.Models
{
    public class LetraI:RealmObject
    {
        //IdPregunta
        public int idLetraI { get; set; }

        //Pregunta
        public String preguntaI { get; set; }

        //Respuesta
        public String respuestaI { get; set; }

        public LetraI()
        {
        }



    }
}
