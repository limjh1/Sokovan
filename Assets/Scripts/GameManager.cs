using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ItemBox[] itemBoxes;
    public bool isGameOver;
    bool isFull;
    public GameObject clearText;

    void Start() {
        isGameOver = false;
    }
    void Update() {        

        if(isGameOver){
            clearText.SetActive(true);
            Time.timeScale = 0;
            return;
        }     
        if(itemBoxes[0].isOveraped && itemBoxes[1].isOveraped && itemBoxes[2].isOveraped)
            isFull = true;
        
        if (isFull){
            isGameOver = true;
        }
    }
}
