using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
   
    public static int phaze_Num;
    public TextMeshProUGUI ScoreText;
    public static int score;

    public static bool next_stage;

    public GameObject GameOverScene;
    public GameObject ClearScene;
    public GameObject Warning;
    public GameObject Danger;

    public bool over = false;
    public bool clear = false;
    public static bool start = false;


    void Start()
    {
        GameOverScene.SetActive(false);
        ClearScene.SetActive(false);
        Warning.SetActive(false);

        phaze_Num = 1;
        score = 0;
        ScoreText.text = "Score : " + score;

        next_stage = true;
    }

    
    void Update()
    {

        if (over == true)
        {
            GameOverScene.SetActive(true);
            start = false; 
            Player.PlayerHP_Num = 10;
        }

        if (over == false)
        {
            GameOverScene.SetActive(false);
            start = true; 
            
        }

        if (clear == true)
        {
            ClearScene.SetActive(true);
            
        }


        ScoreText.text = "Score : " + score;

        

        //배수만큼 바꿔서 하기
        Debug.Log("페이즈 : "+phaze_Num);
        if (phaze_Num == 1 && SpawnManager.Hamburger_Num == 30) 
        {
            phaze_Num += 1;
            next_stage = false;
            //Invoke("Next_Time", 7f);
            Invoke("Warning_Start", 3f);
            SpawnManager.Hamburger_Num = 0;
            SpawnManager.Cola_Num = 0;
            SpawnManager.Poteto_Num = 0;
        }
        if(phaze_Num==2)
        {
            Hamburger.hamburger_speed = 7.0f;
            Poteto.poteto_speed = 7.0f;
            Cola.cola_speed = 7.0f;

            if(SpawnManager.Hamburger_Num == 45 && SpawnManager.Cola_Num == 45)
            {
                phaze_Num += 1;

                next_stage = false; //소환 중지
               // Invoke("Next_Time", 7f);
               Invoke("Warning_Start", 3f);
                SpawnManager.Hamburger_Num = 0;
                SpawnManager.Cola_Num = 0;
                SpawnManager.Poteto_Num = 0;
            }
            
        }
        if(phaze_Num==3)
        {
            Hamburger.hamburger_speed = 9.0f;
            Poteto.poteto_speed = 9.0f;
            Cola.cola_speed = 9.0f;

            if (SpawnManager.Hamburger_Num== 20 && SpawnManager.Cola_Num== 20 && SpawnManager.Poteto_Num== 20)
            {
                phaze_Num += 1;
                
                next_stage = false;
               // Invoke("Next_Time", 7f);
                Invoke("Warning_Start", 3f);
                SpawnManager.Hamburger_Num = 0;
                SpawnManager.Cola_Num = 0;
                SpawnManager.Poteto_Num = 0;
            }
        }
        if(phaze_Num==4)
        {
            Hamburger.hamburger_speed = 8.0f;
            Poteto.poteto_speed = 8.0f;
            Cola.cola_speed = 8.0f;

            if (SpawnManager.Cola_Num== 60 && SpawnManager.Poteto_Num== 60)
            {
                phaze_Num += 1;
                
                next_stage = false;
                //Invoke("Next_Time", 7f);
                Invoke("Danger_Start", 3f);
                SpawnManager.Hamburger_Num = 0;
                SpawnManager.Cola_Num = 0;
                SpawnManager.Poteto_Num = 0;
            }
        }
        if(phaze_Num==5)
        {
            Hamburger.hamburger_speed = 9.0f;
            Poteto.poteto_speed = 9.0f;
            Cola.cola_speed = 9.0f;

            if (SpawnManager.Hamburger_Num== 45 && SpawnManager.Cola_Num== 45 && SpawnManager.Poteto_Num== 45)
            {
                Invoke("Clear_Start", 4f);
            }
        }
    }

    public void restartBtn()
    {
        SceneManager.LoadScene("Title");
        over = false; 
    }

    void Clear_Start()
    {
        clear = true;
    }
    void Next_Time()
    {
        next_stage = true;
        Debug.Log("다음스테이지");
    }

    void Warning_Start() //위험 표시 나오게 하는 함수 
    {
        Warning.SetActive(true);//위험 활성화
        Invoke("Warning_Stop", 3f);//3초 기다림 
    }
    void Warning_Stop() //위험 표시 없어지게 하는 함수 
    {
        Warning.SetActive(false);//위험 비 활성화
        Invoke("Next_Time", 1f);//1초 기다린 후에 몬스터 소환
    }

    void Danger_Start() //위험 표시 나오게 하는 함수 
    {
        Danger.SetActive(true);//위험 활성화
        Invoke("Danger_Stop", 3f);//3초 기다림 
    }
    void Danger_Stop() //위험 표시 없어지게 하는 함수 
    {
        Danger.SetActive(false);//위험 비 활성화
        Invoke("Next_Time", 1f);//1초 기다린 후에 몬스터 소환
    }

}
