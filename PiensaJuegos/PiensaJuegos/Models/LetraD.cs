using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.Models
{
    public class LetraD:RealmObject
    {
        //IdPregunta
        public int idLetraD { get; set; }

        //Pregunta
        public String preguntaD { get; set; }

        //Respuesta
        public String respuestaD { get; set; }


        public LetraD()
        {
        }





    }
}
