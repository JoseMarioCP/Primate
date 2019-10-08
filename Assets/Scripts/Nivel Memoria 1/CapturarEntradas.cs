using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CapturarEntradas : MonoBehaviour
{
    public BotonesPulsados Boton_Izquierdo, Boton_superior, Boton_Derecha, Boton_Inferior;
    public ArrayList Respuestas = new ArrayList();
    public Generacion_Flechas Flechas_des;
    public Text Fila2;

    int Recorrido2 = 0;

   public  bool TuRespuesta = false;


    public void limpiarRespuestas()
    {
        Boton_Izquierdo.pulsado = false;
        Boton_Derecha.pulsado = false;
        Boton_Inferior.pulsado = false;
        Boton_superior.pulsado = false;
    }


    // Update is called once per frame
    void Update()
    {
        capturarRespuestas();

        if (Input.GetKeyUp(KeyCode.S))
            StartCoroutine(RecorrerArray(Respuestas));

        

        if (Flechas_des.flechas.Count == Respuestas.Count && Flechas_des.problema == true)
        {
            TuRespuesta = true;

        }
    }


    //captura las respuestas de los botones pulsados y agrega a un text su correspondiente flecha
    void capturarRespuestas()
    {

        if (Boton_Izquierdo.pulsado)
        {
            Respuestas.Add(1);
            Fila2.text += "#";
        }

        if (Boton_superior.pulsado)
        {
            Respuestas.Add(2);
            Fila2.text += "#";

        }

        if (Boton_Derecha.pulsado)
        {
            Respuestas.Add(3);
            Fila2.text += "#";

        }

        if (Boton_Inferior.pulsado)
        {
            Respuestas.Add(4);
            Fila2.text += "#";

        }


    }



    //recorre el array de las respuestas 
    IEnumerator RecorrerArray(ArrayList Respuestas)
    {
        Fila2.text = "";

        Recorrido2 = 0;//variable global para llevar el contador de los recorridos 

        foreach (int pos in Respuestas)
        {

            Debug.Log("numero " + pos);
            Recorrido2++;

            //salto de linea al mostrar las flechas en pantalla
            if (Recorrido2 == 7)
                Fila2.text += "\n";
            

            yield return new WaitForSeconds(Flechas_des.tiempoEntreFlechas);

            switch (pos)
            {
                case 1:

                    Fila2.text += "A" + "  ";

                    break;

                case 2:

                    Fila2.text += "B" + "  ";

                    break;

                case 3:

                    Fila2.text += "C" + "  ";

                    break;

                case 4:

                    Fila2.text += "D" + "  ";

                    break;

            }//SWITCH

        }
        //Debug.Log("cantidad de recorrido: " + Recorrido2);
    }
}
