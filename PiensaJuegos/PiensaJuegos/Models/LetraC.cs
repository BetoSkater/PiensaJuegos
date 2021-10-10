using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.Models
{
    public class LetraC:RealmObject
    {
        //IdPregunta
        public int idLetraC { get; set; }

        //Pregunta
        public String preguntaC { get; set; }

        //Respuesta
        public String respuestaC { get; set; }

        public LetraC()
        {
        }






    }
}
