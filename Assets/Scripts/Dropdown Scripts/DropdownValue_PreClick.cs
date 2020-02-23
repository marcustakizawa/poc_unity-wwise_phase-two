using UnityEngine;
using UnityEngine.UI;

public class DropdownValue_PreClick : MonoBehaviour
{
    Dropdown m_Dropdown;
    public Text m_Text;

    void Start()
    {
        //Fetch the Dropdown GameObject
        m_Dropdown = GetComponent<Dropdown>();
        //Add listener for when the value of the Dropdown changes, to take action
        m_Dropdown.onValueChanged.AddListener(delegate {
            DropdownValueChanged(m_Dropdown);
        });

        //Initialize the Text to say the first value of the Dropdown
        m_Text.text = "First value of Pre-click bars : " + m_Dropdown.value;
    }
    
    //Output the new value of Dropdown into Text 
    void DropdownValueChanged(Dropdown change)
    {
        m_Text.text = "Number of pre-click bars: " + change.value;
    }
    
}
