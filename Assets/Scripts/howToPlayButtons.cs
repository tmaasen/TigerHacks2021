using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class howToPlayButtons : MonoBehaviour
{
    //Make sure to attach these Buttons in the Inspector
    public Button m_YourFirstButton, m_YourSecondButton;

    void Start() {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        m_YourFirstButton.onClick.AddListener(PlayButton);
        m_YourSecondButton.onClick.AddListener(MainMenu);
    }

    void PlayButton() {
        Debug.Log("You have clicked the play button!");
        SceneManager.UnloadSceneAsync ("GameOver");
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("Main"));
    }

    void MainMenu() {
        Debug.Log("You have clicked the How To Play button!");
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("Menu"));
    }
}