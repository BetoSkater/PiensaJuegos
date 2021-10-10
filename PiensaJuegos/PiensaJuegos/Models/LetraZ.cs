using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.Models
{
    public class LetraZ:RealmObject
    {
        //IdPregunta
        public int idLetraZ { get; set; }

        //Pregunta
        public String preguntaZ { get; set; }

        //Respuesta
        public String respuestaZ { get; set; }


        public LetraZ()
        {
        }
    }
}
