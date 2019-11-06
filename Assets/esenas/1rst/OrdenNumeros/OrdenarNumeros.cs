using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrdenarNumeros : MonoBehaviour
{

    public BotonesPulsados jugar;
    public GameObject instrucciones;
    public GameObject canvasPrincipal;
    public GameObject contenedorImagen;
    public Timer tiempo;
    public Musica sonidos;
    public GameObject contenedores;
    public int IntentosJugar;
    public Puntos_Contar Marcador;

    public int iteraciones = 0;


    public Transform respawn1, respawn2,respawn3;
    public Text numerotxt1, numerotxt2;
    public int numero = 0, numeroAnterior=0 , numeroSiguiente = 0, numeroSiguiente2=0;

    //public List<GameObject> DAD;

    
    public List<GameObject> numeros;
    public List<GameObject> respuestas;

    public GameObject objGanar;
    public Text Correcto;

    public int valor1 = 0, valor2 = 0;
   

    // Start is called before the first frame update
    void Start()
    { 
        //generarNumero();
        //colocar_nombres();  
    }

    // Update is called once per frame
    void Update()
    {
        if(tiempo.tiempo<=0)
        {
            Marcador.decrementarPuntos();
            tiempo.reanudar();
            sonidos.FueraDeTiempo();
            StartCoroutine(Nuevo_Numero());
        }

        if (jugar.pulsado)
        {
            jugar.pulsado = false;
            instrucciones.SetActive(false);
            contenedorImagen.SetActive(true);
            canvasPrincipal.SetActive(true);
            generarNumero();
            //colocar_nombres();
            
        }

        
        if (respuestas.Count > 0)
        {
            verificarSeleccion();
        }
    }
    public void generarNumero()
    {
        limpiar_respuestas();
        if (iteraciones >= IntentosJugar)
        {
            // Correcto.text = "Partida Terminada";
            //objGanar.SetActive(true);
            contenedores.SetActive(false);
            limpiar_respuestas();
            Marcador.Calificar();
            gameObject.GetComponent<OrdenarNumeros>().enabled = false;
        }
        else
        {
            numero = Random.Range(2, 10);
            numerotxt1.text = "" + numero;
            numerotxt2.text = "" + (numero + 2);
            numeroAnterior = numero - 1;
            numeroSiguiente = numero + 1;
            if(numero<=7)
            {
                numeroSiguiente2 = numero + 3;
            }
            else
            {
                numeroSiguiente2 = numero -2;
            }

            //Invoke("colocar_nombres", 1.5f);
            colocar_nombres();
        }
    }



    IEnumerator Nuevo_Numero()
    {
        yield return new WaitForSeconds(.2f);
        objGanar.SetActive(false);
        generarNumero();
        

    }
    /*
    void CompararRespuestas()
    {
        if(valor1==1 && valor2==1)
        {
            valor1 = 0;
            valor2 = 0;
           // Correcto.text = "Respuesta Correccta";
           // objGanar.SetActive(true);
            //Marcador.Incrementar();
            iteraciones++;
            Marcador.incrementarPuntos();
           
            StartCoroutine(Nuevo_Numero());

        }
        else
        {
            //Correcto.text = "Respuesta Incorrecta";
           // objGanar.SetActive(true);
            iteraciones++;
            StartCoroutine(Nuevo_Numero());
           
        }
    }
    */
    
    void verificarSeleccion()
    {

        if (respuestas.Count > 0)
        {

            for (int x = 0; x < respuestas.Count; x++)
            {

                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 1)
                {
                    if (respuestas[x].gameObject.GetComponent<DAD_Ordenar1>().bloqueado == true)
                    {
                            if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroSiguiente)
                            {
                              
                                respuestas[x].gameObject.GetComponent<DAD_Ordenar1>().bloqueado = false;
                                iteraciones++;
                                Marcador.incrementarPuntos();
                                sonidos.Correcta();
                                StartCoroutine(Nuevo_Numero());

                            }
                            else
                            {
                                respuestas[x].gameObject.GetComponent<DAD_Ordenar1>().bloqueado = false;
                                iteraciones++;
                                sonidos.Incorrecta();
                                 Marcador.decrementarPuntos();
                                StartCoroutine(Nuevo_Numero());
                        }
                        tiempo.contadorCero();
                        tiempo.reanudar();


                    }

                }


                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 2)
                {
                    if (respuestas[x].gameObject.GetComponent<DAD_Ordenar2>().bloqueado == true)
                    {
                        
                            if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroSiguiente)
                            {
                                respuestas[x].gameObject.GetComponent<DAD_Ordenar2>().bloqueado = false;
                            iteraciones++;
                            sonidos.Correcta();
                            Marcador.incrementarPuntos();
                            StartCoroutine(Nuevo_Numero());
                        }
                        else
                        {
                            respuestas[x].gameObject.GetComponent<DAD_Ordenar2>().bloqueado = false;
                            iteraciones++;
                            sonidos.Incorrecta();
                            Marcador.decrementarPuntos();
                            StartCoroutine(Nuevo_Numero());
                        }
                        tiempo.contadorCero();
                        tiempo.reanudar();
                    }

                }

                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 3)
                {
                    if (respuestas[x].gameObject.GetComponent<DAD_Ordenar3>().bloqueado == true)
                    {
                       
                            if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroSiguiente)
                            {
                                respuestas[x].gameObject.GetComponent<DAD_Ordenar3>().bloqueado = false;
                            iteraciones++;
                            sonidos.Correcta();
                            Marcador.incrementarPuntos();
                            StartCoroutine(Nuevo_Numero());
                        }
                        else
                        {
                            respuestas[x].gameObject.GetComponent<DAD_Ordenar3>().bloqueado = false;
                            iteraciones++;
                            sonidos.Incorrecta();
                            Marcador.decrementarPuntos();
                            StartCoroutine(Nuevo_Numero());
                        }
                        tiempo.contadorCero();
                        tiempo.reanudar();
                    }

                }

                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 4)
                {
                    if (respuestas[x].gameObject.GetComponent<DAD_Ordenar4>().bloqueado == true)
                    {
                       
                            if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroSiguiente)
                            {
                                respuestas[x].gameObject.GetComponent<DAD_Ordenar4>().bloqueado = false;
                            iteraciones++;
                            sonidos.Correcta();
                            Marcador.incrementarPuntos();
                            StartCoroutine(Nuevo_Numero());
                        }
                        else
                        {
                            respuestas[x].gameObject.GetComponent<DAD_Ordenar4>().bloqueado = false;
                            iteraciones++;
                            sonidos.Incorrecta();
                            Marcador.decrementarPuntos();
                            StartCoroutine(Nuevo_Numero());
                        }
                        tiempo.contadorCero();
                        tiempo.reanudar();
                    }

                }



                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 5)
                {
                    if (respuestas[x].gameObject.GetComponent<DAD_Ordenar5>().bloqueado == true)
                    {
                        
                            if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroSiguiente)
                            {
                                respuestas[x].gameObject.GetComponent<DAD_Ordenar5>().bloqueado = false;
                            iteraciones++;
                            sonidos.Correcta();
                            Marcador.incrementarPuntos();
                            StartCoroutine(Nuevo_Numero());
                        }
                        else
                        {
                            respuestas[x].gameObject.GetComponent<DAD_Ordenar5>().bloqueado = false;
                            iteraciones++;
                            sonidos.Incorrecta();
                            Marcador.decrementarPuntos();
                            StartCoroutine(Nuevo_Numero());
                        }
                        tiempo.contadorCero();
                        tiempo.reanudar();


                    }

                }

                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 6)
                {
                    if (respuestas[x].gameObject.GetComponent<DAD_Ordenar6>().bloqueado == true)
                    {
                       
                            if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroSiguiente)
                            {
                                respuestas[x].gameObject.GetComponent<DAD_Ordenar6>().bloqueado = false;
                            iteraciones++;
                            sonidos.Correcta();
                            Marcador.incrementarPuntos();
                            StartCoroutine(Nuevo_Numero());
                        }
                        else
                        {
                            respuestas[x].gameObject.GetComponent<DAD_Ordenar6>().bloqueado = false;
                            iteraciones++;
                            sonidos.Incorrecta();
                            Marcador.decrementarPuntos();
                            StartCoroutine(Nuevo_Numero());
                        }

                        tiempo.contadorCero();
                        tiempo.reanudar();
                    }

                }

                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 7)
                {
                    if (respuestas[x].gameObject.GetComponent<DAD_Ordenar7>().bloqueado == true)
                    {
                        
                            if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroSiguiente)
                            {
                                respuestas[x].gameObject.GetComponent<DAD_Ordenar7>().bloqueado = false;
                            iteraciones++;
                            sonidos.Correcta();
                            Marcador.incrementarPuntos();
                            StartCoroutine(Nuevo_Numero());
                        }
                        else
                        {
                            respuestas[x].gameObject.GetComponent<DAD_Ordenar7>().bloqueado = false;
                            iteraciones++;
                            sonidos.Incorrecta();
                             Marcador.decrementarPuntos();
                            StartCoroutine(Nuevo_Numero());
                        }
                        tiempo.contadorCero();
                        tiempo.reanudar();

                    }

                }

                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 8)
                {
                    if (respuestas[x].gameObject.GetComponent<DAD_Ordenar8>().bloqueado == true)
                    {
                       
                            if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroSiguiente)
                            {
                                respuestas[x].gameObject.GetComponent<DAD_Ordenar8>().bloqueado = false;
                            iteraciones++;
                            sonidos.Correcta();
                            Marcador.incrementarPuntos();
                            StartCoroutine(Nuevo_Numero());
                        }
                        else
                        {
                            respuestas[x].gameObject.GetComponent<DAD_Ordenar8>().bloqueado = false;
                            iteraciones++;
                            sonidos.Incorrecta();
                            Marcador.decrementarPuntos();
                            StartCoroutine(Nuevo_Numero());
                        }
                        tiempo.contadorCero();
                        tiempo.reanudar();
                    }

                }

                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 9)
                {
                    if (respuestas[x].gameObject.GetComponent<DAD_Ordenar9>().bloqueado == true)
                    {
                       
                            if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroSiguiente)
                            {
                                respuestas[x].gameObject.GetComponent<DAD_Ordenar9>().bloqueado = false;
                            iteraciones++;
                            sonidos.Correcta();
                            Marcador.incrementarPuntos();
                            StartCoroutine(Nuevo_Numero());
                        }
                        else
                        {
                            respuestas[x].gameObject.GetComponent<DAD_Ordenar9>().bloqueado = false;
                            iteraciones++;
                            sonidos.Incorrecta();
                            Marcador.decrementarPuntos();
                            StartCoroutine(Nuevo_Numero());
                        }
                        tiempo.contadorCero();
                        tiempo.reanudar();
                    }

                }

                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 10)
                {
                    if (respuestas[x].gameObject.GetComponent<DAD_Ordenar10>().bloqueado == true)
                    {
                       
                            if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroSiguiente)
                            {
                             
                                respuestas[x].gameObject.GetComponent<DAD_Ordenar10>().bloqueado = false;
                            iteraciones++;
                            sonidos.Correcta();
                            Marcador.incrementarPuntos();
                            StartCoroutine(Nuevo_Numero());
                        }
                        else
                        {
                            respuestas[x].gameObject.GetComponent<DAD_Ordenar10>().bloqueado = false;
                            iteraciones++;
                            sonidos.Incorrecta();
                            Marcador.decrementarPuntos();
                            StartCoroutine(Nuevo_Numero());
                        }
                        tiempo.contadorCero();
                        tiempo.reanudar();




                    }

                }

                //fin del ciclo

            }

            
                //CompararRespuestas();
            
        }
    }


    void colocar_nombres()
    {


        /*
        respuestas.Add(Instantiate(numeros[numeroSiguiente], respawn1.transform.position, Quaternion.identity));
        respuestas.Add(Instantiate(numeros[numeroAnterior], respawn2.transform.position, Quaternion.identity));
        respuestas.Add(Instantiate(numeros[numeroSiguiente2], respawn3.transform.position, Quaternion.identity));
       
        establecerAnteriorSiguiente();
         */
        //int n1;
        int posicion = Random.Range(1, 4);


        switch (posicion)
        {
            case 1:
                respuestas.Add(Instantiate(numeros[numeroSiguiente], respawn1.transform.position, Quaternion.identity));
                respuestas.Add(Instantiate(numeros[numeroAnterior], respawn2.transform.position, Quaternion.identity));
                respuestas.Add(Instantiate(numeros[numeroSiguiente2], respawn3.transform.position, Quaternion.identity));

                break;

            case 2:
                respuestas.Add(Instantiate(numeros[numeroAnterior], respawn1.transform.position, Quaternion.identity));
                respuestas.Add(Instantiate(numeros[numeroSiguiente], respawn2.transform.position, Quaternion.identity));
                respuestas.Add(Instantiate(numeros[numeroSiguiente2], respawn3.transform.position, Quaternion.identity));

                break;

            case 3:
                respuestas.Add(Instantiate(numeros[numeroAnterior], respawn1.transform.position, Quaternion.identity));
                respuestas.Add(Instantiate(numeros[numeroSiguiente2], respawn2.transform.position, Quaternion.identity));
                respuestas.Add(Instantiate(numeros[numeroSiguiente], respawn3.transform.position, Quaternion.identity));

                break;
        }
        establecerAnteriorSiguiente();

    }



    //establecer el contendedor del objeto, donde debe ser arrastrado

    void establecerAnteriorSiguiente()
    {

        if (respuestas.Count > 0)
        {

            for (int x = 0; x < respuestas.Count; x++)
            {

                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre ==1 )
                        respuestas[x].gameObject.GetComponent<DAD_Ordenar1>().posicionContenedor = GameObject.Find("Contenedor_1").transform;

                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 2)
                        respuestas[x].gameObject.GetComponent<DAD_Ordenar2>().posicionContenedor = GameObject.Find("Contenedor_1").transform;

                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 3)  
                        respuestas[x].gameObject.GetComponent<DAD_Ordenar3>().posicionContenedor = GameObject.Find("Contenedor_1").transform;

                 if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 4)
                        respuestas[x].gameObject.GetComponent<DAD_Ordenar4>().posicionContenedor = GameObject.Find("Contenedor_1").transform;

                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 5)
                        respuestas[x].gameObject.GetComponent<DAD_Ordenar5>().posicionContenedor = GameObject.Find("Contenedor_1").transform;

                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 6)
                     respuestas[x].gameObject.GetComponent<DAD_Ordenar6>().posicionContenedor = GameObject.Find("Contenedor_1").transform;
  
                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 7)
                        respuestas[x].gameObject.GetComponent<DAD_Ordenar7>().posicionContenedor = GameObject.Find("Contenedor_1").transform;

                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 8)
                        respuestas[x].gameObject.GetComponent<DAD_Ordenar8>().posicionContenedor = GameObject.Find("Contenedor_1").transform;


                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 9)
                        respuestas[x].gameObject.GetComponent<DAD_Ordenar9>().posicionContenedor = GameObject.Find("Contenedor_1").transform;
                    

                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 10)
                        respuestas[x].gameObject.GetComponent<DAD_Ordenar10>().posicionContenedor = GameObject.Find("Contenedor_1").transform;


            }   //fin del ciclo
            StartCoroutine(esperarDecrementar());

        }
    }

    IEnumerator esperarDecrementar()
    {
        yield return new WaitForSeconds(1f);
        tiempo.decrementar = true;
    }

    public void limpiar_respuestas()
    {
        if (respuestas.Count > 0)
        {

            for (int x = 0; x < respuestas.Count; x++)
            {
                Destroy(respuestas[x]);
            }

            respuestas.Clear();
        }

    }
}
