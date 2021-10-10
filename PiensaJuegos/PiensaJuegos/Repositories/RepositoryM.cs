using PiensaJuegos.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiensaJuegos.Repositories
{
   
    class RepositoryM
    {
        private Realm conexionRealm;

        Transaction transactionM;

        public RepositoryM()
        {

            //Creación del objeto de conexión.

            this.conexionRealm = Realm.GetInstance();

        }//Fin Constructor


        //Método para devolver todas los objetos de la LetraA

        public List<LetraM> GetPreguntasM()
        {
            List<LetraM> listaM = this.conexionRealm.All<LetraM>().ToList();

            return listaM;
        }//Fin GetPreguntasM



        //Método para buscar una pregunta por su Id.

        public LetraM BuscarPreguntaM(int idPreguntaM)
        {
            //Se recuperan todas las preguntas:
            List<LetraM> lista = this.GetPreguntasM();

            //Busqueda de la pregunta en concreto:

            LetraM letraM = lista.FirstOrDefault(z => z.idLetraM == idPreguntaM);

            return letraM;

        }//fin método BuscarPreguntaA


        //método para obtener el ID Máximo de la tabla LetraA.

        public int GetMaximoIdLetraM()
        {
            //Se recuperan todos los personajes
            List<LetraM> lista = this.GetPreguntasM();
            return lista.Count + 1;
        }//Fin método GetMaximoIdLetra

        //Método para insertar en Realm las preguntas de la letra M.
        //Obteniendo el último id disponible.

        public void InsertarPreguntaM(LetraM letraM)
        {
            transactionM = conexionRealm.BeginWrite();
            //letraA.idLetraA = this.GetMaximoIdLetraA();
            var entry = conexionRealm.Add(letraM);
            transactionM.Commit();

        }//Fin metodo InsertarPregunta


    }
}
