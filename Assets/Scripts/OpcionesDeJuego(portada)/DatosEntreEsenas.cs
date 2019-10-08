using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosEntreEsenas : MonoBehaviour
{

	public static DatosEntreEsenas datos;

	//guarda el valor de la opcion para la siguiente esena
	public  int ValorDeOpcion=0;


	// Use this for initialization
	void Awake () 
	{
		if (datos == null) 
		{
			datos = this;
			DontDestroyOnLoad (gameObject);
		} 
		else
		{
			if (datos != this) 
			{
				Destroy (gameObject);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
