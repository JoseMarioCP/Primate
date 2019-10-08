using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Comparar : MonoBehaviour
{
    public GameObject contenedor;
    public int numeroIntentos;

    public Puntos_Contar Marcador;

    public int iteraciones = 0;


    public Transform respawn1, respawn2, respawn3;
    public Text numerotxt1, numerotxt2;
    public int numero1 = 0,numero2=0;
    public int respuestaComparacion;


    public List<GameObject> palabras;
    public List<GameObject> respuestas;

    public GameObject objGanar;
    public Text Correcto;


    // Start is called before the first frame update
    void Start()
    {

        generarNumero();
        colocar_nombres();

    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyUp(KeyCode.A))
        {
            generarNumero();
          
        }

        if (respuestas.Count > 0)
        {
            verificarSeleccion();
        }
    }

    public void generarNumero()
    {
        if (iteraciones >= numeroIntentos)
        {
            //Correcto.text = "Partida Terminada";
            //objGanar.SetActive(true);
            contenedor.SetActive(false);
            limpiar_respuestas();
            Marcador.Calificar();
           
            gameObject.GetComponent<Comparar>().enabled=false;
        }
        else
        {

            numero1 = Random.Range(1, 10);
            numerotxt1.text = "" + numero1;

            numero2 = Random.Range(1, 10);
            numerotxt2.text = "" + numero2;

            colocar_nombres();
        }
       
    }



    IEnumerator Nuevo_Numero()
    {
        yield return new WaitForSeconds(0.5f);
        objGanar.SetActive(false);
        generarNumero();
       // colocar_nombres();
    }

    void CompararNumeros()
    {
        if (numero1 < numero2)
            respuestaComparacion = -1;


        if (numero1 == numero2)
            respuestaComparacion = 0;


        if (numero1 > numero2)
            respuestaComparacion = 1;
    }


    void verificarSeleccion()
    {

        if (respuestas.Count > 0)
        {

            for (int x = 0; x < respuestas.Count; x++)
            {

                if (respuestas[x].gameObject.GetComponent<CaracteristicaComparacion>().valor == -1)
                {
                    if (respuestas[x].gameObject.GetComponent<DAD_Comparacion1>().bloqueado == true)
                    {
                        CompararNumeros();

                        if (respuestas[x].gameObject.GetComponent<CaracteristicaComparacion>().valor == respuestaComparacion)
                        {
                            respuestas[x].gameObject.GetComponent<DAD_Comparacion1>().bloqueado = false;
                            Correcto.text = "Respuesta Correccta";
                            objGanar.SetActive(true);
                            //Marcador.Incrementar();
                            iteraciones++;
                            Marcador.incrementarPuntos();
                            StartCoroutine(Nuevo_Numero());

                            
                        }

                        if (respuestas[x].gameObject.GetComponent<CaracteristicaComparacion>().valor != respuestaComparacion)
                        {
                            respuestas[x].gameObject.GetComponent<DAD_Comparacion1>().bloqueado = false;
                            Correcto.text = "Respuesta Incorrecta";
                            objGanar.SetActive(true);
                            iteraciones++;
                            Marcador.decrementarPuntos();
                            StartCoroutine(Nuevo_Numero());
                            //x += 2;


                        }

                    }

                }


                if (respuestas[x].gameObject.GetComponent<CaracteristicaComparacion>().valor == 0)
                {
                    if (respuestas[x].gameObject.GetComponent<DAD_Comparacion2>().bloqueado == true)
                    {
                        CompararNumeros();
                        if (respuestas[x].gameObject.GetComponent<CaracteristicaComparacion>().valor == respuestaComparacion)
                        {
                            respuestas[x].gameObject.GetComponent<DAD_Comparacion2>().bloqueado = false;
                            Correcto.text = "Respuesta Correccta";
                            objGanar.SetActive(true);
                            //Marcador.Incrementar();
                            iteraciones++;
                            Marcador.incrementarPuntos();
                            StartCoroutine(Nuevo_Numero());
                            
                        }
                        if (respuestas[x].gameObject.GetComponent<CaracteristicaComparacion>().valor != respuestaComparacion)
                        {
                            respuestas[x].gameObject.GetComponent<DAD_Comparacion2>().bloqueado = false;
                            Correcto.text = "Respuesta Incorrecta";
                            objGanar.SetActive(true);
                            iteraciones++;
                            Marcador.decrementarPuntos();
                            StartCoroutine(Nuevo_Numero());
                            // x += 2;
                        }

                    }

                }

                if (respuestas[x].gameObject.GetComponent<CaracteristicaComparacion>().valor == 1)
                {
                    if (respuestas[x].gameObject.GetComponent<DAD_Comparacion3>().bloqueado == true)
                    {
                        CompararNumeros();
                        if (respuestas[x].gameObject.GetComponent<CaracteristicaComparacion>().valor == respuestaComparacion)
                        {
                            respuestas[x].gameObject.GetComponent<DAD_Comparacion3>().bloqueado = false;
                            Correcto.text = "Respuesta Correccta";
                            objGanar.SetActive(true);
                            // Marcador.Incrementar();
                            iteraciones++;
                            Marcador.incrementarPuntos();
                            StartCoroutine(Nuevo_Numero());
                            
                        }
                        if (respuestas[x].gameObject.GetComponent<CaracteristicaComparacion>().valor != respuestaComparacion)
                        {
                            respuestas[x].gameObject.GetComponent<DAD_Comparacion3>().bloqueado = false;
                            Correcto.text = "Respuesta Incorrecta";
                            objGanar.SetActive(true);
                            iteraciones++;
                            Marcador.decrementarPuntos();
                            StartCoroutine(Nuevo_Numero());
                            // x += 2;
                        }

                    }

                }


            }//fin del ciclo


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

    void colocar_nombres()
    {
        limpiar_respuestas();

                respuestas.Add(Instantiate(palabras[1], respawn1.transform.position, Quaternion.identity));


                respuestas.Add(Instantiate(palabras[2], respawn2.transform.position, Quaternion.identity));

                respuestas.Add(Instantiate(palabras[3], respawn3.transform.position, Quaternion.identity));

    }

}
