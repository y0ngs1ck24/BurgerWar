using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//

public class TitleManager : MonoBehaviour
{
    public GameObject StartScene;//

    void Start()
    {
        StartScene.SetActive(true);//
        GameManager.start = true; //추가
    }

  
     public void StartBtn()//
     {
         SceneManager.LoadScene("Stage");
         StartScene.SetActive(false);
     }
}
