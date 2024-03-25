using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance; //싱글톤 나 하나밖에 없다 여러 스크립트에서 접근이 가능하게
    public GameObject rain;
    public GameObject endPanel;


    public Text totalScoreTxt;
    public Text timeTxt;

    int totalScore;

    float totalTime = 30.0f;

    private void Awake()
    {
        Instance = this; //Instance 변수에 나자신을 넣어줌
        Time.timeScale = 1.0f;
    }


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MakeRain", 0f, 1f); //함수 반복실행
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
        Instantiate(rain); // 함수 생성
    }

    void GameOver()
    {
       
    }

    public void AddScore(int score) // score에 데이터 보관하기 위한 변수를 만듦
    {
        totalScore += score;
        totalScoreTxt.text = totalScore.ToString();
    }
}
