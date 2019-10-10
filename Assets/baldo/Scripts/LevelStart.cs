using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelStart : MonoBehaviour
{
    public Sprite naran, manza, pera, uva, plata, linea;

    void Start()
    {
        pera = Resources.Load<Sprite>("pera");
        plata = Resources.Load<Sprite>("platano");
        manza = Resources.Load<Sprite>("manzana");
        naran = Resources.Load<Sprite>("naranja");
        uva = Resources.Load<Sprite>("uva");
        linea = Resources.Load<Sprite>("linea");

        switch(gameObject.name)
        {
            case "icono0_0": 
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = pera;
                    transform.localScale += new Vector3(47, 44, 1);
            break;

            case "icono0_1": 
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = manza;
                    transform.localScale += new Vector3(122, 120, 0);
            break;

            case "icono0_2": 
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = linea;
                    transform.localScale += new Vector3(38, 286, 2);
            break;

            case "icono0_3": 
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = manza;
                    transform.localScale += new Vector3(122, 120, 0);
            break;

            case "icono0_4": 
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = pera;
                    transform.localScale += new Vector3(47, 44, 1);
            break;

            case "icono0_5":
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = linea;
                    transform.localScale += new Vector3(38, 286, 2);
            break;

            case "icono0_6": 
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = pera;
                    transform.localScale += new Vector3(47, 44, 1);
            break;

            case "icono0_7": 
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = manza;
                    transform.localScale += new Vector3(122, 120, 0);
            break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
