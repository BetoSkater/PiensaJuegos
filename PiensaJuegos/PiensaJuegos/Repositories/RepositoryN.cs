using PiensaJuegos.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiensaJuegos.Repositories
{
    class RepositoryN
    {

        private Realm conexionRealm;

        Transaction transactionN;

        public RepositoryN()
        {


            //Creación del objeto de conexión.

            this.conexionRealm = Realm.GetInstance();

        }//Fin Constructor


        //Método para devolver todas los objetos de la LetraN

        public List<LetraN> GetPreguntasN()
        {
            List<LetraN> listaN = this.conexionRealm.All<LetraN>().ToList();

            return listaN;
        }//Fin GetPreguntasN



        //Método para buscar una pregunta por su Id.

        public LetraN BuscarPreguntaN(int idPreguntaN)
        {
            //Se recuperan todas las preguntas:
            List<LetraN> lista = this.GetPreguntasN();

            //Busqueda de la pregunta en concreto:

            LetraN letraN = lista.FirstOrDefault(z => z.idLetraN == idPreguntaN);

            return letraN;

        }//fin método BuscarPreguntaN


        //método para obtener el ID Máximo de la tabla LetraN.

        public int GetMaximoIdLetraN()
        {
            //Se recuperan todos los personajes
            List<LetraN> lista = this.GetPreguntasN();
            return lista.Count + 1;
        }//Fin método GetMaximoIdLetra

        //Método para insertar en Realm las preguntas de la letra N.
        //Obteniendo el último id disponible.

        public void InsertarPreguntaN(LetraN letraN)
        {
            transactionN = conexionRealm.BeginWrite();
            //letraA.idLetraA = this.GetMaximoIdLetraA();
            var entry = conexionRealm.Add(letraN);
            transactionN.Commit();

        }//Fin metodo InsertarPregunta




    }
}
