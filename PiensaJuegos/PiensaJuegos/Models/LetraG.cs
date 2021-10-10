using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.Models
{
    class LetraG:RealmObject
    {

        //IdPregunta
        public int idLetraG { get; set; }

        //Pregunta
        public String preguntaG { get; set; }

        //Respuesta
        public String respuestaG { get; set; }


        public LetraG()
        {
        }



    }
}
