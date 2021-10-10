using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.Models
{
    public class LetraA : RealmObject
    {
        //IdPregunta
        public int idLetraA { get; set; }

        //Pregunta
        public String preguntaA { get; set; }

        //Respuesta
        public String respuestaA { get; set; }

        public LetraA()
        {
        }

    }
}
