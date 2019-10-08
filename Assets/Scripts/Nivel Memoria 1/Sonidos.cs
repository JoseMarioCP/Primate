using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonidos : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip acierto,incorrecto,pregunta;


    public void reproducirSonido(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.loop = false;
        audioSource.Play();

    }


    void acertaste()
    {
        reproducirSonido(acierto);
    }

    void fallaste()
    {
        reproducirSonido(incorrecto);
    }

    void preguntando()
    {
        reproducirSonido(pregunta);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
