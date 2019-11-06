using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Niveles_P1 : MonoBehaviour
{
    public Animator transicionPrincipal;
    public ObjetoEsenas objetoIndes;
    public Animator animacionFinal;
    public Button b1, b2, b3, b4, b5, b6;
    public string n1, n2, n3, n4, n5, n6;
    
    IEnumerator cargarEsena(string escena)
    {
        objetoIndes.capa = 1;

        transicionPrincipal.SetTrigger("salir");
            yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene(escena);
    }

    // Update is called once per frame
    public void contar()
    {
        
        StartCoroutine(cargarEsena(n1));
        //SceneManager.LoadScene(n1);
    }
    public void numerosPalabras()
    {
        StartCoroutine(cargarEsena(n2));
        //SceneManager.LoadScene(n2);
    }

    public void compararNumeros()
    {
        StartCoroutine(cargarEsena(n3));
        //SceneManager.LoadScene(n3);
    }
    public void numeroSiguiente()
    {
        StartCoroutine(cargarEsena(n4));
        //SceneManager.LoadScene(n4);
    }


    public void Patrones()
    {
        StartCoroutine(cargarEsena(n5));
        //SceneManager.LoadScene(n5);
    }

    public void Suma()
    {
        StartCoroutine(cargarEsena(n6));
 //       SceneManager.LoadScene(n6);
    }
}
