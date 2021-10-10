using PiensaJuegos.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiensaJuegos.Repositories
{
    class RepositoryI
    {
        private Realm conexionRealm;

        Transaction transactionI;

        public RepositoryI()
        {

            //Creación del objeto de conexión.

            this.conexionRealm = Realm.GetInstance();

        }//Fin Constructor


        //Método para devolver todas los objetos de la LetraI

        public List<LetraI> GetPreguntasI()
        {
            List<LetraI> listaI = this.conexionRealm.All<LetraI>().ToList();

            return listaI;
        }//Fin GetPreguntasI



        //Método para buscar una pregunta por su Id.

        public LetraI BuscarPreguntaI(int idPreguntaI)
        {
            //Se recuperan todas las preguntas:
            List<LetraI> lista = this.GetPreguntasI();

            //Busqueda de la pregunta en concreto:

            LetraI letraI = lista.FirstOrDefault(z => z.idLetraI == idPreguntaI);

            return letraI;

        }//fin método BuscarPreguntaA


        //método para obtener el ID Máximo de la tabla LetraA.

        public int GetMaximoIdLetraI()
        {
            //Se recuperan todos los personajes
            List<LetraI> lista = this.GetPreguntasI();
            return lista.Count + 1;
        }//Fin método GetMaximoIdLetra

        //Método para insertar en Realm las preguntas de la letra A.
        //Obteniendo el último id disponible.

        public void InsertarPreguntaI(LetraI letraI)
        {
            transactionI = conexionRealm.BeginWrite();
            //letraA.idLetraA = this.GetMaximoIdLetraA();
            var entry = conexionRealm.Add(letraI);
            transactionI.Commit();

        }//Fin metodo InsertarPregunta









    }
}
