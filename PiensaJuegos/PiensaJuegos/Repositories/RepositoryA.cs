using PiensaJuegos.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiensaJuegos.Repositories
{
    class RepositoryA
    {
        private Realm conexionRealm;

        Transaction transactionA;

        public RepositoryA()
        {
            //Creación del objeto de conexión.

            this.conexionRealm = Realm.GetInstance();

        }//Fin Constructor


        //Método para devolver todas los objetos de la LetraA

        public List<LetraA> GetPreguntasA()
        {
            List<LetraA> listaA = this.conexionRealm.All<LetraA>().ToList();

            return listaA;
        }//Fin GetPreguntasA



        //Método para buscar una pregunta por su Id.

        public LetraA BuscarPreguntaA(int idPreguntaA)
        {
            //Se recuperan todas las preguntas:
            List<LetraA> lista = this.GetPreguntasA();

            //Busqueda de la pregunta en concreto:

            LetraA letraA = lista.FirstOrDefault(z => z.idLetraA == idPreguntaA);

            return letraA;

        }//fin método BuscarPreguntaA


        //método para obtener el ID Máximo de la tabla LetraA.

        public int GetMaximoIdLetraA()
        {
            //Se recuperan todos los personajes
            List<LetraA> lista = this.GetPreguntasA();
            return lista.Count + 1;
        }//Fin método GetMaximoIdLetra

        //Método para insertar en Realm las preguntas de la letra A.
        //Obteniendo el último id disponible.

        public void InsertarPreguntaA(LetraA letraA)
        {
            transactionA = conexionRealm.BeginWrite();
            //letraA.idLetraA = this.GetMaximoIdLetraA();
            var entry = conexionRealm.Add(letraA);
            transactionA.Commit();

        }//Fin metodo InsertarPregunta




    }
}
