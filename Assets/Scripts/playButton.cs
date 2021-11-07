using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.SceneManagement;  
public class SceneChanger: MonoBehaviour {  
    public void PlayButton() {  
        Debug.Log("test");
        SceneManager.LoadScene("Main");  
    }  
    public void QuitButton() {  
        Debug.Log("exitgame");  
        Application.Quit();  
    }    
} 