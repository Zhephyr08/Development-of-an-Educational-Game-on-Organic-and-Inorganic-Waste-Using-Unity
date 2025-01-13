using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour
{

public Text scoreText;

    void Start()
    {
        ScoreManage.instance.end();
    }

}
