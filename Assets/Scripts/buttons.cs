using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
    //Make sure to attach these Buttons in the Inspector
    public Button m_YourFirstButton, m_YourSecondButton, m_YourThirdButton;

    void Start() {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        m_YourFirstButton.onClick.AddListener(PlayButton);
        m_YourSecondButton.onClick.AddListener(delegate { TaskWithParameters("Hello"); });
        m_YourThirdButton.onClick.AddListener(() => ButtonClicked(42));
        m_YourThirdButton.onClick.AddListener(PlayButton);
    }

    void PlayButton() {
        //Output this to console when Button1 is clicked
        Debug.Log("You have clicked the play button!");
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("Main"));
    }

    void TaskWithParameters(string message) {
        //Output this to console when the Button2 is clicked
        Debug.Log(message);
    }

    void ButtonClicked(int buttonNo) {
        //Output this to console when the Button3 is clicked
        Debug.Log("Button clicked = " + buttonNo);
    }
}