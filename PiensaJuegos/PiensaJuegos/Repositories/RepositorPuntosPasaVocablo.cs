using PiensaJuegos.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiensaJuegos.Repositories
{
     class RepositorPuntosPasaVocablo
    {

        private Realm conexionRealm;

        Transaction transactionPuntuaciones;

        public RepositorPuntosPasaVocablo()
        {

            //Creación del objeto de conexión.

            this.conexionRealm = Realm.GetInstance();

        }//Fin Constructor


        //Método para devolver todas los objetos de la LetraA

        public List<PuntosPasaVocablo> GetPuntuaciones()
        {
            List<PuntosPasaVocablo> listaPuntos = conexionRealm.All<PuntosPasaVocablo>().OrderBy(a => a.posicion).ToList();

            return listaPuntos;
        }//Fin GetPuntuaciones

        public List<PuntosPasaVocablo> GetPuntuacionesLimit10AndOrderbyPuntuacion()
        {
            List<PuntosPasaVocablo> listaPuntos = conexionRealm.All<PuntosPasaVocablo>().ToList().OrderByDescending(a => a.puntuacion).Take(10).ToList();
            using (var trans = this.conexionRealm.BeginWrite())
            {
                for (int i = 0; i < listaPuntos.Count; i++)
                {
                    listaPuntos[i].posicion = i + 1;
                }

                trans.Commit();
            }
           
            return listaPuntos;

        }//Fin GetPuntuaciones


        //Método para insertar en Realm las puntuaciones


        public void InsertarPuntuacion(PuntosPasaVocablo puntos)
        {
            using (var trans = conexionRealm.BeginWrite())
            {
                var entry = conexionRealm.Add(puntos);
                trans.Commit();
            }

        }//Fin metodo InsertarPregunta

        //Método para buscar una puntuación:

        public PuntosPasaVocablo BuscarPuntuacion(int id)
        {
            //Recuperacion de las puntuaciones para buscar en dicho array:
            List<PuntosPasaVocablo> listaAuxi = this.GetPuntuaciones();

            //Bsuqueda: 

            PuntosPasaVocablo auxPuntos = listaAuxi.FirstOrDefault(z => z.posicion == id);

            return auxPuntos;
        }

        //Método para modificar una puntuación:
        public void ModificarPosicion(PuntosPasaVocablo puntuacion)
        {
            PuntosPasaVocablo puntuacionModificar = this.BuscarPuntuacion(puntuacion.posicion);

            //Una vez localizado se modifica:

            using (var transa = this.conexionRealm.BeginWrite())
            {
                puntuacionModificar.posicion += 1;
                transa.Commit();
            }
        }

        //Método para eliminar la ultima posición: 

        public void EliminarUndecimaPuntuacion(PuntosPasaVocablo puntuacion)
        {
            int localizacion = 11; //Undecima posicion (los valores de la tabla en teoria van del 1 al 11 tras haber insertado el valor)

            PuntosPasaVocablo auxEliminar = BuscarPuntuacion(localizacion);

            using (var trans = this.conexionRealm.BeginWrite())
            {
                this.conexionRealm.Remove(auxEliminar);
                trans.Commit();
            }
        

        }

        //Eliminar las diez primeras puntuaciones (es decir, todas)

        public void EliminarPuntuaciones(PuntosPasaVocablo tuplaBorrar) {

            

            using (var trans = this.conexionRealm.BeginWrite())
            {
                this.conexionRealm.Remove(tuplaBorrar);
                trans.Commit();
            }

        }

        //Método para eliminar todas las filas de la tabla:

        public void EliminarRegistros() //No usar, elimina los registros de toda la base de datos.
        {
            transactionPuntuaciones = conexionRealm.BeginWrite();

            conexionRealm.RemoveAll();
            transactionPuntuaciones.Commit();
        }

    }
}
