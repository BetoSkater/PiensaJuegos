using PiensaJuegos.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiensaJuegos.Repositories
{
    class RepositoryJ
    {

        private Realm conexionRealm;

        Transaction transactionJ;

        public RepositoryJ()
        {


            //Creación del objeto de conexión.

            this.conexionRealm = Realm.GetInstance();

        }//Fin Constructor


        //Método para devolver todas los objetos de la LetraJ

        public List<LetraJ> GetPreguntasJ()
        {
            List<LetraJ> listaJ = this.conexionRealm.All<LetraJ>().ToList();

            return listaJ;
        }//Fin GetPreguntasJ



        //Método para buscar una pregunta por su Id.

        public LetraJ BuscarPreguntaJ(int idPreguntaJ)
        {
            //Se recuperan todas las preguntas:
            List<LetraJ> lista = this.GetPreguntasJ();

            //Busqueda de la pregunta en concreto:

            LetraJ letraJ = lista.FirstOrDefault(z => z.idLetraJ == idPreguntaJ);

            return letraJ;

        }//fin método BuscarPreguntaJ


        //método para obtener el ID Máximo de la tabla LetraA.

        public int GetMaximoIdLetraJ()
        {
            //Se recuperan todos los personajes
            List<LetraJ> lista = this.GetPreguntasJ();
            return lista.Count + 1;
        }//Fin método GetMaximoIdLetra

        //Método para insertar en Realm las preguntas de la letra A.
        //Obteniendo el último id disponible.

        public void InsertarPreguntaJ(LetraJ letraJ)
        {
            transactionJ = conexionRealm.BeginWrite();
            //letraA.idLetraA = this.GetMaximoIdLetraA();
            var entry = conexionRealm.Add(letraJ);
            transactionJ.Commit();

        }//Fin metodo InsertarPregunta







    }
}
