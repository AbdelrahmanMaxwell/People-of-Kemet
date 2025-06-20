using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Farm()
    {
        SceneManager.LoadScene("Farm");
    }

    public void Trade()
    {
        SceneManager.LoadScene("Market");
    }

    public void exit_game()
    {
        Application.Quit();
    }
}
