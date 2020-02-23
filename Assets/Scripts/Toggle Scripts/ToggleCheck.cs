using UnityEngine;
using UnityEngine.UI;

public class ToggleCheck : MonoBehaviour
{
    Toggle m_Toggle;
    public Text m_Text;
    
    void Start()
    {
        //Fetch the Toggle GameObject
        m_Toggle = GetComponent<Toggle>();
        if(m_Toggle == null)
        {
            Debug.LogError("Failed to find an object named 'Toggle'");
            this.enabled = false;
            return;
        }
        //Add listener for when the state of the Toggle changes, to take action
        m_Toggle.onValueChanged.AddListener(delegate {
            ToggleValueChanged(m_Toggle);
        });

        //Initialise the Text to say the first state of the Toggle
        m_Text.text = "Pre-click active : " + m_Toggle.isOn;
    }

    //Output the new state of the Toggle into Text
    void ToggleValueChanged(Toggle change)
    {
        if(m_Toggle.isOn == true )
        {
            m_Text.text = "Pre-click enabled";
        }
        else
        {
            m_Text.text = "Pre-click disabled";
        }
    }
}
