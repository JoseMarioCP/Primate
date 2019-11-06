using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animacion : MonoBehaviour
{
    public ValidarOpciones objetoValidar;
    public Text txt;
    // Update is called once per frame
    void Update()
    {
        objetoValidar = GameObject.Find("barra").GetComponent<ValidarOpciones>();
        txt = GameObject.Find("Text").GetComponent<Text>();

        Animator anim = GetComponent<Animator>();

        GetComponent<Animator>().enabled = false;

        if(objetoValidar.terminado)
        {
            GetComponent<Animator>().enabled = true;
            anim.Play("Termino-1");

            if(objetoValidar.res1 && objetoValidar.res2)
                txt.text = "Correcto\n Quieres seguir jugando";
            else
                txt.text = "Incorrecto\n Quieres seguir jugando";
        }

    }
}
