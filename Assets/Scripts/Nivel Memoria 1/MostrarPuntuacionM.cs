using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarPuntuacionM : MonoBehaviour
{
    
    public float tiempoEspera = 0;
    public Vidas vida;
    public ValidarRespuestas puntuaje;
    public GameObject c1;
    public GameObject c2;
    public GameObject ima1, ima2;
    int puntos;
    public Text aciertos;

   //public Generacion_Flechas gene;
   // public GameObject botones;
    public GameObject controlador;


    // Update is called once per frame
    void Update()
    {
        if(vida.vidas==0 )
        {
            vida.vidas = -1;
            puntos = puntuaje.puntos;
            controlador.SetActive(false);
            mostrarPuntuacion();
        }

    }

    public void mostrarPuntuacion()
    {
        StartCoroutine(espera());

    }

    IEnumerator espera()
    {
       
        yield return new WaitForSeconds(tiempoEspera);
        //controlador.SetActive(false);
        c1.SetActive(false);
        ima1.SetActive(false);
        ima2.SetActive(false);
        

        //Debug.Log("maxima puntuacion : "+puntuaje.puntos);
        c2.SetActive(true);
        //aciertos.text = "Maxima Puntuacion \n      " + puntuaje.puntos;
        Calificacion();
    }

    public void Calificacion()
    {
        if(puntos>=30)
        {
            aciertos.text = "Maxima Puntuacion \n      " + puntos+"  \nEXCELENTE";

        }
        if (puntos >=20 && puntos <= 29)
        {
            aciertos.text = "Maxima Puntuacion \n      " + puntos + "  \nMUY BIEN";
    
        }
        if (puntos >= 10 && puntuaje.puntos <= 19)
        {
            aciertos.text = "Maxima Puntuacion \n      " + puntos + "  \nBIEN";

        }
        if (puntos >= 1 && puntos <= 9)
        {
            aciertos.text = "Maxima Puntuacion \n      " + puntos + "  \n Intenta de nuevo";

        }
    }
}
