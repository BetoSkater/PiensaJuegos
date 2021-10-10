using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.Models
{
    public class LetraJ:RealmObject
    {
        //IdPregunta
        public int idLetraJ { get; set; }

        //Pregunta
        public String preguntaJ { get; set; }

        //Respuesta
        public String respuestaJ { get; set; }

        public LetraJ()
        {
        }



    }
}
