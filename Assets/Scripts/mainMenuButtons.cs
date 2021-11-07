using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainMenuButtons : MonoBehaviour
{
    //Make sure to attach these Buttons in the Inspector
    public Button m_YourFirstButton, m_YourSecondButton, m_YourThirdButton;

    void Start() {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        m_YourFirstButton.onClick.AddListener(PlayButton);
        m_YourSecondButton.onClick.AddListener(HowToButton);
        m_YourThirdButton.onClick.AddListener(QuitGame);
    }

    void PlayButton() {
        //Output this to console when Button1 is clicked
        Debug.Log("You have clicked the play button!");
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("Main"));
    }

    void HowToButton() {
        Debug.Log("You have clicked the How To Button button!");
        SceneManager.LoadScene("HowToScene", LoadSceneMode.Single);
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("How To Scene"));
    }

    void QuitGame() {
        Debug.Log("You have clicked the quit button.");
        Application.Quit();
    }
}