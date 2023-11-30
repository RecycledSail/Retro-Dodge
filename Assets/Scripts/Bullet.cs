using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f; // 탄 속도
    private Rigidbody bulletRigidbody; // 탄의 Rigidbody 컴포넌트
    // Start is called before the first frame update
    void Start()
    {
        // Rigidbody 할당
        bulletRigidbody = GetComponent<Rigidbody>();

        // Rigidbody.velocity = 앞 방향 * speed
        bulletRigidbody.velocity = transform.forward * speed;

        // 3초 후에 자폭
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //충돌 시 실행되는 메서드
    private void OnTriggerEnter(Collider other)
    {
        //상대방에게서 PlayerController 컴포넌트 가져오기
        PlayerController playerController = other.GetComponent<PlayerController>();

        if (playerController != null) //PC가 실제로 존재한다면
        {
            //상대방 사망
            playerController.Die();
        }
    }
}
