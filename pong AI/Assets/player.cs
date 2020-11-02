using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 5f;

    public Transform plyr;
    




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0f);    
    }

    void OnCollisionEnter(Collision collision)
    {
        switch (collision.transform.name)
        {
            case "Sphere":
                //ai.boost
                
                return;


        }


    }
















}
