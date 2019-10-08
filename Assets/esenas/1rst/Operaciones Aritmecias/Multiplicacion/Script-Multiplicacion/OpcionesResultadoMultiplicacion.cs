using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class OpcionesResultadoMultiplicacion : MonoBehaviour
{
    //COPIA DE OPCIONESRESULTADO


    //texto en pantalla de instrucciones
    public GameObject Instrucciones;

    //tema de fondo
    public MusicaFondo temaPrincipal2;

    //referencia de texto para activar al activar los botones
    public Timer tiempoRespuesta;

    int resultadoAbsoluto = 0;

    //instancia de los botones 
    public BotonesPulsados botonP1;
    public BotonesPulsados botonP2;
    public BotonesPulsados botonP3;

    public int resultado1, resultado2, resultado3;

    //texto que mostraran el posible resultado
    public Text primeraOpcion, segundaOpcion, tercerOpcion;

    //referencia al script para obtener el resultado de la operacion
    //public TextosPantalla objetoTexto;
    public OperacionMultiplicacion objetoTexto;


    void Start()
    {
        //al inciar el nivel tarda el tiempo establecido en aparecer las respuestas
        Invoke("establecerResultado", 1.5f);

    }



    public void actualizarResultados()
    {
        //llama al metodo despues de pasar el tiempo para actualizar respuestas en pantalla
        Invoke("establecerResultado", 2.5f);
    }

    public void establecerResultado()
    {
        //obtiene el resultado de la operacion
        resultadoAbsoluto = objetoTexto.resultadoFinal;

        int numeroAleatorio = 0;
        numeroAleatorio = Random.Range(1, 4);

        switch (numeroAleatorio)
        {

            case (1):

                resultado1 = resultadoAbsoluto;
                resultado2 = resultadoAbsoluto + 1;
                resultado3 = resultadoAbsoluto - 1;

                primeraOpcion.text = "" + resultadoAbsoluto;
                segundaOpcion.text = "" + (resultadoAbsoluto + 1);
                tercerOpcion.text = "" + (resultadoAbsoluto - 1);
                break;

            case (2):

                resultado1 = resultadoAbsoluto + 1;
                resultado2 = resultadoAbsoluto;
                resultado3 = resultadoAbsoluto - 1;

                primeraOpcion.text = "" + (resultadoAbsoluto + 1);
                segundaOpcion.text = "" + resultadoAbsoluto;
                tercerOpcion.text = "" + (resultadoAbsoluto - 1);
                break;

            case (3):

                resultado1 = resultadoAbsoluto - 1;
                resultado2 = resultadoAbsoluto + 1;
                resultado3 = resultadoAbsoluto;

                primeraOpcion.text = "" + (resultadoAbsoluto - 1);
                segundaOpcion.text = "" + (resultadoAbsoluto + 1);
                tercerOpcion.text = "" + resultadoAbsoluto;
                break;

        }

        Instrucciones.SetActive(false);
        //llama al metodo despues del tiempo para activar los botones con sus respuestas ya establecidas
        Invoke("ActivarBotones", .5f);

    }


    void ActivarBotones()
    {
        temaPrincipal2.Comenzar();

        //provocara que se comienze a decrementar el tiempo
        tiempoRespuesta.decrementar = true;

        //activando botones
        botonP1.gameObject.SetActive(true);
        botonP2.gameObject.SetActive(true);
        botonP3.gameObject.SetActive(true);
    }

}
