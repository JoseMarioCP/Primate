using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class salir : MonoBehaviour 
{
    

	//variable para comprobar que esta en la esena de portada
	public bool salirJuego=false;
    public InicioPortada menu;
    
	// Update is called once per frame
	void Update () 
	{


        if (Input.GetKeyDown (KeyCode.Escape) && menu.menu==0)
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
