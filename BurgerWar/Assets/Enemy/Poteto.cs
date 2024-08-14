using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poteto : MonoBehaviour
{
    public static float poteto_speed;

    public GameObject boom;

    void Start()
    {
        poteto_speed = 2.0f;    
    }

    void Awake()
    {
        GameObject.Find("Player").GetComponent<Player>();    
    }

    void Update()
    {
        transform.Translate(Vector3.down * poteto_speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Finish")
        {
            Player.PlayerHP_Num -= 2;
            Destroy(gameObject);
        }

        if(collision.gameObject.tag=="BorderBullet")
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
