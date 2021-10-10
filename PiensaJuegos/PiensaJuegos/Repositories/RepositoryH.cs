using PiensaJuegos.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiensaJuegos.Repositories
{
    class RepositoryH
    {

        private Realm conexionRealm;

        Transaction transactionH;

        public RepositoryH()
        {

            //Creación del objeto de conexión.

            this.conexionRealm = Realm.GetInstance();

        }//Fin Constructor


        //Método para devolver todas los objetos de la LetraH

        public List<LetraH> GetPreguntasH()
        {
            List<LetraH> listaH = this.conexionRealm.All<LetraH>().ToList();

            return listaH;
        }//Fin GetPreguntasH



        //Método para buscar una pregunta por su Id.

        public LetraH BuscarPreguntaH(int idPreguntaH)
        {
            //Se recuperan todas las preguntas:
            List<LetraH> lista = this.GetPreguntasH();

            //Busqueda de la pregunta en concreto:

            LetraH letraH = lista.FirstOrDefault(z => z.idLetraH == idPreguntaH);

            return letraH;

        }//fin método BuscarPreguntaH


        //método para obtener el ID Máximo de la tabla LetraH.

        public int GetMaximoIdLetraH()
        {
            //Se recuperan todos los personajes
            List<LetraH> lista = this.GetPreguntasH();
            return lista.Count + 1;
        }//Fin método GetMaximoIdLetra

        //Método para insertar en Realm las preguntas de la letra H.
        //Obteniendo el último id disponible.

        public void InsertarPreguntaH(LetraH letraH)
        {
            transactionH = conexionRealm.BeginWrite();
            //letraA.idLetraA = this.GetMaximoIdLetraA();
            var entry = conexionRealm.Add(letraH);
            transactionH.Commit();

        }//Fin metodo InsertarPregunta






    }
}
