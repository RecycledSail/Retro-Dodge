using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f; // ź �ӵ�
    private Rigidbody bulletRigidbody; // ź�� Rigidbody ������Ʈ
    // Start is called before the first frame update
    void Start()
    {
        // Rigidbody �Ҵ�
        bulletRigidbody = GetComponent<Rigidbody>();

        // Rigidbody.velocity = �� ���� * speed
        bulletRigidbody.velocity = transform.forward * speed;

        // 3�� �Ŀ� ����
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //�浹 �� ����Ǵ� �޼���
    private void OnTriggerEnter(Collider other)
    {
        //���濡�Լ� PlayerController ������Ʈ ��������
        PlayerController playerController = other.GetComponent<PlayerController>();

        if (playerController != null) //PC�� ������ �����Ѵٸ�
        {
            //���� ���
            playerController.Die();
        }
    }
}
