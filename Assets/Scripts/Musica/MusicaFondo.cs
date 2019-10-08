using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaFondo : MonoBehaviour 
{

	public AudioSource TemaPrincipal;
   

	public void Comenzar()
	{
		TemaPrincipal.Play ();

	}


	public void Detener()
	{
		TemaPrincipal.Stop ();
	}
}
