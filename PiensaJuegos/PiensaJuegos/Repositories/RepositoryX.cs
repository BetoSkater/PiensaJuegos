using PiensaJuegos.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiensaJuegos.Repositories
{
    class RepositoryX
    {

        private Realm conexionRealm;

        Transaction transactionX;

        public RepositoryX()
        {


            //Creación del objeto de conexión.

            this.conexionRealm = Realm.GetInstance();

        }//Fin Constructor


        //Método para devolver todas los objetos de la LetraX

        public List<LetraX> GetPreguntasX()
        {
            List<LetraX> listaX = this.conexionRealm.All<LetraX>().ToList();

            return listaX;
        }//Fin GetPreguntasX



        //Método para buscar una pregunta por su Id.

        public LetraX BuscarPreguntaX(int idPreguntaX)
        {
            //Se recuperan todas las preguntas:
            List<LetraX> lista = this.GetPreguntasX();

            //Busqueda de la pregunta en concreto:

            LetraX letraX = lista.FirstOrDefault(z => z.idLetraX == idPreguntaX);

            return letraX;

        }//fin método BuscarPreguntaX


        //método para obtener el ID Máximo de la tabla LetraX.

        public int GetMaximoIdLetraX()
        {
            //Se recuperan todos los personajes
            List<LetraX> lista = this.GetPreguntasX();
            return lista.Count + 1;
        }//Fin método GetMaximoIdLetra

        //Método para insertar en Realm las preguntas de la letra X.
        //Obteniendo el último id disponible.

        public void InsertarPreguntaX(LetraX letraX)
        {
            transactionX = conexionRealm.BeginWrite();
            //letraA.idLetraA = this.GetMaximoIdLetraA();
            var entry = conexionRealm.Add(letraX);
            transactionX.Commit();

        }//Fin metodo InsertarPregunta














    }
}
