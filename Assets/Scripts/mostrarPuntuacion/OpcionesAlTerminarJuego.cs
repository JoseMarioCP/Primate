using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class OpcionesAlTerminarJuego : MonoBehaviour {

    public ControlarAnimaciones transiciones;

	public BotonesPulsados reinciar;
	public BotonesPulsados VolverMenu;


	public string esena;
	public string portada;
	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () 
	{
	
		if(reinciar.pulsado)
        {
            transiciones.animacionFinal();
            //SceneManager.LoadScene(esena);
            StartCoroutine(TiempoAnimacion(esena));
        }
			

		if(VolverMenu.pulsado)
        {
            transiciones.animacionFinal();
            //SceneManager.LoadScene(portada);
            StartCoroutine(TiempoAnimacion(portada));
        }
			
	}

    IEnumerator TiempoAnimacion(string esenaM)
    {
        yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene(esenaM);
    }
}
