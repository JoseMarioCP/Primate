using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{

    int puntos = 0;
    public Text txtPuntos;

    // Start is called before the first frame update
    void Start()
    {
        txtPuntos.text = "Puntos: " + puntos.ToString();
    }


    public void Incrementar()
    {
        puntos++;
        txtPuntos.text = "Puntos: " + puntos.ToString();
    }
}
