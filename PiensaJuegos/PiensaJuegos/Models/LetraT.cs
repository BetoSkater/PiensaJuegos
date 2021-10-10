using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.Models
{
    public class LetraT:RealmObject
    {
        //IdPregunta
        public int idLetraT { get; set; }

        //Pregunta
        public String preguntaT { get; set; }

        //Respuesta
        public String respuestaT { get; set; }


        public LetraT()
        {
        }
    }
}
