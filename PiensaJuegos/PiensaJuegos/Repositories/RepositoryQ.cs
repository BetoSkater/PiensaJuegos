using PiensaJuegos.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiensaJuegos.Repositories
{
    class RepositoryQ
    {


        private Realm conexionRealm;

        Transaction transactionQ;

        public RepositoryQ()
        {


            //Creación del objeto de conexión.

            this.conexionRealm = Realm.GetInstance();

        }//Fin Constructor


        //Método para devolver todas los objetos de la LetraQ

        public List<LetraQ> GetPreguntasQ()
        {
            List<LetraQ> listaQ = this.conexionRealm.All<LetraQ>().ToList();

            return listaQ;
        }//Fin GetPreguntasQ



        //Método para buscar una pregunta por su Id.

        public LetraQ BuscarPreguntaQ(int idPreguntaQ)
        {
            //Se recuperan todas las preguntas:
            List<LetraQ> lista = this.GetPreguntasQ();

            //Busqueda de la pregunta en concreto:

            LetraQ letraQ = lista.FirstOrDefault(z => z.idLetraQ == idPreguntaQ);

            return letraQ;

        }//fin método BuscarPreguntaQ


        //método para obtener el ID Máximo de la tabla LetraQ.

        public int GetMaximoIdLetraQ()
        {
            //Se recuperan todos los personajes
            List<LetraQ> lista = this.GetPreguntasQ();
            return lista.Count + 1;
        }//Fin método GetMaximoIdLetra

        //Método para insertar en Realm las preguntas de la letra A.
        //Obteniendo el último id disponible.

        public void InsertarPreguntaQ(LetraQ letraQ)
        {
            transactionQ = conexionRealm.BeginWrite();
            //letraA.idLetraA = this.GetMaximoIdLetraA();
            var entry = conexionRealm.Add(letraQ);
            transactionQ.Commit();

        }//Fin metodo InsertarPregunta



    }
}
