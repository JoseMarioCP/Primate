using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BotonesPulsados : MonoBehaviour, IPointerDownHandler, IPointerUpHandler 
{
					//script para saber si se esta pulsando un boton en ejecucion del juego

	public bool pulsado=false;

    public void OnPointerDown(PointerEventData evento)
    {
        pulsado = true;
        //StartCoroutine(esperar());
    }

    public void OnPointerUp(PointerEventData evento)
	{
        //pulsado = true;
    }

    void Update()
    {
        StartCoroutine(esperar());
    }

    IEnumerator esperar()
    {
        yield return new WaitForSeconds(0.01f);
        pulsado = false;
    }


}
