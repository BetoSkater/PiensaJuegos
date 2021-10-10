using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.Models
{
    public class LetraP:RealmObject
    {
        //IdPregunta
        public int idLetraP { get; set; }

        //Pregunta
        public String preguntaP { get; set; }

        //Respuesta
        public String respuestaP { get; set; }

        public LetraP()
        {
        }
    }
}
