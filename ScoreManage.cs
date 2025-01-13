using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManage : MonoBehaviour
{

 public static ScoreManage instance;
 public Text scoreText;
 int score = 0 ;
 private void Awake(){
    instance = this;
 }

    void Start()
    {
        scoreText.text = score.ToString() + " POINTS";
    }

    void Update()
    {
        if(score == 300){
            SceneManager.LoadScene("win");
        }
    }

    public void AddPoint(){
        score += 50;
        scoreText.text = score.ToString() + " POINTS";
    }

    public void MinPoint(){
        score -= 50;
        scoreText.text = score.ToString() + " POINTS";
    }

    public void end(){
        scoreText.text = score.ToString() + " POINTS";
    }
}
