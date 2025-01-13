using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TSA : MonoBehaviour
{
    [SerializeField] private AudioSource WrongSoundEffect;
    [SerializeField] private AudioSource RightSoundEffect;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Anorganik"))
        {
            Destroy(collision.gameObject);
            ScoreManage.instance.AddPoint();
            RightSoundEffect.Play();
        }
        if(collision.gameObject.CompareTag("Organik"))
        {
            Destroy(collision.gameObject);
            ScoreManage.instance.MinPoint();
            WrongSoundEffect.Play();
        }
    }


}
