using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vidas : MonoBehaviour
{

    public Text vida;
    public int vidas = 10;



    // Update is called once per frame
    void Start()
    {
        vida.text = vidas.ToString();
    }

    public void decrementarVida()
    {
        vidas--;
        vida.text = vidas.ToString();
    }
}
