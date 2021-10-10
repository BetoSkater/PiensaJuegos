using PiensaJuegos.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiensaJuegos.Repositories
{
    class RepositoryF
    {



        private Realm conexionRealm;

        Transaction transactionF;

        public RepositoryF()
        {


            //Creación del objeto de conexión.

            this.conexionRealm = Realm.GetInstance();

        }//Fin Constructor


        //Método para devolver todas los objetos de la LetraF

        public List<LetraF> GetPreguntasF()
        {
            List<LetraF> listaF = this.conexionRealm.All<LetraF>().ToList();

            return listaF;
        }//Fin GetPreguntasF



        //Método para buscar una pregunta por su Id.

        public LetraF BuscarPreguntaF(int idPreguntaF)
        {
            //Se recuperan todas las preguntas:
            List<LetraF> lista = this.GetPreguntasF();

            //Busqueda de la pregunta en concreto:

            LetraF letraF = lista.FirstOrDefault(z => z.idLetraF == idPreguntaF);

            return letraF;

        }//fin método BuscarPreguntaA


        //método para obtener el ID Máximo de la tabla LetraA.

        public int GetMaximoIdLetraF()
        {
            //Se recuperan todos los personajes
            List<LetraF> lista = this.GetPreguntasF();
            return lista.Count + 1;
        }//Fin método GetMaximoIdLetra

        //Método para insertar en Realm las preguntas de la letra F.
        //Obteniendo el último id disponible.

        public void InsertarPreguntaF(LetraF letraF)
        {
            transactionF = conexionRealm.BeginWrite();
            //No es necesario meter aqui lo de get id ya que se puede hacer desde el  cs de inicio y queda chulo.
            var entry = conexionRealm.Add(letraF);
            transactionF.Commit();

        }//Fin metodo InsertarPregunta







    }
}
