using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    
    public GameObject bulletPrefab; // �Ѿ� ������
    public float spawnRateMin = 0.5f; // �ּ� ���� �ֱ�
    public float spawnRateMax = 3f; // �ִ� ���� �ֱ�

    private Transform target; // �߻��� ���
    private float spawnRate; // ���� ���� �ֱ�
    private float timeAfterSpawn; // �ֱ� �Ѿ� ���� �������� ���� �ð�
    // Start is called before the first frame update
    void Start()
    {
        // �ֱ� �Ѿ� ���� �ð��� 0���� �ʱ�ȭ
        timeAfterSpawn = 0f;

        // ���� �ֱ⸦ spawnRateMin - spawnRateMax ������ �ð����� ����
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);

        // PlayerController ������Ʈ�� �ִ� ���ӿ�����Ʈ�� ã�� target���� ����
        target = FindObjectOfType<PlayerController>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        // timeAfterSpawn ����
        timeAfterSpawn += Time.deltaTime; //Time.deltaTime = Cur frame - last frame

        // ���� �ֱ⺸�� timeAfteSpawn�� �� ũ�ٸ�
        if (timeAfterSpawn > spawnRate)
        {
            // ���� �ð� ����
            timeAfterSpawn = 0f;
            // �Ѿ� �ν��Ͻ� ����
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            // �Ѿ� �ν��Ͻ��� target�� �ٶ�
            bullet.transform.LookAt(target);
            // spawnRate ����ȭ
            spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        }
    }
}
