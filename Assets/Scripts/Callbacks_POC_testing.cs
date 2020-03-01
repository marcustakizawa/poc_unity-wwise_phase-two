using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Callbacks_POC_testing : MonoBehaviour
{
    public Toggle toggle_EndofEvent;

    public void Callback_Toggle_Test()
    {
        Debug.Log("AK_EndOfEvent has been detected");
        toggle_EndofEvent = GameObject.FindWithTag("toggleEndOfEvent").GetComponent<Toggle>();

        if (toggle_EndofEvent.isOn == true)
        {
            Debug.Log("toggle is active");
            toggle_EndofEvent.isOn = false;
            Debug.Log("toggle is off");
        }
    }

}
