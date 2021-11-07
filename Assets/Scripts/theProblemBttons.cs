using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class theProblemBttons : MonoBehaviour
{
    //Make sure to attach these Buttons in the Inspector
    public Button m_YourFirstButton, m_YourSecondButton;

    void Start() {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        m_YourFirstButton.onClick.AddListener(PlayButton);
        m_YourSecondButton.onClick.AddListener(BackToMenu);
    }

    void PlayButton() {
        //Output this to console when Button1 is clicked
        Debug.Log("You have clicked the play button!");
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("Main"));
    }

    void BackToMenu() {
        Debug.Log("You have clicked the How To Button button!");
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("Menu"));
    }

}