using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.Models
{
    public class LetraU: RealmObject
    {
        //IdPregunta
        public int idLetraU { get; set; }

        //Pregunta
        public String preguntaU { get; set; }

        //Respuesta
        public String respuestaU { get; set; }


        public LetraU()
        {
        }

    }
}
