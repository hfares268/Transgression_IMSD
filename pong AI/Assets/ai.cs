using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class ai : MonoBehaviour
{
    public Transform ball;

    [Range(0, 1)]
    public float skill;
    //public float boost = 0;

    void Update()
    {

        Vector3 pos = transform.position;
        pos.y = Mathf.Lerp(transform.position.y, ball.position.y, skill);  //Linearly interpolates 
        transform.position = pos;
    }

}

//https://www.youtube.com/watch?v=jKbZM3KLqVI