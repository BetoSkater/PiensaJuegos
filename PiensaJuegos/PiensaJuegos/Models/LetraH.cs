using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.Models
{
    class LetraH:RealmObject
    {

        //IdPregunta
        public int idLetraH { get; set; }

        //Pregunta
        public String preguntaH { get; set; }

        //Respuesta
        public String respuestaH { get; set; }


        public LetraH()
        {
        }


    }
}
