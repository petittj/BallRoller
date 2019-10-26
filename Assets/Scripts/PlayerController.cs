using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{

    public float speed = 800.0f;
    public Text ScoreText;
    public Text WinText;
    public static int numCount = 0;
    public  int count=0;
    public float X = 0.0f;
   


    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        X = KeepData.PlayerSpeed;
        
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime*X);


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PickUp")
        {
            other.gameObject.SetActive(false);
            count += 1;
            ScoreText.text = "Score: " + count;
            KeepData.GethighScore();
            numCount = count;
            if (count >= 16)
            {
                WinText.gameObject.SetActive(true);

                
                if (KeepData.RoundsPlayed >= KeepData.PlayerLives)
                {
                    SceneManager.LoadScene("End");
                }
                else if (KeepData.RoundsPlayed < KeepData.PlayerLives)
                {
                    SceneManager.LoadScene("MainScene");
                    KeepData.Round();

                }
              
            }
        }
       
    }
}
