using PiensaJuegos.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiensaJuegos.Repositories
{
    class RepositoryE
    {
        private Realm conexionRealm;

        Transaction transactionE;

        public RepositoryE()
        {

            //Creación del objeto de conexión.

            this.conexionRealm = Realm.GetInstance();

        }//Fin Constructor




        //Método para devolver todas los objetos de la LetraA

        public List<LetraE> GetPreguntasE()
        {
            List<LetraE> listaE = this.conexionRealm.All<LetraE>().ToList();

            return listaE;
        }//Fin GetPreguntasE



        //Método para buscar una pregunta por su Id.

        public LetraE BuscarPreguntaE(int idPreguntaE)
        {
            //Se recuperan todas las preguntas:
            List<LetraE> lista = this.GetPreguntasE();

            //Busqueda de la pregunta en concreto:

            LetraE letraE = lista.FirstOrDefault(z => z.idLetraE == idPreguntaE);

            return letraE;

        }//fin método BuscarPreguntaE


        //método para obtener el ID Máximo de la tabla LetraA.

        public int GetMaximoIdLetraE()
        {
            //Se recuperan todos los personajes
            List<LetraE> lista = this.GetPreguntasE();
            return lista.Count + 1;
        }//Fin método GetMaximoIdLetra

        //Método para insertar en Realm las preguntas de la letra E.
        //Obteniendo el último id disponible.
        public void InsertarPreguntaE(LetraE letraE)
        {
            transactionE = conexionRealm.BeginWrite();
            //letraE.idLetraE = this.GetMaximoIdLetraA();
            var entry = conexionRealm.Add(letraE);
            transactionE.Commit();

        }//Fin metodo InsertarPregunta






    }
}
