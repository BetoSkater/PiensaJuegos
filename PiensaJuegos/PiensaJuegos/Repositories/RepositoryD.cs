using PiensaJuegos.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiensaJuegos.Repositories
{
    class RepositoryD
    {
        private Realm conexionRealm;

        Transaction transactionD;

        public RepositoryD()
        {

            //Creación del objeto de conexión.

            this.conexionRealm = Realm.GetInstance();

        }//Fin Constructor



        //Método para devolver todas los objetos de la LetraA

        public List<LetraD> GetPreguntasD()
        {
            List<LetraD> listaD = this.conexionRealm.All<LetraD>().ToList();

            return listaD;
        }//Fin GetPreguntasD



        //Método para buscar una pregunta por su Id.

        public LetraD BuscarPreguntaD(int idPreguntaD)
        {
            //Se recuperan todas las preguntas:
            List<LetraD> lista = this.GetPreguntasD();

            //Busqueda de la pregunta en concreto:

            LetraD letraD = lista.FirstOrDefault(z => z.idLetraD == idPreguntaD);

            return letraD;

        }//fin método BuscarPreguntaD


        //método para obtener el ID Máximo de la tabla LetraD.

        public int GetMaximoIdLetraD()
        {
            //Se recuperan todos los personajes
            List<LetraD> lista = this.GetPreguntasD();
            return lista.Count + 1;
        }//Fin método GetMaximoIdLetra

        //Método para insertar en Realm las preguntas de la letra A.
        //Obteniendo el último id disponible.
        public void InsertarPreguntaD(LetraD letraD)
        {
            transactionD = conexionRealm.BeginWrite();
            //letraD.idLetraD = this.GetMaximoIdLetraD();
            var entry = conexionRealm.Add(letraD);
            transactionD.Commit();

        }//Fin metodo InsertarPregunta









    }
}
