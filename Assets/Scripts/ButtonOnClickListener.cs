using System.Collections;
// Attach this script to an empty GameObject
// Create your button. Next, select your empty
// GameObject and click and drag your button to the corresponding variable (ex. m_playButton)

using UnityEngine;
using UnityEngine.UI;

public class ButtonOnClickListener : MonoBehaviour
{
    public Button m_playButton, m_stopButton;
    // Start is called before the first frame update
    void Start()
    {
        // Calls the TaskOnClick/ButtonClicked method when you click the Button
        m_playButton.onClick.AddListener(TaskOnClick);
        m_stopButton.onClick.AddListener(() => ButtonClicked(42));
    }

    void TaskOnClick()
    {
        //Output this to console when Play Button is clicked
        Debug.Log("You have clicked the Play Button and is now not interactable");
        m_playButton.interactable = false;
    }

    void ButtonClicked(int buttonNo)
    {
        //Output this to console when the Stop Button is clicked
        Debug.Log("Button clicked = " + buttonNo);
        m_playButton.interactable = true;
    }

   
}
