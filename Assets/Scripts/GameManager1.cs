using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance; //�̱��� �� �ϳ��ۿ� ���� ���� ��ũ��Ʈ���� ������ �����ϰ�
    public GameObject rain;
    public GameObject endPanel;


    public Text totalScoreTxt;
    public Text timeTxt;

    int totalScore;

    float totalTime = 30.0f;

    private void Awake()
    {
        Instance = this; //Instance ������ ���ڽ��� �־���
        Time.timeScale = 1.0f;
    }


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MakeRain", 0f, 1f); //�Լ� �ݺ�����
    }

    // Update is called once per frame
    void Update()
    {
        if(totalTime > 0f)
        {
            totalTime -= Time.deltaTime;
            
        }
        else
        {
            totalTime = 0f;
            endPanel.SetActive(true);
            Time.timeScale = 0f;
        }

        timeTxt.text = totalTime.ToString("N2");
    }

    void MakeRain()
    {
        Instantiate(rain); // �Լ� ����
    }

    void GameOver()
    {
       
    }

    public void AddScore(int score) // score�� ������ �����ϱ� ���� ������ ����
    {
        totalScore += score;
        totalScoreTxt.text = totalScore.ToString();
    }
}
