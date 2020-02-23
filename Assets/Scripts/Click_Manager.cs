using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_Manager : MonoBehaviour
{
    [SerializeField]
    private LayerMask _Click_Manager;
    // Update is called once per frame
    void Update()
    {
       if(Input.GetMouseButtonDown(0))
        {
            //Vector2.zero is used to provide the direction of the Raycast to ensure 
            //that only objects at the point of the click are detected
            RaycastHit2D rayHit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, Mathf.Infinity, _Click_Manager);
            if(rayHit.collider != null)
            {
                Debug.Log(rayHit.collider.gameObject + " was clicked!");
    
            
            
            }
        }
    }
}
