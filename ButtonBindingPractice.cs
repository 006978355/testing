using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBindingPractice : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene("Game Scene");
    }

    public void QuitGame(){
        Debug.Log("Quitting Game...");
        Application.Quit();
    }
}
