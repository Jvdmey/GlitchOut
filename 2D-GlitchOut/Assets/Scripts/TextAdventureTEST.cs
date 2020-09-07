using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TextAdventureTEST : MonoBehaviour
{

    public InputField mainInputField;
 
    public Text theConsole;
    public Text inputText;
   // public Text answerText;

    public string myText;
    public string myConsoleText;
  //  public string myAnswerText;



    private void Start()
    {
        
    }
    void Update()
    {
        BeginCheck();

        //if ((answer.ToString() == mainInputField.text)
        //{
        //    inputText.text = "HELP";


        //    Debug.Log("FEEDBACK");
        //}
    }
    public void BeginCheck()
    {
        //string answer = "";
        myText = mainInputField.text;
        myText = inputText.text;
        myConsoleText = theConsole.text;
       // myAnswerText = answerText.text;

        if  (Input.GetKeyDown(KeyCode.Return) && myText == "Hello There")
        {
            mainInputField.text = "";
            theConsole.text = myConsoleText   + myText + "\n\n" + "General Kenobi" + "\n\n";
        }
        if (Input.GetKeyDown(KeyCode.Return) && myText != "Hello There")
        {
            mainInputField.text = "";
            theConsole.text = myConsoleText  + myText + "\n\n" + "Learn your memes" + "\n\n";
        }




        // theConsole.text = string.Concat(myText += myConsoleText  );
        // inputText =  theConsole;
        //mainInputField.text = theConsole.text;

        Debug.Log("FEEDBACK");
        }
    }
    



