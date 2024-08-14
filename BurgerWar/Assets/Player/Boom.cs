using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Hamburger")
        {
            SoundManager.instance.PlaySE("bubu");
            GameManager.score += 10;
            
        }

        if (collision.gameObject.tag == "Cola")
        {
            SoundManager.instance.PlaySE("bubu");
            GameManager.score += 20;
            
        }


        if (collision.gameObject.tag == "Poteto")
        {
            SoundManager.instance.PlaySE("bubu");
            GameManager.score += 30;
            
        }


    }
}
