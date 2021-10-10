using PiensaJuegos.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiensaJuegos.Repositories
{
    class RepositorPuntosPasaVocablo
    {

        private Realm conexionRealm;

        Transaction transactionPuntuaciones;

        public RepositorPuntosPasaVocablo()
        {

            //Creación del objeto de conexión.

            this.conexionRealm = Realm.GetInstance();

        }//Fin Constructor


        //Método para devolver todas los objetos de la LetraA

        public List<PuntosPasaVocablo> GetPuntuaciones()
        {
            List<PuntosPasaVocablo> listaPuntos = this.conexionRealm.All<PuntosPasaVocablo>().ToList();

            return listaPuntos;
        }//Fin GetPuntuaciones


        //Método para insertar en Realm las puntuaciones


        public void InsertarPuntuacion(PuntosPasaVocablo puntos)
        {
            transactionPuntuaciones = conexionRealm.BeginWrite();

            var entry = conexionRealm.Add(puntos);
            transactionPuntuaciones.Commit();

        }//Fin metodo InsertarPregunta



    }
}
