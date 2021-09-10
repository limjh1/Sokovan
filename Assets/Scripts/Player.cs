using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager gameManager;
    public float speed = 10f;
    Rigidbody playerRigidbody;

    void Start() {
        playerRigidbody = GetComponent<Rigidbody>();
    }    

    void Update(){
        if(gameManager.isGameOver){
            return;
        }
        //-1 ~ +1
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");

        float fallSpeed = playerRigidbody.velocity.y;

        /*
        addforce �� ������ ���� �ӵ�
        velocity �� ������ ���� �ӵ� �׷��� ������ �� y�� 0���� ������� �������°� �̻��غ���
        �������� ���� ���� ���� Ŀ���� ����Ǵ� ��� playerRigidbody.AddForce(inputX*speed,0,inputZ*speed);        
        velocity�� ������ �ٷ� �־��� �ӵ���
        */
        Vector3 velocity = new Vector3(inputX,0,inputZ);

        // (inpux * speed, 0 * speed, inpuz * speed)�� �Ǿ������ ��
        velocity = velocity * speed;
        // ���� �������� �ӵ��� �Ҵ�����
        velocity.y = fallSpeed;

        playerRigidbody.velocity = velocity;


    }
}
