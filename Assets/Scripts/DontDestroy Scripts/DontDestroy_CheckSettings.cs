using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy_CheckSettings : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {

        GameObject[] objs = GameObject.FindGameObjectsWithTag("checkSettings");


        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
            Debug.Log("Check Music Settings GameObject was destroyed");
        }

        DontDestroyOnLoad(this.gameObject);
        Debug.Log("Check Music Settings GameObject persists");

    }
}
