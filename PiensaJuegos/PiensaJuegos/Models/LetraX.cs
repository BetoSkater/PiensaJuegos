using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.Models
{
    class LetraX:RealmObject
    {
        //IdPregunta
        public int idLetraX { get; set; }

        //Pregunta
        public String preguntaX { get; set; }

        //Respuesta
        public String respuestaX { get; set; }


        public LetraX()
        {
        }

    }
}
