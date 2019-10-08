using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class MostrarPuntuacionPantallaResta : MonoBehaviour 
{
								//COPIA DE MostrarPuntuacionPantalla

	//referencia para detener la musica cuando se acaben los intentos
	public MusicaFondo temaPrincipal3;

	public Timer tiempo;

	//referencia para acceder al valor de las variables que llevan el conteo de las buenas y malas 
	public OperacionResta respuestas;

	public Canvas can;
	public Canvas can2;

	public int Intentos=0;
	public int LimiteIntentos;

	//es el objeto que se mostrara al terminar el juego
	public GameObject palomita;
	public GameObject tachita;

	//son los objetos que se desactivaran al terminar el juego
	public GameObject palomita2;
	public GameObject tachita2;


	public Text acierto;
	public Text incorrectas;
	//objetos en pantalla
	//public Text numero1, numero2, operacion, resultado, igualacion, aciertos, incorrectas;
	//public BotonesPulsados btn1, btn2, btn3;

	// Use this for initialization
	void Start () 
	{
		palomita.gameObject.SetActive (false);
		tachita.gameObject.SetActive (false);
		can2.gameObject.SetActive (false);
		Intentos = 0;	

	}

	// Update is called once per frame
	void Update () 
	{
		if (Intentos == LimiteIntentos)
		{

			Invoke("mostrarPuntos",2f);

			tiempo.decrementar = false;
		}

		//mostrarPuntos ();

	}

	void mostrarPuntos()
	{
		//desactiva el tema de fondo
		temaPrincipal3.Detener ();
		desactivarObjetos ();
		can2.gameObject.SetActive (true);
		acierto.text = " " + respuestas.respuestaCorrecta;
		palomita.gameObject.SetActive (true);
		incorrectas.text = " " + respuestas.respuestasIncorrectas; 
		tachita.gameObject.SetActive (true);


	}

	void desactivarObjetos()
	{
		can.gameObject.SetActive (false);
		tachita2.gameObject.SetActive (false);
		palomita2.gameObject.SetActive (false);

		/*
		numero1.text = "";
		numero2.text=" ";
		operacion.text=" ";
		resultado.text=" ";
		igualacion.text=" ";
		aciertos.text=" ";
		incorrectas.text=" ";
		btn1.gameObject.SetActive (false);
		btn2.gameObject.SetActive (false);
		btn3.gameObject.SetActive (false);
		*/
	}


}
