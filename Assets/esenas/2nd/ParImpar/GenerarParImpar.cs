using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerarParImpar : MonoBehaviour
{

    public BotonesPulsados jugar;
    public BotonesPulsados btnFlechaIzquierda, btnFlechaDerecha;
    public Text puntosPartida;


    public GameObject instrucciones, PiezasJuego;
    public Text numero; //numero que se muestra para determinar si el numero es par o impar
    public GameObject imagenPuntos;
    public Musica sonidos;


    public int numeroMinimo, numeroMaximo;
    public int intentos = 0;
    public int iteraciones = 0;
    public int NumeroContar = 0;
    public Puntos_Contar Puntos;

    

    public GameObject muestra;  //objeto que se instancia un numero de veces 
    public Transform instanciador;
    
   // public List<GameObject> objetos;
    //public List<GameObject> numeros;
    
    void Update()
    {
        if (jugar.pulsado)
        {
            jugar.pulsado = false;
            instrucciones.SetActive(false);
            Generacion_Numeros(numeroMinimo, numeroMaximo);
            imagenPuntos.SetActive(true);
            PiezasJuego.SetActive(true);
        }




        if (btnFlechaIzquierda.pulsado)
        {
            btnFlechaDerecha.GetComponent<BotonesPulsados>().enabled = false;
            numero.rectTransform.localPosition = new Vector3(-780f, 3f, 0f);
            iteraciones++;
            comprobarRespuesta(-1);


        }

        if (btnFlechaDerecha.pulsado)
        {
            btnFlechaIzquierda.GetComponent<BotonesPulsados>().enabled = false;
            numero.rectTransform.localPosition = new Vector3(760f, 3f, 0f);
            iteraciones++;
            comprobarRespuesta(1);


        }


    }
    
    public void comprobarRespuesta(int pos)
    {
        int residuo = NumeroContar % 2;
        // Debug.Log(residuo+" -- " + pos);
        if(residuo==0 && pos== 1)
        {
            // Debug.Log("respuesta correcta - Par");
            sonidos.Correcta();

            Puntos.incrementarPuntos();
        }
        else
        {

            if (residuo == 1 && pos == -1)
            {
                // Debug.Log("respuesta correcta - Impar");
                sonidos.Correcta();

                Puntos.incrementarPuntos();
            }
            else
            {
                // Debug.Log("respuesta INcorrecta");
                sonidos.Incorrecta();
                Puntos.decrementarPuntos();
                
            }
         
         
        }


        Generacion_Numeros(numeroMinimo, numeroMaximo);

    }



    IEnumerator establecerNumero()
    {
        yield return new WaitForSeconds(1f);
        numero.GetComponent<Text>().enabled = true;
        numero.rectTransform.localPosition = new Vector3(10f, 75f, 0f);
        numero.text = NumeroContar.ToString();
        btnFlechaDerecha.GetComponent<BotonesPulsados>().enabled = true;
        btnFlechaIzquierda.GetComponent<BotonesPulsados>().enabled = true;

    }

       
    IEnumerator mostrarPuntos()
    {
        yield return new WaitForSeconds(1f);
        Puntos.Calificar();

    }

    public void Generacion_Numeros(int n1, int n2)
    {

        if (iteraciones < intentos)
        {

            //indica el numero de elemtos que se crearon de acuerdo al rango establecido
            NumeroContar = Random.Range(n1, n2);
            //StartCoroutine(tiempoObjetos());
            StartCoroutine(establecerNumero());

        }
        else
        {
            //desactivamos este mismo componente para no seguir generando numeross
            gameObject.GetComponent<GenerarParImpar>().enabled = false;
            StartCoroutine(mostrarPuntos());
        }

    }
}
