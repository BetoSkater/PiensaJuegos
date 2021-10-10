using PiensaJuegos.Models;
using PiensaJuegos.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PiensaJuegos.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VentanaCarga : ContentPage
    {
        //Variables Repository por cada letra:

        RepositoryA repoA;
        RepositoryB repoB;
        RepositoryC repoC;
        RepositoryD repoD;
        RepositoryE repoE;
        RepositoryF repoF;
        RepositoryG repoG;
        RepositoryH repoH;
        RepositoryI repoI;
        RepositoryJ repoJ;
        RepositoryK repoK;
        RepositoryL repoL;
        RepositoryM repoM;
        RepositoryN repoN;
        RepositoryNie repoNie;
        RepositoryO repoO;
        RepositoryP repoP;
        RepositoryQ repoQ;
        RepositoryR repoR;
        RepositoryS repoS;
        RepositoryT repoT;
        RepositoryU repoU;
        RepositoryV repoV;
        RepositoryW repoW;
        RepositoryX repoX;
        RepositoryY repoY;
        RepositoryZ repoZ;

        RepositorPuntosPasaVocablo repoPuntos; //TODO quitar

        public VentanaCarga()
        {
            InitializeComponent();


            //Asignaciones de los repositories:

            this.repoA = new RepositoryA();
            this.repoB = new RepositoryB();
            this.repoC = new RepositoryC();
            this.repoD = new RepositoryD();
            this.repoE = new RepositoryE();
            this.repoF = new RepositoryF();
            this.repoG = new RepositoryG();
            this.repoH = new RepositoryH();
            this.repoI = new RepositoryI();
            this.repoJ = new RepositoryJ();
            this.repoK = new RepositoryK();
            this.repoL = new RepositoryL();
            this.repoM = new RepositoryM();
            this.repoN = new RepositoryN();
            this.repoNie = new RepositoryNie();
            this.repoO = new RepositoryO();
            this.repoP = new RepositoryP();
            this.repoQ = new RepositoryQ();
            this.repoR = new RepositoryR();
            this.repoS = new RepositoryS();
            this.repoT = new RepositoryT();
            this.repoU = new RepositoryU();
            this.repoV = new RepositoryV();
            this.repoW = new RepositoryW();
            this.repoX = new RepositoryX();
            this.repoY = new RepositoryY();
            this.repoZ = new RepositoryZ();

            this.repoPuntos = new RepositorPuntosPasaVocablo(); //TODO quitar

            //Llamada a los métodos para la inserción de valores en las diversas tablas de la base de datos. 
            InicioInsertarTodasLasPreguntas();


            //Todo igual esta llamada la tengo que poner dentro del método InicioInsertarTodasLasPreguntas.

            //Modificar mas o menos con los tiempos de carga de la base de datos:

            DelayActionAsync(5000); //5 segundos



        }



        //Metodo de transición tras un periodo de tiempo:

        public async Task DelayActionAsync(int retraso)
        {
            await Task.Delay(retraso);

            await Navigation.PushAsync(new VentanaSeleccion());


        }//Fin DelayActionAsync

        //Método general para realizar todas las inserciones en la base de datos:

        public void InicioInsertarTodasLasPreguntas()
        {
            //TODO esto solo sirve de prueba:

            //Comprobación con arrays de las pregutnas: TODO borrar cuando sea necesario

            List<LetraA> pruebaA = repoA.GetPreguntasA();
            List<LetraB> pruebaB = repoB.GetPreguntasB();
            List<LetraC> pruebaC = repoC.GetPreguntasC();
            List<LetraD> pruebaD = repoD.GetPreguntasD();
            List<LetraE> pruebaE = repoE.GetPreguntasE();
            List<LetraF> pruebaF = repoF.GetPreguntasF();
            List<LetraG> pruebaG = repoG.GetPreguntasG();
            List<LetraH> pruebaH = repoH.GetPreguntasH();
            List<LetraI> pruebaI = repoI.GetPreguntasI();
            List<LetraJ> pruebaJ = repoJ.GetPreguntasJ();
            List<LetraK> pruebaK = repoK.GetPreguntasK();
            List<LetraL> pruebaL = repoL.GetPreguntasL();
            List<LetraM> pruebaM = repoM.GetPreguntasM();
            List<LetraN> pruebaN = repoN.GetPreguntasN();
            List<LetraNie> pruebaNie = repoNie.GetPreguntasNie();
            List<LetraO> pruebaO = repoO.GetPreguntasO();
            List<LetraP> pruebaP = repoP.GetPreguntasP();
            List<LetraQ> pruebaQ = repoQ.GetPreguntasQ();
            List<LetraR> pruebaR = repoR.GetPreguntasR();
            List<LetraS> pruebaS = repoS.GetPreguntasS();
            List<LetraT> pruebaT = repoT.GetPreguntasT();
            List<LetraU> pruebaU = repoU.GetPreguntasU();
            List<LetraV> pruebaV = repoV.GetPreguntasV();
            List<LetraW> pruebaW = repoW.GetPreguntasW();
            List<LetraX> pruebaX = repoX.GetPreguntasX();
            List<LetraY> pruebaY = repoY.GetPreguntasY();
            List<LetraZ> pruebaZ = repoZ.GetPreguntasZ();
            List<PuntosPasaVocablo> pruebaPuntos = repoPuntos.GetPuntuaciones(); //TODO sale nulo, RIP
            //Primero Se comprueba si existen valores en la base de datos. Sólo se comprueba con la tabla A.

            if (repoA.GetPreguntasA().Count == 0)
            {


                InicioInsertarPreguntasA();
                InicioInsertarPreguntasB();
                InicioInsertarPreguntasC();
                InicioInsertarPreguntasD();
                InicioInsertarPreguntasE();
                InicioInsertarPreguntasF();
                InicioInsertarPreguntasG();
                InicioInsertarPreguntasH();
                InicioInsertarPreguntasI();
                InicioInsertarPreguntasJ();
                InicioInsertarPreguntasK();
                InicioInsertarPreguntasL();
                InicioInsertarPreguntasM();
                InicioInsertarPreguntasN();
                InicioInsertarPreguntasNie();
                InicioInsertarPreguntasO();
                InicioInsertarPreguntasP();
                InicioInsertarPreguntasQ();
                InicioInsertarPreguntasR();
                InicioInsertarPreguntasS();
                InicioInsertarPreguntasT();
                InicioInsertarPreguntasU();
                InicioInsertarPreguntasV();
                InicioInsertarPreguntasW();
                InicioInsertarPreguntasX();
                InicioInsertarPreguntasY();
                InicioInsertarPreguntasZ();

                InsertarPuntuacionesPrueba(); //TODO ELIMINAR

            }


        }
        //Método para la insercción de Preguntas A:

        public void InicioInsertarPreguntasA()
        {
            //Pregunta 1:
            LetraA letraA1 = new LetraA();
            letraA1.idLetraA = repoA.GetMaximoIdLetraA();
            letraA1.preguntaA = "Con la A. Suspensión de partículas diminutas, sean sólidos o líqudos, en un gas.";
            letraA1.respuestaA = "Aerosol";
            //Se inserta la pregunta aqui para que las sucesivas preguntas objengan el Id actualizado:
            repoA.InsertarPreguntaA(letraA1);

            //Pregunta 2:

            LetraA letraA2 = new LetraA();
            letraA2.idLetraA = repoA.GetMaximoIdLetraA();
            letraA2.preguntaA = "Empieza por A. Sustancia orgánica con propiedades alcalinas.";
            letraA2.respuestaA = "Alcaloide";
            repoA.InsertarPreguntaA(letraA2);

            //Pregunta 3:

            LetraA letraA3 = new LetraA();
            letraA3.idLetraA = repoA.GetMaximoIdLetraA();
            letraA3.preguntaA = "Con la A. Medicamento que quíta el dolor.";
            letraA3.respuestaA = "Analgésico";
            repoA.InsertarPreguntaA(letraA3);

            //Pregunta 4:

            LetraA letraA4 = new LetraA();
            letraA4.idLetraA = repoA.GetMaximoIdLetraA();
            letraA4.preguntaA = "Empieza por A. Relativo a dar consejo o dictamen.";
            letraA4.respuestaA = "Asesorar";
            repoA.InsertarPreguntaA(letraA4);

            //Pregunta 5:

            LetraA letraA5 = new LetraA();
            letraA5.idLetraA = repoA.GetMaximoIdLetraA();
            letraA5.preguntaA = "Comienza con A. Presagio, anuncio, indicio de algo futuro.";
            letraA5.respuestaA = "Augurio";
            repoA.InsertarPreguntaA(letraA5);

        }//Fin método insertar pregutnas A.


        //Método para insertas las preguntas Letra B:

        public void InicioInsertarPreguntasB()
        {
            //Pregunta 1:

            LetraB letraB1 = new LetraB();
            letraB1.idLetraB = repoB.GetMaximoIdLetraB();
            letraB1.preguntaB = "Con la B. Dialecto de los asturianos.";
            letraB1.respuestaB = "Bable";
            repoB.InsertarPreguntaB(letraB1);

            //Pregunta 2:

            LetraB letraB2 = new LetraB();
            letraB2.idLetraB = repoB.GetMaximoIdLetraB();
            letraB2.preguntaB = "Comienza con B. Parrilla para asar carne.";
            letraB2.respuestaB = "Barbacoa";
            repoB.InsertarPreguntaB(letraB2);
            //Pregunta 3:

            LetraB letraB3 = new LetraB();
            letraB3.idLetraB = repoB.GetMaximoIdLetraB();
            letraB3.preguntaB = "Empieza por B. Roca volcánica de color negro verdoso.";
            letraB3.respuestaB = "Basalto";
            repoB.InsertarPreguntaB(letraB3);
            //Pregunta 4:

            LetraB letraB4 = new LetraB();
            letraB4.idLetraB = repoB.GetMaximoIdLetraB();
            letraB4.preguntaB = "Con la B. Elemento metaloide del sistema periódico con número atómico cinco.";
            letraB4.respuestaB = "Boro";
            repoB.InsertarPreguntaB(letraB4);
            //Pregunta 1:

            LetraB letraB5 = new LetraB();
            letraB5.idLetraB = repoB.GetMaximoIdLetraB();
            letraB5.preguntaB = "Empieza por B. Aguja imantada que marca la dirección del norte magnético.";
            letraB5.respuestaB = "Brújula";
            repoB.InsertarPreguntaB(letraB5);
        }//Fin metodo insertar preguntas Letra B.

        //Método para insertar preguntas LetraC.

        public void InicioInsertarPreguntasC()
        {
            //Pregunta 1:
            LetraC letraC1 = new LetraC();
            letraC1.idLetraC = repoC.GetMaximoIdLetraC();
            letraC1.preguntaC = "Comienza por C. Metal alcalinotérreo comúnmente conocido por su alta presencia en los huesos.";
            letraC1.respuestaC = "Calcio";
            repoC.InsertarPreguntaC(letraC1);

            //Pregunta 2:
            LetraC letraC2 = new LetraC();
            letraC2.idLetraC = repoC.GetMaximoIdLetraC();
            letraC2.preguntaC = "Con la C. Casa pequeña de construcción provisional.";
            letraC2.respuestaC = "Caseta";
            repoC.InsertarPreguntaC(letraC2);

            //Pregunta 3:
            LetraC letraC3 = new LetraC();
            letraC3.idLetraC = repoC.GetMaximoIdLetraC();
            letraC3.preguntaC = "Empieza por C. Vela de cera, larga y gruesa.";
            letraC3.respuestaC = "Cirio";
            repoC.InsertarPreguntaC(letraC3);

            //Pregunta 4:
            LetraC letraC4 = new LetraC();
            letraC4.idLetraC = repoC.GetMaximoIdLetraC();
            letraC4.preguntaC = "Con la C. Parte prominente y curvilínea cubierta de pelo sobre la cuenca del ojo.";
            letraC4.respuestaC = "Ceja";
            repoC.InsertarPreguntaC(letraC4);

            //Pregunta 5:
            LetraC letraC5 = new LetraC();
            letraC5.idLetraC = repoC.GetMaximoIdLetraC();
            letraC5.preguntaC = "Comienza por C. Cavidad subterránea.";
            letraC5.respuestaC = "Cueva";
            repoC.InsertarPreguntaC(letraC5);

        }//Fin método insertar preguntas letra C


        //Método para insertar preguntas letra D:

        public void InicioInsertarPreguntasD()
        {

            //Pregunta 1:
            LetraD letraD1 = new LetraD();
            letraD1.idLetraD = repoD.GetMaximoIdLetraD();
            letraD1.preguntaD = "Comienza por D. Isótopo estable del hidrógeno.";
            letraD1.respuestaD = "Deuterio";
            repoD.InsertarPreguntaD(letraD1);

            //Pregunta 2:
            LetraD letraD2 = new LetraD();
            letraD2.idLetraD = repoD.GetMaximoIdLetraD();
            letraD2.preguntaD = "Empieza por D. Acción de derribar.";
            letraD2.respuestaD = "Derribo";
            repoD.InsertarPreguntaD(letraD2);

            //Pregunta 3:
            LetraD letraD3 = new LetraD();
            letraD3.idLetraD = repoD.GetMaximoIdLetraD();
            letraD3.preguntaD = "Con la D. En la mitología romana se la conoce como la diosa de la caza, protectora de la Luna y de la naturaleza.";
            letraD3.respuestaD = "Diana";
            repoD.InsertarPreguntaD(letraD3);

            //Pregunta 4:
            LetraD letraD4 = new LetraD();
            letraD4.idLetraD = repoD.GetMaximoIdLetraD();
            letraD4.preguntaD = "Empieza por D. Sacerdote de los antiguos galos y celtas.";
            letraD4.respuestaD = "Druida";
            repoD.InsertarPreguntaD(letraD4);

            //Pregunta 5:
            LetraD letraD5 = new LetraD();
            letraD5.idLetraD = repoD.GetMaximoIdLetraD();
            letraD5.preguntaD = "Con la D. Montículo de arena movediza en desiertos y playas.";
            letraD5.respuestaD = "Duna";
            repoD.InsertarPreguntaD(letraD5);

        }//Fin método insertar preguntas letra D

        //Método para insertar preguntas letra E

        public void InicioInsertarPreguntasE()
        {
            //Pregunta 1
            LetraE letraE1 = new LetraE();
            letraE1.idLetraE = repoE.GetMaximoIdLetraE();
            letraE1.preguntaE = "Comienza por E. Elemento sintético del sistema periódico perteneciente al periodo de los actínidos nombrado en honor a Albert Einstein.";
            letraE1.respuestaE = "Einstenio";
            repoE.InsertarPreguntaE(letraE1);

            //Pregunta 2:
            LetraE letraE2 = new LetraE();
            letraE2.idLetraE = repoE.GetMaximoIdLetraE();
            letraE2.preguntaE = "Con la E. Ocultar una cosa, tapar.";
            letraE2.respuestaE = "Encubrir";
            repoE.InsertarPreguntaE(letraE2);

            //Pregunta 3:
            LetraE letraE3 = new LetraE();
            letraE3.idLetraE = repoE.GetMaximoIdLetraE();
            letraE3.preguntaE = "Empieza por D. Mamífero insectívoro con el dorso y los costados cubiertos de púas, capaz de enrollarse en forma de bola.";
            letraE3.respuestaE = "Erizo";
            repoE.InsertarPreguntaE(letraE3);

            //Pregunta 4:
            LetraE letraE4 = new LetraE();
            letraE4.idLetraE = repoE.GetMaximoIdLetraE();
            letraE4.preguntaE = "Con la E. Elaboración culinaria cuya base es una variedad de hortalizas cortadas y aderezadas con una vinagreta o una salsa.";
            letraE4.respuestaE = "Ensalada";
            repoE.InsertarPreguntaE(letraE4);

            //Pregutna 5:
            LetraE letraE5 = new LetraE();
            letraE5.idLetraE = repoE.GetMaximoIdLetraE();
            letraE5.preguntaE = "Con la E. Rama de la filosofía que trata de la moral.";
            letraE5.respuestaE = "Ética";
            repoE.InsertarPreguntaE(letraE5);



        }//Fin método insertar preguntas letra E

        //Método para insertar preguntas letra F
        public void InicioInsertarPreguntasF()
        {
            //Pregunta 1
            LetraF letraF1 = new LetraF();
            letraF1.idLetraF = repoF.GetMaximoIdLetraF();
            letraF1.preguntaF = "Con la F. Elemento químico más electronegativo del sistema periódico.";
            letraF1.respuestaF = "Fluor";
            repoF.InsertarPreguntaF(letraF1);

            //Pregunta 2:
            LetraF letraF2 = new LetraF();
            letraF2.idLetraF = repoF.GetMaximoIdLetraF();
            letraF2.preguntaF = "Con la F. Potaje de alubias o habas con tocino y morcilla.";
            letraF2.respuestaF = "Fabada";
            repoF.InsertarPreguntaF(letraF2);

            //Pregunta 3:
            LetraF letraF3 = new LetraF();
            letraF3.idLetraF = repoF.GetMaximoIdLetraF();
            letraF3.preguntaF = "Comienza por F. Deslealtad.";
            letraF3.respuestaF = "Felonía";
            repoF.InsertarPreguntaF(letraF3);

            //Pregunta 4:
            LetraF letraF4 = new LetraF();
            letraF4.idLetraF = repoF.GetMaximoIdLetraF();
            letraF4.preguntaF = "Empieza por F. Juego entre dos equipos, cada uno de los cuales, impulsando un balón con los pies, trata de hacerlo pasar por la meta contraria.";
            letraF4.respuestaF = "Fútbol";
            repoF.InsertarPreguntaF(letraF4);

            //Pregutna 5:
            LetraF letraF5 = new LetraF();
            letraF5.idLetraF = repoF.GetMaximoIdLetraF();
            letraF5.preguntaF = "Con la F. Abundante en árboles que forman espesura.";
            letraF5.respuestaF = "Frondoso";
            repoF.InsertarPreguntaF(letraF5);
        }//Fin método insertar preguntas letra F

        //Método para insertar preguntas letra G
        public void InicioInsertarPreguntasG()
        {
            //Pregunta 1:
            LetraG letraG1 = new LetraG();
            letraG1.idLetraG = repoG.GetMaximoIdLetraG();
            letraG1.preguntaG = "Con la G. Metal semiconductor muy utilizado en electrónica.";
            letraG1.respuestaG = "Germanio";
            repoG.InsertarPreguntaG(letraG1);
            //Pregunta 2:
            LetraG letraG2 = new LetraG();
            letraG2.idLetraG = repoG.GetMaximoIdLetraG();
            letraG2.preguntaG = "Empieza con la G. En el fútbol, acto de introducir el balón en la portería.";
            letraG2.respuestaG = "Gol";
            repoG.InsertarPreguntaG(letraG2);
            //Pregunta 3:
            LetraG letraG3 = new LetraG();
            letraG3.idLetraG = repoG.GetMaximoIdLetraG();
            letraG3.preguntaG = "Comienza por G. Gran porción de mar que se interna en la tierra.";
            letraG3.respuestaG = "Golfo";
            repoG.InsertarPreguntaG(letraG3);
            //Pregunta 4:
            LetraG letraG4 = new LetraG();
            letraG4.idLetraG = repoG.GetMaximoIdLetraG();
            letraG4.preguntaG = "Con la G. Abono formado por el excremento de ciertas aves marinas.";
            letraG4.respuestaG = "Guano";
            repoG.InsertarPreguntaG(letraG4);
            //Pregunta 5:
            LetraG letraG5 = new LetraG();
            letraG5.idLetraG = repoG.GetMaximoIdLetraG();
            letraG5.preguntaG = "Empieza por G. Animal invertebrado, de cuerpo blando, cilindrico, alargado, contráctil y dividido en anillos.";
            letraG5.respuestaG = "Gusano";
            repoG.InsertarPreguntaG(letraG5);
        }//Fin método insertrar preguntas letras G

        //Metodo para introducir preguntas letra H
        public void InicioInsertarPreguntasH()
        {
            //Pregunta 1:
            LetraH letraH1 = new LetraH();
            letraH1.idLetraH = repoH.GetMaximoIdLetraH();
            letraH1.preguntaH = "Empieza por H. Primer elemento del sistema periódico.";
            letraH1.respuestaH = "Hidrógeno";
            repoH.InsertarPreguntaH(letraH1);
            //Pregunta 2:
            LetraH letraH2 = new LetraH();
            letraH2.idLetraH = repoH.GetMaximoIdLetraH();
            letraH2.preguntaH = "Comienza por H. Agua en estado sólido.";
            letraH2.respuestaH = "Hielo";
            repoH.InsertarPreguntaH(letraH2);
            //Pregunta 3:
            LetraH letraH3 = new LetraH();
            letraH3.idLetraH = repoH.GetMaximoIdLetraH();
            letraH3.preguntaH = "Con la H. Parte del cuerpo donde nace el brazo.";
            letraH3.respuestaH = "Hombro";
            repoH.InsertarPreguntaH(letraH3);
            //Pregunta 4:
            LetraH letraH4 = new LetraH();
            letraH4.idLetraH = repoH.GetMaximoIdLetraH();
            letraH4.preguntaH = "Comienza por H. Parte sólida y dura del esqueleto del esqueleto interior de los vertebrados.";
            letraH4.respuestaH = "Hueso";
            repoH.InsertarPreguntaH(letraH4);
            //Pregunta 5:
            LetraH letraH5 = new LetraH();
            letraH5.idLetraH = repoH.GetMaximoIdLetraH();
            letraH5.preguntaH = "Con la H. Mamífero carnicero que se emplea en la caza de conejos.";
            letraH5.respuestaH = "Hurón";
            repoH.InsertarPreguntaH(letraH5);

        }//Fin metodo insertar preguntas H

        //Método para insertar preguntas letra I

        public void InicioInsertarPreguntasI()
        {
            //Pregunta 1:
            LetraI letraI1 = new LetraI();
            letraI1.idLetraI = repoI.GetMaximoIdLetraI();
            letraI1.preguntaI = "Con la I. Metal de transción que se engloba dentro de los metales nobles.";
            letraI1.respuestaI = "Iridio";
            repoI.InsertarPreguntaI(letraI1);
            //Pregunta 2:
            LetraI letraI2 = new LetraI();
            letraI2.idLetraI = repoI.GetMaximoIdLetraI();
            letraI2.preguntaI = "Comienza con I. Burla fina y disimulada.";
            letraI2.respuestaI = "Ironía";
            repoI.InsertarPreguntaI(letraI2);
            //Pregunta 3:
            LetraI letraI3 = new LetraI();
            letraI3.idLetraI = repoI.GetMaximoIdLetraI();
            letraI3.preguntaI = "Con la I. Tercera parte del intestino delgado.";
            letraI3.respuestaI = "Íleon";
            repoI.InsertarPreguntaI(letraI3);
            //Pregunta 4:
            LetraI letraI4 = new LetraI();
            letraI4.idLetraI = repoI.GetMaximoIdLetraI();
            letraI4.preguntaI = "Comienza por I. Concerniente al imperio.";
            letraI4.respuestaI = "Imperial";
            repoI.InsertarPreguntaI(letraI4);
            //Pregunta 5:
            LetraI letraI5 = new LetraI();
            letraI5.idLetraI = repoI.GetMaximoIdLetraI();
            letraI5.preguntaI = "Empieza por I. Que carece de honra, despreciable.";
            letraI5.respuestaI = "Infame";
            repoI.InsertarPreguntaI(letraI5);
        }//Fin método insertar preguntas letra I

        //Método para la insercción de valores letra J:
        public void InicioInsertarPreguntasJ()
        {
            //Pregunta 1:
            LetraJ letraJ1 = new LetraJ();
            letraJ1.idLetraJ = repoJ.GetMaximoIdLetraJ();
            letraJ1.preguntaJ = "Con la J. Producto que se obtiene mediante la combinación de un álcali con una grasa y sirve para lavar.";
            letraJ1.respuestaJ = "Jabón";
            repoJ.InsertarPreguntaJ(letraJ1);
            //Pregunta 2:
            LetraJ letraJ2 = new LetraJ();
            letraJ2.idLetraJ = repoJ.GetMaximoIdLetraJ();
            letraJ2.preguntaJ = "Comienza por H. Dolor de cabeza intermitente.";
            letraJ2.respuestaJ = "Jaqueca";
            repoJ.InsertarPreguntaJ(letraJ2);
            //Pregunta 3:
            LetraJ letraJ3 = new LetraJ();
            letraJ3.idLetraJ = repoJ.GetMaximoIdLetraJ();
            letraJ3.preguntaJ = "Con la J. Jinete en las carreras de caballos.";
            letraJ3.respuestaJ = "Jockey";
            repoJ.InsertarPreguntaJ(letraJ3);
            //Pregunta 4:
            LetraJ letraJ4 = new LetraJ();
            letraJ4.idLetraJ = repoJ.GetMaximoIdLetraJ();
            letraJ4.preguntaJ = "Empieza por J. Planta júncea, con cañas o tallos delgados, flexibles, de color verde oscuro.";
            letraJ4.respuestaJ = "Junco";
            repoJ.InsertarPreguntaJ(letraJ4);
            //Pregunta 5:
            LetraJ letraJ5 = new LetraJ();
            letraJ5.idLetraJ = repoJ.GetMaximoIdLetraJ();
            letraJ5.preguntaJ = "Con la J. Planeta de mayor tamaño del sistema solar.";
            letraJ5.respuestaJ = "Júpiter";
            repoJ.InsertarPreguntaJ(letraJ5);
        }//Fin metodo insertar preguntas letra J

        //Metodo para insertar preguntas letra K
        public void InicioInsertarPreguntasK()
        {
            //Pregunta 1:
            LetraK letraK1 = new LetraK();
            letraK1.idLetraK = repoK.GetMaximoIdLetraK();
            letraK1.preguntaK = "Comienza por K. Túnica de vestir japonesa.";
            letraK1.respuestaK = "Kimono";
            repoK.InsertarPreguntaK(letraK1);
            //Pregunta 2:
            LetraK letraK2 = new LetraK();
            letraK2.idLetraK = repoK.GetMaximoIdLetraK();
            letraK2.preguntaK = "Comienza por K. Local de ocio en el que los clientes pueden interpretar canciones leyendo la letra en una pantalla.";
            letraK2.respuestaK = "Karaoke";
            repoK.InsertarPreguntaK(letraK2);
            //Pregunta 3:
            LetraK letraK3 = new LetraK();
            letraK3.idLetraK = repoK.GetMaximoIdLetraK();
            letraK3.preguntaK = "Comienza por K. Fruto de carne verdosa con piel vellosa y parda.";
            letraK3.respuestaK = "Kiwi";
            repoK.InsertarPreguntaK(letraK3);
            //Pregunta 4:
            LetraK letraK4 = new LetraK();
            letraK4.idLetraK = repoK.GetMaximoIdLetraK();
            letraK4.preguntaK = "Con la K. Prefijo que indica 1000 unidades.";
            letraK4.respuestaK = "Kilo";
            repoK.InsertarPreguntaK(letraK4);
            //Pregunta 5:
            LetraK letraK5 = new LetraK();
            letraK5.idLetraK = repoK.GetMaximoIdLetraK();
            letraK5.preguntaK = "Empieza por K. Establecimiento callejero especializado en la venta de presa.";
            letraK5.respuestaK = "Kiosco";
            repoK.InsertarPreguntaK(letraK5);
        }//Fin método insertar preguntas letra K

        //Método para insertar preguntas letra L
        public void InicioInsertarPreguntasL()
        {
            //Pregunta 1:
            LetraL letraL1 = new LetraL();
            letraL1.idLetraL = repoL.GetMaximoIdLetraL();
            letraL1.preguntaL = "Con la L. Elemento del grupo de los elementos alcalinos popularmente conocido por su uso en baterias y medicamentos.";
            letraL1.respuestaL = "Litio";
            repoL.InsertarPreguntaL(letraL1);
            //Pregunta 2:
            LetraL letraL2 = new LetraL();
            letraL2.idLetraL = repoL.GetMaximoIdLetraL();
            letraL2.preguntaL = "Comienza por L. Piedra llana enq ue ordinariamente se pone una inscripción.";
            letraL2.respuestaL = "Lápida";
            repoL.InsertarPreguntaL(letraL2);
            //Pregunta 3:
            LetraL letraL3 = new LetraL();
            letraL3.idLetraL = repoL.GetMaximoIdLetraL();
            letraL3.preguntaL = "Empieza por L. Lugar donde se reúnen los masones.";
            letraL3.respuestaL = "Logia";
            repoL.InsertarPreguntaL(letraL3);
            //Pregunta 4:
            LetraL letraL4 = new LetraL();
            letraL4.idLetraL = repoL.GetMaximoIdLetraL();
            letraL4.preguntaL = "Con la L. Claridad que irradian los cuerpos en combustión, ignición o incandescencia.";
            letraL4.respuestaL = "Luz";
            repoL.InsertarPreguntaL(letraL4);
            //Pregunta 5:
            LetraL letraL5 = new LetraL();
            letraL5.idLetraL = repoL.GetMaximoIdLetraL();
            letraL5.preguntaL = "Con la L. Caer agua de las nubes.";
            letraL5.respuestaL = "Llover";
            repoL.InsertarPreguntaL(letraL5);
        }//Fin método insertar preguntas letra L

        //Método para insetar preguntas letra M
        public void InicioInsertarPreguntasM()
        {
            //Pregunta 1:
            LetraM letraM1 = new LetraM();
            letraM1.idLetraM = repoM.GetMaximoIdLetraM();
            letraM1.preguntaM = "Con la M. Orgánulo de las células eucariontes en el que tiene lugar la respiración celular.";
            letraM1.respuestaM = "Mitocondria";
            repoM.InsertarPreguntaM(letraM1);
            //Pregunta 2:
            LetraM letraM2 = new LetraM();
            letraM2.idLetraM = repoM.GetMaximoIdLetraM();
            letraM2.preguntaM = "Empieza por M. Ciencia oculta que pretende obrar prodigios.";
            letraM2.respuestaM = "Magia";
            repoM.InsertarPreguntaM(letraM2);
            //Pregunta 3:
            LetraM letraM3 = new LetraM();
            letraM3.idLetraM = repoM.GetMaximoIdLetraM();
            letraM3.preguntaM = "Con la M. Grasa de los animales, especialmente la cel cerdo.";
            letraM3.respuestaM = "Manteca";
            repoM.InsertarPreguntaM(letraM3);
            //Pregunta 4:
            LetraM letraM4 = new LetraM();
            letraM4.idLetraM = repoM.GetMaximoIdLetraM();
            letraM4.preguntaM = "Comienza con M. Agregación de partículas o cosas que forman un cuerpo.";
            letraM4.respuestaM = "Masa";
            repoM.InsertarPreguntaM(letraM4);
            //Pregunta 5:
            LetraM letraM5 = new LetraM();
            letraM5.idLetraM = repoM.GetMaximoIdLetraM();
            letraM5.preguntaM = "Con la M. Cantidad de sustancia de un sistema que contiene tantas entidades elementales como átomos hay en 0,012 kilogramos de carbono 12.";
            letraM5.respuestaM = "Mol";
            repoM.InsertarPreguntaM(letraM5);
        }//Fin método insertar preguntas letra M

        //Metodo para la insercción de preguntas Letra N
        public void InicioInsertarPreguntasN()
        {
            //Pregunta 1:
            LetraN letraN1 = new LetraN();
            letraN1.idLetraN = repoN.GetMaximoIdLetraN();
            letraN1.preguntaN = "Con la N. Elemento no metálico presente en una gran cantidad de compuestos químicos, como por ejemplo, el amonio.";
            letraN1.respuestaN = "Nitrógeno";
            repoN.InsertarPreguntaN(letraN1);
            //Pregunta 2:
            LetraN letraN2 = new LetraN();
            letraN2.idLetraN = repoN.GetMaximoIdLetraN();
            letraN2.preguntaN = "Comienza por N. Persona que no se inclina hacia ninguna opción.";
            letraN2.respuestaN = "Neutral";
            repoN.InsertarPreguntaN(letraN2);
            //Pregunta 3:
            LetraN letraN3 = new LetraN();
            letraN3.idLetraN = repoN.GetMaximoIdLetraN();
            letraN3.preguntaN = "Empieza por N. Articulación de los dedos.";
            letraN3.respuestaN = "Nudillos";
            repoN.InsertarPreguntaN(letraN3);
            //Pregunta 4:
            LetraN letraN4 = new LetraN();
            letraN4.idLetraN = repoN.GetMaximoIdLetraN();
            letraN4.preguntaN = "Con la N. Que sigue en orden al octavo.";
            letraN4.respuestaN = "Noveno";
            repoN.InsertarPreguntaN(letraN4);
            //Pregunta 5:
            LetraN letraN5 = new LetraN();
            letraN5.idLetraN = repoN.GetMaximoIdLetraN();
            letraN5.preguntaN = "Comienza por N. Rama de la medicina que se encarga del estudio del sistema nervioso.";
            letraN5.respuestaN = "Neurología";
            repoN.InsertarPreguntaN(letraN5);
        }//Fin metodo insertar preguntas letra N.

        //Metodo insertar preguntas letra Ñ
        public void InicioInsertarPreguntasNie()
        {
            //Pregunta 1:
            LetraNie letraNie1 = new LetraNie();
            letraNie1.idLetraNie = repoNie.GetMaximoIdLetraNie();
            letraNie1.preguntaNie = "Comienza por Ñ. Pimiento pequeño y redondeado que se comercializa principalmente seco.";
            letraNie1.respuestaNie = "Ñora";
            repoNie.InsertarPreguntaNie(letraNie1);
            //Pregunta 2:
            LetraNie letraNie2 = new LetraNie();
            letraNie2.idLetraNie = repoNie.GetMaximoIdLetraNie();
            letraNie2.preguntaNie = "Contiene la Ñ. Vaso, generalmente de forma cilíndrica o ligeramente cónica, alto y estrecho, que se usa para beber vino o cerveza.";
            letraNie2.respuestaNie = "Caña";
            repoNie.InsertarPreguntaNie(letraNie2);
            //Pregunta 3:
            LetraNie letraNie3 = new LetraNie();
            letraNie3.idLetraNie = repoNie.GetMaximoIdLetraNie();
            letraNie3.preguntaNie = "Contiene la ÑFruto nutritivo y sabroso, del  tamaño de la nuez, y cubierto de una cáscara gruesa y correosa de color marrón oscuro.";
            letraNie3.respuestaNie = "Castaña";
            repoNie.InsertarPreguntaNie(letraNie3);
            //Pregunta 4:
            LetraNie letraNie4 = new LetraNie();
            letraNie4.idLetraNie = repoNie.GetMaximoIdLetraNie();
            letraNie4.preguntaNie = "Contiene la Ñ. Nombre común a varias especies de hongos agaricáceos, algunos de los cuales son comestibles.";
            letraNie4.respuestaNie = "Champiñón";
            repoNie.InsertarPreguntaNie(letraNie4);
            //Pregunta 5:
            LetraNie letraNie5 = new LetraNie();
            letraNie5.idLetraNie = repoNie.GetMaximoIdLetraNie();
            letraNie5.preguntaNie = "Contiene la Ñ. Intervalo de tiempo en el que la Tierra da una vuelta completa al rededor del Sol.";
            letraNie5.respuestaNie = "Año";
            repoNie.InsertarPreguntaNie(letraNie5);
        }//Fin insertar preguntas Letra Ñ

        //Método para insertar preguntas Letra O.
        public void InicioInsertarPreguntasO()
        {
            //Pregunta 1:
            LetraO letraO1 = new LetraO();
            letraO1.idLetraO = repoO.GetMaximoIdLetraO();
            letraO1.preguntaO = "Con la O. Comburente muy empleado en los procesos de combustión.";
            letraO1.respuestaO = "Oxígeno";
            repoO.InsertarPreguntaO(letraO1);
            //Pregunta 2:
            LetraO letraO2 = new LetraO();
            letraO2.idLetraO = repoO.GetMaximoIdLetraO();
            letraO2.preguntaO = "Empieza por O. Rama de la zoologia que estudia las aves.";
            letraO2.respuestaO = "Ornitología";
            repoO.InsertarPreguntaO(letraO2);
            //Pregunta 3:
            LetraO letraO3 = new LetraO();
            letraO3.idLetraO = repoO.GetMaximoIdLetraO();
            letraO3.preguntaO = "Comienza por O. Atrevimiento, audacia.";
            letraO3.respuestaO = "Osadía";
            repoO.InsertarPreguntaO(letraO3);
            //Pregunta 4:
            LetraO letraO4 = new LetraO();
            letraO4.idLetraO = repoO.GetMaximoIdLetraO();
            letraO4.preguntaO = "Con la O. Que impide el paso de la luz.";
            letraO4.respuestaO = "Opaco";
            repoO.InsertarPreguntaO(letraO4);
            //Pregunta 5:
            LetraO letraO5 = new LetraO();
            letraO5.idLetraO = repoO.GetMaximoIdLetraO();
            letraO5.preguntaO = "Comienza por O. Paraje con vegetación y manantiales en medio del desierto.";
            letraO5.respuestaO = "Oasis";
            repoO.InsertarPreguntaO(letraO5);
        }//Fin método insertar preguntas letra O

        //Metodo para insertar preguntas Letra P
        public void InicioInsertarPreguntasP()
        {
            //Pregunta 1:
            LetraP letraP1 = new LetraP();
            letraP1.idLetraP = repoP.GetMaximoIdLetraP();
            letraP1.preguntaP = "Con la P. Metal de transición englobado en los metales nobles muy usado en joyería cuya símbolo químico empieza por P.";
            letraP1.respuestaP = "Platino";
            repoP.InsertarPreguntaP(letraP1);
            //Pregunta 2:
            LetraP letraP2 = new LetraP();
            letraP2.idLetraP = repoP.GetMaximoIdLetraP();
            letraP2.preguntaP = "Comienza por P. Acción de tocar algo con las manos para reconocerlo.";
            letraP2.respuestaP = "Palpar";
            repoP.InsertarPreguntaP(letraP2);
            //Pregunta 3:
            LetraP letraP3 = new LetraP();
            letraP3.idLetraP = repoP.GetMaximoIdLetraP();
            letraP3.preguntaP = "Empieza por P. Marisco crustáceo cirrípedo con un pedúnculo carnoso comestible.";
            letraP3.respuestaP = "Percebe";
            repoP.InsertarPreguntaP(letraP3);
            //Pregunta 4:
            LetraP letraP4 = new LetraP();
            letraP4.idLetraP = repoP.GetMaximoIdLetraP();
            letraP4.preguntaP = "Comienza con P. Arma corta, ofensiva, de acero que solo hiere de punta.";
            letraP4.respuestaP = "Puñal.";
            repoP.InsertarPreguntaP(letraP4);
            //Pregunta 5:
            LetraP letraP5 = new LetraP();
            letraP5.idLetraP = repoP.GetMaximoIdLetraP();
            letraP5.preguntaP = "Con la P. Sacerdotisa de Apolo que daba los oráculos.";
            letraP5.respuestaP = "Pitonisa";
            repoP.InsertarPreguntaP(letraP5);
        }//Fin metodo insertar preguntas letra P

        //Método para insertar preguntas letra Q:

        public void InicioInsertarPreguntasQ()
        {
            //Pregunta 1:
            LetraQ letraQ1 = new LetraQ();
            letraQ1.idLetraQ = repoQ.GetMaximoIdLetraQ();
            letraQ1.preguntaQ = "Con la Q. Fracción del petróleo natural, obtenida por refinación y destilación, usada en el alumbrado y como combustible en los propulsores de chorro.";
            letraQ1.respuestaQ = "Queroseno";
            repoQ.InsertarPreguntaQ(letraQ1);
            //Pregunta 2:
            LetraQ letraQ2 = new LetraQ();
            letraQ2.idLetraQ = repoQ.GetMaximoIdLetraQ();
            letraQ2.preguntaQ = "Comienza por Q. Masa que se hace de la leche cuajada y privada de suero.";
            letraQ2.respuestaQ = "Queso";
            repoQ.InsertarPreguntaQ(letraQ2);
            //Pregunta 3:
            LetraQ letraQ3 = new LetraQ();
            letraQ3.idLetraQ = repoQ.GetMaximoIdLetraQ();
            letraQ3.preguntaQ = "Empieza por Q. Ciencia que estudia la composición interna de las sustancias y sus transformaciones.";
            letraQ3.respuestaQ = "Química";
            repoQ.InsertarPreguntaQ(letraQ3);
            //Pregunta 4:
            LetraQ letraQ4 = new LetraQ();
            letraQ4.idLetraQ = repoQ.GetMaximoIdLetraQ();
            letraQ4.preguntaQ = "Con la Q. Adivinación supersticiona a través de la lectura de la palma de la mano.";
            letraQ4.respuestaQ = "Quiromancia";
            repoQ.InsertarPreguntaQ(letraQ4);
            //Pregunta 5:
            LetraQ letraQ5 = new LetraQ();
            letraQ5.idLetraQ = repoQ.GetMaximoIdLetraQ();
            letraQ5.preguntaQ = "Con la Q. Romper, separar con violencia.";
            letraQ5.respuestaQ = "Quebrantar";
            repoQ.InsertarPreguntaQ(letraQ5);
        }//Fin insertar preguntas Letra Q

        //Metodo para insertar valores letra R

        public void InicioInsertarPreguntasR()
        {

            //Pregunta 1:
            LetraR letraR1 = new LetraR();
            letraR1.idLetraR = repoR.GetMaximoIdLetraR();
            letraR1.preguntaR = "Con la R. Elemento más pesado de los metales alcalinotérreos que destaca por sus propiedades radiactivas.";
            letraR1.respuestaR = "Radio";
            repoR.InsertarPreguntaR(letraR1);
            //Pregunta 2:
            LetraR letraR2 = new LetraR();
            letraR2.idLetraR = repoR.GetMaximoIdLetraR();
            letraR2.preguntaR = "Con la R. Hueso un poco más corto que el cúbito, con el cual forma el antebrazo.";
            letraR2.respuestaR = "Radio";
            repoR.InsertarPreguntaR(letraR2);
            //Pregunta 3:
            LetraR letraR3 = new LetraR();
            letraR3.idLetraR = repoR.GetMaximoIdLetraR();
            letraR3.preguntaR = "Con la R. Segmento lineal que une un punto cualquiera de la circunferencia o de la superficie de una esfera con su centro.";
            letraR3.respuestaR = "Radio";
            repoR.InsertarPreguntaR(letraR3);
            //Pregunta 4:
            LetraR letraR4 = new LetraR();
            letraR4.idLetraR = repoR.GetMaximoIdLetraR();
            letraR4.preguntaR = "Con la R. Aparato electrónico que permite captar ondas electromagnéticas de alta longitud de onda.";
            letraR4.respuestaR = "Radio";
            repoR.InsertarPreguntaR(letraR4);
            //Pregunta 5:
            LetraR letraR5 = new LetraR();
            letraR5.idLetraR = repoR.GetMaximoIdLetraR();
            letraR5.preguntaR = "Empieza por R. Instrumento para hilar.";
            letraR5.respuestaR = "Rueca";
            repoR.InsertarPreguntaR(letraR5);
        }//Fin metodo insertar preguntas Letra R

        //Metodo para insertar preguntas letra S
        public void InicioInsertarPreguntasS()
        {
            //Pregunta 1:
            LetraS letraS1 = new LetraS();
            letraS1.idLetraS = repoS.GetMaximoIdLetraS();
            letraS1.preguntaS = "Con la S. Elemento no metálico nombrado en honor de la Luna.";
            letraS1.respuestaS = "Selenio";
            repoS.InsertarPreguntaS(letraS1);
            //Pregunta 2:
            LetraS letraS2 = new LetraS();
            letraS2.idLetraS = repoS.GetMaximoIdLetraS();
            letraS2.preguntaS = "Comienza por S. Recipiente en el que se sirve la sal de mesa.";
            letraS2.respuestaS = "Salero";
            repoS.InsertarPreguntaS(letraS2);
            //Pregunta 3:
            LetraS letraS3 = new LetraS();
            letraS3.idLetraS = repoS.GetMaximoIdLetraS();
            letraS3.preguntaS = "Empieza por S. Adobar con sal y pimienta.";
            letraS3.respuestaS = "Salpimentar";
            repoS.InsertarPreguntaS(letraS3);
            //Pregunta 4:
            LetraS letraS4 = new LetraS();
            letraS4.idLetraS = repoS.GetMaximoIdLetraS();
            letraS4.preguntaS = "Con la S. Líquido coagulable que circula por venas y arterias.";
            letraS4.respuestaS = "Sangre";
            repoS.InsertarPreguntaS(letraS4);
            //Pregunta 5:
            LetraS letraS5 = new LetraS();
            letraS5.idLetraS = repoS.GetMaximoIdLetraS();
            letraS5.preguntaS = "Con la S. Materia que habiendo estado suspensa en un fluido, se posa en el fondo.";
            letraS5.respuestaS = "Sedimento";
            repoS.InsertarPreguntaS(letraS5);
        }//Fin método insertar preguntas Letra S

        //Método para insertar valores letra T
        public void InicioInsertarPreguntasT()
        {

            //Pregunta 1:
            LetraT letraT1 = new LetraT();
            letraT1.idLetraT = repoT.GetMaximoIdLetraT();
            letraT1.preguntaT = "Con la T. Metal de la primera serie de transición muy usado en implantes quirúrgicos.";
            letraT1.respuestaT = "Titanio";
            repoT.InsertarPreguntaT(letraT1);
            //Pregunta 2:
            LetraT letraT2 = new LetraT();
            letraT2.idLetraT = repoT.GetMaximoIdLetraT();
            letraT2.preguntaT = "Comienza por T. Palo grueso y fuerte.";
            letraT2.respuestaT = "Tranca";
            repoT.InsertarPreguntaT(letraT2);
            //Pregunta 3:
            LetraT letraT3 = new LetraT();
            letraT3.idLetraT = repoT.GetMaximoIdLetraT();
            letraT3.preguntaT = "Con la T. Mueble o utensilio inútil arrinconado en una casa.";
            letraT3.respuestaT = "Trasto";
            repoT.InsertarPreguntaT(letraT3);
            //Pregunta 4:
            LetraT letraT4 = new LetraT();
            letraT4.idLetraT = repoT.GetMaximoIdLetraT();
            letraT4.preguntaT = "Empieza por T. Lugar donde se administra justicia.";
            letraT4.respuestaT = "Tribunal";
            repoT.InsertarPreguntaT(letraT4);
            //Pregunta 5:
            LetraT letraT5 = new LetraT();
            letraT5.idLetraT = repoT.GetMaximoIdLetraT();
            letraT5.preguntaT = "Con la T. Periodo de tres años.";
            letraT5.respuestaT = "Trienio";
            repoT.InsertarPreguntaT(letraT5);
        }//Fin metodo insertar preguntas T
        //Metodo para insertar preguntas LetraU
        public void InicioInsertarPreguntasU()
        {

            //Pregunta 1:
            LetraU letraU1 = new LetraU();
            letraU1.idLetraU = repoU.GetMaximoIdLetraU();
            letraU1.preguntaU = "Comienza por U. Elemento químico metálico radiactivo usado en las centrales nucleares.";
            letraU1.respuestaU = "Uranio";
            repoU.InsertarPreguntaU(letraU1);
            //Pregunta 2:
            LetraU letraU2 = new LetraU();
            letraU2.idLetraU = repoU.GetMaximoIdLetraU();
            letraU2.preguntaU = "Con la U. Juntar dos o más cosas entre sí.";
            letraU2.respuestaU = "Unir";
            repoU.InsertarPreguntaU(letraU2);
            //Pregunta 3:
            LetraU letraU3 = new LetraU();
            letraU3.idLetraU = repoU.GetMaximoIdLetraU();
            letraU3.preguntaU = "Con la U. Fruto de la vid.";
            letraU3.respuestaU = "Uva";
            repoU.InsertarPreguntaU(letraU3);
            //Pregunta 4:
            LetraU letraU4 = new LetraU();
            letraU4.idLetraU = repoU.GetMaximoIdLetraU();
            letraU4.preguntaU = "Empieza por U. Maquinar, disponer una intriga.";
            letraU4.respuestaU = "Urdir";
            repoU.InsertarPreguntaU(letraU4);
            //Pregunta 5:
            LetraU letraU5 = new LetraU();
            letraU5.idLetraU = repoU.GetMaximoIdLetraU();
            letraU5.preguntaU = "Con la U. Sustancia nitrogenada contenida en la orina.";
            letraU5.respuestaU = "Urea";
            repoU.InsertarPreguntaU(letraU5);
        }//fin metodo insertar preguntas U.
        //Método para insertar preguntas letra V
        public void InicioInsertarPreguntasV()
        {
            //Pregunta 1:
            LetraV letraV1 = new LetraV();
            letraV1.idLetraV = repoV.GetMaximoIdLetraV();
            letraV1.preguntaV = "Empieza por V. Metal de transición empleado por algunas bacterias en el proceso de la respiración";
            letraV1.respuestaV = "Vanadio";
            repoV.InsertarPreguntaV(letraV1);
            //Pregunta 2:
            LetraV letraV2 = new LetraV();
            letraV2.idLetraV = repoV.GetMaximoIdLetraV();
            letraV2.preguntaV = "Con la V. De color parecido al de la hierba fresca.";
            letraV2.respuestaV = "Verde";
            repoV.InsertarPreguntaV(letraV2);
            //Pregunta 3:
            LetraV letraV3 = new LetraV();
            letraV3.idLetraV = repoV.GetMaximoIdLetraV();
            letraV3.preguntaV = "Comienza por V. Hábito de obrar mal.";
            letraV3.respuestaV = "Vicio";
            repoV.InsertarPreguntaV(letraV3);
            //Pregunta 4:
            LetraV letraV4 = new LetraV();
            letraV4.idLetraV = repoV.GetMaximoIdLetraV();
            letraV4.preguntaV = "Con la V. Alternativa de cosas prósperas y adversas.";
            letraV4.respuestaV = "Vicisitud";
            repoV.InsertarPreguntaV(letraV4);
            //Pregunta 5:
            LetraV letraV5 = new LetraV();
            letraV5.idLetraV = repoV.GetMaximoIdLetraV();
            letraV5.preguntaV = "Con la V. Corriente de aire producida en la atmósfera por causas naturales.";
            letraV5.respuestaV = "Viento";
            repoV.InsertarPreguntaV(letraV5);

        }//Fin método insertar preguntas letra V

        //Método para insertar preguntas letra W
        public void InicioInsertarPreguntasW()
        {
            //Pregunta 1:
            LetraW letraW1 = new LetraW();
            letraW1.idLetraW = repoW.GetMaximoIdLetraW();
            letraW1.preguntaW = "Con la W. Metal de transición cuyo simbolo es una W.";
            letraW1.respuestaW = "Wolframio";
            repoW.InsertarPreguntaW(letraW1);
            //Pregunta 2:
            LetraW letraW2 = new LetraW();
            letraW2.idLetraW = repoW.GetMaximoIdLetraW();
            letraW2.preguntaW = "Empieza por W. Licor alcohólico de cereales fermentados de origen escocés.";
            letraW2.respuestaW = "Whisky";
            repoW.InsertarPreguntaW(letraW2);
            //Pregunta 3:
            LetraW letraW3 = new LetraW();
            letraW3.idLetraW = repoW.GetMaximoIdLetraW();
            letraW3.preguntaW = "Con la W. Sistema de conexión inalámbrica, dentro de un área determinada, entre dispositivos electrónicos, y frecuentemente para acceso a internet.";
            letraW3.respuestaW = "Wifi";
            repoW.InsertarPreguntaW(letraW3);
            //Pregunta 4:
            LetraW letraW4 = new LetraW();
            letraW4.idLetraW = repoW.GetMaximoIdLetraW();
            letraW4.preguntaW = "Contiene la W. Apellido del científico que postuló la Teoría de la Evolución.";
            letraW4.respuestaW = "Darwin";
            repoW.InsertarPreguntaW(letraW4);
            //Pregunta 5:
            LetraW letraW5 = new LetraW();
            letraW5.idLetraW = repoW.GetMaximoIdLetraW();
            letraW5.preguntaW = "Contiene la W. Arte marcial de origen coreano, que desarrolla especialmente las técnicas de salto.";
            letraW5.respuestaW = "Taekwondo";
            repoW.InsertarPreguntaW(letraW5);

        }//Fin método insertar preguntas letra W

        //Método para insertar preguntas letra X
        public void InicioInsertarPreguntasX()
        {
            //Pregunta 1:
            LetraX letraX1 = new LetraX();
            letraX1.idLetraX = repoX.GetMaximoIdLetraX();
            letraX1.preguntaX = "Comienza por X. Gas noble.";
            letraX1.respuestaX = "Xénon";
            repoX.InsertarPreguntaX(letraX1);
            //Pregunta 2:
            //Pregunta 1:
            LetraX letraX2 = new LetraX();
            letraX2.idLetraX = repoX.GetMaximoIdLetraX();
            letraX2.preguntaX = "Empieza por X. Instrumento musical de percursión compuesto de láminas de madera o metal tocado con dos macillos.";
            letraX2.respuestaX = "Xilófono";
            repoX.InsertarPreguntaX(letraX2);
            //Pregunta 3:
            //Pregunta 1:
            LetraX letraX3 = new LetraX();
            letraX3.idLetraX = repoX.GetMaximoIdLetraX();
            letraX3.preguntaX = "Contiene la X. Pedir ayuda, socorro, amparo.";
            letraX3.respuestaX = "Auxilio";
            repoX.InsertarPreguntaX(letraX3);
            //Pregunta 4:
            //Pregunta 1:
            LetraX letraX4 = new LetraX();
            letraX4.idLetraX = repoX.GetMaximoIdLetraX();
            letraX4.preguntaX = "Contiene la X. Concavidad que forma el arranque del brazo con el cuerpo.";
            letraX4.respuestaX = "Axila";
            repoX.InsertarPreguntaX(letraX4);
            //Pregunta 5:
            //Pregunta 1:
            LetraX letraX5 = new LetraX();
            letraX5.idLetraX = repoX.GetMaximoIdLetraX();
            letraX5.preguntaX = "Contiene la X. Sustancia blanca constituida por sal de ácido bórico y sodio, usada en farmacia y en la industria, que se puede encontrar en estado natural.";
            letraX5.respuestaX = "Bórax";
            repoX.InsertarPreguntaX(letraX5);

        }//Fin método insertar preguntas letra X

        //Método para insertar preguntas letra Y
        public void InicioInsertarPreguntasY()
        {
            //Pregunta 1:
            LetraY letraY1 = new LetraY();
            letraY1.idLetraY = repoY.GetMaximoIdLetraY();
            letraY1.preguntaY = "Con la Y. Elemento no metálico representado por \"I\" ."; //https://docs.microsoft.com/es-es/dotnet/desktop/winforms/controls/how-to-put-quotation-marks-in-a-string-windows-forms?view=netframeworkdesktop-4.8
            letraY1.respuestaY = "Yodo";
            repoY.InsertarPreguntaY(letraY1);
            //Pregunta 2:
            LetraY letraY2 = new LetraY();
            letraY2.idLetraY = repoY.GetMaximoIdLetraY();
            letraY2.preguntaY = "Con la Y. Sulfato de calcio que se raya con la uña y se endurece rápidamente cuando se endurece con agua.";
            letraY2.respuestaY = "Yeso";
            repoY.InsertarPreguntaY(letraY2);
            //Pregunta 3:
            LetraY letraY3 = new LetraY();
            letraY3.idLetraY = repoY.GetMaximoIdLetraY();
            letraY3.preguntaY = "Con la Y. Materia seca e inflamable.";
            letraY3.respuestaY = "Yesca";
            repoY.InsertarPreguntaY(letraY3);
            //Pregunta 4:
            LetraY letraY4 = new LetraY();
            letraY4.idLetraY = repoY.GetMaximoIdLetraY();
            letraY4.preguntaY = "Con la Y. Meterial textil que se saca de ciertas plantas.";
            letraY4.respuestaY = "Yute";
            repoY.InsertarPreguntaY(letraY4);
            //Pregunta 5:
            LetraY letraY5 = new LetraY();
            letraY5.idLetraY = repoY.GetMaximoIdLetraY();
            letraY5.preguntaY = "Con la Y. Abuela.";
            letraY5.respuestaY = "Yaya";
            repoY.InsertarPreguntaY(letraY5);

        }//Fin método insertar preguntas letra Y

        //Método para insertar preguntas letra Z
        public void InicioInsertarPreguntasZ()
        {
            //Pregunta 1:
            LetraZ letraZ1 = new LetraZ();
            letraZ1.idLetraZ = repoZ.GetMaximoIdLetraZ();
            letraZ1.preguntaZ = "Comienza con Z. Segundo elemento de la segunda serie de metales de transición.";
            letraZ1.respuestaZ = "Zirconio";
            repoZ.InsertarPreguntaZ(letraZ1);
            //Pregunta 2:
            LetraZ letraZ2 = new LetraZ();
            letraZ2.idLetraZ = repoZ.GetMaximoIdLetraZ();
            letraZ2.preguntaZ = "Comienza por Z. Parque en el que se cuidan y se exhiben animales.";
            letraZ2.respuestaZ = "Zoo";
            repoZ.InsertarPreguntaZ(letraZ2);
            //Pregunta 3:
            LetraZ letraZ3 = new LetraZ();
            letraZ3.idLetraZ = repoZ.GetMaximoIdLetraZ();
            letraZ3.preguntaZ = "Con la Z. Grosero.";
            letraZ3.respuestaZ = "Zafio";
            repoZ.InsertarPreguntaZ(letraZ3);
            //Pregunta 4:
            LetraZ letraZ4 = new LetraZ();
            letraZ4.idLetraZ = repoZ.GetMaximoIdLetraZ();
            letraZ4.preguntaZ = "Con la Z. Paso muy largo y acelerado.";
            letraZ4.respuestaZ = "Zancada";
            repoZ.InsertarPreguntaZ(letraZ4);
            //Pregunta 5:
            LetraZ letraZ5 = new LetraZ();
            letraZ5.idLetraZ = repoZ.GetMaximoIdLetraZ();
            letraZ5.preguntaZ = "Con la Z. Arbusto rosáceo, de tallos zarmentosos, con aguijones fuertes y ganchos cuyo fruto es la zarzamora.";
            letraZ5.respuestaZ = "Zarza";
            repoZ.InsertarPreguntaZ(letraZ5);

        }//Fin método insertar preguntas letra Z


        //TODO o
        //TODO INSERCCION DE LAS PUNTUACIONES DE PRUEBA, esto se tiene que hacer en la ventana de puntuaciones, que salga una alerta para meter un valor si la puntuacion obtenida es top 10

        //TODO o

        public void InsertarPuntuacionesPrueba()
        {



            List<PuntosPasaVocablo> listaPuntuaciones = new List<PuntosPasaVocablo>();


            repoPuntos.InsertarPuntuacion(new PuntosPasaVocablo(1, 9876, "Ana", "Experto", 27, 269));
            repoPuntos.InsertarPuntuacion(new PuntosPasaVocablo(2, 8765, "Juan", "Experto", 27, 269));
            repoPuntos.InsertarPuntuacion(new PuntosPasaVocablo(3, 7986, "Paco", "Experto", 27, 269));
            repoPuntos.InsertarPuntuacion(new PuntosPasaVocablo(4, 6776, "Elena", "Experto", 27, 269));
            repoPuntos.InsertarPuntuacion(new PuntosPasaVocablo(5, 5976, "Pedro", "Experto", 27, 269));
            repoPuntos.InsertarPuntuacion(new PuntosPasaVocablo(6, 4776, "Petronila", "Experto", 27, 269));
            repoPuntos.InsertarPuntuacion(new PuntosPasaVocablo(7, 4676, "Carlos", "Experto", 27, 269));
            repoPuntos.InsertarPuntuacion(new PuntosPasaVocablo(8, 3576, "Judith", "Experto", 27, 269));
            repoPuntos.InsertarPuntuacion(new PuntosPasaVocablo(9, 2976, "Sara", "Experto", 27, 269));
            repoPuntos.InsertarPuntuacion(new PuntosPasaVocablo(10, 1276, "Cristian", "Experto", 27, 269));
        }

    }
}