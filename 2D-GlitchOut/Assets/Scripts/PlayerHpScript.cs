using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHpScript : MonoBehaviour
{

    public static int hitPoints = 100;
    Text hitPointsDisplay;

    public Sprite hpBarDrop100;
    public Sprite hpBarDrop90;
    public Sprite hpBarDrop75;
    public Sprite hpBarDrop50;
    public Sprite hpBarDrop25;
    public Sprite hpBarDrop10;
    public Sprite hpBarDrop0;
    public GameObject hpBar;
    
    public void Switch(int hpBarSwitch = 6)
    {
        switch (hpBarSwitch)
        {
            case 0:
                this.hpBar.GetComponent<Image>().sprite = hpBarDrop100;
                break;
            case 1:
                this.hpBar.GetComponent<Image>().sprite = hpBarDrop90;
                break;
            case 2:
                this.hpBar.GetComponent<Image>().sprite = hpBarDrop75;
                break;
            case 3:
                this.hpBar.GetComponent<Image>().sprite = hpBarDrop50;
                break;
            case 4:
                this.hpBar.GetComponent<Image>().sprite = hpBarDrop25;
                break;
            case 5:
                this.hpBar.GetComponent<Image>().sprite = hpBarDrop10;
                break;
            case 6:
                this.hpBar.GetComponent<Image>().sprite = hpBarDrop0;
                break;
        }
    }

    void Start()
    {
        hitPointsDisplay = GetComponent<Text>();
    }

    void Update()
    {
        hitPointsDisplay.text = hitPoints + "%";

        if (hitPoints >= 100)
        {
            Switch(hpBarSwitch: (0));
        }

        if (hitPoints <= 99 && hitPoints >= 76)
        {
            Switch(hpBarSwitch:(1));
        }

        if (hitPoints <= 75 && hitPoints >= 51)
        {
            Switch(hpBarSwitch: (2));
        }

        if (hitPoints <= 50 && hitPoints >= 26)
        {
            Switch(hpBarSwitch: (3));
        }

        if (hitPoints <= 25 && hitPoints >= 11)
        {
            Switch(hpBarSwitch: (4));
        }

        if (hitPoints <= 10 && hitPoints >= 1)
        {
            Switch(hpBarSwitch: (5));
        }

        if (hitPoints <= 0)
        {
            Switch(hpBarSwitch: (6));
            SceneManager.LoadScene("MainMenuScene");
        }
    }
}
