using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PostMusic : MonoBehaviour
{
    public AK.Wwise.Event MusicEvent;
    public Toggle toggleCallbackTest;
    public string musicInfo;
    
    //Use this for initialization
    void Start()
    {
        //MusicEvent.Post(gameObject, (uint)AkCallbackType.AK_EndOfEvent, CallbackFunction);
        MusicEvent.Post(gameObject, (uint)AkCallbackType.AK_MusicSyncAll | (uint)AkCallbackType.AK_EndOfEvent, CallbackFunction2);
        Debug.Log("this Event has an AK_EndOfEvent");
    }

    void CallbackFunction(object in_cookie, AkCallbackType in_type, object in_info)
    {
        toggleCallbackTest = GameObject.FindWithTag("CallbackTesting").GetComponent<Toggle>();

        if (toggleCallbackTest.isOn == false)
        {
            toggleCallbackTest.isOn = true;
        }
    }

    void CallbackFunction2(object in_cookie, AkCallbackType in_type, object in_info)
    {
        toggleCallbackTest = GameObject.FindWithTag("CallbackTesting").GetComponent<Toggle>();

        Debug.Log("this is " + in_type);

        AkMusicSyncCallbackInfo musicSyncInfo = in_info as AkMusicSyncCallbackInfo;

        if (in_type == AkCallbackType.AK_EndOfEvent)
        {
            Debug.Log("CallbackFunction2");
            toggleCallbackTest.isOn = true;
        }

        if (musicSyncInfo == null)
        {
            //Callback ws not MusicSyncUserCue
            return;
        }

        musicInfo = musicSyncInfo.userCueName;

        Debug.Log("the name of the user cue is " + musicInfo);

        


    }

    
        
}
