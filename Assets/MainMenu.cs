using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OnPlay()
    {
        SceneManager.LoadScene(1);
    }

    public void OnProgress()
    {
        SceneManager.LoadScene(2);
    }

    public void OnChickens()
    {
        SceneManager.LoadScene(3);
    }

    public void OnSettings()
    {
        SceneManager.LoadScene(4);
    }

    public void OnCredits()
    {
        SceneManager.LoadScene(5);
    }
}
