using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resultados : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject newObject = GameObject.Find("Res-1");
        Image image = newObject.GetComponent<Image>();
        image.enabled = false;

        GameObject newObject2 = GameObject.Find("Res-2");
        Image image2 = newObject2.GetComponent<Image>();
        image2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
