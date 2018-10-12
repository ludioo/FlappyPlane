using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScene : MonoBehaviour {

    public void Play()
    {
        Application.LoadLevel("Gameplay");
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Udah Keluar");
    }

    public void Home()
    {
        Application.LoadLevel("MainMenu");
    }
}
