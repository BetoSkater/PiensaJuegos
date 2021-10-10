using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.Models
{
    class LetraR:RealmObject
    {
        //IdPregunta
        public int idLetraR { get; set; }

        //Pregunta
        public String preguntaR { get; set; }

        //Respuesta
        public String respuestaR { get; set; }


        public LetraR()
            
        {
        }

    }
}
