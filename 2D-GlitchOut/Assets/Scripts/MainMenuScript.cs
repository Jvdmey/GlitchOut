using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    public GameObject optionsEnable;
    public GameObject mainMenuEnable;

    public void StartGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void OptionsYes()
    {
        optionsEnable.SetActive(true);
        mainMenuEnable.SetActive(false);
    }

    public void OptionsNo()
    {
        optionsEnable.SetActive(false);
        mainMenuEnable.SetActive(true);
    }
}
