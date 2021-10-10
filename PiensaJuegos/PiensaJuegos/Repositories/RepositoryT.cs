using PiensaJuegos.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiensaJuegos.Repositories
{
    class RepositoryT
    {

        private Realm conexionRealm;

        Transaction transactionT;

        public RepositoryT()
        {


            //Creación del objeto de conexión.

            this.conexionRealm = Realm.GetInstance();

        }//Fin Constructor


        //Método para devolver todas los objetos de la LetraT

        public List<LetraT> GetPreguntasT()
        {
            List<LetraT> listaT = this.conexionRealm.All<LetraT>().ToList();

            return listaT;
        }//Fin GetPreguntasT



        //Método para buscar una pregunta por su Id.

        public LetraT BuscarPreguntaT(int idPreguntaT)
        {
            //Se recuperan todas las preguntas:
            List<LetraT> lista = this.GetPreguntasT();

            //Busqueda de la pregunta en concreto:

            LetraT letraT = lista.FirstOrDefault(z => z.idLetraT == idPreguntaT);

            return letraT;

        }//fin método BuscarPreguntaT


        //método para obtener el ID Máximo de la tabla LetraT.

        public int GetMaximoIdLetraT()
        {
            //Se recuperan todos los personajes
            List<LetraT> lista = this.GetPreguntasT();
            return lista.Count + 1;
        }//Fin método GetMaximoIdLetra

        //Método para insertar en Realm las preguntas de la letra T.
        //Obteniendo el último id disponible.

        public void InsertarPreguntaT(LetraT letraT)
        {
            transactionT = conexionRealm.BeginWrite();
            //letraA.idLetraA = this.GetMaximoIdLetraA();
            var entry = conexionRealm.Add(letraT);
            transactionT.Commit();

        }//Fin metodo InsertarPregunta









    }
}
