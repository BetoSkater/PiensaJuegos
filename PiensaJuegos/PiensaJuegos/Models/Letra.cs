using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.Models
{
    //Ojo: Como letra no va a interactuar con la base de datos, no hace falta que herede de RealmObject
    public class Letra
    {

        //Clase con el mismo esqueleto que todas las preguntas para asignar el valor de las preguntas a dicha variable:
        //Letra
        public String letra { get; set; }

        //IdPregunta
        public int idLetra { get; set; }

        //Pregunta
        public String pregunta { get; set; }

        //Respuesta
        public String respuesta { get; set; }


        //SIN RESPONDER
        public bool sinRespuesta { get; set; }

        //Acertada
        public bool acertada { get; set; }

        //Fallada
        public bool fallada { get; set; }

        public Letra(String letra, int idLetra, String pregunta, String respuesta, bool sinRespuesta, bool acertada, bool fallada)
        {
            this.letra = letra;
            this.idLetra = idLetra;
            this.pregunta = pregunta;
            this.respuesta = respuesta;
            this.sinRespuesta = sinRespuesta;
            this.acertada = acertada;
            this.fallada = fallada;
        }

        public Letra()
        {
        }

    }

}
