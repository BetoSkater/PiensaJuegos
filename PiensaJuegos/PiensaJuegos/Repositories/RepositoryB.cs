using PiensaJuegos.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiensaJuegos.Repositories
{
   
    class RepositoryB
    {
       
        private Realm conexionRealm;

        Transaction transactionB;

        public RepositoryB()
        {
            //Creación del objeto de conexión.

            this.conexionRealm = Realm.GetInstance();

        }//Fin Constructor


        //Método para devolver todas los objetos de la LetraA

        public List<LetraB> GetPreguntasB()
        {
            List<LetraB> listaB = this.conexionRealm.All<LetraB>().ToList();

            return listaB;
        }//Fin GetPreguntasA



        //Método para buscar una pregunta por su Id.

        public LetraB BuscarPreguntaB(int idPreguntaB)
        {
            //Se recuperan todas las preguntas:
            List<LetraB> lista = this.GetPreguntasB();

            //Busqueda de la pregunta en concreto:

            LetraB letraB = lista.FirstOrDefault(z => z.idLetraB == idPreguntaB);

            return letraB;

        }//fin método BuscarPreguntaB


        //método para obtener el ID Máximo de la tabla LetraA.

        public int GetMaximoIdLetraB()
        {
            //Se recuperan todos los personajes
            List<LetraB> lista = this.GetPreguntasB();
            return lista.Count + 1;
        }//Fin método GetMaximoIdLetra

        //Método para insertar en Realm las preguntas de la letra A.
        //Obteniendo el último id disponible.
        public void InsertarPreguntaB(LetraB letraB)
        {
            transactionB = conexionRealm.BeginWrite();
            //letraB.idLetraB = this.GetMaximoIdLetraB();
            var entry = conexionRealm.Add(letraB);
            transactionB.Commit();

        }//Fin metodo InsertarPreguntaB









    }
}
