using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float spawnTime; //햄버거
   // public float spawnTime2; //감자튀김
   // public float spawnTime3; //콜라

    public float curTime;
   // public float curTime2;
   // public float curTime3;

    public Transform spawnPoints;
    public Transform spawnPoints2;
    public Transform spawnPoints3;

    public GameObject hamberger;
    public GameObject poteto;
    public GameObject cola;

    public static int Hamburger_Num;
    public static int Poteto_Num;
    public static int Cola_Num;

    public int x; // 적       햄버거
  //  public int y; //감자튀김
  //  public int z; //콜라

    void Start()
    {

    }

    void Update()
    {
        if (GameManager.start == true) //추가
        {
            if (GameManager.phaze_Num == 1 && Hamburger_Num != 30 || GameManager.phaze_Num == 2 && Hamburger_Num != 45 ||
                GameManager.phaze_Num == 3 && Hamburger_Num != 20 || GameManager.phaze_Num == 5 && Hamburger_Num != 45 ||
                GameManager.phaze_Num == 3 && Poteto_Num != 20 || GameManager.phaze_Num == 4 && Poteto_Num != 60 ||
                GameManager.phaze_Num == 5 && Poteto_Num != 45 || GameManager.phaze_Num == 2 && Cola_Num != 45 ||
                GameManager.phaze_Num == 3 && Cola_Num != 20 || GameManager.phaze_Num == 4 && Cola_Num != 60 ||
                GameManager.phaze_Num == 5 && Cola_Num != 45)
            {
                if (curTime >= spawnTime)  //햄버거
                {
                    x = Random.Range(0, 3);
                    SpawnMake_x();
                }


                curTime += Time.deltaTime;
                

            }
            // Debug.Log(Hamburger_Num);


        }
        void SpawnMake_x()
        {
            if (x == 0)
            {
                int w = Random.Range(0, 3);
                if (w == 0)
                {
                    if (GameManager.phaze_Num == 1 && Hamburger_Num != 30 || GameManager.phaze_Num == 2 && Hamburger_Num != 45 ||
                    GameManager.phaze_Num == 3 && Hamburger_Num != 20 || GameManager.phaze_Num == 5 && Hamburger_Num != 45)
                    {
                        if (GameManager.next_stage)
                        {
                            curTime = 0;
                            Instantiate(hamberger, spawnPoints);
                            Hamburger_Num += 1;
                        }
                    }
                }
                if (w == 1)
                {
                    if (GameManager.phaze_Num == 3 && Poteto_Num != 20 || GameManager.phaze_Num == 4 && Poteto_Num != 60 ||
                    GameManager.phaze_Num == 5 && Poteto_Num != 45)
                    {
                        if (GameManager.next_stage)
                        {
                            curTime = 0;
                            Instantiate(poteto, spawnPoints);
                            Poteto_Num += 1;
                        }
                    }
                }

                if (w == 2)
                {
                    if (GameManager.phaze_Num == 2 && Cola_Num != 45 || GameManager.phaze_Num == 3 && Cola_Num != 20 ||
                    GameManager.phaze_Num == 4 && Cola_Num != 60 || GameManager.phaze_Num == 5 && Cola_Num != 45)
                    {
                        if (GameManager.next_stage)
                        {
                            curTime = 0;
                            Instantiate(cola, spawnPoints);
                            Cola_Num += 1;
                        }
                    }
                }

            }
            if (x == 1)
            {
                int q = Random.Range(0, 3);
                if (q == 0)
                {
                    if (GameManager.phaze_Num == 1 && Hamburger_Num != 30 || GameManager.phaze_Num == 2 && Hamburger_Num != 45 ||
                    GameManager.phaze_Num == 3 && Hamburger_Num != 20 || GameManager.phaze_Num == 5 && Hamburger_Num != 45)
                    {
                        if (GameManager.next_stage)
                        {
                            curTime = 0;
                            Instantiate(hamberger, spawnPoints2);
                            Hamburger_Num += 1;
                        }
                    }
                }
                if (q == 1)
                {
                    if (GameManager.phaze_Num == 3 && Poteto_Num != 20 || GameManager.phaze_Num == 4 && Poteto_Num != 60 ||
                    GameManager.phaze_Num == 5 && Poteto_Num != 45)
                    {
                        if (GameManager.next_stage)
                        {
                            curTime = 0;
                            Instantiate(poteto, spawnPoints2);
                            Poteto_Num += 1;
                        }
                    }
                }

                if (q == 2)
                {
                    if (GameManager.phaze_Num == 2 && Cola_Num != 45 || GameManager.phaze_Num == 3 && Cola_Num != 20 ||
                    GameManager.phaze_Num == 4 && Cola_Num != 60 || GameManager.phaze_Num == 5 && Cola_Num != 45)
                    {
                        if (GameManager.next_stage)
                        {
                            curTime = 0;
                            Instantiate(cola, spawnPoints2);
                            Cola_Num += 1;
                        }
                    }
                }

            }
            if (x == 2)
            {
                int e = Random.Range(0, 3);
                if (e == 0)
                {
                    if (GameManager.phaze_Num == 1 && Hamburger_Num != 30 || GameManager.phaze_Num == 2 && Hamburger_Num != 45 ||
                   GameManager.phaze_Num == 3 && Hamburger_Num != 20 || GameManager.phaze_Num == 5 && Hamburger_Num != 45)
                    {
                        if (GameManager.next_stage)
                        {
                            curTime = 0;
                            Instantiate(hamberger, spawnPoints3);
                            Hamburger_Num += 1;
                        }
                    }
                }

                if (e == 1)
                {
                    if (GameManager.phaze_Num == 3 && Poteto_Num != 20 || GameManager.phaze_Num == 4 && Poteto_Num != 60 ||
                    GameManager.phaze_Num == 5 && Poteto_Num != 45)
                    {
                        if (GameManager.next_stage)
                        {
                            curTime = 0;
                            Instantiate(poteto, spawnPoints3);
                            Poteto_Num += 1;
                        }
                    }
                }

                if (e == 2)
                {
                    if (GameManager.phaze_Num == 2 && Cola_Num != 45 || GameManager.phaze_Num == 3 && Cola_Num != 20 ||
                    GameManager.phaze_Num == 4 && Cola_Num != 60 || GameManager.phaze_Num == 5 && Cola_Num != 45)
                    {
                        if (GameManager.next_stage)
                        {
                            curTime = 0;
                            Instantiate(cola, spawnPoints3);
                            Cola_Num += 1;
                        }
                    }
                }

            }
        }

    }
}
