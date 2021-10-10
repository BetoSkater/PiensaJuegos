using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.Models
{
    class LetraNie:RealmObject
    {
        //IdPregunta
        public int idLetraNie { get; set; }

        //Pregunta
        public String preguntaNie { get; set; }

        //Respuesta
        public String respuestaNie { get; set; }

        public LetraNie()
        {
        }
    }
}
