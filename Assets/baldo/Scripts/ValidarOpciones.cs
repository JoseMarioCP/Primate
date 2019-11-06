using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarOpciones : MonoBehaviour
{
    public string vacio1, vacio2, patron;
    
    public GameObject slotVacio1, slotVacio2;
    public Transform hijo1, hijo2;

    public bool res1 = false, res2 = false, terminado = false;

    public CrearPatron objetoPatron;


    public void ValidarSlots()
    {

        vacio1 = "Slot"+objetoPatron.x.ToString();  // Se obtienen los indices de campos vacios
        vacio2 = "Slot"+objetoPatron.x2.ToString();
        patron = objetoPatron.patron;

        slotVacio1 = GameObject.Find(vacio1); // Se le asigna una variable a los objetos vacios
        slotVacio2 = GameObject.Find(vacio2);

        if(slotVacio1.transform.childCount == 1 && slotVacio2.transform.childCount == 1)
            terminado = true;

        if(slotVacio1.transform.childCount==1){ // Si este objeto tiene un hijo, regresara el primero
            hijo1 = slotVacio1.transform.GetChild(0);
            switch(patron[objetoPatron.x-1])
            {
                case '1': //Checar que la fruta que debe de estar es naranja
                    if(ValidarResultado(hijo1, "naranja")) // Método que manda el slot y la fruta que esta en este instante
                        res1 = true;
                break;

                case '2': //Checar que la fruta que debe de estar es manzana
                    if(ValidarResultado(hijo1, "manzana"))
                        res1 = true;
                break;

                case '3': //Checar que la fruta que debe de estar es pera
                    if(ValidarResultado(hijo1, "pera"))
                        res1 = true;
                break;

                case '4': //Checar que la fruta que debe de estar es uva
                    if(ValidarResultado(hijo1, "uva"))
                        res1 = true;
                break;
                
                case '5': //Checar que la fruta que debe de estar es platano
                    if(ValidarResultado(hijo1, "platano"))
                        res1 = true;
                break;
            }
        }

        if(slotVacio2.transform.childCount==1){ // Si este objeto tiene un hijo, regresara el primero
            hijo2 = slotVacio2.transform.GetChild(0);
            switch(patron[objetoPatron.x2-1])
            {
                case '1': //Checar que la fruta que debe de estar es naranja
                    if(ValidarResultado(hijo2, "naranja"))
                        res2 = true;
                break;

                case '2': //Checar que la fruta que debe de estar es manzana
                    if(ValidarResultado(hijo2, "manzana"))
                        res2 = true;
                break;

                case '3': //Checar que la fruta que debe de estar es pera
                    if(ValidarResultado(hijo2, "pera"))
                        res2 = true;
                break;

                case '4': //Checar que la fruta que debe de estar es uva
                    if(ValidarResultado(hijo2, "uva"))
                        res2 = true;
                break;
                
                case '5': //Checar que la fruta que debe de estar es platano
                    if(ValidarResultado(hijo2, "platano"))
                        res2 = true;
                break;
            }
        }

    }

    public void Update()
    {
        objetoPatron = GameObject.Find("cartel1").GetComponent<CrearPatron>();  //Se obtiene el gameObject dodne se encuentra el script CrearPatron
        patron = objetoPatron.patron; 

        ValidarSlots(); //Valida constantemente si algo esta arriba de los slots
        
        if(res1){   // Si el primer slots esta correcto habilita la imagen de correcto
            GameObject newObject = GameObject.Find("Res-1");
            Image image = newObject.GetComponent<Image>();
            image.enabled = true;
        }
        
        if(res2){
            GameObject newObject2 = GameObject.Find("Res-2");
            Image image2 = newObject2.GetComponent<Image>();
            image2.enabled = true;
        }        
    }

    public bool ValidarResultado(Transform hijo, string nombre) //Revisa si el objeto que esta arriba del slot es el correcto
    {
        if(hijo.name == nombre){ // Compara el nombre del objeto que esta situado arriba y la fruta que debería estar
            Debug.Log("Correcto");
            return true;
        }
        else{
            Debug.Log("Incorrecto");
            return false;
        }
    }
}
