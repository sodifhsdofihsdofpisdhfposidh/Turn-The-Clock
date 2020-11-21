using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Runtime;

public class Menu : MonoBehaviour
{
    public void Jouer()
    {
        SceneManager.LoadScene("level");
    }

    public void Quitter()
    {
        Application.Quit();
    }

    public void Tuto()
    {
        SceneManager.LoadScene("tutoriallevel");
    }
}
