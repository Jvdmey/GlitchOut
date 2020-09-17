using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TypewriterLike : MonoBehaviour
{
   public Text theConsoleText;
    string typedOurText;

    void Update()
    {
        
        typedOurText = theConsoleText.text;
        //theConsoleText.text = "";

        PlayText();
        //Starts delay
        StartCoroutine("PlayText");
    }
    IEnumerator PlayText()
    {
        foreach (char c in typedOurText)
        {
            theConsoleText.text += c;
            yield return new WaitForSeconds(0.08f);
        }
    }
}
