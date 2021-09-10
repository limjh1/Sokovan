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
        addforce 는 관성이 들어가는 속도
        velocity 는 관성이 없는 속도 그러나 떨어질 때 y도 0으로 덮어씌워서 떨어지는게 이상해보임
        관성으로 인한 점점 힘이 커져서 적용되는 방식 playerRigidbody.AddForce(inputX*speed,0,inputZ*speed);        
        velocity를 넣으면 바로 넣어짐 속도가
        */
        Vector3 velocity = new Vector3(inputX,0,inputZ);

        // (inpux * speed, 0 * speed, inpuz * speed)이 되어버리는 것
        velocity = velocity * speed;
        // 원래 떨어지는 속도를 할당해줌
        velocity.y = fallSpeed;

        playerRigidbody.velocity = velocity;


    }
}
