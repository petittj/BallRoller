using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Showdata : MonoBehaviour
{
    public Text Lives;
    public Text round;
    public Text CSpeed;
    public Text BSpeed;
    public Text HScore;
    public Text PName;



    private void Awake()
    {
        Lives.text = "Lives: " + KeepData.PlayerLives;
        round.text = "round: " + KeepData.RoundsPlayed;
        CSpeed.text = "Cube Speed: " + KeepData.PlayerSpeed;
        BSpeed.text = "Ball Speed: " + KeepData.CubeSpeed;
        HScore.text = "HighScore: " + KeepData.HighScore;
        PName.text = KeepData.PlayerName;


    }



}
