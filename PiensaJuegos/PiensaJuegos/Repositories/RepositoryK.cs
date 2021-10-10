using PiensaJuegos.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiensaJuegos.Repositories
{
    class RepositoryK
    {

        private Realm conexionRealm;

        Transaction transactionK;

        public RepositoryK()
        {


            //Creación del objeto de conexión.

            this.conexionRealm = Realm.GetInstance();

        }//Fin Constructor


        //Método para devolver todas los objetos de la LetraA

        public List<LetraK> GetPreguntasK()
        {
            List<LetraK> listaK = this.conexionRealm.All<LetraK>().ToList();

            return listaK;
        }//Fin GetPreguntasK



        //Método para buscar una pregunta por su Id.

        public LetraK BuscarPreguntaK(int idPreguntaK)
        {
            //Se recuperan todas las preguntas:
            List<LetraK> lista = this.GetPreguntasK();

            //Busqueda de la pregunta en concreto:

            LetraK letraK = lista.FirstOrDefault(z => z.idLetraK == idPreguntaK);

            return letraK;

        }//fin método BuscarPreguntaK


        //método para obtener el ID Máximo de la tabla LetraA.

        public int GetMaximoIdLetraK()
        {
            //Se recuperan todos los personajes
            List<LetraK> lista = this.GetPreguntasK();
            return lista.Count + 1;
        }//Fin método GetMaximoIdLetra

        //Método para insertar en Realm las preguntas de la letra A.
        //Obteniendo el último id disponible.

        public void InsertarPreguntaK(LetraK letraK)
        {
            transactionK = conexionRealm.BeginWrite();
            //letraA.idLetraA = this.GetMaximoIdLetraA();
            var entry = conexionRealm.Add(letraK);
            transactionK.Commit();

        }//Fin metodo InsertarPregunta




    }
}
