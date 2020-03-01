using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wwise_Test_20200201 : MonoBehaviour
{
    // Declaring variables for Starting Postition
    public int r1;
    public int r1_intValue;
    public int r2;
    public int r2_intValue;
    public int r3;
    public int r3_intValue;

    // Declaring variables for Pre-Click
    public int disabled_intValue;
    public int pc2;
    public int pc2_intValue;
    public int pc4;
    public int pc4_intValue;

    // Declaring variables for Solo 
    public Toggle toggle_gtrSolo;
    public Toggle toggle_drumSolo;

    // Callback Function Tests

    public static uint musicEventID;

    // Keys for PlayerPrefs, using PlayerPrefs.GetInt("key1", key2)

    /***PRE-CLICK***/
    //"preClick_disabled", disabled_intValue
    //"preClick_2b", pc2_intValue
    //"preClick_4b", pc4_intValue

    /***STARTING POSITION***/
    //"sp_r1", r1_intValue
    //"sp_r2", r2_intValue
    //"sp_r3", r3_intValue


    // Start is called before the first frame update
    public void Wwise_Test_PlayEvent()
    {
        r1 = PlayerPrefs.GetInt("sp_r1", r1_intValue);
        r2 = PlayerPrefs.GetInt("sp_r2", r1_intValue);
        r3 = PlayerPrefs.GetInt("sp_r3", r1_intValue);

        pc2 = PlayerPrefs.GetInt("preClick_2b", pc2_intValue);
        pc4 = PlayerPrefs.GetInt("preClick_4b", pc4_intValue);

        musicEventID = 3520207502;

        /**** Play Events, No Pre-Click ****/

        // Rehearsal 1

        if ((r1 == 1) && (pc2 != 1) && (pc4 != 1))
        {
            AkSoundEngine.PostEvent("POC_rehearsal_1_9M", GameObject.FindWithTag("PlayContainer"));   

        }
    
        // Rehearsal 2

        if ((r2 == 1) && (pc2 != 1) && (pc4 != 1))
        {
            AkSoundEngine.PostEvent("POC_rehearsal_2_6M", GameObject.FindWithTag("PlayContainer"));
        }

        // Rehearsal 3

        if ((r3 == 1) && (pc2 != 1) && (pc4 != 1))
        {
            AkSoundEngine.PostEvent("POC_rehearsal_3_3M", GameObject.FindWithTag("PlayContainer"));
        }

        /**** Pre-Click Play Events ****/

        if ((r1 == 1) && (pc2 == 1))
        {
            AkSoundEngine.PostEvent("POC_rehearsal_1_9M_click_2M", GameObject.FindWithTag("PlayContainer"));
;       }

        if ((r1 == 1) && (pc4 == 1))
        {
            AkSoundEngine.PostEvent("POC_rehearsal_1_9M_click_4M", GameObject.FindWithTag("PlayContainer"));
        }

        if ((r2 == 1) && (pc2 == 1))
        {
            AkSoundEngine.PostEvent("POC_rehearsal_2_6M_click_2M", GameObject.FindWithTag("PlayContainer"));
        }

        if ((r2 == 1) && (pc4 == 1))
        {
            AkSoundEngine.PostEvent("POC_rehearsal_2_6M_click_4M", GameObject.FindWithTag("PlayContainer"));
        }

        if ((r3 == 1) && (pc2 == 1))
        {
            AkSoundEngine.PostEvent("POC_rehearsal_3_6M_click_2M", GameObject.FindWithTag("PlayContainer"));
        }

        if ((r3 == 1) && (pc4 == 1))
        {
            AkSoundEngine.PostEvent("POC_rehearsal_3_6M_click_4M", GameObject.FindWithTag("PlayContainer"));
        }

       

    }


    public void Wwise_Test_StopEvent()
    {
        AkSoundEngine.PostEvent("Stop_All", GameObject.FindWithTag("PlayContainer"));
    }

    public void Wwise_Test_PauseEvent()
    {
        r1 = PlayerPrefs.GetInt("sp_r1", r1_intValue);
        r2 = PlayerPrefs.GetInt("sp_r2", r1_intValue);
        r3 = PlayerPrefs.GetInt("sp_r3", r1_intValue);

        pc2 = PlayerPrefs.GetInt("preClick_2b", pc2_intValue);
        pc4 = PlayerPrefs.GetInt("preClick_4b", pc4_intValue);

        /**** Pause - Rehearsal Number (no Pre-Click)****/

        //2020-02-10: events without Pre-Click are not ready for POC. Hope to be available 
        //by the end of the week. 

        // Rehearsal 1

        if ((r1 == 1) && (pc2 != 1) && (pc4 != 1))
        {
            AkSoundEngine.PostEvent("Pause_rehearsal_1_9M", GameObject.FindWithTag("PlayContainer"));
        }

        // Rehearsal 2

        if ((r2 == 1) && (pc2 != 1) && (pc4 != 1))
        {
            AkSoundEngine.PostEvent("Pause_rehearsal_2_6M", GameObject.FindWithTag("PlayContainer"));
        }
         
        // Rehearsal 3

        if ((r3 == 1) && (pc2 != 1) && (pc4 != 1)) 
        {
            AkSoundEngine.PostEvent("Pause_rehearsal_3_3M", GameObject.FindWithTag("PlayContainer"));
        }
        

        /*****Pause Pre-Click:*****/

        //For Rehearsal Number 1

        if ((r1 == 1) && (pc2 == 1))
        {
            AkSoundEngine.PostEvent("Pause_rehearsal_1_click_2M", GameObject.FindWithTag("PlayContainer"));
        }

        if((r1 == 1) && (pc4 == 1))
        {
            AkSoundEngine.PostEvent("Pause_rehearsal_1_click_4M", GameObject.FindWithTag("PlayContainer"));
        }
            
        //For Rehearsal Number 2

        if ((r2 ==1) && (pc2 == 1))
        {
            AkSoundEngine.PostEvent("Pause_rehearsal_2_click_2M", GameObject.FindWithTag("PlayContainer"));
        }
        
        if ((r2 == 1) && (pc4 == 1))
        {
            AkSoundEngine.PostEvent("Pause_rehearsal_2_click_4M", GameObject.FindWithTag("PlayContainer"));
        }

        //For Rehearsal Number 3

        if ((r3 == 1) && (pc2 == 1))
        {
            AkSoundEngine.PostEvent("Pause_rehearsal_3_click_2M", GameObject.FindWithTag("PlayContainer"));
        }
        
        if ((r3 == 1) && (pc4 == 1))
        {
            AkSoundEngine.PostEvent("Pause_rehearsal_3_click_4M", GameObject.FindWithTag("PlayContainer"));
        }
        

    }

    public void Wwise_Test_ResumeEvent()
    {
        r1 = PlayerPrefs.GetInt("sp_r1", r1_intValue);
        r2 = PlayerPrefs.GetInt("sp_r2", r1_intValue);
        r3 = PlayerPrefs.GetInt("sp_r3", r1_intValue);

        pc2 = PlayerPrefs.GetInt("preClick_2b", pc2_intValue);
        pc4 = PlayerPrefs.GetInt("preClick_4b", pc4_intValue);

        /**** Resume - Rehearsal Number (no Pre-Click) ****/
        //2020-02-10: events without Pre-Click are not ready for POC. Hope to be available 
        //by the end of the week. 

        // Rehearsal 1

        if ((r1 == 1) && (pc2 != 1) && (pc4 != 1))
        {
            AkSoundEngine.PostEvent("Resume_rehearsal_1_9M", GameObject.FindWithTag("PlayContainer"));
        }

        // Rehearsal 2

        if ((r2 == 1) && (pc2 != 1) && (pc4 != 1))
        {
            AkSoundEngine.PostEvent("Resume_rehearsal_2_6M", GameObject.FindWithTag("PlayContainer"));
        }
        
        // Rehearsal 3

        if ((r3 == 1) && (pc2 != 1) && (pc4 != 1))
        {
            AkSoundEngine.PostEvent("Resume_rehearsal_3_3M", GameObject.FindWithTag("PlayContainer"));
        }
        

        /**** Resume Pre-Click ****/

        //For Rehearsal Number 1

        if ((r1 == 1) && (pc2 == 1))
        {
            AkSoundEngine.PostEvent("Resume_rehearsal_1_click_2M", GameObject.FindWithTag("PlayContainer"));
        }

        if ((r1 == 1) && (pc4 ==1))
        {
            AkSoundEngine.PostEvent("Resume_rehearsal_1_click_4M", GameObject.FindWithTag("PlayContainer"));
        }

        //For Rehearsal Number 2

        if ((r2 == 1) && (pc2 == 1))
        {
            AkSoundEngine.PostEvent("Resume_rehearsal_2_click_2M", GameObject.FindWithTag("PlayContainer"));
        }

        if ((r2 == 1) && (pc4 ==1))
        {
            AkSoundEngine.PostEvent("Resume_rehearsal_2_click_4M", GameObject.FindWithTag("PlayContainer"));
        }

        //For Rehearsal Number 3

        if ((r3 == 1) && (pc2 == 1))
        {
            AkSoundEngine.PostEvent("Resume_rehearsal_3_click_2M", GameObject.FindWithTag("PlayContainer"));
        }

        if (r3 == 1 && pc4 == 1)
        {
            AkSoundEngine.PostEvent("resume_rehearsal_3_click_4M", GameObject.FindWithTag("PlayContainer"));
        }

        
    }

    public void Wwise_GuitarSoloEvents()
    {
        r1 = PlayerPrefs.GetInt("sp_r1", r1_intValue);
        r2 = PlayerPrefs.GetInt("sp_r2", r1_intValue);
        r3 = PlayerPrefs.GetInt("sp_r3", r1_intValue);

        pc2 = PlayerPrefs.GetInt("preClick_2b", pc2_intValue);
        pc4 = PlayerPrefs.GetInt("preClick_4b", pc4_intValue);

        toggle_gtrSolo = GameObject.FindWithTag("Toggle_GtrSolo").GetComponent<Toggle>();
        toggle_drumSolo = GameObject.FindWithTag("Toggle_DrumSolo").GetComponent<Toggle>();

        /**** Guitar Solo, No Pre-Click ****/

        // Rehearsal 1

        if ((r1 == 1) && (pc2 != 1) && (pc4 != 1) && (toggle_gtrSolo.isOn == true))
        {
            AkSoundEngine.PostEvent("gtr_solo_rehearsal_1_9M", GameObject.FindWithTag("PlayContainer"));
        }

        if ((r1 == 1) && (pc2 != 1) && (pc4 != 1) && (toggle_gtrSolo.isOn == false))
        {
            AkSoundEngine.PostEvent("Unmute_All", GameObject.FindWithTag("PlayContainer"));
        }

        // Rehearsal 2

        if ((r2 == 1) && (pc2 != 1) && (pc4 != 1) && (toggle_gtrSolo.isOn == true))
        {
            AkSoundEngine.PostEvent("gtr_solo_rehearsal_2_6M", GameObject.FindWithTag("PlayContainer"));
        }

        if ((r2 == 1) && (pc2 != 1) && (pc4 != 1) && (toggle_gtrSolo.isOn == false))
        {
            AkSoundEngine.PostEvent("Unmute_All", GameObject.FindWithTag("PlayContainer"));
        }

        // Rehearsal 3

        if ((r3 == 1) && (pc2 != 1) && (pc4 != 1) && (toggle_gtrSolo.isOn == true))
        {
            AkSoundEngine.PostEvent("gtr_solo_rehearsal_3_3M", GameObject.FindWithTag("PlayContainer"));
        }

        if ((r3 == 1) && (pc2 != 1) && (pc4 != 1) && (toggle_gtrSolo.isOn == false))
        {
            AkSoundEngine.PostEvent("Unmute_All", GameObject.FindWithTag("PlayContainer"));
        }

        /**** Guitar Solo Pre-Click Events ****/

        //For Rehearsal 1

        if ((r1 == 1) && (pc2 == 1) && (toggle_gtrSolo.isOn == true))
        {
            AkSoundEngine.PostEvent("gtr_solo_rehearsal_1_click_2M", GameObject.FindWithTag("PlayContainer"));
            Debug.Log("Guitar Solo is active");
        }

        if ((r1 == 1) && (pc2 == 1) && (toggle_gtrSolo.isOn == false))
        {
            AkSoundEngine.PostEvent("Unmute_All", GameObject.FindWithTag("PlayContainer"));
            Debug.Log("Guitar Solo is not active");
        }
        
        if ((r1 == 1) && (pc4 == 1) && (toggle_gtrSolo.isOn == true))
        {
            AkSoundEngine.PostEvent("gtr_solo_rehearsal_1_click_4M", GameObject.FindWithTag("PlayContainer"));
            Debug.Log("Guitar Solo is active");
        }

        if ((r1 == 1) && (pc4 == 1) && (toggle_gtrSolo.isOn == false))
        {
            AkSoundEngine.PostEvent("Unmute_All", GameObject.FindWithTag("PlayContainer"));
        
        }
        
        //For Rehearsal 2

        if ((r2 == 1) && (pc2 == 1) && (toggle_gtrSolo.isOn == true))
        {
            AkSoundEngine.PostEvent("gtr_solo_rehearsal_2_click_2M", GameObject.FindWithTag("PlayContainer"));
        }

        if ((r2 == 1) && (pc2 == 1) && (toggle_gtrSolo.isOn == false))
        {
            AkSoundEngine.PostEvent("Unmute_All", GameObject.FindWithTag("PlayContainer"));
        }

        if ((r2 == 1) && (pc4 == 1) && (toggle_gtrSolo.isOn == true))
        {
            AkSoundEngine.PostEvent("gtr_solo_rehearsal_2_click_4M", GameObject.FindWithTag("PlayContainer"));
        }

        if ((r2 == 1) && (pc4 == 1) && (toggle_gtrSolo.isOn == false))
        {
            AkSoundEngine.PostEvent("Unmute_All", GameObject.FindWithTag("PlayContainer"));
        }
        
        //For Rehearsal 3

        if ((r3 == 1) && (pc2 == 1) && (toggle_gtrSolo.isOn == true))
        {
            AkSoundEngine.PostEvent("gtr_solo_rehearsal_3_click_2M", GameObject.FindWithTag("PlayContainer"));
        }

        if ((r3 == 1) && (pc2 == 1) && (toggle_gtrSolo.isOn == false))
        {
            AkSoundEngine.PostEvent("Unmute_All", GameObject.FindWithTag("PlayContainer"));
        }

        if ((r3 == 1) && (pc4 == 1) && (toggle_gtrSolo.isOn == true))
        {
            AkSoundEngine.PostEvent("gtr_solo_rehearsal_3_click_4M", GameObject.FindWithTag("PlayContainer"));
        }

        if ((r3 == 1) && (pc4 == 1) && (toggle_gtrSolo.isOn == false))
        {
            AkSoundEngine.PostEvent("Unmute_All", GameObject.FindWithTag("PlayContainer"));
        }

        //  both toggles active
        if (toggle_drumSolo.isOn && toggle_gtrSolo.isOn == true)
        {
            AkSoundEngine.PostEvent("Unmute_All", GameObject.FindWithTag("PlayContainer"));
            toggle_drumSolo.isOn = false;
            toggle_gtrSolo.isOn = false;
        }

    }

    public void Wwise_DrumSoloEvents()
     {
        r1 = PlayerPrefs.GetInt("sp_r1", r1_intValue);
        r2 = PlayerPrefs.GetInt("sp_r2", r1_intValue);
        r3 = PlayerPrefs.GetInt("sp_r3", r1_intValue);

        pc2 = PlayerPrefs.GetInt("preClick_2b", pc2_intValue);
        pc4 = PlayerPrefs.GetInt("preClick_4b", pc4_intValue);

        toggle_drumSolo = GameObject.FindWithTag("Toggle_DrumSolo").GetComponent<Toggle>();
        toggle_gtrSolo = GameObject.FindWithTag("Toggle_GtrSolo").GetComponent<Toggle>();

        /**** Drum Solo, No Pre-Click ****/

        // Rehearsal 1

        if ((r1 == 1) && (pc2 != 1) && (pc4 != 1) && (toggle_drumSolo.isOn == true))
        {
            AkSoundEngine.PostEvent("drum_solo_rehearsal_1_9M", GameObject.FindWithTag("PlayContainer"));
        }

        if ((r1 == 1) && (pc2 != 1) && (pc4 != 1) && (toggle_drumSolo.isOn == false))
        {
            AkSoundEngine.PostEvent("Unmute_All", GameObject.FindWithTag("PlayContainer"));
        }

        // Rehearsal 2

        if ((r2 == 1) && (pc2 != 1) && (pc4 != 1) && (toggle_drumSolo.isOn == true))
        {
            AkSoundEngine.PostEvent("drum_solo_rehearsal_2_6M", GameObject.FindWithTag("PlayContainer"));
        }

        if ((r2 == 1) && (pc2 != 1) && (pc4 != 1) && (toggle_drumSolo.isOn == false))
        {
            AkSoundEngine.PostEvent("Unmute_All", GameObject.FindWithTag("PlayContainer"));
        }

        // Rehearsal 3

        if ((r3 == 1) && (pc2 != 1) && (pc4 != 1) && (toggle_drumSolo.isOn == true))
        {
            AkSoundEngine.PostEvent("drum_solo_rehearsal_3_3M", GameObject.FindWithTag("PlayContainer"));
        }

        if ((r3 == 1) && (pc2 != 1) && (pc4 != 1) && (toggle_drumSolo.isOn == false))
        {
            AkSoundEngine.PostEvent("Unmute_All", GameObject.FindWithTag("PlayContainer"));
        }

        /**** Drum Solo Pre-Click Events ****/

        //For Rehearsal 1

        if ((r1 == 1) && (pc2 == 1) && (toggle_drumSolo.isOn == true))
        {
            AkSoundEngine.PostEvent("drum_solo_rehearsal_1_click_2M", GameObject.FindWithTag("PlayContainer"));
        }

        if ((r1 == 1) && (pc2 == 1) && (toggle_drumSolo.isOn == false))
        {
            AkSoundEngine.PostEvent("Unmute_All", GameObject.FindWithTag("PlayContainer"));
        }


        if ((r1 == 1) && (pc4 == 1) && (toggle_drumSolo.isOn == true))
        {
            AkSoundEngine.PostEvent("drum_solo_rehearsal_1_click_4M", GameObject.FindWithTag("PlayContainer"));
        }

        if ((r1 == 1) && (pc4 == 1) && (toggle_drumSolo.isOn == false))
        {
            AkSoundEngine.PostEvent("Unmute_All", GameObject.FindWithTag("PlayContainer"));

        }

        //For Rehearsal 2

        if ((r2 == 1) && (pc2 == 1) && (toggle_drumSolo.isOn == true))
        {
            AkSoundEngine.PostEvent("drum_solo_rehearsal_2_click_2M", GameObject.FindWithTag("PlayContainer"));
        }

        if ((r2 == 1) && (pc2 == 1) && (toggle_drumSolo.isOn == false))
        {
            AkSoundEngine.PostEvent("Unmute_All", GameObject.FindWithTag("PlayContainer"));
        }

        if ((r2 == 1) && (pc4 == 1) && (toggle_drumSolo.isOn == true))
        {
            AkSoundEngine.PostEvent("drum_solo_rehearsal_2_click_4M", GameObject.FindWithTag("PlayContainer"));
        }

        if ((r2 == 1) && (pc4 == 1) && (toggle_drumSolo.isOn == false))
        {
            AkSoundEngine.PostEvent("Unmute_All", GameObject.FindWithTag("PlayContainer"));
        }

        //For Rehearsal 3

        if ((r3 == 1) && (pc2 == 1) && (toggle_drumSolo.isOn == true))
        {
            AkSoundEngine.PostEvent("drum_solo_rehearsal_3_click_2M", GameObject.FindWithTag("PlayContainer"));
        }

        if ((r3 == 1) && (pc2 == 1) && (toggle_drumSolo.isOn == false))
        {
            AkSoundEngine.PostEvent("Unmute_All", GameObject.FindWithTag("PlayContainer"));
        }

        if ((r3 == 1) && (pc4 == 1) && (toggle_drumSolo.isOn == true))
        {
            AkSoundEngine.PostEvent("drum_solo_rehearsal_3_click_4M", GameObject.FindWithTag("PlayContainer"));
        }

        if ((r3 == 1) && (pc4 == 1) && (toggle_drumSolo.isOn == false))
        {
            AkSoundEngine.PostEvent("Unmute_All", GameObject.FindWithTag("PlayContainer"));
        }

     }

    public void UnMute_All()
    {
        toggle_drumSolo = GameObject.FindWithTag("Toggle_DrumSolo").GetComponent<Toggle>();
        toggle_gtrSolo = GameObject.FindWithTag("Toggle_GtrSolo").GetComponent<Toggle>();

        if ((toggle_drumSolo.isOn == true) && (toggle_gtrSolo.isOn == true))
        {
            toggle_drumSolo.isOn = false;
            toggle_gtrSolo.isOn = false;
            AkSoundEngine.PostEvent("Unmute_All", GameObject.FindWithTag("PlayContainer"));
        }
    }

}
        


