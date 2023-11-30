using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidBody; //플레이어 게임오브젝트의 RigidBody 컴포넌트
    public float speed = 8f; //플레이어 속도

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true) //위 방향키
        {
            playerRigidBody.AddForce(0f, 0f, speed);
        }

        if (Input.GetKey(KeyCode.DownArrow) == true) //아래 방향키
        {
            playerRigidBody.AddForce(0f, 0f, -speed);
        }

        if (Input.GetKey(KeyCode.RightArrow) == true) //오른쪽 방향키
        {
            playerRigidBody.AddForce(speed, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.LeftArrow) == true) //왼쪽 방향키
        {
            playerRigidBody.AddForce(-speed, 0f, 0f);
        }
    }

    public void Die()
    {
        //죽으면 게임 오브젝트 비활성화
        gameObject.SetActive(false);
    }
}
