using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour 
{

	public Text contador;
	public float tiempo;
	public bool decrementar=false;
    public float valorReanudar = 10;



	// Use this for initialization
	void Start () 
	{
		contador.text = "Tiempo: " + tiempo;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
		if (Input.GetKeyDown (KeyCode.E))
			decrementar = true;
		
		if (Input.GetKeyDown (KeyCode.R))
			reanudar ();


        //llama al metodo para decrementar el contador hasta que llegue a cero 
		if(decrementar==true)
			bajarContador ();

	}


    //decrementar cada segundo el contador y al llegar a cero la variable decrementar cambia su valor para no seguir decrementando
	void bajarContador()
	{
        
		tiempo -= Time.deltaTime;
		contador.text = "Tiempo: "+tiempo.ToString("f0");

		if (tiempo <= 0)
		{
			decrementar = false;
			contador.text = "Tiempo: " + 0;
		}
	}


    //reiniciar el tiempo o contador
	public void reanudar()
	{
		tiempo = valorReanudar;
		contador.text = "Tiempo: " + tiempo;
	}


	public void contadorCero()
	{
		tiempo = 10;
		contador.text = "Tiempo: " + 0;
		decrementar = false;
	}
}
