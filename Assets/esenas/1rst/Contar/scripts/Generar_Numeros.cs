using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Generar_Numeros : MonoBehaviour
{
    public int numeroMinimo, numeroMaximo;
   public int intentos = 0;
    public int iteraciones = 0;
    public int NumeroContar = 0;
    public Puntos_Contar Puntos;

    //public Text txtTerminado;
   // public GameObject partidaTerminadaObj;

    public GameObject muestra;  //objeto que se instancia un numero de veces 
    public Transform instanciador;

    public GameObject Respawns;
    public Transform respawn1, respawn2, respawn3;
    public List<GameObject> objetos;


    public List<GameObject> numeros;
    public List<GameObject> respuestas;


    private void Start()
    {
        Generacion_Numeros(numeroMinimo, numeroMaximo);
        colocar_nombres();
    }

    // Update is called once per frame
    void Update()
    {

       

        verificar_Respuesta();
        /*
        if(Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("se presiono");
            if (objetos.Count >= 1)
                Limpiar_Lista();

            Generacion_Numeros(1,5);
        }
        */

        /*
        if (Input.GetKeyUp(KeyCode.B))
        {
            Debug.Log("se Limpio la lista");
            Limpiar_Lista();
        }
        */
    }


    public void Generacion_Numeros(int n1, int n2)
    {

        if(iteraciones<intentos)
        {
            //indica el numero de elemtos que se crearon de acuerdo al rango establecido
            NumeroContar = Random.Range(n1, n2);

            Vector3 espacio = new Vector3(1f, 0f, 0f);
            for (int x = 0; x < NumeroContar; x++)
            {
                objetos.Add(Instantiate(muestra, instanciador.transform.position + espacio, Quaternion.identity));
                espacio = espacio + new Vector3(1.7f, 0f, 0f);

            }

        }
        else
        {
            gameObject.GetComponent<Generar_Numeros>().enabled = false;
            Respawns.SetActive(false);
          //  txtTerminado.text = "partida Terminada";
             Puntos.Calificar();
           // partidaTerminadaObj.SetActive(true);
        }
        
    }

    
    void verificar_Respuesta()
    {
        if(respuestas.Count>0)
        {
            for (int x = 0; x < respuestas.Count; x++)
            {
                if (respuestas[x].GetComponent<BotonesPulsados>().pulsado)
                {
                    Debug.Log("el boton " + x + " fue pulsado");

                    if(respuestas[x].GetComponent<Caracteristica>().Numero_Nombre==NumeroContar)
                    {
                        iteraciones++;
                        Puntos.incrementarPuntos();
                        limpiar_respuestas();
                        limpiar_objetos();
                        Generacion_Numeros(1,5);
                        colocar_nombres();
                    }
                    else
                    {
                        iteraciones++;
                        Puntos.decrementarPuntos();
                        limpiar_respuestas();
                        limpiar_objetos();
                        Generacion_Numeros(1, 5);
                        colocar_nombres();
                    }
                }
            }

        }

        
    }

    void colocar_nombres()
    {
       // limpiar_respuestas();

        int n1, n2;
        int posicion = Random.Range(1, 3);

        switch (posicion)
        {
            case 1:

                respuestas.Add(Instantiate(numeros[NumeroContar], respawn1.transform.position, Quaternion.identity));
                respuestas[0].transform.SetParent(respawn1);
  

                n1 = Random.Range(1, 10);
                if (n1 == NumeroContar)
                {
                    n1 = Random.Range(1, 10);
                }

                respuestas.Add(Instantiate(numeros[n1], respawn2.transform.position, Quaternion.identity));
                respuestas[1].transform.SetParent(respawn2);
                n2 = Random.Range(1, 10);
                if (n1 == n2 || n2 == NumeroContar)
                {
                    n2 = Random.Range(1, 10);
                }

                respuestas.Add(Instantiate(numeros[n2], respawn3.transform.position, Quaternion.identity));
                respuestas[2].transform.SetParent(respawn3);
                break;

            case 2:
                n1 = Random.Range(1, 10);
                if (n1 == NumeroContar)
                {
                    n1 = Random.Range(1, 10);
                }

                respuestas.Add(Instantiate(numeros[n1], respawn1.transform.position, Quaternion.identity));
                respuestas[0].transform.SetParent(respawn1);

                respuestas.Add(Instantiate(numeros[NumeroContar], respawn2.transform.position, Quaternion.identity));
                respuestas[1].transform.SetParent(respawn2);

                n2 = Random.Range(1, 10);
                if (n1 == n2 || n2 == NumeroContar)
                {
                    n2 = Random.Range(1, 10);
                }

                respuestas.Add(Instantiate(numeros[n2], respawn3.transform.position, Quaternion.identity));
                respuestas[2].transform.SetParent(respawn3);
                break;

            case 3:
                n1 = Random.Range(1, 10);
                if (n1 == NumeroContar)
                {
                    n1 = Random.Range(1, 10);
                }

                respuestas.Add(Instantiate(numeros[n1], respawn1.transform.position, Quaternion.identity));
                respuestas[0].transform.SetParent(respawn1);
                n2 = Random.Range(1, 10);
                if (n1 == n2 || n2 == NumeroContar)
                {
                    n2 = Random.Range(1, 10);
                }

                respuestas.Add(Instantiate(numeros[n2], respawn2.transform.position, Quaternion.identity));
                respuestas[1].transform.SetParent(respawn2);

                respuestas.Add(Instantiate(numeros[NumeroContar], respawn3.transform.position, Quaternion.identity));
                respuestas[2].transform.SetParent(respawn3);
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

    public void limpiar_objetos()
    {
        if (objetos.Count > 0)
        {

            for (int x = 0; x < objetos.Count; x++)
            {
                Destroy(objetos[x]);
            }

            objetos.Clear();
        }

    }
}
