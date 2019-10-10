using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opciones : MonoBehaviour
{
    GameObject linea1, linea2;
    GameObject[] frutas;
    // Start is called before the first frame update
    void Start()
    {
        frutas = new GameObject[5];
        frutas[0] = GameObject.Find("naranja");
        frutas[1] = GameObject.Find("manzana");
        frutas[2] = GameObject.Find("pera");
        frutas[3] = GameObject.Find("uva");
        frutas[4] = GameObject.Find("platano");

        linea1 = GameObject.Find("icono0_2");
        linea2 = GameObject.Find("icono0_5");
    }

    // Update is called once per frame
    void Update()
    {
        ChecarLinea1();

        ChecarLinea2();
    }

    public void ChecarLinea1()
    {
        if(frutas[2].transform.position.y > 680 && frutas[2].transform.position.y < 760 && frutas[2].transform.position.x > 550 && frutas[2].transform.position.x < 670) 
        {
            linea1.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("lineaCorrecta");
        }
        else if(frutas[0].transform.position.y > 680 && frutas[0].transform.position.y < 760 && frutas[0].transform.position.x > 550 && frutas[0].transform.position.x < 670) 
        {
            linea1.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("lineaIncorrecta");
        }
        else
        {
            linea1.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("linea");
        }
    }
    public void ChecarLinea2()
    {
        if(frutas[1].transform.position.y > 680 && frutas[1].transform.position.y < 760 && frutas[1].transform.position.x > 1140 && frutas[1].transform.position.x < 1295) 
        {
            linea2.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("lineaCorrecta");
        }
        else if(frutas[0].transform.position.y > 680 && frutas[0].transform.position.y < 760 && frutas[0].transform.position.x > 1140 && frutas[0].transform.position.x < 1295)
        {
            linea2.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("lineaIncorrecta");
        }
        else
        {
            linea2.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("linea");
        }
    }

}
