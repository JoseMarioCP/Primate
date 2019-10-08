using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Opciones_Salida : MonoBehaviour
{
    // Start is called before the first frame update
    public BotonesPulsados Reiniciar, volverInicio;
    public string reinciar, inicio;

    void Update()
    {
        if (Reiniciar.pulsado)
            reiniciar();

        if (volverInicio.pulsado)
            Salirinicio();
    }

    void reiniciar()
    {
        SceneManager.LoadScene(reinciar);
    }

    void Salirinicio()
    {
        SceneManager.LoadScene(inicio);
    }
}
