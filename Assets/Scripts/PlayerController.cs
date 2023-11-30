using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidBody; //�÷��̾� ���ӿ�����Ʈ�� RigidBody ������Ʈ
    public float speed = 8f; //�÷��̾� �ӵ�

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true) //�� ����Ű
        {
            playerRigidBody.AddForce(0f, 0f, speed);
        }

        if (Input.GetKey(KeyCode.DownArrow) == true) //�Ʒ� ����Ű
        {
            playerRigidBody.AddForce(0f, 0f, -speed);
        }

        if (Input.GetKey(KeyCode.RightArrow) == true) //������ ����Ű
        {
            playerRigidBody.AddForce(speed, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.LeftArrow) == true) //���� ����Ű
        {
            playerRigidBody.AddForce(-speed, 0f, 0f);
        }
    }

    public void Die()
    {
        //������ ���� ������Ʈ ��Ȱ��ȭ
        gameObject.SetActive(false);
    }
}
