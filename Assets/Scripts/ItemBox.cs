using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    public bool isOveraped = false;

    private Renderer myRenderer;
    public Color touchColor;
    private Color originalColor;

    void Start() {
        myRenderer = GetComponent<Renderer>();
        originalColor = myRenderer.material.color;
    }

    //트리거인 콜라이더와 충돌할때 자동 실행
    //Enter은 충돌한 그 순간 
    void OnTriggerEnter(Collider other) {
        if(other.tag == "EndPoint")
            isOveraped = true;
            myRenderer.material.color = touchColor;
    }
    //Exit는 충돌후 떼어지는 순간 
    void OnTriggerExit(Collider other) {
        if(other.tag == "EndPoint")
            isOveraped = false;
            myRenderer.material.color = originalColor;
    }
    //stay는 충돌하고 있는 혹은 붙어있는 동안..
    void OnTriggerStay(Collider other) {
         if(other.tag == "EndPoint")
            isOveraped = true;
            myRenderer.material.color = touchColor; 
    }
}
