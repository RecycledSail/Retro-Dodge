using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI 라이브러리
using UnityEngine.SceneManagement; // 씬 라이브러리

public class GameManager : MonoBehaviour
{
    public GameObject gameOverText; // 게임오버 텍스트 GameObject
    public Text timeText; // 생존 시간 Text
    public Text recordText; // 기록 점수 Text

    private float surviveTime; // 생존 시간
    private bool isGameover; // 게임오버 상태
    // Start is called before the first frame update
    void Start()
    {
        // 생존 시간 초기화
        surviveTime = 0f;
        // 게임오버 상태 초기화
        isGameover = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameover)
        {
            surviveTime += Time.deltaTime;
            timeText.text = "Time: " + (int)surviveTime;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                //SampleScene 씬 다시 로드
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

    // 게임오버 됐을 때
    public void EndGame()
    {
        // 현재 상태를 게임오버 상태로 전환
        isGameover = true;
        // 게임오버 텍스트 GameObject 활성화
        gameOverText.SetActive(true);

        float bestTime = PlayerPrefs.GetFloat("BestTime");

        // 지금이 최고 기록이라면
        if (surviveTime > bestTime)
        {
            // 변경된 최고 기록을 저장
            bestTime = surviveTime;
            PlayerPrefs.SetFloat("Besttime", bestTime);
        }

        // 최고 기록을 recordText를 이용해 표시
        recordText.text = "Best Time: " + (int)bestTime;
    }
}
