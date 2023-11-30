using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    
    public GameObject bulletPrefab; // 총알 프리팹
    public float spawnRateMin = 0.5f; // 최소 생성 주기
    public float spawnRateMax = 3f; // 최대 생성 주기

    private Transform target; // 발사할 대상
    private float spawnRate; // 실제 생성 주기
    private float timeAfterSpawn; // 최근 총알 생성 시점에서 지난 시간
    // Start is called before the first frame update
    void Start()
    {
        // 최근 총알 생성 시간을 0으로 초기화
        timeAfterSpawn = 0f;

        // 생성 주기를 spawnRateMin - spawnRateMax 사이의 시간으로 설정
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);

        // PlayerController 컴포넌트가 있는 게임오브젝트를 찾아 target으로 설정
        target = FindObjectOfType<PlayerController>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        // timeAfterSpawn 갱신
        timeAfterSpawn += Time.deltaTime; //Time.deltaTime = Cur frame - last frame

        // 생성 주기보다 timeAfteSpawn이 더 크다면
        if (timeAfterSpawn > spawnRate)
        {
            // 누적 시간 리셋
            timeAfterSpawn = 0f;
            // 총알 인스턴스 생성
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            // 총알 인스턴스가 target을 바라봄
            bullet.transform.LookAt(target);
            // spawnRate 랜덤화
            spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        }
    }
}
