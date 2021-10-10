using PiensaJuegos.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiensaJuegos.Repositories
{
    class RepositoryG
    {

        private Realm conexionRealm;

        Transaction transactionG;

        public RepositoryG()
        {


            //Creación del objeto de conexión.

            this.conexionRealm = Realm.GetInstance();

        }//Fin Constructor


        //Método para devolver todas los objetos de la LetraG

        public List<LetraG> GetPreguntasG()
        {
            List<LetraG> listaG = this.conexionRealm.All<LetraG>().ToList();

            return listaG;
        }//Fin GetPreguntasG



        //Método para buscar una pregunta por su Id.

        public LetraG BuscarPreguntaG(int idPreguntaG)
        {
            //Se recuperan todas las preguntas:
            List<LetraG> lista = this.GetPreguntasG();

            //Busqueda de la pregunta en concreto:

            LetraG letraG = lista.FirstOrDefault(z => z.idLetraG == idPreguntaG);

            return letraG;

        }//fin método BuscarPreguntaG


        //método para obtener el ID Máximo de la tabla LetraG.

        public int GetMaximoIdLetraG()
        {
            //Se recuperan todos los personajes
            List<LetraG> lista = this.GetPreguntasG();
            return lista.Count + 1;
        }//Fin método GetMaximoIdLetra

        //Método para insertar en Realm las preguntas de la letra G.
        //Obteniendo el último id disponible.

        public void InsertarPreguntaG(LetraG letraG)
        {
            transactionG = conexionRealm.BeginWrite();
            //letraA.idLetraA = this.GetMaximoIdLetraA();
            var entry = conexionRealm.Add(letraG);
            transactionG.Commit();

        }//Fin metodo InsertarPregunta










    }
}
