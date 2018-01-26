﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

    // Loads the Main Scene
    public void LoadMain()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main");
    }

    // Loads the Final Scene ???
    public void LoadFinal()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Final");
    }

    // Loads the Credits Scene
    public void LoadCredits()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Credits");
    }

    // Closes the game
    public void Exit()
    {
        Application.Quit();
    }

}
