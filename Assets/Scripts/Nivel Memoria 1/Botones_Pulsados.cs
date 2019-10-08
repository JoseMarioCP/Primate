using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Botones_Pulsados : MonoBehaviour,IPointerDownHandler,IPointerUpHandler 
{
	//script para saber si se esta pulsando un boton en ejecucion del juego

	public bool pulsado=false;

	public void OnPointerDown(PointerEventData evento)
	{
		pulsado = true;
	}

	public void OnPointerUp(PointerEventData evento)
	{
		//pulsado = true;
	}


	// Update is called once per frame
	void LateUpdate () 
	{
		pulsado = false;	
	}


}