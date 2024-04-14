using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnMyButtonClick()
    {
        Application.Quit();

    }
    public void StartGame()
    {
        SceneManager.LoadScene("level1");
    }

    public void StartTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }
}
