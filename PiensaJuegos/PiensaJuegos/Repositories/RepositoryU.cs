using PiensaJuegos.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiensaJuegos.Repositories
{
    class RepositoryU
    {


        private Realm conexionRealm;

        Transaction transactionU;

        public RepositoryU()
        {


            //Creación del objeto de conexión.

            this.conexionRealm = Realm.GetInstance();

        }//Fin Constructor


        //Método para devolver todas los objetos de la LetraU

        public List<LetraU> GetPreguntasU()
        {
            List<LetraU> listaU = this.conexionRealm.All<LetraU>().ToList();

            return listaU;
        }//Fin GetPreguntasU



        //Método para buscar una pregunta por su Id.

        public LetraU BuscarPreguntaU(int idPreguntaU)
        {
            //Se recuperan todas las preguntas:
            List<LetraU> lista = this.GetPreguntasU();

            //Busqueda de la pregunta en concreto:

            LetraU letraU = lista.FirstOrDefault(z => z.idLetraU == idPreguntaU);

            return letraU;

        }//fin método BuscarPreguntaU


        //método para obtener el ID Máximo de la tabla LetraU.

        public int GetMaximoIdLetraU()
        {
            //Se recuperan todos los personajes
            List<LetraU> lista = this.GetPreguntasU();
            return lista.Count + 1;
        }//Fin método GetMaximoIdLetra

        //Método para insertar en Realm las preguntas de la letra U.
        //Obteniendo el último id disponible.

        public void InsertarPreguntaU(LetraU letraU)
        {
            transactionU = conexionRealm.BeginWrite();
            //letraA.idLetraA = this.GetMaximoIdLetraA();
            var entry = conexionRealm.Add(letraU);
            transactionU.Commit();

        }//Fin metodo InsertarPregunta













    }
}
