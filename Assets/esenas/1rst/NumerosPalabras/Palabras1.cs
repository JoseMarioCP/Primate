using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Palabras1 : MonoBehaviour
{

    public Musica sonidos;
    public GameObject contenedor,fondo;
    public int IntentosJugar;
    //public Puntos Marcador;
    public Puntos_Contar Marcador;

    public int iteraciones = 0;


    public Transform respawn1, respawn2, respawn3;
    public Text numerotxt;
    public int numero = 0;
    public List<GameObject> palabras;
    public List<GameObject> respuestas;

    public GameObject objGanar;
    public Text Correcto;


    // Start is called before the first frame update
    void Start()
    {
        generarNumero();
        // colocar_nombres();
        StartCoroutine(Nuevo_Numero());
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

    IEnumerator Nuevo_Numero()
    {
        yield return new WaitForSeconds(0.5f);
        //objGanar.SetActive(false);
        generarNumero();
       
    }

    void verificarSeleccion()
    {

        if (respuestas.Count > 0)
        {

            for (int x = 0; x < respuestas.Count; x++)
            {

                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 1)
                {
                    if (respuestas[x].gameObject.GetComponent<DAD_P1>().bloqueado == true)
                    {
                        if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numero)
                        {
                            respuestas[x].gameObject.GetComponent<DAD_P1>().bloqueado = false;
                            // Correcto.text = "Respuesta Correccta";
                            //objGanar.SetActive(true);
                            sonidos.Correcta();
                            iteraciones++;
                            //Marcador.Incrementar();
                            Marcador.incrementarPuntos();
                       
                            StartCoroutine(Nuevo_Numero());

                            
                        }

                        if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre != numero)
                        {
                            respuestas[x].gameObject.GetComponent<DAD_P1>().bloqueado = false;
                            //Correcto.text = "Respuesta Incorrecta";
                            //objGanar.SetActive(true);
                            sonidos.Incorrecta();
                            iteraciones++;
                            Marcador.decrementarPuntos();

                           
                            StartCoroutine(Nuevo_Numero());
                       


                        }

                    }

                }


                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 2)
                {
                    if (respuestas[x].gameObject.GetComponent<DAD_P2>().bloqueado == true)
                    {
                        if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numero)
                        {
                            respuestas[x].gameObject.GetComponent<DAD_P2>().bloqueado = false;
                            //Correcto.text = "Respuesta Correccta";
                            // objGanar.SetActive(true);
                            //Marcador.Incrementar();

                            sonidos.Correcta();
                            iteraciones++;
                            Marcador.incrementarPuntos();
                           
                            StartCoroutine(Nuevo_Numero());
                           
                        }
                        if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre != numero)
                        {
                            respuestas[x].gameObject.GetComponent<DAD_P2>().bloqueado = false;
                            //Correcto.text = "Respuesta Incorrecta";
                            //objGanar.SetActive(true);
                            sonidos.Incorrecta();
                            iteraciones++;
                            Marcador.decrementarPuntos();
                            
                            StartCoroutine(Nuevo_Numero());
                          
                        }

                    }

                }

                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 3)
                {
                    if (respuestas[x].gameObject.GetComponent<DAD_P3>().bloqueado == true)
                    {
                        if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numero)
                        {
                            respuestas[x].gameObject.GetComponent<DAD_P3>().bloqueado = false;
                            //Correcto.text = "Respuesta Correccta";
                            //objGanar.SetActive(true);
                            // Marcador.Incrementar();
                            sonidos.Correcta();
                            iteraciones++;
                            Marcador.incrementarPuntos();
                           
                            StartCoroutine(Nuevo_Numero());
                           
                        }
                        if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre != numero)
                        {
                            respuestas[x].gameObject.GetComponent<DAD_P3>().bloqueado = false;
                            //Correcto.text = "Respuesta Incorrecta";
                            // objGanar.SetActive(true);
                            sonidos.Incorrecta();
                            iteraciones++;
                            Marcador.decrementarPuntos();
                          
                            StartCoroutine(Nuevo_Numero());
                          
                        }

                    }

                }

                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 4)
                {
                    if (respuestas[x].gameObject.GetComponent<DAD_P4>().bloqueado == true)
                    {
                        if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numero)
                        {
                            respuestas[x].gameObject.GetComponent<DAD_P4>().bloqueado = false;
                            //Correcto.text = "Respuesta Correccta";
                            //objGanar.SetActive(true);
                            //Marcador.Incrementar();
                            sonidos.Correcta();
                            iteraciones++;
                            Marcador.incrementarPuntos();
                           
                            StartCoroutine(Nuevo_Numero());
                           
                        }
                        if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre != numero)
                        {
                            respuestas[x].gameObject.GetComponent<DAD_P4>().bloqueado = false;
                            // Correcto.text = "Respuesta Incorrecta";
                            sonidos.Incorrecta();
                            iteraciones++;
                            Marcador.decrementarPuntos();
                           
                            StartCoroutine(Nuevo_Numero());
                            
                        }

                    }

                }



                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 5)
                {
                    if (respuestas[x].gameObject.GetComponent<DAD_P5>().bloqueado == true)
                    {
                        if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numero)
                        {
                            respuestas[x].gameObject.GetComponent<DAD_P5>().bloqueado = false;
                            //Correcto.text = "Respuesta Correccta";
                            //objGanar.SetActive(true);
                            // Marcador.Incrementar();
                            sonidos.Correcta();
                            iteraciones++;
                            Marcador.incrementarPuntos();
                           
                            StartCoroutine(Nuevo_Numero());
                           
                        }
                        if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre != numero)
                        {
                            respuestas[x].gameObject.GetComponent<DAD_P5>().bloqueado = false;
                            // Correcto.text = "Respuesta Incorrecta";
                            //objGanar.SetActive(true);
                            sonidos.Incorrecta();
                            iteraciones++;
                            Marcador.decrementarPuntos();
                           
                            StartCoroutine(Nuevo_Numero());
                            
                        }

                    }

                }

                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 6)
                {
                    if (respuestas[x].gameObject.GetComponent<DAD_P6>().bloqueado == true)
                    {
                        if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numero)
                        {
                            respuestas[x].gameObject.GetComponent<DAD_P6>().bloqueado = false;
                            // Correcto.text = "Respuesta Correccta";
                            // objGanar.SetActive(true);
                            //Marcador.Incrementar();
                            sonidos.Correcta();
                            iteraciones++;
                            Marcador.incrementarPuntos();

                            StartCoroutine(Nuevo_Numero());
                           
                        }
                        if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre != numero)
                        {
                            respuestas[x].gameObject.GetComponent<DAD_P6>().bloqueado = false;
                            //Correcto.text = "Respuesta Incorrecta";
                            //objGanar.SetActive(true);
                            sonidos.Incorrecta();
                            iteraciones++;
                            Marcador.decrementarPuntos();

                           
                            StartCoroutine(Nuevo_Numero());
                            // x += 2;
                        }

                    }

                }

                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 7)
                {
                    if (respuestas[x].gameObject.GetComponent<DAD_P7>().bloqueado == true)
                    {
                        if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numero)
                        {
                            respuestas[x].gameObject.GetComponent<DAD_P7>().bloqueado = false;
                            //Correcto.text = "Respuesta Correccta";
                            //objGanar.SetActive(true);
                            // Marcador.Incrementar();
                            sonidos.Correcta();
                            iteraciones++;
                            Marcador.incrementarPuntos();
                            StartCoroutine(Nuevo_Numero());
                           
                        }
                        if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre != numero)
                        {
                            respuestas[x].gameObject.GetComponent<DAD_P7>().bloqueado = false;
                            // Correcto.text = "Respuesta Incorrecta";
                            // objGanar.SetActive(true);
                            sonidos.Incorrecta();
                            iteraciones++;
                            Marcador.decrementarPuntos();
                           
                            StartCoroutine(Nuevo_Numero());
                            // x += 2;
                        }

                    }

                }

                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 8)
                {
                    if (respuestas[x].gameObject.GetComponent<DAD_P8>().bloqueado == true)
                    {
                        if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numero)
                        {
                            respuestas[x].gameObject.GetComponent<DAD_P8>().bloqueado = false;
                            //Correcto.text = "Respuesta Correccta";
                            //objGanar.SetActive(true);

                            //Marcador.Incrementar();
                            sonidos.Correcta();
                            iteraciones++;
                            Marcador.incrementarPuntos();
                            StartCoroutine(Nuevo_Numero());
                          
                        }
                        if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre != numero)
                        {
                            respuestas[x].gameObject.GetComponent<DAD_P8>().bloqueado = false;
                            // Correcto.text = "Respuesta Incorrecta";
                            // objGanar.SetActive(true);
                            sonidos.Incorrecta();
                            iteraciones++;
                            Marcador.decrementarPuntos();
                            
                            StartCoroutine(Nuevo_Numero());
                            //   x += 2;
                        }

                    }

                }

                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 9)
                {
                    if (respuestas[x].gameObject.GetComponent<DAD_P9>().bloqueado == true)
                    {
                        if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numero)
                        {
                            respuestas[x].gameObject.GetComponent<DAD_P9>().bloqueado = false;
                            //Correcto.text = "Respuesta Correccta";
                            //objGanar.SetActive(true);
                            // Marcador.Incrementar();
                            sonidos.Correcta();
                            iteraciones++;
                            Marcador.incrementarPuntos();
                            StartCoroutine(Nuevo_Numero());
                            
                        }
                        if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre != numero)
                        {
                            respuestas[x].gameObject.GetComponent<DAD_P9>().bloqueado = false;
                            // Correcto.text = "Respuesta Incorrecta";
                            // objGanar.SetActive(true);
                            sonidos.Incorrecta();
                            iteraciones++;
                            Marcador.decrementarPuntos();
                           
                            StartCoroutine(Nuevo_Numero());
                            // x += 2;
                        }

                    }

                }

                if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == 10)
                {
                    if (respuestas[x].gameObject.GetComponent<DAD_P10>().bloqueado == true)
                    {
                        if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre == numero)
                        {
                            respuestas[x].gameObject.GetComponent<DAD_P10>().bloqueado = false;
                            // Correcto.text = "Respuesta Correccta";
                            // objGanar.SetActive(true);
                            // Marcador.Incrementar();
                            sonidos.Correcta();
                            iteraciones++;
                            Marcador.incrementarPuntos();
                            StartCoroutine(Nuevo_Numero());
                            
                        }
                        if (respuestas[x].gameObject.GetComponent<Caracteristica>().Numero_Nombre != numero)
                        {
                            respuestas[x].gameObject.GetComponent<DAD_P10>().bloqueado = false;
                            // Correcto.text = "Respuesta Incorrecta";
                            // objGanar.SetActive(true);
                            sonidos.Incorrecta();
                            iteraciones++;
                            Marcador.decrementarPuntos();
                           
                            StartCoroutine(Nuevo_Numero());
                            // x += 2;
                        }

                    }

                }

                //fin del ciclo

            }


        }
    }



    public void generarNumero()
    {
        if (iteraciones >= IntentosJugar)
        {
            //Correcto.text = "Partida Terminada";
            //objGanar.SetActive(true);
            contenedor.SetActive(false);
            fondo.SetActive(false);
            limpiar_respuestas();
            Marcador.Calificar();
            gameObject.GetComponent<Palabras1>().enabled = false;
        }
        else
        {
            numero = Random.Range(1, 10);
            numerotxt.text = "" + numero;
            colocar_nombres();
            //Invoke("colocar_nombres", f);
        }

        
    }



    void colocar_nombres()
    {
        limpiar_respuestas();

        int n1, n2;
        int posicion = Random.Range(1, 3);

        switch (posicion)
        {
            case 1:

                respuestas.Add(Instantiate(palabras[numero], respawn1.transform.position, Quaternion.identity));

                n1 = Random.Range(1, 10);
                if (n1 == numero)
                {
                    n1 = Random.Range(1, 10);
                }

                respuestas.Add(Instantiate(palabras[n1], respawn2.transform.position, Quaternion.identity));

                n2 = Random.Range(1, 10);
                if (n1 == n2 || n2 == numero)
                {
                    n2 = Random.Range(1, 10);
                }

                respuestas.Add(Instantiate(palabras[n2], respawn3.transform.position, Quaternion.identity));

                break;

            case 2:
                n1 = Random.Range(1, 10);
                if (n1 == numero)
                {
                    n1 = Random.Range(1, 10);
                }

                respuestas.Add(Instantiate(palabras[n1], respawn1.transform.position, Quaternion.identity));


                respuestas.Add(Instantiate(palabras[numero], respawn2.transform.position, Quaternion.identity));

                n2 = Random.Range(1, 10);
                if (n1 == n2 || n2 == numero)
                {
                    n2 = Random.Range(1, 10);
                }

                respuestas.Add(Instantiate(palabras[n2], respawn3.transform.position, Quaternion.identity));

                break;

            case 3:
                n1 = Random.Range(1, 10);
                if (n1 == numero)
                {
                    n1 = Random.Range(1, 10);
                }

                respuestas.Add(Instantiate(palabras[n1], respawn1.transform.position, Quaternion.identity));

                n2 = Random.Range(1, 10);
                if (n1 == n2 || n2 == numero)
                {
                    n2 = Random.Range(1, 10);
                }

                respuestas.Add(Instantiate(palabras[n2], respawn2.transform.position, Quaternion.identity));


                respuestas.Add(Instantiate(palabras[numero], respawn3.transform.position, Quaternion.identity));

                break;
        }

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
