using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneManage : MonoBehaviour
{

    [SerializeField] private AudioSource TrasisiSoundEffect;
    public void LoadToScene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }

    public void quit(){
        Application.Quit();
    }


    public void mulai(){
        TrasisiSoundEffect.Play();
    }



}
