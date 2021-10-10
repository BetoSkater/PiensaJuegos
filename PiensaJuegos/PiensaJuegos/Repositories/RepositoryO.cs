using PiensaJuegos.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiensaJuegos.Repositories
{
    class RepositoryO
    {

        private Realm conexionRealm;

        Transaction transactionO;

        public RepositoryO()
        {


            //Creación del objeto de conexión.

            this.conexionRealm = Realm.GetInstance();

        }//Fin Constructor


        //Método para devolver todas los objetos de la LetraO

        public List<LetraO> GetPreguntasO()
        {
            List<LetraO> listaO = this.conexionRealm.All<LetraO>().ToList();

            return listaO;
        }//Fin GetPreguntasO



        //Método para buscar una pregunta por su Id.

        public LetraO BuscarPreguntaO(int idPreguntaO)
        {
            //Se recuperan todas las preguntas:
            List<LetraO> lista = this.GetPreguntasO();

            //Busqueda de la pregunta en concreto:

            LetraO letraO = lista.FirstOrDefault(z => z.idLetraO == idPreguntaO);

            return letraO;

        }//fin método BuscarPreguntaO


        //método para obtener el ID Máximo de la tabla LetraO.

        public int GetMaximoIdLetraO()
        {
            //Se recuperan todos los personajes
            List<LetraO> lista = this.GetPreguntasO();
            return lista.Count + 1;
        }//Fin método GetMaximoIdLetra

        //Método para insertar en Realm las preguntas de la letra O.
        //Obteniendo el último id disponible.

        public void InsertarPreguntaO(LetraO letraO)
        {
            transactionO = conexionRealm.BeginWrite();
            //letraA.idLetraA = this.GetMaximoIdLetraA();
            var entry = conexionRealm.Add(letraO);
            transactionO.Commit();

        }//Fin metodo InsertarPregunta




    }
}
