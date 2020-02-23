using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Toggle_CheckStatus : MonoBehaviour
{
    /**** Toggle variables for Pre-Click ****/

    public Toggle toggle_preClick_disabled;
    public Toggle toggle_preClick_2B;
    public Toggle toggle_preClick_4B;

    /**** Toggle variables for Starting Postion ****/

    public Toggle toggle_r1;
    public Toggle toggle_r2;
    public Toggle toggle_r3;

    /**** Integer variables for Pre-Click ****/

    public int disabled_intValue;
    public int pc2_intValue;
    public int pc4_intValue;

    /**** Integer variables for Starting Postion ****/

    public int r1_intValue;
    public int r2_intValue;
    public int r3_intValue;



    /**** List of tags for PreClick: ****/

    //PreClick_Disabled
    //PreClick_2B
    //PreClick_4B

    /**** List of tags for StartingPostion: ****/

    //Toggle_R1
    //Toggle_R2
    //Toggle_R3


    public void ToggleStatus_PreClick()
    {
        //In order to "find" the object, the tag must be associated with the "Toggle" object, not the parent GameObject. 
        //For example, the tag "PreClick_Disabled" must be tagged with "Toggle_Disabled", not the GameObject: PreClick_Disabled

        toggle_preClick_disabled = GameObject.FindWithTag("PreClick_Disabled").GetComponent<Toggle>();
        toggle_preClick_2B = GameObject.FindWithTag("PreClick_2B").GetComponent<Toggle>();
        toggle_preClick_4B = GameObject.FindWithTag("PreClick_4B").GetComponent<Toggle>();

        //Using tags to find the correct Toggle objects. If not found, an error message will appear in the console. 

        if (toggle_preClick_disabled == null)
        {

            Debug.LogError("Failed to find Toggle with tag 'PreClick_Disabled'");
            this.enabled = false;
            return;
        }

        if (toggle_preClick_2B == null)
        {
            Debug.LogError("Failed to find Toggle with tag 'PreClick_2B");
            this.enabled = false;
            return;
               
        }

        if (toggle_preClick_4B == null)
        {
            Debug.LogError("Failed to find Toggle with tag 'PreClick_4B");
            this.enabled = false;
            return;
        }

        //Checking to check status of Toggle. If 'true', an integer is stored in a variable in order to save using PlayerPrefs. 

        if (toggle_preClick_disabled.isOn == true)
        {
            Debug.Log(toggle_preClick_disabled.isOn);
            disabled_intValue = 1;
            Debug.Log("the integer value of 'PreClick_Disabled' is " + disabled_intValue);
            PlayerPrefs.SetInt("preClick_disabled", disabled_intValue);
            PlayerPrefs.Save();
            Debug.Log("PlayerPrefs Values for Pre-Click Disabled " + PlayerPrefs.GetInt("preClick_disabled", disabled_intValue));
        }
        
        if (toggle_preClick_2B.isOn == true)
        {
            Debug.Log(toggle_preClick_2B.isOn);
            pc2_intValue = 1;
            Debug.Log("the integer value of 'PreClick_2B' is " + pc2_intValue);
            PlayerPrefs.SetInt("preClick_2b", pc2_intValue);
            PlayerPrefs.Save();
            Debug.Log("PlayerPrefs Value for Pre-Click 2B is " + PlayerPrefs.GetInt("preClick_2b", pc2_intValue));
            
        }

        if(toggle_preClick_4B.isOn == true)
        {
            Debug.Log(toggle_preClick_4B.isOn);
            pc4_intValue = 1;
            Debug.Log("the integer value of 'PreClick_4B' is " + pc4_intValue);
            PlayerPrefs.SetInt("preClick_4b", pc4_intValue);
            PlayerPrefs.Save();
            Debug.Log("PlayerPrefs value for Pre-Click 4B is " + PlayerPrefs.GetInt("preClick_4b", pc4_intValue));
        }

       
    }

    public void ToggleStatus_StartingPosition()
    {
        //In order to "find" the object, the tag must be associated with the "Toggle" object, not the parent GameObject. 
        //For example, the tag "PreClick_Disabled" must be tagged with "Toggle_Disabled", not the GameObject: PreClick_Disabled

        toggle_r1 = GameObject.FindWithTag("Toggle_R1").GetComponent<Toggle>();
        toggle_r2 = GameObject.FindWithTag("Toggle_R2").GetComponent<Toggle>();
        toggle_r3 = GameObject.FindWithTag("Toggle_R3").GetComponent<Toggle>();

        //Using tags to find the correct Toggle objects. If not found, an error message will appear in the console. 

        if (toggle_r1 == null)
        {
            Debug.LogError("Failed to find Toggle with 'Toggle_R1' tag");
            this.enabled = false;
            return;
        }

        if (toggle_r2 == null) 
        {
            Debug.LogError("Failed to find Toggle with 'Toggle_R2' tag");
            this.enabled = false;
            return;
        }

        if (toggle_r3 == null)
        {
            Debug.LogError("Failed to find Toggle with 'Toggle_R3' tag");
            this.enabled = false;
            return;
        }

        //Checking to check status of Toggle. If 'true', an integer is stored in a variable in order to save using PlayerPrefs. 

        if (toggle_r1.isOn == true)
        {
            Debug.Log(toggle_r1.isOn);
            r1_intValue = 1;
            Debug.Log("the integer value of r1_intValue is " + r1_intValue);
            PlayerPrefs.SetInt("sp_r1", r1_intValue);
            PlayerPrefs.Save();
            Debug.Log("PlayerPrefs value for Starting Postion, Rehearsal 1 is " + PlayerPrefs.GetInt("sp_r1", r1_intValue));
        }

        if (toggle_r2.isOn == true)
        {
            Debug.Log(toggle_r2.isOn);
            r2_intValue = 1;
            Debug.Log("the integer value of r2_intValue is " + r2_intValue);
            PlayerPrefs.SetInt("sp_r2", r2_intValue);
            PlayerPrefs.Save();
            Debug.Log("PlayerPrefs value for Starting Postion, Rehearsal 2 is " + PlayerPrefs.GetInt("sp_r2", r2_intValue));

        }

        if (toggle_r3.isOn == true)
        {
            Debug.Log(toggle_r3.isOn);
            r3_intValue = 1;
            Debug.Log("the integer value of r3_intValue is " + r3_intValue);
            PlayerPrefs.SetInt("sp_r3", r3_intValue);
            PlayerPrefs.Save();
            Debug.Log("PlayerPrefs value for Starting Postion, Rehearsal 3 is " + PlayerPrefs.GetInt("sp_r3", r3_intValue));
        }

    }

}
        
