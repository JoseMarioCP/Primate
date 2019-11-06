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

        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        if(SceneManager.GetActiveScene().name == "Juego")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else
            SceneManager.LoadScene("Juego");

    }
}
