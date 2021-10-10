using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.Models
{
    class LetraF:RealmObject
    {

        //IdPregunta
        public int idLetraF { get; set; }

        //Pregunta
        public String preguntaF { get; set; }

        //Respuesta
        public String respuestaF { get; set; }


        public LetraF()
        {
        }



    }
}
