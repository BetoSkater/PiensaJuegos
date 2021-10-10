using PiensaJuegos.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiensaJuegos.Repositories
{
    class RepositoryC
    {

        private Realm conexionRealm;

        Transaction transactionC;

        public RepositoryC()
        {
            //Creación del objeto de conexión.

            this.conexionRealm = Realm.GetInstance();

        }//Fin Constructor


        //Método para devolver todas los objetos de la LetraA

        public List<LetraC> GetPreguntasC()
        {
            List<LetraC> listaC = this.conexionRealm.All<LetraC>().ToList();

            return listaC;
        }//Fin GetPreguntasC



        //Método para buscar una pregunta por su Id.

        public LetraC BuscarPreguntaC(int idPreguntaC)
        {
            //Se recuperan todas las preguntas:
            List<LetraC> lista = this.GetPreguntasC();

            //Busqueda de la pregunta en concreto:

            LetraC letraC = lista.FirstOrDefault(z => z.idLetraC == idPreguntaC);

            return letraC;

        }//fin método BuscarPreguntaC


        //método para obtener el ID Máximo de la tabla LetraA.

        public int GetMaximoIdLetraC()
        {
            //Se recuperan todos los personajes
            List<LetraC> lista = this.GetPreguntasC();
            return lista.Count + 1;
        }//Fin método GetMaximoIdLetra

        //Método para insertar en Realm las preguntas de la letra A.
        //Obteniendo el último id disponible.
        public void InsertarPreguntaC(LetraC letraC)
        {
            transactionC = conexionRealm.BeginWrite();
            //letraC.idLetraC = this.GetMaximoIdLetraC();
            var entry = conexionRealm.Add(letraC);
            transactionC.Commit();

        }//Fin metodo InsertarPregunta






    }
}
