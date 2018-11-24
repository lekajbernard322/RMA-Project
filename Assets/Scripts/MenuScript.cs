using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {
    
    public void OnStartClick()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void OnAboutClick()
    {
        SceneManager.LoadScene("AboutScene");
    }

    public void OnExitClick()
    {
        Application.Quit();
    }


}
