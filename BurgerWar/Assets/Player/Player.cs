using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private float Inputkey;

    private bool isLeft = false;
    private bool isRight = false;

    public float maxShotDelay; 
    public float curShotDelay; 

    public GameObject bulletobj;
    public Slider PlayerHP;
    public static float PlayerHP_Num = 10;

    public GameManager gameManager;// 총알 이펙트 게임 오브젝트

    //public GameObject boomEffect; // 스킬 이펙트

    public GameObject bulletEffect; // 파티클 시스템 게임 오브젝트

    ParticleSystem ps;

    //ParticleSystem py;


    void Start()
    {
        ps = bulletEffect.GetComponent<ParticleSystem>(); // 파티클 시스템 컴포넌트를 가져오기
        //py = boomEffect.GetComponent<ParticleSystem>();
        PlayerHP.GetComponent<Slider>();
        PlayerHP.value = 10;
    }


    void Update()
    {
        Reload();

        if (GameManager.start==true) //추가
        {

            PlayerHP.value = PlayerHP_Num;

            if (PlayerHP.value == 0) //GameOver
            {
                GameManager.start = false;
                gameManager.over = true;//
            }

            if (isLeft)
            {
                transform.Translate(-1.5f, 0, 0);
                isLeft = false;
            }
            if (isRight)
            {
                transform.Translate(1.5f, 0, 0);
                isRight = false;
            }
            if (gameObject.transform.position == new Vector3(-1.87f, -3, -5) && isLeft)
            {
                isLeft = false;
            }
            if (gameObject.transform.position == new Vector3(1.13f, -3, -5) && isRight)
            {
                isRight = false;
            }
            
        }
        

    }



    public void LeftBtnDown()
    {
        if (gameObject.transform.position != new Vector3(-1.87f, -3, -5))
        {
            isLeft = true;
        }


    }
    public void RightBtnDown()
    {
        if (gameObject.transform.position != new Vector3(1.13f, -3, -5))
        {
            isRight = true;
        }
    }

    public void AttackBtnDown()
    {
        if (curShotDelay < maxShotDelay)
            return;
        SoundManager.instance.PlaySE("NormalGun_Fire_birdman");
        GameObject bulletEft = Instantiate(bulletEffect, new Vector3(this.transform.position.x + 0.5f,//이펙트위치
            this.transform.position.y + 0.5f, this.transform.position.z), transform.rotation);//이펙트위치
        ps.Play();//총알 이펙트 플레이
        GameObject bullet = Instantiate(bulletobj, new Vector3(this.transform.position.x + 0.5f,
            this.transform.position.y + 1f, this.transform.position.z), transform.rotation);
        Rigidbody2D rigid = bullet.GetComponent<Rigidbody2D>();
        rigid.AddForce(Vector2.up * 10, ForceMode2D.Impulse);

        curShotDelay = 0;
    }

    void Reload()
    {
        curShotDelay += Time.deltaTime;
    }

    
}
