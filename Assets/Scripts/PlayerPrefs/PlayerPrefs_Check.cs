using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefs_Check : MonoBehaviour
{
    public int r3_intValue;
    public int pc4_intValue;
    void Start()
    {
        if (PlayerPrefs.GetInt("sp_r3", r3_intValue) < 1)
        {
            this.enabled = false;
            Debug.LogError("The integer value for Starting Position does not exist in PlayerPrefs");
            return;
        }

        r3_intValue = PlayerPrefs.GetInt("sp_r3", r3_intValue);
        Debug.Log("the integer value for Rehearsal #3 is " + PlayerPrefs.GetInt("sp_r3", r3_intValue));

        if (PlayerPrefs.GetInt("preClick_4b", pc4_intValue) < 1)
        {
            this.enabled = false;
            Debug.LogError("The integer value for Pre-Click 4 bars does not exist in PlayerPrefs");
            return;
        }

        pc4_intValue = PlayerPrefs.GetInt("preClick_4b", pc4_intValue);
        Debug.Log("the integer value for Pre-click 4 bars is " + PlayerPrefs.GetInt("preClick_4b", pc4_intValue));

    }

    public void PlayerPrefs_Delete()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("All music settings have been deleted");
    }


}
    
