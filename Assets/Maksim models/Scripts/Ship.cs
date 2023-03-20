using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public float angle = 10f;
    public float speed = 10f;
    public bool isMovingRight = true;
    void Update()
    {
        if (isMovingRight)
        {
            if (transform.eulerAngles.z > angle && transform.eulerAngles.z < 360-angle - 1) isMovingRight = false;

            transform.Rotate(new Vector3(0,0,speed * Time.deltaTime));
        }
        else 
        {
            if (transform.eulerAngles.z < 360-angle && transform.eulerAngles.z > angle + 1) isMovingRight = true;

            transform.Rotate(new Vector3(0,0,-speed * Time.deltaTime));
        }
    }
}
