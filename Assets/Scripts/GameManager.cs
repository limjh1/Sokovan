using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if(Input.GetKeyDown(KeyCode.Space)){
            SceneManager.LoadScene(0);
        }

        if(isGameOver){
            clearText.SetActive(true);  
            return;
        }     
        if(itemBoxes[0].isOveraped && itemBoxes[1].isOveraped && itemBoxes[2].isOveraped)
            isFull = true;
        
        if (isFull){
            isGameOver = true;
        }
    }
}
