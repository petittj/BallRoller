using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Scenes : MonoBehaviour
{
    public static int numround = 0;
    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void EndGame()
    {
        SceneManager.LoadScene("End");
    }
    public void IntroGame()
    {
        SceneManager.LoadScene("Intro");
    }
    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
