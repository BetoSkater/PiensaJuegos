using PiensaJuegos.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiensaJuegos.Repositories
{
    class RepositoryS
    {

        private Realm conexionRealm;

        Transaction transactionS;

        public RepositoryS()
        {


            //Creación del objeto de conexión.

            this.conexionRealm = Realm.GetInstance();

        }//Fin Constructor


        //Método para devolver todas los objetos de la LetraS

        public List<LetraS> GetPreguntasS()
        {
            List<LetraS> listaS = this.conexionRealm.All<LetraS>().ToList();

            return listaS;
        }//Fin GetPreguntasS



        //Método para buscar una pregunta por su Id.

        public LetraS BuscarPreguntaS(int idPreguntaS)
        {
            //Se recuperan todas las preguntas:
            List<LetraS> lista = this.GetPreguntasS();

            //Busqueda de la pregunta en concreto:

            LetraS letraS = lista.FirstOrDefault(z => z.idLetraS == idPreguntaS);

            return letraS;

        }//fin método BuscarPreguntaS


        //método para obtener el ID Máximo de la tabla LetraS.

        public int GetMaximoIdLetraS()
        {
            //Se recuperan todos los personajes
            List<LetraS> lista = this.GetPreguntasS();
            return lista.Count + 1;
        }//Fin método GetMaximoIdLetra

        //Método para insertar en Realm las preguntas de la letra S.
        //Obteniendo el último id disponible.

        public void InsertarPreguntaS(LetraS letraS)
        {
            transactionS = conexionRealm.BeginWrite();
            //letraA.idLetraA = this.GetMaximoIdLetraA();
            var entry = conexionRealm.Add(letraS);
            transactionS.Commit();

        }//Fin metodo InsertarPregunta



    }
}
