using PiensaJuegos.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiensaJuegos.Repositories
{
    class RepositoryV
    {

        private Realm conexionRealm;

        Transaction transactionV;

        public RepositoryV()
        {


            //Creación del objeto de conexión.

            this.conexionRealm = Realm.GetInstance();

        }//Fin Constructor


        //Método para devolver todas los objetos de la LetraA

        public List<LetraV> GetPreguntasV()
        {
            List<LetraV> listaV = this.conexionRealm.All<LetraV>().ToList();

            return listaV;
        }//Fin GetPreguntasV



        //Método para buscar una pregunta por su Id.

        public LetraV BuscarPreguntaV(int idPreguntaV)
        {
            //Se recuperan todas las preguntas:
            List<LetraV> lista = this.GetPreguntasV();

            //Busqueda de la pregunta en concreto:

            LetraV letraV = lista.FirstOrDefault(z => z.idLetraV == idPreguntaV);

            return letraV;

        }//fin método BuscarPreguntaV


        //método para obtener el ID Máximo de la tabla LetraV.

        public int GetMaximoIdLetraV()
        {
            //Se recuperan todos los personajes
            List<LetraV> lista = this.GetPreguntasV();
            return lista.Count + 1;
        }//Fin método GetMaximoIdLetra

        //Método para insertar en Realm las preguntas de la letra A.
        //Obteniendo el último id disponible.

        public void InsertarPreguntaV(LetraV letraV)
        {
            transactionV = conexionRealm.BeginWrite();
            //letraA.idLetraA = this.GetMaximoIdLetraA();
            var entry = conexionRealm.Add(letraV);
            transactionV.Commit();

        }//Fin metodo InsertarPregunta









    }
}
