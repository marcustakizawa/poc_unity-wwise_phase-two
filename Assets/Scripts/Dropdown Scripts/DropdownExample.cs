using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownExample : MonoBehaviour
{
    //TODO: Read values from database, spreadsheet, online
    public List<string> names = new List<string>() { "Please Select","Rehearsal 1", "Rehearsal 2", "Rehearsal 3" };

    public Dropdown dropdown;
    public Text selectedName;

    public void Dropdown_IndexChanged(int index)
    {
        selectedName.text = names[index];
        if(index == 0)
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
        dropdown.AddOptions(names);
    }

}
