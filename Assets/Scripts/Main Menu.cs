using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
public void PlayGame()
    {
        SceneManager.LoadScene("Main Game");
    }
public void QuitGame()
{
    Application.Quit();
}
public void EndGame()
    {
        SceneManager.LoadScene("End Game");
    }
}
