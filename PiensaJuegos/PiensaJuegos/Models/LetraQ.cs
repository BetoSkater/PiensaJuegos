using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.Models
{
    public class LetraQ:RealmObject
    {
        //IdPregunta
        public int idLetraQ { get; set; }

        //Pregunta
        public String preguntaQ { get; set; }

        //Respuesta
        public String respuestaQ { get; set; }


        public LetraQ()
        {
        }

    }
}
