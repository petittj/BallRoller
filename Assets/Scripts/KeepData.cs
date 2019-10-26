using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KeepData : MonoBehaviour
{
    public static string PlayerName;
    public static float PlayerSpeed;
    public static float CubeSpeed;
    public static int PlayerLives;
    public static int RoundsPlayed=1;
    public static int HighScore=0;
    public static int score;


    public InputField PlayerNameInput;
    public Slider PlayerSpeedSlider;
    public Slider CubeSpeedSlider;
    public Dropdown PlayerLivesDropdown;
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void UpdateName()
    {
        PlayerName = PlayerNameInput.text;
    }
    
    public void ChangePlayerSpeed()
    {
        PlayerSpeed = PlayerSpeedSlider.value;
    }

    public static void GethighScore()
    {
        score = PlayerController.numCount;
        if (score> HighScore)
        {
            HighScore = score + 1 ;
        }
    }

    public static void Round()
    {
        RoundsPlayed += 1;
        //SceneManager.LoadScene("End");

        //if (RoundsPlayed > PlayerLives)
        // {

        //}
    }

    public void ChangeCubeSpeed()
    {
        CubeSpeed = CubeSpeedSlider.value;
    }
    public void SetLives()
    {
        PlayerLives = PlayerLivesDropdown.value;
    }


}
