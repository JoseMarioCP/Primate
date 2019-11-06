using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OperacionDivision : MonoBehaviour
{
    int[] divisores = {2,4,6,8};

    public BotonesPulsados jugar;
    public GameObject instrucciones;
    public GameObject canvasPrincipal;
    public GameObject contenedorImagen;
    public OpcionesResultadosDivision establecerResultado;
    public int numeroMin1 = 0, numeroMax1 = 0, numeroMin2 = 0, numeroMax2 = 0;


    //tema de fondo
    public MusicaFondo temaPrincipal;

    //sonidos de accion (ganar y perder)
    public Musica sonidoAccion;

    //variable para la verificacion de puntos durante el juego
    public MostrarPuntuacionDivision puntuacion;


    //referencia de texto para desactivar el tiempo al contestar
    public Timer tiempoRespuesta;

    public int resultadoFinal = 0;

    public int numeroAleatorio = 0, primerNumero = 0, segundoNumero = 0;


    public GameObject Respuesta;
    public Text num1, num2, resultadoPantalla, operacionTexto;

    public int respuestaCorrecta = 0, respuestasIncorrectas = 0;
    //aciertos e incorrectas (textos) en pantalla
    public Text buenas, malas;


    public OpcionesResultadosDivision R1;


    public BotonesPulsados boton1;
    public BotonesPulsados boton2;
    public BotonesPulsados boton3;

    
    // Update is called once per frame
    void Update()
    {
        if (jugar.pulsado)
        {
            jugar.pulsado = false;
            instrucciones.SetActive(false);
            //contenedorImagen.SetActive(true);
            canvasPrincipal.SetActive(true);
            puntuacion.Intentos = 0;
            buenas.text = "Puntos: " + 0;
            //malas.text = "" + 0;
            GeneradorNumeros();
            boton1.gameObject.SetActive(false);
            boton2.gameObject.SetActive(false);
            boton3.gameObject.SetActive(false);
            establecerResultado.establecerResultado();


        }

        //verifica si no has contestado y el tiempo se ha acabado te incrementara un error y se generaran otros numero
        if (tiempoRespuesta.tiempo <= 0)
        {

            //se detiene el tema principal de fondo
            temaPrincipal.Detener();

            //activa el sonido correspondiente
            //sonidoAccion.Incorrecta();
            sonidoAccion.FueraDeTiempo();

            IncrementarIncorrectas();
            Invoke("desactivarScriptPulsacion", .2f);
            boton1.gameObject.SetActive(false);
            boton2.gameObject.SetActive(false);
            boton3.gameObject.SetActive(false);

            Respuesta.SetActive(true);
            resultadoPantalla.enabled = true;

            Invoke("GeneradorNumeros", 2f);
            Invoke("activarScriptPulsacion", 3.2f);
            R1.actualizarResultados();

            //incrementa el nivel de intento permitidos en el juego
            puntuacion.Intentos++;

            tiempoRespuesta.reanudar();
        }

        
        if (boton1.pulsado == true && boton2.pulsado == false && boton3.pulsado == false)
        {

            if (R1.resultado1.Equals(resultadoFinal))
            {
                Debug.Log("CORRECTO");

                //se detiene el tema principal de fondo
                temaPrincipal.Detener();

                //activa el sonido correspondiente
                sonidoAccion.Correcta();

                //deja al contador en cero 
                tiempoRespuesta.contadorCero();

                //desactivarScriptPulsacion ();
                IncrementarAciertos();

                //deja al contador en cero 
                tiempoRespuesta.contadorCero();

                Invoke("desactivarScriptPulsacion", .05f);
                //desactivarScriptPulsacion ();

                //desactiva los demas botones
                boton2.gameObject.SetActive(false);
                boton3.gameObject.SetActive(false);

                //muestra el resultado en pantalla
                Respuesta.SetActive(true);
                resultadoPantalla.enabled = true;

                //llama al metodo para generar otros numeros
                Invoke("GeneradorNumeros", 2f);
                //activa nuevamente la pulsacion de los botones al aparecer
                Invoke("activarScriptPulsacion", 3.2f);
                //actualiza el resultado que aparece en los botones
                R1.actualizarResultados();

                //incrementa el nivel de intento permitidos en el juego
                puntuacion.Intentos++;
            }
            else
            {
                //se detiene el tema principal de fondo
                temaPrincipal.Detener();

                //activa el sonido correspondiente
                sonidoAccion.Incorrecta();

                //deja al contador en cero 
                tiempoRespuesta.contadorCero();

                IncrementarIncorrectas();

                Invoke("desactivarScriptPulsacion", .05f);
                //desactivarScriptPulsacion ();

                boton2.gameObject.SetActive(false);
                boton3.gameObject.SetActive(false);

                Respuesta.SetActive(true);
                resultadoPantalla.enabled = true;

                Invoke("GeneradorNumeros", 2f);
                Invoke("activarScriptPulsacion", 3.2f);
                R1.actualizarResultados();

                //incrementa el nivel de intento permitidos en el juego
                puntuacion.Intentos++;
            }

        }


        if (boton2.pulsado == true && boton1.pulsado == false && boton3.pulsado == false)
        {
            //Debug.Log ("comparando opcion2");

            if (R1.resultado2.Equals(resultadoFinal))
            {
                Debug.Log("CORRECTO");

                //se detiene el tema principal de fondo
                temaPrincipal.Detener();

                //activa el sonido correspondiente
                sonidoAccion.Correcta();

                //deja al contador en cero 
                tiempoRespuesta.contadorCero();


                //desactivarScriptPulsacion ();
                IncrementarAciertos();

                Invoke("desactivarScriptPulsacion", .05f);
                //desactivarScriptPulsacion ();

                boton1.gameObject.SetActive(false);
                boton3.gameObject.SetActive(false);

                Respuesta.SetActive(true);
                resultadoPantalla.enabled = true;

                Invoke("GeneradorNumeros", 2f);

                Invoke("activarScriptPulsacion", 3.2f);
                R1.actualizarResultados();



                //incrementa el nivel de intento permitidos en el juego
                puntuacion.Intentos++;
            }
            else
            {
                //se detiene el tema principal de fondo
                temaPrincipal.Detener();

                //activa el sonido correspondiente
                sonidoAccion.Incorrecta();

                //deja al contador en cero 
                tiempoRespuesta.contadorCero();

                IncrementarIncorrectas();

                Invoke("desactivarScriptPulsacion", .05f);
                //desactivarScriptPulsacion ();

                boton1.gameObject.SetActive(false);
                boton3.gameObject.SetActive(false);

                Respuesta.SetActive(true);
                resultadoPantalla.enabled = true;

                Invoke("GeneradorNumeros", 2f);
                Invoke("activarScriptPulsacion", 3.2f);
                R1.actualizarResultados();


                //incrementa el nivel de intento permitidos en el juego
                puntuacion.Intentos++;
            }

        }

        if (boton3.pulsado == true && boton2.pulsado == false && boton1.pulsado == false)
        {
            //Debug.Log ("comparando opcion3");

            if (R1.resultado3.Equals(resultadoFinal))
            {
                Debug.Log("CORRECTO");

                //se detiene el tema principal de fondo
                temaPrincipal.Detener();

                //activa el sonido correspondiente
                sonidoAccion.Correcta();

                //deja al contador en cero 
                tiempoRespuesta.contadorCero();

                IncrementarAciertos();

                Invoke("desactivarScriptPulsacion", .05f);
                //desactivarScriptPulsacion ();

                boton1.gameObject.SetActive(false);
                boton2.gameObject.SetActive(false);

                //aciva la respuesta en pantalla
                Respuesta.SetActive(true);
                resultadoPantalla.enabled = true;
                //llama al metodo para generar nuevos numeros 
                Invoke("GeneradorNumeros", 2f);


                Invoke("activarScriptPulsacion", 3.2f);

                //llama al metodo para actualizar los resultados
                R1.actualizarResultados();


                //incrementa el nivel de intento permitidos en el juego
                puntuacion.Intentos++;

            }
            else
            {

                //se detiene el tema principal de fondo
                temaPrincipal.Detener();

                //activa el sonido correspondiente
                sonidoAccion.Incorrecta();


                //deja al contador en cero 
                tiempoRespuesta.contadorCero();

                IncrementarIncorrectas();

                //desactivando las funciones de los botones
                Invoke("desactivarScriptPulsacion", .05f);
                //desactivarScriptPulsacion ();

                boton1.gameObject.SetActive(false);
                boton2.gameObject.SetActive(false);

                //aciva la respuesta en pantalla
                Respuesta.SetActive(true);
                resultadoPantalla.enabled = true;
                //llama al metodo para generar nuevos numeros 
                Invoke("GeneradorNumeros", 2f);

                Invoke("activarScriptPulsacion", 3.2f);
                //llama al metodo para actualizar los resultados
                R1.actualizarResultados();

                //incrementa el nivel de intento permitidos en el juego
                puntuacion.Intentos++;
            }

        }



    }


    //GENERA LOS NUMEROS PARA REALIZR LA OPERACION ARITMETICA

    public void GeneradorNumeros()
    {

        //desactiva los botones para generar el nuevo problema
        boton1.gameObject.SetActive(false);
        boton2.gameObject.SetActive(false);
        boton3.gameObject.SetActive(false);

        //genera un numero aleatorio para tomar un numero en el array divisores
        numeroAleatorio = Random.Range(numeroMin1, numeroMax1);
        primerNumero = divisores[numeroAleatorio];

        numeroAleatorio = Random.Range(numeroMin2, numeroMax2);
        segundoNumero = numeroAleatorio;

        resultadoPantalla.text = "" + realizarOperacion(primerNumero, segundoNumero);
        //desactica el texto en pantalla
        Respuesta.SetActive(false);
        resultadoPantalla.enabled = false;
    }

    public int realizarOperacion(int n1, int n2)
    {
        operacionTexto.text = "/";
        //Debug.Log("suma: valor del numero: " + operacion.ToString());
        resultadoFinal = (n1 * n2)/n2;
        num1.text = "" + n1*n2;
        num2.text = "" + n2;


        return resultadoFinal;

    }

    void IncrementarAciertos()
    {
        //incrementa la variable que lleva el conteo de las respuestas correctas
        respuestaCorrecta++;
        //incrementa la puntuacion en pantalla de aciertos
        buenas.text = "Puntos: " + respuestaCorrecta;


    }

    void IncrementarIncorrectas()
    {

        if (respuestaCorrecta > 0)
        {

            respuestaCorrecta--;
            buenas.text = "Puntos: " + respuestaCorrecta;
        }



        /*
        //incrementa la variable que lleva el conteo de las respuestas Incorrectas
        respuestasIncorrectas++;
        //incrementa la puntuacion en pantalla de errores
        malas.text = "" + respuestasIncorrectas;
        */
    }

    void desactivarScriptPulsacion()
    {
        boton1.enabled = false;
        boton2.enabled = false;
        boton3.enabled = false;
    }

    void activarScriptPulsacion()
    {
        boton1.enabled = true;
        boton2.enabled = true;
        boton3.enabled = true;
    }
}

