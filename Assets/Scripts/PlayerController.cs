using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // RigidBody public에서 private로 변경하여 안정성
    private Rigidbody playerRigidBody; // 플레이어 게임오브젝트의 RigidBody 컴포넌트
    public float speed = 8f; // 플레이어 속도

    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Horizontal, Vertical 입력값 감지
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        // 실제 이동 속도를 입력값 * 이동 속력으로 결정
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        // Vector3 속도를 (xSpeed, 0, zSpeed)
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);

        // RigidBody.velocity에 newVelocity 할당
        playerRigidBody.velocity = newVelocity;
    }

    public void Die()
    {
        //죽으면 게임 오브젝트 비활성화
        gameObject.SetActive(false);
    }
}
