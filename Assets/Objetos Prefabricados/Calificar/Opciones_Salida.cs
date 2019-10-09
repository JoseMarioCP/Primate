using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Opciones_Salida : MonoBehaviour
{
    // Start is called before the first frame update
    public ControlarAnimaciones animacion;
    public BotonesPulsados Reiniciar, volverInicio;
    public string reinciar, inicio;

    void Update()
    {
        if (Reiniciar.pulsado)
        {
            animacion.animacionFinal();
            StartCoroutine(reiniciarNivel());
        }
            

        if (volverInicio.pulsado)
        {
            animacion.animacionFinal();
            StartCoroutine(SalirInicio());
        }
            
    }


    IEnumerator reiniciarNivel()
    {
        yield return new WaitForSeconds(1.3f);
        SceneManager.LoadScene(reinciar);
    }

    IEnumerator SalirInicio()
    {
        yield return new WaitForSeconds(1.3f);
        SceneManager.LoadScene(inicio);
    }
    
}
