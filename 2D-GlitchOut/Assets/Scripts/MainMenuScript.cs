using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    #region Variables
    public GameObject optionsEnable;
    public GameObject mainMenuEnable;
    #endregion
    #region Start & Quit
    public void StartGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void Quit()
    {
        Application.Quit();
    }

    #endregion
    #region OptionsActivation
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
    #endregion
}
