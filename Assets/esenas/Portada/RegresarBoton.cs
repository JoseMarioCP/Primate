using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RegresarBoton : MonoBehaviour
{


    public ControlarAnimaciones transicion;
   public void Regresar()
    {

        StartCoroutine(regresarPortada());
    }


    IEnumerator regresarPortada()
    {
        transicion.animacionFinal();
        yield return new WaitForSeconds(0.8f);
        SceneManager.LoadScene("PortadaJuego");

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
