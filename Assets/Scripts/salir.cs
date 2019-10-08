using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class salir : MonoBehaviour 
{
    

	//variable para comprobar que esta en la esena de portada
	public bool salirJuego=false;

    
	// Update is called once per frame
	void Update () 
	{


        if (Input.GetKeyDown (KeyCode.Escape))
        {
			if (salirJuego == true) 
			{
               Application.Quit ();
                
		
			} else {
               
                SceneManager.LoadScene ("PortadaDeJuego");
			}
		}
	}
    
    
}
