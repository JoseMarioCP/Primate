using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrdenarNumeros : MonoBehaviour
{

    public GameObject contenedores;
    public int IntentosJugar;
    public Puntos_Contar Marcador;

    public int iteraciones = 0;


    public Transform respawn1, respawn2,respawn3;
    public Text numerotxt;
    public int numero = 0, numeroAnterior=0 , numeroSiguiente = 0;

    //public List<GameObject> DAD;

    
    public List<GameObject> numeros;
    public List<GameObject> respuestas;

    public GameObject objGanar;
    public Text Correcto;

    public int valor1 = 0, valor2 = 0;
   

    // Start is called before the first frame update
    void Start()
    { 
        generarNumero();
        colocar_nombres();  
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyUp(KeyCode.A))
        {
            generarNumero();
            colocar_nombres();
        }
        */
        if (respuestas.Count > 0)
        {
            verificarSeleccion();
        }
    }
    public void generarNumero()
    {
       
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
            numero = Random.Range(2, 9);
            numerotxt.text = "" + numero;
            numeroAnterior = numero - 1;
            numeroSiguiente = numero + 1;
            colocar_nombres();


        }


    }

    IEnumerator Nuevo_Numero()
    {
        yield return new WaitForSeconds(0.5f);
        objGanar.SetActive(false);
        generarNumero();
        

    }

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
                        if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroAnterior)
                        {
                            respuestas[x].gameObject.GetComponent<DAD_Ordenar1>().bloqueado = false;
                            valor1 = 1;
                        }
                        else
                        {
                            if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroSiguiente)
                            {
                                valor2 = 1;
                                respuestas[x].gameObject.GetComponent<DAD_Ordenar1>().bloqueado = false;

                            }
                          
                        }
                        
                    }

                }


                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 2)
                {
                    if (respuestas[x].gameObject.GetComponent<DAD_Ordenar2>().bloqueado == true)
                    {
                        if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroAnterior)
                        {
                            respuestas[x].gameObject.GetComponent<DAD_Ordenar2>().bloqueado = false;
                            valor1 = 1;
                        }
                        else
                        {
                            if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroSiguiente)
                            {
                                respuestas[x].gameObject.GetComponent<DAD_Ordenar2>().bloqueado = false;
                                valor2 = 1;
                            }
                        }

                    }

                }

                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 3)
                {
                    if (respuestas[x].gameObject.GetComponent<DAD_Ordenar3>().bloqueado == true)
                    {
                        if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroAnterior)
                        {
                            valor1 = 1; 
                            respuestas[x].gameObject.GetComponent<DAD_Ordenar3>().bloqueado = false;
                           
                        }
                        else
                        {
                            if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroSiguiente)
                            {
                                respuestas[x].gameObject.GetComponent<DAD_Ordenar3>().bloqueado = false;
                                valor2 = 1;
                            }
                        }

                    }

                }

                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 4)
                {
                    if (respuestas[x].gameObject.GetComponent<DAD_Ordenar4>().bloqueado == true)
                    {
                        if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroAnterior)
                        {
                            respuestas[x].gameObject.GetComponent<DAD_Ordenar4>().bloqueado = false;
                            valor1 = 1;
                        }
                        else
                        {
                            if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroSiguiente)
                            {
                                respuestas[x].gameObject.GetComponent<DAD_Ordenar4>().bloqueado = false;
                                valor2 = 1;
                            }

                        }

                    }

                }



                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 5)
                {
                    if (respuestas[x].gameObject.GetComponent<DAD_Ordenar5>().bloqueado == true)
                    {
                        if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroAnterior)
                        {
                            respuestas[x].gameObject.GetComponent<DAD_Ordenar5>().bloqueado = false;       
                            valor1 = 1;
                        }
                        else
                        {
                            if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroSiguiente)
                            {
                                respuestas[x].gameObject.GetComponent<DAD_Ordenar5>().bloqueado = false;
                                valor2 = 1;
                            }

                        }



                    }

                }

                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 6)
                {
                    if (respuestas[x].gameObject.GetComponent<DAD_Ordenar6>().bloqueado == true)
                    {
                        if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroAnterior)
                        {
                            respuestas[x].gameObject.GetComponent<DAD_Ordenar6>().bloqueado = false; 
                            valor1 = 1;
                        }
                        else
                        {
                            if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroSiguiente)
                            {
                                respuestas[x].gameObject.GetComponent<DAD_Ordenar6>().bloqueado = false;
                                valor2 = 1;
                            }
                        }

                       
                      

                    }

                }

                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 7)
                {
                    if (respuestas[x].gameObject.GetComponent<DAD_Ordenar7>().bloqueado == true)
                    {
                        if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroAnterior)
                        {  
                            respuestas[x].gameObject.GetComponent<DAD_Ordenar7>().bloqueado = false;                         
                            valor1 = 1;
                        }
                        else
                        {
                            if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroSiguiente)
                            {
                                respuestas[x].gameObject.GetComponent<DAD_Ordenar7>().bloqueado = false;
                                valor2 = 1;
                            }
                        }

                    }

                }

                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 8)
                {
                    if (respuestas[x].gameObject.GetComponent<DAD_Ordenar8>().bloqueado == true)
                    {
                        if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroAnterior)
                        {
                            respuestas[x].gameObject.GetComponent<DAD_Ordenar8>().bloqueado = false;
                            valor1 = 1;
                        }
                        else
                        {
                            if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroSiguiente)
                            {
                                respuestas[x].gameObject.GetComponent<DAD_Ordenar8>().bloqueado = false;
                                valor2 = 1;
                            }
                        }

                    }

                }

                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 9)
                {
                    if (respuestas[x].gameObject.GetComponent<DAD_Ordenar9>().bloqueado == true)
                    {
                        if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroAnterior)
                        {
                            respuestas[x].gameObject.GetComponent<DAD_Ordenar9>().bloqueado = false;                          
                            valor1 = 1;
                        }
                        else
                        {
                            if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroSiguiente)
                            {
                                respuestas[x].gameObject.GetComponent<DAD_Ordenar9>().bloqueado = false;
                                valor2 = 1;
                            }
                        }

                    }

                }

                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 10)
                {
                    if (respuestas[x].gameObject.GetComponent<DAD_Ordenar10>().bloqueado == true)
                    {
                        if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroAnterior)
                        {
                            respuestas[x].gameObject.GetComponent<DAD_Ordenar10>().bloqueado = false;
                            valor1 = 1;
                        }
                        else
                        {
                            if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroSiguiente)
                            {
                                valor2 = 1;
                                respuestas[x].gameObject.GetComponent<DAD_Ordenar10>().bloqueado = false;

                            }

                        }



                    }

                }

                //fin del ciclo

            }

            if(valor1!=0 && valor2!=0)
            {
                CompararRespuestas();
            }
        }
    }


    //establecer numero anterior y siguiente

    void establecerAnteriorSiguiente()
    {

        if (respuestas.Count > 0)
        {

            for (int x = 0; x < respuestas.Count; x++)
            {

                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre ==1 )
                {
                  
                        if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroAnterior)
                        {
                        respuestas[x].gameObject.GetComponent<DAD_Ordenar1>().posicionContenedor = GameObject.Find("Contenedor_1").transform;

                        }

                        if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroSiguiente)
                        {
                        respuestas[x].gameObject.GetComponent<DAD_Ordenar1>().posicionContenedor = GameObject.Find("Contenedor_2").transform;


                    }

                    

                }

                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 2)
                {
                    
                    if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroAnterior)
                    {
                        respuestas[x].gameObject.GetComponent<DAD_Ordenar2>().posicionContenedor = GameObject.Find("Contenedor_1").transform;

                    }

                    if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroSiguiente)
                    {
                        respuestas[x].gameObject.GetComponent<DAD_Ordenar2>().posicionContenedor = GameObject.Find("Contenedor_2").transform;
                    }

                }
                  
                    if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 3)
                    {
                       
                        if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroAnterior)
                        {
                            respuestas[x].gameObject.GetComponent<DAD_Ordenar3>().posicionContenedor = GameObject.Find("Contenedor_1").transform;

                        }

                        if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroSiguiente)
                        {
                            respuestas[x].gameObject.GetComponent<DAD_Ordenar3>().posicionContenedor = GameObject.Find("Contenedor_2").transform;
    
                        }

                    }
                        if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 4)
                        {
                           
                            if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroAnterior)
                            {
                                respuestas[x].gameObject.GetComponent<DAD_Ordenar4>().posicionContenedor = GameObject.Find("Contenedor_1").transform;

                            }

                            if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroSiguiente)
                            {
                                respuestas[x].gameObject.GetComponent<DAD_Ordenar4>().posicionContenedor = GameObject.Find("Contenedor_2").transform;

                            }

                        }

                        if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 5)
                        {
                           
                            if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroAnterior)
                            {
                                respuestas[x].gameObject.GetComponent<DAD_Ordenar5>().posicionContenedor = GameObject.Find("Contenedor_1").transform;

                            }

                            if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroSiguiente)
                            {
                                respuestas[x].gameObject.GetComponent<DAD_Ordenar5>().posicionContenedor = GameObject.Find("Contenedor_2").transform;

                            }

                        }


                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 6)
                {

                    if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroAnterior)
                    {
                        respuestas[x].gameObject.GetComponent<DAD_Ordenar6>().posicionContenedor = GameObject.Find("Contenedor_1").transform;

                    }

                    if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroSiguiente)
                    {
                        respuestas[x].gameObject.GetComponent<DAD_Ordenar6>().posicionContenedor = GameObject.Find("Contenedor_2").transform;

                    }

                }


                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 7)
                {

                    if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroAnterior)
                    {
                        respuestas[x].gameObject.GetComponent<DAD_Ordenar7>().posicionContenedor = GameObject.Find("Contenedor_1").transform;

                    }

                    if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroSiguiente)
                    {
                        respuestas[x].gameObject.GetComponent<DAD_Ordenar7>().posicionContenedor = GameObject.Find("Contenedor_2").transform;

                    }

                }

                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 8)
                {

                    if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroAnterior)
                    {
                        respuestas[x].gameObject.GetComponent<DAD_Ordenar8>().posicionContenedor = GameObject.Find("Contenedor_1").transform;

                    }

                    if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroSiguiente)
                    {
                        respuestas[x].gameObject.GetComponent<DAD_Ordenar8>().posicionContenedor = GameObject.Find("Contenedor_2").transform;

                    }

                }

                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 9)
                {

                    if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroAnterior)
                    {
                        respuestas[x].gameObject.GetComponent<DAD_Ordenar9>().posicionContenedor = GameObject.Find("Contenedor_1").transform;

                    }

                    if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroSiguiente)
                    {
                        respuestas[x].gameObject.GetComponent<DAD_Ordenar9>().posicionContenedor = GameObject.Find("Contenedor_2").transform;
  
                    }

                }

                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 10)
                {

                    if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroAnterior)
                    {
                        respuestas[x].gameObject.GetComponent<DAD_Ordenar10>().posicionContenedor = GameObject.Find("Contenedor_1").transform;

                    }

                    if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numeroSiguiente)
                    {
                        respuestas[x].gameObject.GetComponent<DAD_Ordenar10>().posicionContenedor = GameObject.Find("Contenedor_2").transform;

                    }

                }


            }   //fin del ciclo


        }

    }



    void colocar_nombres()
    {
        limpiar_respuestas();


       // respuestas.Add(Instantiate(numeros[numero], respawn1.transform.position, Quaternion.identity));
        respuestas.Add(Instantiate(numeros[numeroAnterior], respawn2.transform.position, Quaternion.identity));
        respuestas.Add(Instantiate(numeros[numeroSiguiente], respawn3.transform.position, Quaternion.identity));

        establecerAnteriorSiguiente();

        // int n1, n2;
        //int posicion = Random.Range(1, 3);

        /*
        switch (posicion)
        {
            case 1:

                respuestas.Add(Instantiate(numeros[numero], respawn1.transform.position, Quaternion.identity));

                n1 = Random.Range(1, 10);
                if (n1 == numero)
                {
                    n1 = Random.Range(1, 10);
                }

                respuestas.Add(Instantiate(numeros[numeroAnterior], respawn2.transform.position, Quaternion.identity));

                n2 = Random.Range(1, 10);
                if (n1 == n2 || n2 == numero)
                {
                    n2 = Random.Range(1, 10);
                }

                respuestas.Add(Instantiate(numeros[numeroSiguiente], respawn3.transform.position, Quaternion.identity));

                break;

            case 2:
                n1 = Random.Range(1, 10);
                if (n1 == numero)
                {
                    n1 = Random.Range(1, 10);
                }

                respuestas.Add(Instantiate(numeros[n1], respawn1.transform.position, Quaternion.identity));


                respuestas.Add(Instantiate(numeros[numero], respawn2.transform.position, Quaternion.identity));

                n2 = Random.Range(1, 10);
                if (n1 == n2 || n2 == numero)
                {
                    n2 = Random.Range(1, 10);
                }

                respuestas.Add(Instantiate(numeros[n2], respawn3.transform.position, Quaternion.identity));

                break;

            case 3:
                n1 = Random.Range(1, 10);
                if (n1 == numero)
                {
                    n1 = Random.Range(1, 10);
                }

                respuestas.Add(Instantiate(numeros[n1], respawn1.transform.position, Quaternion.identity));

                n2 = Random.Range(1, 10);
                if (n1 == n2 || n2 == numero)
                {
                    n2 = Random.Range(1, 10);
                }

                respuestas.Add(Instantiate(numeros[n2], respawn2.transform.position, Quaternion.identity));


                respuestas.Add(Instantiate(numeros[numero], respawn3.transform.position, Quaternion.identity));

                break;
        }
        */
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
