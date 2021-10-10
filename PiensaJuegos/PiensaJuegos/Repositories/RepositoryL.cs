using PiensaJuegos.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiensaJuegos.Repositories
{
    class RepositoryL
    {


        private Realm conexionRealm;

        Transaction transactionL;

        public RepositoryL()
        {


            //Creación del objeto de conexión.

            this.conexionRealm = Realm.GetInstance();

        }//Fin Constructor


        //Método para devolver todas los objetos de la LetraL

        public List<LetraL> GetPreguntasL()
        {
            List<LetraL> listaL = this.conexionRealm.All<LetraL>().ToList();

            return listaL;
        }//Fin GetPreguntasL



        //Método para buscar una pregunta por su Id.

        public LetraL BuscarPreguntaL(int idPreguntaL)
        {
            //Se recuperan todas las preguntas:
            List<LetraL> lista = this.GetPreguntasL();

            //Busqueda de la pregunta en concreto:

            LetraL letraL = lista.FirstOrDefault(z => z.idLetraL == idPreguntaL);

            return letraL;

        }//fin método BuscarPreguntaL


        //método para obtener el ID Máximo de la tabla LetraA.

        public int GetMaximoIdLetraL()
        {
            //Se recuperan todos los personajes
            List<LetraL> lista = this.GetPreguntasL();
            return lista.Count + 1;
        }//Fin método GetMaximoIdLetra

        //Método para insertar en Realm las preguntas de la letra L.
        //Obteniendo el último id disponible.

        public void InsertarPreguntaL(LetraL letraL)
        {
            transactionL = conexionRealm.BeginWrite();
            //letraA.idLetraA = this.GetMaximoIdLetraA();
            var entry = conexionRealm.Add(letraL);
            transactionL.Commit();

        }//Fin metodo InsertarPregunta




    }
}
