using PiensaJuegos.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiensaJuegos.Repositories
{
    class RepositoryP
    {

        private Realm conexionRealm;

        Transaction transactionP;

        public RepositoryP()
        {


            //Creación del objeto de conexión.

            this.conexionRealm = Realm.GetInstance();

        }//Fin Constructor


        //Método para devolver todas los objetos de la LetraA

        public List<LetraP> GetPreguntasP()
        {
            List<LetraP> listaP = this.conexionRealm.All<LetraP>().ToList();

            return listaP;
        }//Fin GetPreguntasP



        //Método para buscar una pregunta por su Id.

        public LetraP BuscarPreguntaP(int idPreguntaP)
        {
            //Se recuperan todas las preguntas:
            List<LetraP> lista = this.GetPreguntasP();

            //Busqueda de la pregunta en concreto:

            LetraP letraP = lista.FirstOrDefault(z => z.idLetraP == idPreguntaP);

            return letraP;

        }//fin método BuscarPreguntaP


        //método para obtener el ID Máximo de la tabla LetraA.

        public int GetMaximoIdLetraP()
        {
            //Se recuperan todos los personajes
            List<LetraP> lista = this.GetPreguntasP();
            return lista.Count + 1;
        }//Fin método GetMaximoIdLetra

        //Método para insertar en Realm las preguntas de la letra A.
        //Obteniendo el último id disponible.

        public void InsertarPreguntaP(LetraP letraP)
        {
            transactionP = conexionRealm.BeginWrite();
            //letraA.idLetraA = this.GetMaximoIdLetraA();
            var entry = conexionRealm.Add(letraP);
            transactionP.Commit();

        }//Fin metodo InsertarPregunta





    }
}
