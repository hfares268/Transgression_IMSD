
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float speed = 100f;
    Vector3 velocity;
    
    // Start is called before the first frame update
    void Start()
    {

        float derpx = Random.Range(0, 2) * 2f - 1f;
        float derpy = Random.Range(0, 2) * 2f - 1f * Random.Range(0f,0f); //pick btw 0 and 1 if zero assign sign to it

        //GetComponent<Rigidbody>().velocity = new Vector3(derpx * speed, derpy, 0f);
        velocity = new Vector3(derpx, derpy, 0);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        velocity = velocity.normalized * speed;
        transform.position += velocity* Time.deltaTime;
        
    }


    void OnCollisionEnter(Collision collision)
    {
        switch (collision.transform.name)
        {
            case "top":
            case "bottom":
                //velocity.x *= -1f;
                velocity.y *= -1f;
                return;

            case "ai1":
            case "ai2":
            case "p1":
            case "p2":
                velocity.x *= -1f;
                return;
        }


    }






}

//https://www.youtube.com/watch?v=jKbZM3KLqVI