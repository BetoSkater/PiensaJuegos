using PiensaJuegos.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiensaJuegos.Repositories
{
    class RepositoryZ
    {

        private Realm conexionRealm;

        Transaction transactionZ;

        public RepositoryZ()
        {


            //Creación del objeto de conexión.

            this.conexionRealm = Realm.GetInstance();

        }//Fin Constructor


        //Método para devolver todas los objetos de la LetraZ

        public List<LetraZ> GetPreguntasZ()
        {
            List<LetraZ> listaZ = this.conexionRealm.All<LetraZ>().ToList();

            return listaZ;
        }//Fin GetPreguntasZ



        //Método para buscar una pregunta por su Id.

        public LetraZ BuscarPreguntaZ(int idPreguntaZ)
        {
            //Se recuperan todas las preguntas:
            List<LetraZ> lista = this.GetPreguntasZ();

            //Busqueda de la pregunta en concreto:

            LetraZ letraZ = lista.FirstOrDefault(z => z.idLetraZ == idPreguntaZ);

            return letraZ;

        }//fin método BuscarPreguntaZ


        //método para obtener el ID Máximo de la tabla LetraZ.

        public int GetMaximoIdLetraZ()
        {
            //Se recuperan todos los personajes
            List<LetraZ> lista = this.GetPreguntasZ();
            return lista.Count + 1;
        }//Fin método GetMaximoIdLetra

        //Método para insertar en Realm las preguntas de la letra Z.
        //Obteniendo el último id disponible.

        public void InsertarPreguntaZ(LetraZ letraZ)
        {
            transactionZ = conexionRealm.BeginWrite();
            //letraA.idLetraA = this.GetMaximoIdLetraA();
            var entry = conexionRealm.Add(letraZ);
            transactionZ.Commit();

        }//Fin metodo InsertarPregunta

        //TODO HE TERMINADO LOS REPOSITORIOS, TOCA CONTINUAR CON LOS LETRAXVIEWMODEL






    }
}
