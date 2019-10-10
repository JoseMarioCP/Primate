using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void GoToMainScene()
    {
        Debug.Log("Regresando al Menu");
        SceneManager.LoadScene("PatronesMenu");
    }

    public void GotoGameScene()
    {
        Debug.Log("Abriendo Juego");
        SceneManager.LoadScene("Juego");
    }

    public void GotoInicio()
    {
        Debug.Log("volviendo inicio");
        SceneManager.LoadScene("PortadaJuego");
    }
}
