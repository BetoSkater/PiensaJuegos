using PiensaJuegos.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiensaJuegos.Repositories
{
    class RepositoryY
    {

        private Realm conexionRealm;

        Transaction transactionY;

        public RepositoryY()
        {


            //Creación del objeto de conexión.

            this.conexionRealm = Realm.GetInstance();

        }//Fin Constructor


        //Método para devolver todas los objetos de la LetraY

        public List<LetraY> GetPreguntasY()
        {
            List<LetraY> listaY = this.conexionRealm.All<LetraY>().ToList();

            return listaY;
        }//Fin GetPreguntasY



        //Método para buscar una pregunta por su Id.

        public LetraY BuscarPreguntaY(int idPreguntaY)
        {
            //Se recuperan todas las preguntas:
            List<LetraY> lista = this.GetPreguntasY();

            //Busqueda de la pregunta en concreto:

            LetraY letraY = lista.FirstOrDefault(z => z.idLetraY == idPreguntaY);

            return letraY;

        }//fin método BuscarPreguntaY


        //método para obtener el ID Máximo de la tabla LetraY.

        public int GetMaximoIdLetraY()
        {
            //Se recuperan todos los personajes
            List<LetraY> lista = this.GetPreguntasY();
            return lista.Count + 1;
        }//Fin método GetMaximoIdLetra

        //Método para insertar en Realm las preguntas de la letra A.
        //Obteniendo el último id disponible.

        public void InsertarPreguntaY(LetraY letraY)
        {
            transactionY = conexionRealm.BeginWrite();
            //letraA.idLetraA = this.GetMaximoIdLetraA();
            var entry = conexionRealm.Add(letraY);
            transactionY.Commit();

        }//Fin metodo InsertarPregunta









    }
}
