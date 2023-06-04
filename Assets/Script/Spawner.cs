using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawner : MonoBehaviour
{
    public static int Skor;
    public TextMeshProUGUI skorYazi , gameOver;


    private void Update()
    {
        skorYazi.text=Skor.ToString();
        gameOver.text= "Oyun Bitti! \n Skor:" + Skor.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        float xPoz = Random.Range(-5f, 5f);
        float yPoz = Random.Range(6.5f, 15f);
        if (collision.gameObject.tag=="Zemin")
        {
            transform.position = new Vector2(xPoz,yPoz);
            Skor++;

        }
        else if(collision.gameObject.tag=="Player")
        {
            transform.position = new Vector2(xPoz, yPoz);
            Health.health--;
        }
    }
}
