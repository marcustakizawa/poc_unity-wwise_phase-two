using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextCheck_MusicSettings : MonoBehaviour
{

    //Declaring variables in CheckMusicSettings Object
    public Toggle toggle_preClick;
    //public Text preClickBars_text;
    //public Text startingPosition_text;

    
    void Start()
    {
        toggle_preClick = GameObject.FindWithTag("toggle_preClick").GetComponent<Toggle>();
        //preClickBars_text  = GameObject.FindWithTag("PreClickBars_Text").GetComponent<Text>();
        //startingPosition_text = GameObject.FindWithTag("StartingPosition_Text").GetComponent<Text>();

        if (toggle_preClick  == null)
        {

            Debug.LogError("Failed to find Toggle  with tag 'toggle_preClick'");
            this.enabled = false;
            return;
        }

        /*if (preClickBars_text  == null)
        {
            Debug.LogError("Failed to find Text component with tag 'PreClickBars_Text'");
            this.enabled = false;
            return;

        }

        if (startingPosition_text == null)
        {
            Debug.LogError("Failed to find Text component with tag 'StartingPosition_Text'");
            this.enabled = false;
            return;
        }
        */

        Debug.Log(toggle_preClick.isOn);
        //Debug.Log(preClickBars_text.text);
        //Debug.Log(startingPosition_text.text);

        
    }

    
  
}
