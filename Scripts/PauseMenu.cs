using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Runtime;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseUI;

    private bool paused = false;

    void Start()
    {
        PauseUI.SetActive(false);
    }

    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            paused = !paused;
        }

        if (paused)
        {
            PauseUI.SetActive(true);
            Time.timeScale = 0;
        }

        if (!paused)
        {
            PauseUI.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void Continuer()
    {
        paused = false;
    }

    public void Recommencer()
    {
        Stage.stage = 6;
        SceneManager.LoadScene("level");
        
    }

    public void Quitter()
    {
        Application.Quit();
    }

    public void RecommencerTuto()
    {
        Stage.stage = 6;
        SceneManager.LoadScene("tutoriallevel");

    }

}
