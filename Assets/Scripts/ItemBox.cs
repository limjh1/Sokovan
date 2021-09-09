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

    //Ʈ������ �ݶ��̴��� �浹�Ҷ� �ڵ� ����
    //Enter�� �浹�� �� ���� 
    void OnTriggerEnter(Collider other) {
        if(other.tag == "EndPoint")
            isOveraped = true;
            myRenderer.material.color = touchColor;
    }
    //Exit�� �浹�� �������� ���� 
    void OnTriggerExit(Collider other) {
        if(other.tag == "EndPoint")
            isOveraped = false;
            myRenderer.material.color = originalColor;
    }
    //stay�� �浹�ϰ� �ִ� Ȥ�� �پ��ִ� ����..
    void OnTriggerStay(Collider other) {
         if(other.tag == "EndPoint")
            isOveraped = true;
            myRenderer.material.color = touchColor; 
    }
}
