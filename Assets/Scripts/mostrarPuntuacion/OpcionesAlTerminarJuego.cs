using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class OpcionesAlTerminarJuego : MonoBehaviour {

    public ControlarAnimaciones transiciones;

	public BotonesPulsados reinciar;
	public BotonesPulsados VolverMenu;


	public string esena;
	string portada="PortadaDeJuego";
	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () 
	{
	
		if(reinciar.pulsado)
        {
            SceneManager.LoadScene(esena);
            transiciones.animacionFinal();
        }
			

		if(VolverMenu.pulsado)
        {
            SceneManager.LoadScene(portada);
            transiciones.animacionFinal();
        }
			
	}
}
