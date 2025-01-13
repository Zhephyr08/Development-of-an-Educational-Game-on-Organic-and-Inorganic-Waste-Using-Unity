using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class waktu : MonoBehaviour
{

public float timeremain = 0;
public bool timeisrunning = true;
public Text timeText;

float s;

public GameObject Canvas2;

 void Start()
 {
    timeisrunning = true;
 }

 void Update()
 {
    if(timeisrunning)
    {
        if( timeremain >= 0)
        {
            timeremain -= Time.deltaTime;
            displaytime(timeremain);
        }
    }

    if(timeisrunning && timeremain <= 0)
    {
         SceneManager.LoadScene("Score");
         timeisrunning = false;
    }

 }

 void displaytime(float timetodisplay)
 {
    timetodisplay +=1;
    float minutes = Mathf.FloorToInt (timetodisplay / 60);
    float seconds = Mathf.FloorToInt (timetodisplay % 60);
    timeText.text = "Time " + minutes.ToString("00") + ":" + seconds.ToString("00");
 }

}
