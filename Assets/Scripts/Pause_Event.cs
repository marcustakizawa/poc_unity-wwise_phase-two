﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_Event : MonoBehaviour
{
    [SerializeField]
    private LayerMask _Pause_Event;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit2D rayHit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, Mathf.Infinity, _Pause_Event);
            if(rayHit)
            {
                Debug.Log("Left click on " + rayHit.collider.gameObject); 
            }
        }
    }
}
