using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // RigidBody public���� private�� �����Ͽ� ������
    private Rigidbody playerRigidBody; // �÷��̾� ���ӿ�����Ʈ�� RigidBody ������Ʈ
    public float speed = 8f; // �÷��̾� �ӵ�

    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Horizontal, Vertical �Է°� ����
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        // ���� �̵� �ӵ��� �Է°� * �̵� �ӷ����� ����
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        // Vector3 �ӵ��� (xSpeed, 0, zSpeed)
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);

        // RigidBody.velocity�� newVelocity �Ҵ�
        playerRigidBody.velocity = newVelocity;
    }

    public void Die()
    {
        //������ ���� ������Ʈ ��Ȱ��ȭ
        gameObject.SetActive(false);
    }
}
