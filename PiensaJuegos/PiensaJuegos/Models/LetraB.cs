using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.Models
{
    class LetraB : RealmObject
    {

        //IdPregunta
        public int idLetraB { get; set; }

        //Pregunta
        public String preguntaB { get; set; }

        //Respuesta
        public String respuestaB { get; set; }



        public LetraB()
        {
        }




    }
}
