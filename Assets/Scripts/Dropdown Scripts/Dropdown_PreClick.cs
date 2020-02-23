using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dropdown_PreClick : MonoBehaviour
{
    //TODO: Read values from database, spreadsheet, online
    public List<string> names = new List<string>() { "Please Select", "2 bars", "4 bars" };
    // Dropdown is referencing the script "Dropdown" within Dropdown_PreClick GameObject.
    public Dropdown dropdown;
    public Text selectedName;

    public void Dropdown_IndexChanged(int index)
    {
        selectedName.text = names[index];
        if (index == 0)
        {
            selectedName.color = Color.red;
        }
        else
        {
            selectedName.color = Color.white;
        }
    }

    void Start()
    {
        PopulateList();
    }

    void PopulateList()
    {
        //from Unity documentation: https://docs.unity3d.com/540/Documentation/ScriptReference/UI.Dropdown.AddOptions.html
        //in this case, we are adding the list of text strings called "names".
        dropdown.AddOptions(names);
    }

}
