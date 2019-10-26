using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    public Text TheScore;

    private void Awake()
    {
        TheScore.text = PlayerController.numCount.ToString();
    }

}
