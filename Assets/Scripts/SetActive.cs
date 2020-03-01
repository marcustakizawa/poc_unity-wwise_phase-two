using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    public GameObject GameObject;
    public void SetActiveMusicManager()
    {
        GameObject = GameObject.FindWithTag("MusicEventManager");
        Debug.Log("MusicEventManager");
        GameObject.GetComponent<PostMusic>().enabled = true;

        
    }

   
}
