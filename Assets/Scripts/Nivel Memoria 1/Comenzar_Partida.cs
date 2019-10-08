using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Comenzar_Partida : MonoBehaviour {

	public bool Comenzar = false;
	public BotonesPulsados Boton_Comenzar; 

	
	// Update is called once per frame
	void Update () 

	{
		if (Boton_Comenzar.pulsado == true) 
		{
			Comenzar = true;
			Boton_Comenzar.pulsado = false;
		}

	}
}
