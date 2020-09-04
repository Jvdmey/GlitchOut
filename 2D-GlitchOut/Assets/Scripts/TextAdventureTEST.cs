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


	// Checks if there is anything entered into the input field.


	public void Start()
	{
		//Adds a listener that invokes the "LockInput" method when the player finishes editing the main input field.
		//Passes the main input field into the method when "LockInput" is invoked
		mainInputField.onEndEdit.AddListener(delegate { LockInput(mainInputField); });
	}

	void Update()
    {
        if (Input.GetKeyDown (KeyCode.Return))
        {
            inputText.text = "HELP";
            

            Debug.Log("FEEDBACK");
        }
        
    }
	public void LockInput(InputField input)
	{
		if (input.text.Length > 0)
		{
			Debug.Log("Text has been entered");
		}
		else if (input.text.Length == 0)
		{
			Debug.Log("Main Input Empty");
		}
	}

}
