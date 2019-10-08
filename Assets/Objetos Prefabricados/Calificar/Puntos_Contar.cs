using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Puntos_Contar : MonoBehaviour
{
    public int puntosNumero = 0;
    public GameObject canvasPrincipal;
    public Text puntos;
    public GameObject canvasFinal;
    public Text textoCalificacion, numAciertos;

    public void incrementarPuntos()
    {
        puntosNumero++;
        puntos.text = "puntos: " + puntosNumero.ToString();
    }

    public void decrementarPuntos()
    {
        
        if (puntosNumero==0)
        {
           
            puntos.text = "puntos: " + puntosNumero.ToString();
        }

        if (puntosNumero > 0)
        {
            puntosNumero--;
            puntos.text = "puntos: " + puntosNumero.ToString();
        }
        puntos.text = "puntos: " + puntosNumero.ToString();
        
    }
    public void Calificar()
    {
        canvasPrincipal.SetActive(false);

        if(puntosNumero>=9)
        {
            textoCalificacion.text = " Excelente";
        }

        if (puntosNumero >= 6 && puntosNumero <=8 )
        {
            textoCalificacion.text = "Muy Bien";
        }

        if (puntosNumero <= 5 )
        {
            textoCalificacion.text ="Intenta de nuevo";
        }
        numAciertos.text = puntosNumero.ToString() + "/10";
        canvasFinal.SetActive(true);

    }
}
