using UnityEngine;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine.UI;



public class ConsoleController : MonoBehaviour
{

    void Update()
    {
        KeepActive();
    }

    public void KeepActive()
    {
        GetComponent<InputField>().ActivateInputField();
    }

}