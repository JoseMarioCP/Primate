using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.EventSystems;

public class PulsarOpcionesPortada : MonoBehaviour,IPointerDownHandler,IPointerUpHandler {

	public bool pulsado=false;

	public void OnPointerDown(PointerEventData evento)
	{
		pulsado = true;
	}

	public void OnPointerUp(PointerEventData evento)
	{
		pulsado = false;
	}


	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
