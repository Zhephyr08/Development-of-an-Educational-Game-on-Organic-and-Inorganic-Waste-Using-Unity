using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{

    public GameObject[] item;
    public GameObject[] itemDrop;
    public int jarak;
    public Vector2[] itemPos;
    [SerializeField] private AudioSource RightSoundEffect;
    [SerializeField] private AudioSource WrongSoundEffect;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < itemPos.Length; i++){
            itemPos[i] = item[i].transform.localPosition;
        }
    
    }

    public void ItemDrag(int number){ 
        item[number].transform.position = Input.mousePosition;
    }

    public void ItemEndDrag(int number){

        float distance = Vector3.Distance(item[number].transform.localPosition, itemDrop[number].transform.localPosition);

        if(distance < jarak){
            item[number].transform.localPosition = itemDrop[number].transform.localPosition;
            ScoreManage.instance.AddPoint();
            RightSoundEffect.Play();
        }else{
            item[number].transform.localPosition = itemPos[number];
            ScoreManage.instance.MinPoint();
            WrongSoundEffect.Play();
        }

    }

}
