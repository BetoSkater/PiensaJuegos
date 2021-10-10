using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.Models
{
    public class LetraE:RealmObject
    {

        //IdPregunta
        public int idLetraE { get; set; }

        //Pregunta
        public String preguntaE { get; set; }

        //Respuesta
        public String respuestaE { get; set; }


        public LetraE()
        {
        }



    }
}
