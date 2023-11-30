using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI ���̺귯��
using UnityEngine.SceneManagement; // �� ���̺귯��

public class GameManager : MonoBehaviour
{
    public GameObject gameOverText; // ���ӿ��� �ؽ�Ʈ GameObject
    public Text timeText; // ���� �ð� Text
    public Text recordText; // ��� ���� Text

    private float surviveTime; // ���� �ð�
    private bool isGameover; // ���ӿ��� ����
    // Start is called before the first frame update
    void Start()
    {
        // ���� �ð� �ʱ�ȭ
        surviveTime = 0f;
        // ���ӿ��� ���� �ʱ�ȭ
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
                //SampleScene �� �ٽ� �ε�
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

    // ���ӿ��� ���� ��
    public void EndGame()
    {
        // ���� ���¸� ���ӿ��� ���·� ��ȯ
        isGameover = true;
        // ���ӿ��� �ؽ�Ʈ GameObject Ȱ��ȭ
        gameOverText.SetActive(true);

        float bestTime = PlayerPrefs.GetFloat("BestTime");

        // ������ �ְ� ����̶��
        if (surviveTime > bestTime)
        {
            // ����� �ְ� ����� ����
            bestTime = surviveTime;
            PlayerPrefs.SetFloat("Besttime", bestTime);
        }

        // �ְ� ����� recordText�� �̿��� ǥ��
        recordText.text = "Best Time: " + (int)bestTime;
    }
}
