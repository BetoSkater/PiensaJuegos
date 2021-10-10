using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.Models
{
    public class LetraK:RealmObject
    {
        //IdPregunta
        public int idLetraK { get; set; }

        //Pregunta
        public String preguntaK { get; set; }

        //Respuesta
        public String respuestaK { get; set; }

        public LetraK()
        {
        }


    }
}
