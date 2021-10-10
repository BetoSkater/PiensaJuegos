using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiensaJuegos.Models
{
    public class PuntosPasaVocablo : RealmObject
    {
        public int posicion { get; set; }
        public int puntuacion { get; set; }
        public String usuario { get; set; }
        public String dificultad { get; set; }
        public int acertadas { get; set; }
        public int tiempo { get; set; }





        public PuntosPasaVocablo(int posicion, int puntuacion, String usuario, String dificultad, int acertadas, int tiempo)
        {
            this.posicion = posicion;
            this.puntuacion = puntuacion;
            this.usuario = usuario;
            this.dificultad = dificultad;
            this.acertadas = acertadas;
            this.tiempo = tiempo;
        }

        public PuntosPasaVocablo() { }

    }
}
