using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausarPartida : MonoBehaviour
{
    public string esena;
    public ControlarAnimaciones transiciones;
    public Canvas canvasPausa;
    public BotonesPulsados BS, BN;
   
    public AudioSource musica;


    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
                canvasPausa.gameObject.SetActive(true);
                Debug.Log("activando el canvas");
                Time.timeScale = 0f;
                musica.Pause();
          

        }

        if (BS.pulsado)
        {
            musica.Stop();
            BS.pulsado = false;
            Time.timeScale = 2f;
           
            transiciones.animacionFinal();
            StartCoroutine(EsperarAnimacion());
          
         
        }

        if (BN.pulsado)
        {
            BN.pulsado = false;
            canvasPausa.gameObject.SetActive(false);
            musica.Play();
            Time.timeScale = 1f;

        }


    }

    IEnumerator EsperarAnimacion()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(esena);
    }
}
