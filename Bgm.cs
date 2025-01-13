using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bgm : MonoBehaviour
{

    public static Bgm instance;

    private void Awake(){

    if( instance == null){
        instance = this;
        DontDestroyOnLoad(gameObject); 
    }else{
        Destroy(gameObject);
    }
    
 }

}
