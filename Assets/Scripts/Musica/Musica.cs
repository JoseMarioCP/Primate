using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musica : MonoBehaviour
{
    //REFERENCIA AL AUDIO
    public AudioSource tema;

    public AudioClip brotarObjeto, RespuestaC;
    public AudioClip RespuestaI;
    public AudioClip TiempoLimite;

    public void Incorrecta()
    {
        ReproduceSonido(RespuestaI);
    }


    public void Correcta()
    {
        ReproduceSonido(RespuestaC);
    }

    public void FueraDeTiempo()
    {
        ReproduceSonido(TiempoLimite);
    }

    public void brotar()
    {
        ReproduceSonido(brotarObjeto);
    }


    void ReproduceSonido(AudioClip sonido)
    {
        tema.clip = sonido;
        tema.loop = false;
        tema.Play();
    }

    public void bajaVolumen()
     {
        
            tema.volume=0.2f;
    }
    public void subirVolumen()
    {
        tema.volume = 1f;

    }


    public void Detener()
    {
        tema.Stop();
    }

}
