using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Health : MonoBehaviour
{
    public static int health=3;
    public TextMeshProUGUI healthCount;
    public GameObject GameOVer;
    void Start()
    {
        
    }

    
    void Update()
    {
        healthCount.text = "Can:" + health.ToString();        
        if (health ==0)
        {
            GameOVer.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
