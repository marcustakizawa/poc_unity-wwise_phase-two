using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script manages the player preferences for the music. 
//The GameObject with the "settings" tag is the MusicSettings GameObject.

public class DontDestroy : MonoBehaviour
{
    public static DontDestroy CurrentMusicSettingsInstance;

    // Start is called before the first frame update
    void Awake()
    {
        if(CurrentMusicSettingsInstance != null)
        {
            //other instance of Music Settings should exist, not this one 
            //Let's destroy ourselves 
            Destroy(this.gameObject);
            Debug.Log("CurrentMusicSettingsInstance was destroyed");
            return;
        }

        CurrentMusicSettingsInstance = this;
        GameObject.DontDestroyOnLoad(this.gameObject);
        Debug.Log("This is the CurrentMusicSettingsInstance");

        /*
        GameObject[] objs = GameObject.FindGameObjectsWithTag("settings");


        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
            Debug.Log("Music Settings GameObject was destroyed");
        }

        DontDestroyOnLoad(this.gameObject);
        Debug.Log("Music Settings GameObject is not destroyed");
        */
    }


}
