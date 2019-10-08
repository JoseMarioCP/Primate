using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarDeEsena : MonoBehaviour 
{

								// cambiar de esena en el nivel de portada

	public PulsarOpcionesPortada BotonSuma;
	public PulsarOpcionesPortada BotonResta;
	public PulsarOpcionesPortada BotonMemoria;
	string SiguienteNivel="";

	public string N1, N2,N3;

    //referencia del script que contendra el valor para el nivel de juego
    //public DatosEntreEsenas dato;

    private void Awake()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update ()
	{
		if (BotonSuma.pulsado == true) 
		{
			//dato.ValorDeOpcion = 1;
			//SiguienteNivel = "NivelSuma(Charlie)";
			SiguienteNivel = N1;
			Invoke ("CambiarEsena",0.2f);
		}


		if (BotonResta.pulsado == true) 
		{
			//dato.ValorDeOpcion = 2;
		//	SiguienteNivel = "Nivel 2(Resta)";
			SiguienteNivel = N2;
			Invoke ("CambiarEsena",0.2f);
		}

        if (BotonMemoria.pulsado == true)
        {
            //dato.ValorDeOpcion = 2;
            //	SiguienteNivel = "Nivel 2(Resta)";
            SiguienteNivel = N3;
            Invoke("CambiarEsena", 0.2f);
        }
        
    }

	void CambiarEsena()
	{
		SceneManager.LoadScene (SiguienteNivel);
	}
}
