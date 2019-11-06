using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioPortada : MonoBehaviour
{

    public int menu = 0;

    public Animator transicionPrincipal;


    public GameObject fondo, fondo2,fondo3;
    public int objeto;  //es el objeto indestruible entre esenas
    public GameObject transicionTemas;
    public Musica sonidos;
    public GameObject logoSprite, arcoNumeros;
    public GameObject canvasDetector,canvasOpcionesPrincipales,canvasGrados,CanvasPrimero, CanvasSegundo, DetectorBotonRegresar;
     public Animator animacionInicial,letreroOpcionesPrincipales, letreroOpcionesGrados,transicionTemasA;
    public Animator mono;
    //  public Animator animacionInicial, letreroOpcionesPrincipales, cartelPrimero,transicionTemasA;

    public BotonesPulsados logo,DetectarJugar, DetectarPremios, DetectarCreditos,primero,segundo,tercero,botonRegresar;
    public bool titulos;
   

    // Start is called before the first frame update
    void Awake()
    {
        objeto = GameObject.Find("objetoindestruible").GetComponent<ObjetoEsenas>().capa;
        comprobarRegreso(objeto);

        StartCoroutine(esperarEmpezar());
        Time.timeScale = 1f;
    }



    //animacion de la transicion al empezar el juego 
    IEnumerator esperarEmpezar()
    {

        // transicionPrincipal.SetTrigger("empezar");
        animacionInicial.SetTrigger("empezar");
        yield return new WaitForSeconds(1f);
        //transicionPrincipal.enabled = false;
    }


    //se comprueba el regreso de un nivel a la portada paraa determinar el 
    //canvas con los niveles del grado
    void comprobarRegreso(int capa)
    {

        if(capa==1)
         {
            menu = 3;
            DetectorBotonRegresar.SetActive(true);
            logoSprite.SetActive(false);
            arcoNumeros.SetActive(false);
            fondo.SetActive(false);
            fondo2.SetActive(true);
            canvasOpcionesPrincipales.SetActive(false);        
            StartCoroutine(animacionNivelesPrimero());
        }

        if (capa == 2)
        {
            menu = 3;
            DetectorBotonRegresar.SetActive(true);
            logoSprite.SetActive(false);
            arcoNumeros.SetActive(false);
            fondo.SetActive(false);
            fondo2.SetActive(true);
            canvasOpcionesPrincipales.SetActive(false);
            StartCoroutine(animacionNivelesSegundo());
        }
    }


    

    /**********   ANIMACION DE LOS CANVAS DE LAS OPCIONES PRINCIPALES Y SECUNDARIAS  **********/


    //Canvas principales Letrero 1
    IEnumerator animacionOpciones1()
    {
       
        yield return new WaitForSeconds(0.8f);
        fondo.SetActive(false);
        fondo2.SetActive(true);

        DetectorBotonRegresar.SetActive(true);
        canvasOpcionesPrincipales.SetActive(true);
        letreroOpcionesPrincipales.SetTrigger("bajar");
        DetectorBotonRegresar.SetActive(true);
        //desactivando los logos del juego
        logoSprite.SetActive(false);
        arcoNumeros.SetActive(false);
    }


    //Canvas de opciones GRados (Letrero 2 contiene primero,segundo y tercero)
    IEnumerator animacionOpciones2()
    {
        yield return new WaitForSeconds(1f);
        canvasOpcionesPrincipales.SetActive(false);
        canvasGrados.SetActive(true);
        letreroOpcionesGrados.SetTrigger("bajar");
    }


        /**********   ANIMACION DE LOS CANVAS QUE CONTIENE LOS NIVELES DE LOS TRES GRADOS  **********/

    //Canvas de los temas Primero
    IEnumerator animacionNivelesPrimero()
    {
        transicionPrincipal.SetTrigger("salir");
        
        yield return new WaitForSeconds(0.8f);

        transicionPrincipal.ResetTrigger("salir");

        fondo2.SetActive(false);
        fondo3.SetActive(true);
        canvasGrados.SetActive(false);
        CanvasPrimero.SetActive(true);
      //  letreroOpcionesGrados.SetTrigger("bajar");
        //transicionTemas.SetTrigger("empezar");
        //transicionTemas.SetActive(true); 
    }


    //Canvas de los temas Primero
    IEnumerator animacionNivelesSegundo()
    {
        transicionPrincipal.SetTrigger("salir");

        yield return new WaitForSeconds(0.8f);

        transicionPrincipal.ResetTrigger("salir");

        fondo2.SetActive(false);
        fondo3.SetActive(true);
        canvasGrados.SetActive(false);
        CanvasSegundo.SetActive(true);
        //  letreroOpcionesGrados.SetTrigger("bajar");
        //transicionTemas.SetTrigger("empezar");
        //transicionTemas.SetActive(true); 
    }





    //corrutinas para regresar a las opciones anteriores
    IEnumerator regresarALogo()
    {
        menu--;
        yield return new WaitForSeconds(0.8f);
        canvasDetector.SetActive(true);
        canvasOpcionesPrincipales.SetActive(false);
        DetectorBotonRegresar.SetActive(false);
        fondo2.SetActive(false);
        fondo.SetActive(true);

        logoSprite.SetActive(true);
        arcoNumeros.SetActive(true);
        animacionInicial.SetTrigger("empezar");
    
    }

    IEnumerator regresarAOP()
    {
        menu--;
        yield return new WaitForSeconds(0.8f);

        canvasGrados.SetActive(false);
        canvasOpcionesPrincipales.SetActive(true);
        //animacionInicial.SetTrigger("empezar");
    }

    IEnumerator regresarAOPG()
    {
        transicionPrincipal.SetTrigger("salir");

        menu--;
        yield return new WaitForSeconds(0.8f);
        transicionPrincipal.ResetTrigger("salir");

        fondo2.SetActive(true);
        fondo3.SetActive(false);

        CanvasPrimero.SetActive(false);
        CanvasSegundo.SetActive(false);

        canvasGrados.SetActive(true);
        //canvasGrados.SetActive(true);
        //canvasOpcionesPrincipales.SetActive(true);
        //animacionInicial.SetTrigger("empezar");
    }


    void Regresar()
    {
        if(menu==1)
        {   
            letreroOpcionesPrincipales.SetTrigger("subir");
            StartCoroutine(regresarALogo());          
        }

        if (menu == 2)
        {

            letreroOpcionesGrados.SetTrigger("subir");
            StartCoroutine(regresarAOP());
        }

        if (menu == 3)
        {

            letreroOpcionesGrados.SetTrigger("subir");
            StartCoroutine(regresarAOPG());
        }

    }

    // Update is called once per frame
    void Update()
    {

       if(botonRegresar.pulsado)
        {
            Regresar();
        }

        if (logo.pulsado)
        {
            menu++;

            sonidos.brotar();
            //sonidos.Correcta();
            animacionInicial.SetTrigger("desvanecer");
            mono.SetTrigger("pulsado");
            canvasDetector.SetActive(false);
            StartCoroutine(animacionOpciones1());
            logo.pulsado = false;
        }

        if (DetectarJugar.pulsado)
        {

            menu++;
            letreroOpcionesPrincipales.SetTrigger("subir");
            StartCoroutine(animacionOpciones2());
        }


        if (primero.pulsado)
        {
            menu++;
            primero.pulsado = false;
            //letreroOpcionesGrados.SetTrigger("subir");
            StartCoroutine(animacionNivelesPrimero());
        }

        
        if (segundo.pulsado)
        {
            menu++;
            segundo.pulsado = false;
            //letreroOpcionesGrados.SetTrigger("subir");
            StartCoroutine(animacionNivelesSegundo());
        }
        


        if (titulos)
        {       
            canvasDetector.SetActive(false);
            CanvasPrimero.SetActive(true);
            logo.pulsado = false;
            titulos = false;
        }
    }

}
