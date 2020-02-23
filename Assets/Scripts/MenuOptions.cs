using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOptions : MonoBehaviour
{
    public int preClickBars;
    public int rehearsalNumber;

    void Start()
    {
        if(preClickBars == 2 && rehearsalNumber == 1)
        {
            Debug.Log("You have selected 2 bars of pre-click starting at rehearsal number 1.");
        }
    }
}
