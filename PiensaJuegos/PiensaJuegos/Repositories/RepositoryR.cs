using PiensaJuegos.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiensaJuegos.Repositories
{
    class RepositoryR
    {


        private Realm conexionRealm;

        Transaction transactionR;

        public RepositoryR()
        {


            //Creación del objeto de conexión.

            this.conexionRealm = Realm.GetInstance();

        }//Fin Constructor


        //Método para devolver todas los objetos de la LetraR

        public List<LetraR> GetPreguntasR()
        {
            List<LetraR> listaR = this.conexionRealm.All<LetraR>().ToList();

            return listaR;
        }//Fin GetPreguntasR



        //Método para buscar una pregunta por su Id.

        public LetraR BuscarPreguntaR(int idPreguntaR)
        {
            //Se recuperan todas las preguntas:
            List<LetraR> lista = this.GetPreguntasR();

            //Busqueda de la pregunta en concreto:

            LetraR letraR = lista.FirstOrDefault(z => z.idLetraR == idPreguntaR);

            return letraR;

        }//fin método BuscarPreguntaR


        //método para obtener el ID Máximo de la tabla LetraR.

        public int GetMaximoIdLetraR()
        {
            //Se recuperan todos los personajes
            List<LetraR> lista = this.GetPreguntasR();
            return lista.Count + 1;
        }//Fin método GetMaximoIdLetra

        //Método para insertar en Realm las preguntas de la letra R.
        //Obteniendo el último id disponible.

        public void InsertarPreguntaR(LetraR letraR)
        {
            transactionR = conexionRealm.BeginWrite();
            //letraA.idLetraA = this.GetMaximoIdLetraA();
            var entry = conexionRealm.Add(letraR);
            transactionR.Commit();

        }//Fin metodo InsertarPregunta




    }
}
