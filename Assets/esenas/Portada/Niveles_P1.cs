using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Niveles_P1 : MonoBehaviour
{
    public Button b1, b2, b3, b4, b5, b6;
    public string n1, n2, n3, n4, n5, n6;
    // Update is called once per frame
    public void contar()
    {
        SceneManager.LoadScene(n1);
    }
    public void numerosPalabras()
    {
        SceneManager.LoadScene(n2);
    }

    public void compararNumeros()
    {
        SceneManager.LoadScene(n3);
    }
    public void numeroSiguiente()
    {
        SceneManager.LoadScene(n4);
    }

    public void Suma()
    {
        SceneManager.LoadScene(n6);
    }
}
