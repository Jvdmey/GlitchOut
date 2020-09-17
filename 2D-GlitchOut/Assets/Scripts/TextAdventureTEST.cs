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
     string myAnswerText;



    private void Start()
    {
       
    }
    void Update()
    {
       // StartCoroutine("PlayText");
        BeginCheck();

        //if ((answer.ToString() == mainInputField.text)
        //{
        //    inputText.text = "HELP";


        //    Debug.Log("FEEDBACK");
        //}
    }
    public void BeginCheck()
    {
        myText = mainInputField.text;
        myConsoleText = theConsole.text;
        myAnswerText = "\n\nType an actual command";
        myText = inputText.text;
        //string answer = "";



        // myAnswerText = answerText.text;

        if  (Input.GetKeyDown(KeyCode.Return) && myText == "Hello There")
        {
      
            StartCoroutine("PlayText");
            mainInputField.text = "";
            theConsole.text = myConsoleText + "\n\n";
            //theConsole.text = myConsoleText +"\n\n"  + myText + "\n\n" + "General Kenobi" + "\n\n";
        }
        if (Input.GetKeyDown(KeyCode.Return) && myText != "Hello There")
        {
            //StartCoroutine("PlayText");
            StartCoroutine("PlayFail");
           
            mainInputField.text = "";
            // theConsole.text =  "\n\n" + "Type an actual command" + "\n\n";
            theConsole.text = myConsoleText + "\n\n" ;
        }
        //myAnswerText + "\n\n" + 



        // theConsole.text = string.Concat(myText += myConsoleText  );
        // inputText =  theConsole;
        //mainInputField.text = theConsole.text;

        //Debug.Log("FEEDBACK");
    }

    IEnumerator PlayText()
    {
        foreach (char c in myText)
        {
            Debug.Log(c);
        
            yield return new WaitForSeconds(0.08f); 
           
            theConsole.text += c;
        }
    }
    IEnumerator PlayFail()
    {
        foreach (char c in myText)
        {
            Debug.Log(c);

            yield return new WaitForSeconds(0.08f);

            theConsole.text += c;
        }
        foreach (char d in myAnswerText)
        {
            Debug.Log(d);

            yield return new WaitForSeconds(0.03f);

            theConsole.text += d;
        }
    }
 }
    



