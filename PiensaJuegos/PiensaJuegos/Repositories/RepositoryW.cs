using PiensaJuegos.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiensaJuegos.Repositories
{
    class RepositoryW
    {

        private Realm conexionRealm;

        Transaction transactionW;

        public RepositoryW()
        {


            //Creación del objeto de conexión.

            this.conexionRealm = Realm.GetInstance();

        }//Fin Constructor


        //Método para devolver todas los objetos de la LetraW

        public List<LetraW> GetPreguntasW()
        {
            List<LetraW> listaW = this.conexionRealm.All<LetraW>().ToList();

            return listaW;
        }//Fin GetPreguntasW



        //Método para buscar una pregunta por su Id.

        public LetraW BuscarPreguntaW(int idPreguntaW)
        {
            //Se recuperan todas las preguntas:
            List<LetraW> lista = this.GetPreguntasW();

            //Busqueda de la pregunta en concreto:

            LetraW letraW = lista.FirstOrDefault(z => z.idLetraW == idPreguntaW);

            return letraW;

        }//fin método BuscarPreguntaW


        //método para obtener el ID Máximo de la tabla LetraA.

        public int GetMaximoIdLetraW()
        {
            //Se recuperan todos los personajes
            List<LetraW> lista = this.GetPreguntasW();
            return lista.Count + 1;
        }//Fin método GetMaximoIdLetra

        //Método para insertar en Realm las preguntas de la letra W.
        //Obteniendo el último id disponible.

        public void InsertarPreguntaW(LetraW letraW)
        {
            transactionW = conexionRealm.BeginWrite();
            //letraA.idLetraA = this.GetMaximoIdLetraA();
            var entry = conexionRealm.Add(letraW);
            transactionW.Commit();

        }//Fin metodo InsertarPregunta






    }
}
