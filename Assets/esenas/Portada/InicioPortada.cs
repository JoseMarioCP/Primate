using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioPortada : MonoBehaviour
{
    public Musica sonidos;
    public GameObject logosprite;
    public GameObject canvasPrincipal,CanvasMenu;
    public Animator animacionInicial;
    public BotonesPulsados logo;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(logo.pulsado)
        {
            sonidos.brotar();
            //sonidos.Correcta();
            animacionInicial.SetTrigger("desvanecer");
            canvasPrincipal.SetActive(false);
            CanvasMenu.SetActive(true);
            logo.pulsado = false;
        }
    }

}
