using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class BackToMenuScript : MonoBehaviour {

    public void OnBackToMenuClick()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
