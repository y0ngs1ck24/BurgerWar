using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hamburger : MonoBehaviour
{
    public static float hamburger_speed;
    public GameObject boom;

    void Start()
    {
        hamburger_speed = 3.0f;
    }

    void Awake()
    {
        GameObject.Find("Player").GetComponent<Player>();
    }


    void Update()
    {
        Debug.Log("스피드 : "+hamburger_speed);
        transform.Translate(Vector3.down* hamburger_speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Player.PlayerHP_Num -= 1;
            Destroy(gameObject);
            
        }

        if(collision.gameObject.tag == "BorderBullet")
        {
            GameObject temp;
            temp = Instantiate(boom, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Boom")
        {
            Destroy(gameObject);
        }
    }

    
}
