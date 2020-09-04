using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TextAdventureTEST : MonoBehaviour
{
    public Text theConsole;
    public InputField mainInputField;
    public Text inputText;
    public string myText;



    private void Start()
    {
        
    }
    void Update()
    {
        
        BeginCheck();

        //if (Input.GetKeyDown (KeyCode.Return))
        //{
        //    inputText.text = "HELP";
            

        //    Debug.Log("FEEDBACK");
        //}
    }
    public void BeginCheck()
    {
        string answer = "Hello";
        myText = mainInputField.text;
        myText = inputText.text;

        if (answer.ToString() == mainInputField.text)
        {
            mainInputField.text = "HELP";


            Debug.Log("FEEDBACK");
        }
    }


	}

