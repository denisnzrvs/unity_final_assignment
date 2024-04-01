using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void Play ()

    { 
        SceneManager.LoadScene("MainLevel");
    }

    public void QuitGame ()
    {
        Application.Quit();
        Debug.Log("Game has quit.");
    }
}
