using PiensaJuegos.Models;
using PiensaJuegos.Repositories;
using PiensaJuegos.ViewModels;
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
    public partial class JuegoPasoVocablo : ContentPage
    {
        String dificultadPartida = "";

        //Ejemplo de uso de System.Timer: https://stackoverflow.com/questions/17300744/how-to-implement-countdowntimer-class-in-xamarin-c-sharp-android/17301154
        //Variables cuenta atrás:
        private System.Timers.Timer _timer;
        //private int _countSeconds;

        //Creación de los objetosViewModel de cada letra:
        public LetraAModel aVm = new LetraAModel();
        public LetraBModel bVm = new LetraBModel();
        public LetraCModel cVm = new LetraCModel();
        public LetraDModel dVm = new LetraDModel();
        public LetraEModel eVm = new LetraEModel();
        public LetraFModel fVm = new LetraFModel();
        public LetraGModel gVm = new LetraGModel();
        public LetraHModel hVm = new LetraHModel();
        public LetraIModel iVm = new LetraIModel();
        public LetraJModel jVm = new LetraJModel();
        public LetraKModel kVm = new LetraKModel();
        public LetraLModel lVm = new LetraLModel();
        public LetraMModel mVm = new LetraMModel();
        public LetraNModel nVm = new LetraNModel();
        public LetraNieModel nieVm = new LetraNieModel();
        public LetraOModel oVm = new LetraOModel();
        public LetraPModel pVm = new LetraPModel();
        public LetraQModel qVm = new LetraQModel();
        public LetraRModel rVm = new LetraRModel();
        public LetraSModel sVm = new LetraSModel();
        public LetraTModel tVm = new LetraTModel();
        public LetraUModel uVm = new LetraUModel();
        public LetraVModel vVm = new LetraVModel();
        public LetraWModel wVm = new LetraWModel();
        public LetraXModel xVm = new LetraXModel();
        public LetraYModel yVm = new LetraYModel();
        public LetraZModel zVm = new LetraZModel();

        //Creación del objeto viewModel del temporizador:

        public TemporizadorModel temporizadorVM = new TemporizadorModel();

        //Creación del objetoViewModel de la pregunta:

        public PreguntaModel preguntaVM = new PreguntaModel();


        //TODO pendiente


        //Creación de los objetos Letra _ que almacenarán el valor de una pregunta de manera aleatoria:

        LetraA preguntaA = new LetraA();
        LetraB preguntaB = new LetraB();
        LetraC preguntaC = new LetraC();
        LetraD preguntaD = new LetraD();
        LetraE preguntaE = new LetraE();
        LetraF preguntaF = new LetraF();
        LetraG preguntaG = new LetraG();
        LetraH preguntaH = new LetraH();
        LetraI preguntaI = new LetraI();
        LetraJ preguntaJ = new LetraJ();
        LetraK preguntaK = new LetraK();
        LetraL preguntaL = new LetraL();
        LetraM preguntaM = new LetraM();
        LetraN preguntaN = new LetraN();
        LetraNie preguntaNie = new LetraNie();
        LetraO preguntaO = new LetraO();
        LetraP preguntaP = new LetraP();
        LetraQ preguntaQ = new LetraQ();
        LetraR preguntaR = new LetraR();
        LetraS preguntaS = new LetraS();
        LetraT preguntaT = new LetraT();
        LetraU preguntaU = new LetraU();
        LetraV preguntaV = new LetraV();
        LetraW preguntaW = new LetraW();
        LetraX preguntaX = new LetraX();
        LetraY preguntaY = new LetraY();
        LetraZ preguntaZ = new LetraZ();

        //Declaración de la lista que contiene todas las preguntas:

        List<Letra> listaPreguntas = new List<Letra>();

        //Variables necesarias para el uso de los métodos que integran la lógica del juego:
        bool veintisieteRespuestas = false; //Una vez se tienen 27 respuestas, pasa a ser true, finalizando la partida. //TODO Igual es inecesario ya que al final no se si haré uso de un do...while
        int contadorCiclo = 0; //Contador que sirve para conocer la posición en el "rosco".
        int contadorFinal = 0; //El del método
        int aciertos = 0;            //Número de preguntas acertadas.
        int fallos = 0;              //Número de preguntas falladas.
        int preguntasRestantes = 27; //Número de preguntas pendientes de responder.
        //----------------------------------------------------------INICIO CLASE---------------------------------------------
        public JuegoPasoVocablo(String dificultad) //Esto es la clase, no es un método sin más. 
        {
            InitializeComponent();

            //Asignación de la dificultad de la partida:

            dificultadPartida = dificultad;

            //Bindings de las etiquetas:
            imgA.BindingContext = aVm;
            imgB.BindingContext = bVm;
            imgC.BindingContext = cVm;
            imgD.BindingContext = dVm;
            imgE.BindingContext = eVm;
            imgF.BindingContext = fVm;
            imgG.BindingContext = gVm;
            imgH.BindingContext = hVm;
            imgI.BindingContext = iVm;
            imgJ.BindingContext = jVm;
            imgK.BindingContext = kVm;
            imgL.BindingContext = lVm;
            imgM.BindingContext = mVm;
            imgN.BindingContext = nVm;
            imgNie.BindingContext = nieVm;
            imgO.BindingContext = oVm;
            imgP.BindingContext = pVm;
            imgQ.BindingContext = qVm;
            imgR.BindingContext = rVm;
            imgS.BindingContext = sVm;
            imgT.BindingContext = tVm;
            imgU.BindingContext = uVm;
            imgV.BindingContext = vVm;
            imgW.BindingContext = wVm;
            imgX.BindingContext = xVm;
            imgY.BindingContext = yVm;
            imgZ.BindingContext = zVm;

            //Intento el Binding aqui Temporizador:
            // this.BindingContext = temporizadorVM;
            //this.lblTemporizador.Text = temporizadorVM.segundosRestantes.ToString();
            this.contenedorTemp.BindingContext = temporizadorVM;
            this.lblTemporizador.Text = temporizadorVM.segundosRestantes.ToString();
           
         
            
            //Aqui tengo que llamar al metodo que extrae los valores de la base de datos: Mejor antes del tiempo para que el jugador no pierda segundos.
            CargarPartida();
            GenerarListaPreguntas();


            //TODO he añadido el contenedorTemp. Se tiene que hacer despues de cargar la partida para evitar el NullObjectReference o similares:
            this.contenedorPreg.BindingContext = preguntaVM; //El binding se hace aui al stack que contiene la Label.
            preguntaVM.letraPregunta = listaPreguntas[contadorCiclo] ;
           // this.lblPregunta.Text = preguntaVM.letraPregunta.pregunta.ToString();

            ContadorTiempoAsync(dificultad);

            //  FuncionamientoJuego();

            this.btnRendirse.Clicked += FinPartida;

           // this.btnConfirmar.Clicked += pruebaBotonUno;
            this.btnPasar.Clicked += pruebaBotonUno;


            //TODO eliminar, esto tiene que ir en el metodo que inicie el juego

            EncenderFondoFoco(contadorCiclo);
        }//Fin constructor


        //Método para obtener el tiempo en función de la dificultad seleccionada por el usiario:

        public int TiempoDificultad(String dificultadSeleccioanda)
        {
            int tiempoEquivalente = 0; //Segundos
            switch (dificultadSeleccioanda)
            {

                case "Principiante":
                    tiempoEquivalente = 999;
                    break;
                case "General":
                    tiempoEquivalente = 600;
                    break;
                case "Experto":
                    tiempoEquivalente = 300;
                    break;
                default:
                    tiempoEquivalente = 999;
                    break;
            }
            return tiempoEquivalente;
        }//Fin método tiempoDificultad()


        //Método que realiza la cuenta atrás:

        public async Task ContadorTiempoAsync(String dificultadObtenida)
        { //PAra que se ejecute en un hilo aparte y no se tueste la aplicación, tiene que ser una tarea asíncrona.


            _timer = new System.Timers.Timer();
            _timer.Interval = 1000; //Entiendo que esto es un intervalo de 1 segundo (se introduce en milisegundos)

            _timer.Elapsed += Temporizador;
            //_timer.Elapsed += async (x, y) => { await Task.Delay(1); };

            temporizadorVM.segundosRestantes = TiempoDificultad(dificultadObtenida);
            //_countSeconds = TiempoDificultad(dificultadObtenida);

            _timer.Enabled = true;


        } //Fin metodo asociar contadorTiempo

        //Metodo que escucha el evento temporal, es decir, lo que cambia cada segundo:

        private void Temporizador(Object sender, System.Timers.ElapsedEventArgs e)
        {
            //  _countSeconds--;
            temporizadorVM.segundosRestantes = temporizadorVM.segundosRestantes - 1;

            //TODO el temporizador funciona, pero no imprime los valores. Lo hace de forma aleatoria y muchas vees imprime un valor, y no vuelve a cambiarse nunca.
            // this.contenedorTemp.BindingContext = temporizadorVM; //El binding se hace aui al stack que contiene la Label.

            //this.lblTemporizador.Text = temporizadorVM.segundosRestantes.ToString();

            if (temporizadorVM.segundosRestantes == 0)
            {
                _timer.Stop();
                //this.lblTemporizador.Text = "Fin";
                //TODO añadir llamada al metodo que finalice el juego, tiene que ser el mismo que el de conseguir la victoria o completar el panel aun con errores
            }
        }//Fin OnTimedEvent()

        //Método para generar un número aleatorio entre 1 y 5:

        public int ObtenerNumeroAleatorio()
        {


            Random generadorAleatorios = new Random();

            return generadorAleatorios.Next(1, 6);

            //Parece que funciona bien, tras hacer varias llamadas todos los valores van del 1 al 5, ya que el primer valor que entra tiene id 1, no 0.


        }//fin método números aleatorios.


        //Metodo para obtener los valores de la base de datos:

        public void CargarPartida()
        {

            //Se crean los objetos. Se hace una peticion con un numero aleatorio para que cada pregunta se obtenga de cada tabla correspondiente de la base de datos de forma aleatoria. 

            RepositoryA repoA = new RepositoryA();
            preguntaA = repoA.BuscarPreguntaA(ObtenerNumeroAleatorio());

            RepositoryB repoB = new RepositoryB();
            preguntaB = repoB.BuscarPreguntaB(ObtenerNumeroAleatorio());

            RepositoryC repoC = new RepositoryC();
            preguntaC = repoC.BuscarPreguntaC(ObtenerNumeroAleatorio());

            RepositoryD repoD = new RepositoryD();
            preguntaD = repoD.BuscarPreguntaD(ObtenerNumeroAleatorio());

            RepositoryE repoE = new RepositoryE();
            preguntaE = repoE.BuscarPreguntaE(ObtenerNumeroAleatorio());

            RepositoryF repoF = new RepositoryF();
            preguntaF = repoF.BuscarPreguntaF(ObtenerNumeroAleatorio());

            RepositoryG repoG = new RepositoryG();
            preguntaG = repoG.BuscarPreguntaG(ObtenerNumeroAleatorio());

            RepositoryH repoH = new RepositoryH();
            preguntaH = repoH.BuscarPreguntaH(ObtenerNumeroAleatorio());

            RepositoryI repoI = new RepositoryI();
            preguntaI = repoI.BuscarPreguntaI(ObtenerNumeroAleatorio());

            RepositoryJ repoJ = new RepositoryJ();
            preguntaJ = repoJ.BuscarPreguntaJ(ObtenerNumeroAleatorio());

            RepositoryK repoK = new RepositoryK();
            preguntaK = repoK.BuscarPreguntaK(ObtenerNumeroAleatorio());

            RepositoryL repoL = new RepositoryL();
            preguntaL = repoL.BuscarPreguntaL(ObtenerNumeroAleatorio());

            RepositoryM repoM = new RepositoryM();
            preguntaM = repoM.BuscarPreguntaM(ObtenerNumeroAleatorio());

            RepositoryN repoN = new RepositoryN();
            preguntaN = repoN.BuscarPreguntaN(ObtenerNumeroAleatorio());

            RepositoryNie repoNie = new RepositoryNie();
            preguntaNie = repoNie.BuscarPreguntaNie(ObtenerNumeroAleatorio());

            RepositoryO repoO = new RepositoryO();
            preguntaO = repoO.BuscarPreguntaO(ObtenerNumeroAleatorio());

            RepositoryP repoP = new RepositoryP();
            preguntaP = repoP.BuscarPreguntaP(ObtenerNumeroAleatorio());

            RepositoryQ repoQ = new RepositoryQ();
            preguntaQ = repoQ.BuscarPreguntaQ(ObtenerNumeroAleatorio());

            RepositoryR repoR = new RepositoryR();
            preguntaR = repoR.BuscarPreguntaR(ObtenerNumeroAleatorio());

            RepositoryS repoS = new RepositoryS();
            preguntaS = repoS.BuscarPreguntaS(ObtenerNumeroAleatorio());

            RepositoryT repoT = new RepositoryT();
            preguntaT = repoT.BuscarPreguntaT(ObtenerNumeroAleatorio());

            RepositoryU repoU = new RepositoryU();
            preguntaU = repoU.BuscarPreguntaU(ObtenerNumeroAleatorio());

            RepositoryV repoV = new RepositoryV();
            preguntaV = repoV.BuscarPreguntaV(ObtenerNumeroAleatorio());

            RepositoryW repoW = new RepositoryW();
            preguntaW = repoW.BuscarPreguntaW(ObtenerNumeroAleatorio());

            RepositoryX repoX = new RepositoryX();
            preguntaX = repoX.BuscarPreguntaX(ObtenerNumeroAleatorio());

            RepositoryY repoY = new RepositoryY();
            preguntaY = repoY.BuscarPreguntaY(ObtenerNumeroAleatorio());

            RepositoryZ repoZ = new RepositoryZ();
            preguntaZ = repoZ.BuscarPreguntaZ(ObtenerNumeroAleatorio());

        }//Fin método CargarPArtida

        //Método para el funcionamiento de la lógica del cilo de juego:

        public void GenerarListaPreguntas()
        {


            //TODO Y SI METO TODAS LAS PREGUNTAS EN UN ARRAY DE PREGUNTA? Y EN PREGUNTA LE CALZO LOS BOOLEANS?

            Letra auxPreA = new Letra("A", preguntaA.idLetraA, preguntaA.preguntaA, preguntaA.respuestaA, true, false, false);
            Letra auxPreB = new Letra("B", preguntaB.idLetraB, preguntaB.preguntaB, preguntaB.respuestaB, true, false, false);
            Letra auxPreC = new Letra("C", preguntaC.idLetraC, preguntaC.preguntaC, preguntaC.respuestaC, true, false, false);
            Letra auxPreD = new Letra("D", preguntaD.idLetraD, preguntaD.preguntaD, preguntaD.respuestaD, true, false, false);
            Letra auxPreE = new Letra("E", preguntaE.idLetraE, preguntaE.preguntaE, preguntaE.respuestaE, true, false, false);
            Letra auxPreF = new Letra("F", preguntaF.idLetraF, preguntaF.preguntaF, preguntaF.respuestaF, true, false, false);
            Letra auxPreG = new Letra("G", preguntaG.idLetraG, preguntaG.preguntaG, preguntaG.respuestaG, true, false, false);
            Letra auxPreH = new Letra("H", preguntaH.idLetraH, preguntaH.preguntaH, preguntaH.respuestaH, true, false, false);
            Letra auxPreI = new Letra("I", preguntaI.idLetraI, preguntaI.preguntaI, preguntaI.respuestaI, true, false, false);
            Letra auxPreJ = new Letra("J", preguntaJ.idLetraJ, preguntaJ.preguntaJ, preguntaJ.respuestaJ, true, false, false);
            Letra auxPreK = new Letra("K", preguntaK.idLetraK, preguntaK.preguntaK, preguntaK.respuestaK, true, false, false);
            Letra auxPreL = new Letra("L", preguntaL.idLetraL, preguntaL.preguntaL, preguntaL.respuestaL, true, false, false);
            Letra auxPreM = new Letra("M", preguntaM.idLetraM, preguntaM.preguntaM, preguntaM.respuestaM, true, false, false);
            Letra auxPreN = new Letra("N", preguntaN.idLetraN, preguntaN.preguntaN, preguntaN.respuestaN, true, false, false);
            Letra auxPreNie = new Letra("Ñ", preguntaNie.idLetraNie, preguntaNie.preguntaNie, preguntaNie.respuestaNie, true, false, false);
            Letra auxPreO = new Letra("O", preguntaO.idLetraO, preguntaO.preguntaO, preguntaO.respuestaO, true, false, false);
            Letra auxPreP = new Letra("P", preguntaP.idLetraP, preguntaP.preguntaP, preguntaP.respuestaP, true, false, false);
            Letra auxPreQ = new Letra("Q", preguntaQ.idLetraQ, preguntaQ.preguntaQ, preguntaQ.respuestaQ, true, false, false);
            Letra auxPreR = new Letra("R", preguntaR.idLetraR, preguntaR.preguntaR, preguntaR.respuestaR, true, false, false);
            Letra auxPreS = new Letra("S", preguntaS.idLetraS, preguntaS.preguntaS, preguntaS.respuestaS, true, false, false);
            Letra auxPreT = new Letra("T", preguntaT.idLetraT, preguntaT.preguntaT, preguntaT.respuestaT, true, false, false);
            Letra auxPreU = new Letra("U", preguntaU.idLetraU, preguntaU.preguntaU, preguntaU.respuestaU, true, false, false);
            Letra auxPreV = new Letra("V", preguntaV.idLetraV, preguntaV.preguntaV, preguntaV.respuestaV, true, false, false);
            Letra auxPreW = new Letra("W", preguntaW.idLetraW, preguntaW.preguntaW, preguntaW.respuestaW, true, false, false);
            Letra auxPreX = new Letra("X", preguntaX.idLetraX, preguntaX.preguntaX, preguntaX.respuestaX, true, false, false);
            Letra auxPreY = new Letra("Y", preguntaY.idLetraY, preguntaY.preguntaY, preguntaY.respuestaY, true, false, false);
            Letra auxPreZ = new Letra("Z", preguntaZ.idLetraZ, preguntaZ.preguntaZ, preguntaZ.respuestaZ, true, false, false);
            //TODO poner todas las preguntas con este formato


            listaPreguntas.Add(auxPreA);
            listaPreguntas.Add(auxPreB);
            listaPreguntas.Add(auxPreC);
            listaPreguntas.Add(auxPreD);
            listaPreguntas.Add(auxPreE);
            listaPreguntas.Add(auxPreF);
            listaPreguntas.Add(auxPreG);
            listaPreguntas.Add(auxPreH);
            listaPreguntas.Add(auxPreI);
            listaPreguntas.Add(auxPreJ);
            listaPreguntas.Add(auxPreK);
            listaPreguntas.Add(auxPreL);
            listaPreguntas.Add(auxPreM);
            listaPreguntas.Add(auxPreN);
            listaPreguntas.Add(auxPreNie);
            listaPreguntas.Add(auxPreO);
            listaPreguntas.Add(auxPreP);
            listaPreguntas.Add(auxPreQ);
            listaPreguntas.Add(auxPreR);
            listaPreguntas.Add(auxPreS);
            listaPreguntas.Add(auxPreT);
            listaPreguntas.Add(auxPreU);
            listaPreguntas.Add(auxPreV);
            listaPreguntas.Add(auxPreW);
            listaPreguntas.Add(auxPreX);
            listaPreguntas.Add(auxPreY);
            listaPreguntas.Add(auxPreZ);


        }//Método para generar la lista de preguntas: 


        //Método para el funcionamiento del ciclo de preguntas:

        public async Task FuncionamientoJuego()
        {
            //Igual le puedo poner como parámetro de entrada el boolean de findepartida
            // https://docs.microsoft.com/es-es/xamarin/xamarin-forms/app-fundamentals/triggers
            //Creo que la parte mplementar la clase genérica TriggerAction<T>, con el parámetro genérico correspondiente al puede ser muy interesante
            do
            {
                if (listaPreguntas[contadorCiclo].sinRespuesta)
                {
                    //Se llama al método que cambia el color de fondo:
                    EncenderFondoFoco(contadorCiclo);

                    if (contadorCiclo == 26 && preguntasRestantes > 0)
                    { //Con esto, una vez completada la primera vuelta, se reactiva el ciclo para que se respondan las preguntas que queden sin responder. 
                        contadorCiclo = 0;
                    }
                }
                else
                {
                    contadorCiclo++; //Es decir, si una pregunta ya ha sido respondida, se "salta" sin que el usuario tenga que pulsaar el botón de siguiente.
                }


            } while (!veintisieteRespuestas);
        } //Fin tarea asíncrona FuncionamientoJuego


        //Métodos para activar tanto el sonido de fallo como el de acierto:

        public void SuenaAcierto() {
            var melodiaAcierto = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            melodiaAcierto.Load("sonidoacierto.mp3");
        }//Fin método SuenaAcierto

        public void SuenaFallo() {
            var melodiaFallo = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            melodiaFallo.Load("sonidofallo.mp3");
        }//Fin método SuenaFallo



        //Método para calcular la puntuación:

        public int ObtenerPuntuacion(int tiempo, int aciertos, int fallos, String dificultad) {

            int valorDificultad = 0;

            switch (dificultad) {
                case "Principiante":
                    valorDificultad = 1;
                    break;
                case "General":
                    valorDificultad = 3;
                    break;
                case "Experto":
                    valorDificultad = 5;
                    break;
                default:
                    valorDificultad = 1;
                    break;
            }

            int resultado = Convert.ToInt32((Math.Pow((valorDificultad * aciertos),5))-Math.Pow((fallos * 3),1/3)) + tiempo ; //El 1/3 es para hacer que sea la raiz cúbica
            //TODO pendiente hacer lo del tiempo
            return resultado; 


        }


        //Método que se ejecuta cuando se pulsa el botón de enviar respuesta:

        public async Task EnviarRespuesta(int i)
        {

            String respuestaCorrecta = listaPreguntas[i].respuesta.ToString();

            String respuestaUsuario = txtRespuesta.Text.ToString();

            //Nota: Se escriben dos llamadas al método SiguienteContador. una en el código de acierto y otra en el de fallo.
            //en el código en el que no se ha introducirdo respuesta no. Por este motivo, no se pone al final del if..else if... else

            if (respuestaUsuario.Equals(respuestaCorrecta))
            {

                listaPreguntas[i].sinRespuesta = false;
                listaPreguntas[i].acertada = true;
                AcertarFondoFoco(i);
                this.lblInformativa.Text = "¡Respuesta correcta!";
                this.lblInformativa.TextColor = Color.Lime;
                aciertos++;
                preguntasRestantes--;
                SiguienteContador(i);

                //TODO las variables que cuantan los fallos y los aciertos han de ser globales para poder usarlas en los diferentes métodos.
            }
            else if (respuestaUsuario.Equals(""))
            {
                this.lblInformativa.Text = "¡Debes introducir una respuesta!";
                this.lblInformativa.TextColor = Color.White;
            }
            else
            {
                listaPreguntas[i].sinRespuesta = false;
                listaPreguntas[i].fallada = true;
                FallarFondoFoco(i);
                this.lblInformativa.Text = "¡Respuesta incorrecta!";
                this.lblInformativa.TextColor = Color.Crimson;
                SiguienteContador(i);
                fallos++;
                preguntasRestantes--;
            }

        }//Fin método async Task EnviarRespuesta


        //Método para pasar vocablo:

        public async Task PasarVocablo(int i)
        { //Este método debería devolver el contador

            //Lo primero es que quite el foco de la pregunta:

            ApagarFondoFoco(i);
            SiguienteContador(i);

            //Ahora, se inrementa el contador:

            //El incremento del contador se realiza en un método aparte ya que va a ser usado por varios métodos.



        }//fin método PasarVocablo


        //Metodo para incrementar el contador teniendo en cuenta los saltos producidos por las preguntas que ya han sido respondidas.

        public int SiguienteContador(int contadorActual)
        {

           

            do
            {
                contadorFinal++;
                if (contadorFinal == 27)
                { //Del 0 al 26 hay 27 valores (27 letras)
                    contadorFinal = 0;
                }
            } while (!listaPreguntas[contadorFinal].sinRespuesta);

            //Explicación: Lo primero que se hace es incrementar el contador en uno. Si la pregunta no ha sido respondida, sale del bucle.
            //Si la pregunta ha sido respondida, se vuelve a ejecutar el bucle, repitiéndose este proceso hasta que se encuentre un letra
            //cuya pregunta no haya sido respondida. Si el valor del contador excede el equivalente a las 27 letras
            // (es decir, el número 26, ya que el cero cuenta), se fuerza a que su valor pase a ser cero. 

            return contadorFinal;
        }
        //Método que finaliza la partida y navega a la ventana de puntuaciones:

        public async void FinPartida(Object Sender, EventArgs e)
        {
            //En primer lugar se calcula la puntuación del usuario:
            int puntuacion = ObtenerPuntuacion(20,aciertos,fallos,dificultadPartida);

            int nuevaPosicion = -1;


            RepositorPuntosPasaVocablo repoPuntos = new RepositorPuntosPasaVocablo();

            List<PuntosPasaVocablo> listaPuntuaciones = repoPuntos.GetPuntuaciones();

            //Se comprueba si la puntuación del usuario está ene l top 10.

            //Se crea el delegado para el método de comprobación:

            //Action<PuntosPasaVocablo> accion = new Action<PuntosPasaVocablo>(ComprobarPuntuacion(int puntuacion));

            //listaPuntuaciones.ForEach(listaPuntuaciones, accion);

            for (int i = 0; i <= listaPuntuaciones.Count; i++) {
                if (puntuacion >= listaPuntuaciones[i].puntuacion)
                {
                    nuevaPosicion = i + 1;
                    break; //Imagino que esto funciona como en Java
                    

                }
            }

            if (nuevaPosicion > 0 && nuevaPosicion < 11)
            {
                //PONER el display a promp. 
                //Si la puntuación está en el top 10:  
                //el botón de ok del cuadro de dialogo obtiene el nombre intertado e introduce el usuario.

                String usuario = await DisplayPromptAsync(String.Format("Tu puntuación es: {0}", puntuacion), "Tu puntuación está entre las diez primeras. Introduce tu nombre", "Confirmar");


                PuntosPasaVocablo auxPuntos = new PuntosPasaVocablo(nuevaPosicion, puntuacion, usuario, dificultadPartida, aciertos, 20);

                //TODO ACTUALIZAR TODAS LAS POSICIONES DE LA BASE DE DATOS
            }
            else { 
            
                   //Alerta normal

            
            
            }//fin if

            

            

            //Si la puntuación no está en el top 10, poner la alerta normal
            await Navigation.PushAsync(new PuntuacionPasaVocablo());


        }//Fin método FinPartida

        //Método para comprobar la puntuación: (haciendo uso de los delegados)
        //https://docs.microsoft.com/en-us/dotnet/api/system.array.foreach?view=net-5.0
        public static void ComprobarPuntuacion(int puntos) {
        
          

        }

        //Triggers que llaman a los métodos para el inicio de la partida:



        //----- Metodos para el cambio de los fondos -------/ 
        //Método para los cambios de color del fondo de la label de la letra cuya pregunta está siendo mostrada para responder::

        public void EncenderFondoFoco(int i)
        {

            if (listaPreguntas[i].sinRespuesta)
            {
                switch (i)
                {

                    case 0:
                        imgA.BackgroundColor = Color.Orange;
                        break;
                    case 1:
                        imgB.BackgroundColor = Color.Orange;
                        break;
                    case 2:
                        imgC.BackgroundColor = Color.Orange;
                        break;
                    case 3:
                        imgD.BackgroundColor = Color.Orange;
                        break;
                    case 4:
                        imgE.BackgroundColor = Color.Orange;
                        break;
                    case 5:
                        imgF.BackgroundColor = Color.Orange;
                        break;
                    case 6:
                        imgG.BackgroundColor = Color.Orange;
                        break;
                    case 7:
                        imgH.BackgroundColor = Color.Orange;
                        break;
                    case 8:
                        imgI.BackgroundColor = Color.Orange;
                        break;
                    case 9:
                        imgJ.BackgroundColor = Color.Orange;
                        break;
                    case 10:
                        imgK.BackgroundColor = Color.Orange;
                        break;
                    case 11:
                        imgL.BackgroundColor = Color.Orange;
                        break;
                    case 12:
                        imgM.BackgroundColor = Color.Orange;
                        break;
                    case 13:
                        imgN.BackgroundColor = Color.Orange;
                        break;
                    case 14:
                        imgNie.BackgroundColor = Color.Orange;
                        break;
                    case 15:
                        imgO.BackgroundColor = Color.Orange;
                        break;
                    case 16:
                        imgP.BackgroundColor = Color.Orange;
                        break;
                    case 17:
                        imgQ.BackgroundColor = Color.Orange;
                        break;
                    case 18:
                        imgR.BackgroundColor = Color.Orange;
                        break;
                    case 19:
                        imgS.BackgroundColor = Color.Orange;
                        break;
                    case 20:
                        imgT.BackgroundColor = Color.Orange;
                        break;
                    case 21:
                        imgU.BackgroundColor = Color.Orange;
                        break;
                    case 22:
                        imgV.BackgroundColor = Color.Orange;
                        break;
                    case 23:
                        imgW.BackgroundColor = Color.Orange;
                        break;
                    case 24:
                        imgX.BackgroundColor = Color.Orange;
                        break;
                    case 25:
                        imgY.BackgroundColor = Color.Orange;
                        break;
                    case 26:
                        imgZ.BackgroundColor = Color.Orange;
                        break;


                }//Fin switch

            }//Fin if

        }//Fin metodo EnciendeFondoFoco


        //Método para apagar el foco de una pregunta cuando se ha pasado vocablo

        public void ApagarFondoFoco(int i)
        {

            if (listaPreguntas[i].sinRespuesta)
            {
                switch (i)
                {

                    case 0:
                        imgA.BackgroundColor = Color.DodgerBlue;
                        break;
                    case 1:
                        imgB.BackgroundColor = Color.DodgerBlue;
                        break;
                    case 2:
                        imgC.BackgroundColor = Color.DodgerBlue;
                        break;
                    case 3:
                        imgD.BackgroundColor = Color.DodgerBlue;
                        break;
                    case 4:
                        imgE.BackgroundColor = Color.DodgerBlue;
                        break;
                    case 5:
                        imgF.BackgroundColor = Color.DodgerBlue;
                        break;
                    case 6:
                        imgG.BackgroundColor = Color.DodgerBlue;
                        break;
                    case 7:
                        imgH.BackgroundColor = Color.DodgerBlue;
                        break;
                    case 8:
                        imgI.BackgroundColor = Color.DodgerBlue;
                        break;
                    case 9:
                        imgJ.BackgroundColor = Color.DodgerBlue;
                        break;
                    case 10:
                        imgK.BackgroundColor = Color.DodgerBlue;
                        break;
                    case 11:
                        imgL.BackgroundColor = Color.DodgerBlue;
                        break;
                    case 12:
                        imgM.BackgroundColor = Color.DodgerBlue;
                        break;
                    case 13:
                        imgN.BackgroundColor = Color.DodgerBlue;
                        break;
                    case 14:
                        imgNie.BackgroundColor = Color.DodgerBlue;
                        break;
                    case 15:
                        imgO.BackgroundColor = Color.DodgerBlue;
                        break;
                    case 16:
                        imgP.BackgroundColor = Color.DodgerBlue;
                        break;
                    case 17:
                        imgQ.BackgroundColor = Color.DodgerBlue;
                        break;
                    case 18:
                        imgR.BackgroundColor = Color.DodgerBlue;
                        break;
                    case 19:
                        imgS.BackgroundColor = Color.DodgerBlue;
                        break;
                    case 20:
                        imgT.BackgroundColor = Color.DodgerBlue;
                        break;
                    case 21:
                        imgU.BackgroundColor = Color.DodgerBlue;
                        break;
                    case 22:
                        imgV.BackgroundColor = Color.DodgerBlue;
                        break;
                    case 23:
                        imgW.BackgroundColor = Color.DodgerBlue;
                        break;
                    case 24:
                        imgX.BackgroundColor = Color.DodgerBlue;
                        break;
                    case 25:
                        imgY.BackgroundColor = Color.DodgerBlue;
                        break;
                    case 26:
                        imgZ.BackgroundColor = Color.DodgerBlue;
                        break;


                }//Fin switch

            }//Fin if

        }//Fin metodo ApagaFondoFoco

        //Método para fijar el color de acierto de una letra:

        public void AcertarFondoFoco(int i)
        {

            if (listaPreguntas[i].acertada)
            {
                switch (i)
                {

                    case 0:
                        imgA.BackgroundColor = Color.Lime;
                        break;
                    case 1:
                        imgB.BackgroundColor = Color.Lime;
                        break;
                    case 2:
                        imgC.BackgroundColor = Color.Lime;
                        break;
                    case 3:
                        imgD.BackgroundColor = Color.Lime;
                        break;
                    case 4:
                        imgE.BackgroundColor = Color.Lime;
                        break;
                    case 5:
                        imgF.BackgroundColor = Color.Lime;
                        break;
                    case 6:
                        imgG.BackgroundColor = Color.Lime;
                        break;
                    case 7:
                        imgH.BackgroundColor = Color.Lime;
                        break;
                    case 8:
                        imgI.BackgroundColor = Color.Lime;
                        break;
                    case 9:
                        imgJ.BackgroundColor = Color.Lime;
                        break;
                    case 10:
                        imgK.BackgroundColor = Color.Lime;
                        break;
                    case 11:
                        imgL.BackgroundColor = Color.Lime;
                        break;
                    case 12:
                        imgM.BackgroundColor = Color.Lime;
                        break;
                    case 13:
                        imgN.BackgroundColor = Color.Lime;
                        break;
                    case 14:
                        imgNie.BackgroundColor = Color.Lime;
                        break;
                    case 15:
                        imgO.BackgroundColor = Color.Lime;
                        break;
                    case 16:
                        imgP.BackgroundColor = Color.Lime;
                        break;
                    case 17:
                        imgQ.BackgroundColor = Color.Lime;
                        break;
                    case 18:
                        imgR.BackgroundColor = Color.Lime;
                        break;
                    case 19:
                        imgS.BackgroundColor = Color.Lime;
                        break;
                    case 20:
                        imgT.BackgroundColor = Color.Lime;
                        break;
                    case 21:
                        imgU.BackgroundColor = Color.Lime;
                        break;
                    case 22:
                        imgV.BackgroundColor = Color.Lime;
                        break;
                    case 23:
                        imgW.BackgroundColor = Color.Lime;
                        break;
                    case 24:
                        imgX.BackgroundColor = Color.Lime;
                        break;
                    case 25:
                        imgY.BackgroundColor = Color.Lime;
                        break;
                    case 26:
                        imgZ.BackgroundColor = Color.Lime;
                        break;


                }//Fin switch

            }//Fin if

        }//Fin metodo AcertarFondoFoco




        //Método para fijar el color de fallo de una letra:

        public void FallarFondoFoco(int i)
        {

            if (listaPreguntas[i].fallada)
            {
                switch (i)
                {

                    case 0:
                        imgA.BackgroundColor = Color.Crimson;
                        break;
                    case 1:
                        imgB.BackgroundColor = Color.Crimson;
                        break;
                    case 2:
                        imgC.BackgroundColor = Color.Crimson;
                        break;
                    case 3:
                        imgD.BackgroundColor = Color.Crimson;
                        break;
                    case 4:
                        imgE.BackgroundColor = Color.Crimson;
                        break;
                    case 5:
                        imgF.BackgroundColor = Color.Crimson;
                        break;
                    case 6:
                        imgG.BackgroundColor = Color.Crimson;
                        break;
                    case 7:
                        imgH.BackgroundColor = Color.Crimson;
                        break;
                    case 8:
                        imgI.BackgroundColor = Color.Crimson;
                        break;
                    case 9:
                        imgJ.BackgroundColor = Color.Crimson;
                        break;
                    case 10:
                        imgK.BackgroundColor = Color.Crimson;
                        break;
                    case 11:
                        imgL.BackgroundColor = Color.Crimson;
                        break;
                    case 12:
                        imgM.BackgroundColor = Color.Crimson;
                        break;
                    case 13:
                        imgN.BackgroundColor = Color.Crimson;
                        break;
                    case 14:
                        imgNie.BackgroundColor = Color.Crimson;
                        break;
                    case 15:
                        imgO.BackgroundColor = Color.Crimson;
                        break;
                    case 16:
                        imgP.BackgroundColor = Color.Crimson;
                        break;
                    case 17:
                        imgQ.BackgroundColor = Color.Crimson;
                        break;
                    case 18:
                        imgR.BackgroundColor = Color.Crimson;
                        break;
                    case 19:
                        imgS.BackgroundColor = Color.Crimson;
                        break;
                    case 20:
                        imgT.BackgroundColor = Color.Crimson;
                        break;
                    case 21:
                        imgU.BackgroundColor = Color.Crimson;
                        break;
                    case 22:
                        imgV.BackgroundColor = Color.Crimson;
                        break;
                    case 23:
                        imgW.BackgroundColor = Color.Crimson;
                        break;
                    case 24:
                        imgX.BackgroundColor = Color.Crimson;
                        break;
                    case 25:
                        imgY.BackgroundColor = Color.Crimson;
                        break;
                    case 26:
                        imgZ.BackgroundColor = Color.Crimson;
                        break;


                }//Fin switch

            }//Fin if

        }//Fin metodo FallarFondoFoco


        //Pruebas del boton

        public void pruebaBotonUno(Object sender, EventArgs e)
        {
            ApagarFondoFoco(contadorCiclo);
            contadorCiclo = SiguienteContador(contadorCiclo);
            EncenderFondoFoco(contadorCiclo);
            preguntaVM.letraPregunta = listaPreguntas[contadorCiclo];
        }

        //Prueba botón confirmar respuesta:

        public void pruebaEnviarRespeusta() {

            String respuestaCorrecta = listaPreguntas[contadorCiclo].respuesta.ToString();

            String respuestaUsuario = txtRespuesta.Text.ToString();

            //Nota: Se escriben dos llamadas al método SiguienteContador. una en el código de acierto y otra en el de fallo.
            //en el código en el que no se ha introducirdo respuesta no. Por este motivo, no se pone al final del if..else if... else

            if (respuestaUsuario.Equals(respuestaCorrecta))
            {

                listaPreguntas[contadorCiclo].sinRespuesta = false;
                listaPreguntas[contadorCiclo].acertada = true;
                AcertarFondoFoco(contadorCiclo);
                this.lblInformativa.Text = "¡Respuesta correcta!";
                this.lblInformativa.TextColor = Color.Lime;
                aciertos++;
                preguntasRestantes--;
                SiguienteContador(contadorCiclo);

                //TODO las variables que cuantan los fallos y los aciertos han de ser globales para poder usarlas en los diferentes métodos.
            }
            else if (respuestaUsuario.Equals(""))
            {
                this.lblInformativa.Text = "¡Debes introducir una respuesta!";
                this.lblInformativa.TextColor = Color.White;
            }
            else
            {
                listaPreguntas[contadorCiclo].sinRespuesta = false;
                listaPreguntas[contadorCiclo].fallada = true;
                FallarFondoFoco(contadorCiclo);
                this.lblInformativa.Text = "¡Respuesta incorrecta!";
                this.lblInformativa.TextColor = Color.Crimson;
                SiguienteContador(contadorCiclo);
                fallos++;
                preguntasRestantes--;
            }

            //TODO aqui poner que si todas las preguntas se han respondido, el booleano se activa y en algun lugar poner el valueEventListener que escuhca que ese valor ha pasado atrue, y dentro, una llamada al método finalizar partida.
        }

    }
}