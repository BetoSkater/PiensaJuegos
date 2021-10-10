using PiensaJuegos.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiensaJuegos.Repositories
{
    class RepositoryNie
    {


        private Realm conexionRealm;

        Transaction transactionNie;

        public RepositoryNie()
        {


            //Creación del objeto de conexión.

            this.conexionRealm = Realm.GetInstance();

        }//Fin Constructor


        //Método para devolver todas los objetos de la LetraNie

        public List<LetraNie> GetPreguntasNie()
        {
            List<LetraNie> listaNie = this.conexionRealm.All<LetraNie>().ToList();

            return listaNie;
        }//Fin GetPreguntasNie



        //Método para buscar una pregunta por su Id.

        public LetraNie BuscarPreguntaNie(int idPreguntaNie)
        {
            //Se recuperan todas las preguntas:
            List<LetraNie> lista = this.GetPreguntasNie();

            //Busqueda de la pregunta en concreto:

            LetraNie letraNie = lista.FirstOrDefault(z => z.idLetraNie == idPreguntaNie);

            return letraNie;

        }//fin método BuscarPreguntaNie


        //método para obtener el ID Máximo de la tabla LetraNie.

        public int GetMaximoIdLetraNie()
        {
            //Se recuperan todos los personajes
            List<LetraNie> lista = this.GetPreguntasNie();
            return lista.Count + 1;
        }//Fin método GetMaximoIdLetra

        //Método para insertar en Realm las preguntas de la letra Nie.
        //Obteniendo el último id disponible.

        public void InsertarPreguntaNie(LetraNie letraNie)
        {
            transactionNie = conexionRealm.BeginWrite();
            //letraA.idLetraA = this.GetMaximoIdLetraA();
            var entry = conexionRealm.Add(letraNie);
            transactionNie.Commit();

        }//Fin metodo InsertarPregunta




    }
}
