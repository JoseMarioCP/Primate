using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DAD_Ordenar3 : MonoBehaviour
{
    public Transform posicionContenedor;

    Vector2 posicionInicial;

    float deltax, deltay;

    public bool bloqueado;

    bool posicionEstablecida = false;

    // Start is called before the first frame update
    void Start()
    {
        posicionInicial = transform.position;
        //Debug.Log("posicion inicial drag: " + posicionInicial);
       // posicionContenedor = GameObject.Find("Contenedor").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (!posicionEstablecida)
        {
            //posicionInicial = transform.position;
            posicionEstablecida = true;

        }

        if (Input.touchCount > 0 && !bloqueado)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                    {
                        deltax = touchPos.x - transform.position.x;
                        deltay = touchPos.y - transform.position.y;
                    }

                    break;

                case TouchPhase.Moved:
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                    {
                        transform.position = new Vector2(touchPos.x - deltax, touchPos.y - deltay);
                    }

                    break;

                case TouchPhase.Ended:
                    if (Mathf.Abs(transform.position.x - posicionContenedor.position.x) <= 2.5f &&
                        Mathf.Abs(transform.position.y - posicionContenedor.position.y) <= 2.5f)
                    {
                        transform.position = new Vector2(posicionContenedor.position.x, posicionContenedor.position.y);
                        bloqueado = true;
                        Debug.Log("objetos colocado");
                    }
                    else
                    {
                        transform.position = new Vector2(posicionInicial.x, posicionInicial.y);
                    }
                    break;


            }
        }

    }
}
