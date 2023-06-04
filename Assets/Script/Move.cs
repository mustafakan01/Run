using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float MoveSpeed;

   
    void Start()
    {
        
    }

   
    void Update()
    {
        float hiz = MoveSpeed * Input.GetAxis("Horizontal");
        transform.Translate(hiz * Time.deltaTime, 0, 0);
    }
}
