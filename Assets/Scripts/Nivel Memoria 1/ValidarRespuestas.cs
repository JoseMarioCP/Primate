using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ValidarRespuestas : MonoBehaviour
{

    public int puntos = 0;
    public Musica sonidos;

    public Timer tiempo;
    public CapturarEntradas respustasTactiles;
    public GameObject botones;

    public Generacion_Flechas preguntas;
    public CapturarEntradas res;
    public Vidas vida;
    public Text texto1, texto2,puntuacion;
   
    void Update()
    {
        //se verifica si las preguntas y las respuestas ya han salido mostradas y tecleadas
        if ((preguntas.problema && res.TuRespuesta) || tiempo.tiempo<=0 )
        {
             tiempo.contadorCero();
            //para los valores para indicar que sigue otra iteracion de preguntas y repsuestas
            res.TuRespuesta = false;
            preguntas.problema = false;

            if (preguntas.flechas.Count == res.Respuestas.Count)
                StartCoroutine(validando());
            else
                llenarVacio();

           
        }
            
    }

    private void llenarVacio()
    {

        do
        {
            res.Respuestas.Add(0);

        } while (res.Respuestas.Count <= preguntas.flechas.Count);
        StartCoroutine(validando());

    }

    /*
    IEnumerator esperar()
    {
        yield return new WaitForSeconds(0.5f);
        //respustasTactiles. = false ; //desactivando los botones de respuestas

        
    }
    */


        //se recorre ambos array para comparar sus valores y mostrarlos en pantalla
    IEnumerator validando()
    {

        respustasTactiles.enabled = false;      //se desactiva el script que captura las entradas de los botones
        botones.SetActive(false);               //se desactiva el objeto que contiene los botones
        yield return new WaitForSeconds(2f);


        //preguntas.audio.Detener();
        preguntas.musica.Detener();       
        preguntas.musica.subirVolumen();

        //se acctivan los texto para las respuesta y flechas
        texto1.enabled = true;
        texto2.enabled = true;

        //se limpian los textos para agregar lo que hay en cada array
        texto1.text = "";
        texto2.text = "";

        
        for (int i=0;i<preguntas.flechas.Count;i++)
        {

            yield return new WaitForSeconds(preguntas.tiempoEntreFlechas);

            switch (preguntas.flechas[i])
            {
                case 1:

                    texto1.text += "A" + "  ";

                    break;

                case 2:

                   texto1.text += "B" + "  ";

                    break;

                case 3:

                    texto1.text += "C" + "  ";

                    break;

                case 4:

                    texto1.text += "D" + "  ";

                    break;

            }//SWITCH




            //Debug.Log("pregunta: " + preguntas.flechas[pos]);

                        //----verificamos si coinciden las cadenas del array de flechas con respuestas---//

            if (!preguntas.flechas[i].Equals(res.Respuestas[i]))        //ambas valores difieren 
            {
                //texto1.text += " "+preguntas.flechas[i].ToString();
                // texto2.text += " "+res.Respuestas[i].ToString();

                sonidos.Incorrecta();
                Debug.Log("perdiste una vida!!!");

                vida.decrementarVida();     //decrementamos el marcador de vidas y acctualizamos en pantalla el nuevo valor 

                switch (res.Respuestas[i])
                {
                    case 1:

                        texto2.text += "A" + "  ";
                        //texto2.color = new Color(1.0f, 0.0f, 0.0f);

                        break;

                    case 2:

                        texto2.text += "B" + "  ";
                        //texto2.color = new Color(1.0f, 0.0f, 0.0f);

                        break;

                    case 3:

                        texto2.text += "C" + "  ";
                        //texto2.color = new Color(1.0f, 0.0f, 0.0f);

                        break;

                    case 4:

                        texto2.text += "D" + "  ";
                        //texto2.color = new Color(1.0f, 0.0f, 0.0f);

                        break;

                    case 0:

                        texto2.text += "?"+ "   ";
                        //texto2.color = new Color(1.0f, 0.0f, 0.0f);

                        break;


                }//SWITCH
            }
            else    //ambos valores coinciden quiere decir QUE LAS RESPUEESTAS ES CORRECTA
            {
                sonidos.Correcta();
;                puntos++;       //se aumenta la puntuacion
                puntuacion.text = puntos.ToString();
                switch (res.Respuestas[i])
                {
                    case 1:

                        texto2.text += "A" + "  ";

                        break;

                    case 2:

                        texto2.text += "B" + "  ";

                        break;

                    case 3:

                        texto2.text += "C" + "  ";

                        break;

                    case 4:

                        texto2.text += "D" + "  ";

                        break;

                   

                }//SWITCH
                //texto1.text += " "+preguntas.flechas[i].ToString();
                //texto2.text += " "+res.Respuestas[i].ToString();

            }



        }// iteracion en el for 

        Debug.Log("salio de validar");

        //se reincian las preguntas y respuestas
        // res.TuRespuesta = false;
        res.Respuestas.Clear();   //arraylis de las respuestas se limpia 
        
        yield return new WaitForSeconds(3f);
            
                                        /*desactivando los textos en la pantalla*/
        texto2.text = "";
        texto1.text = "";

        tiempo.reanudar();
        respustasTactiles.enabled = true;       //activando el script para la captura de respuestas
        respustasTactiles.limpiarRespuestas();  //limpiando cualquier posibles respuesta que se queda en ciclo pulsando
        
        preguntas.AnadirFlechas();      //siguiente iteracion de flechas
    

    }


}
