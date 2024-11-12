//using System;
//using System.Collections;
//using System.Collections.Generic;
//using TMPro;
//using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 Direction;
    private float Gravity = -9.8f;
    public float Force = 3f;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButton(0))
        {
            Direction = Vector3.up * Force;
        }

        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began)
            {
                Direction = Vector3.up * Force;
            }
        }

        Direction.y += Gravity * Time.deltaTime;

        transform.position += Direction*Time.deltaTime;
    }
    private void OnEnable()
    {
        Vector3 position = transform.position;
        position.y = 0.45f;
        transform.position = position;
        Direction = new Vector3(0, 0, 0);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            FindAnyObjectByType<GameManager>().GameOver();
        }
        else if(other.tag=="Scoring")
        {
            FindAnyObjectByType<GameManager>().IncreaseScore();
        }
    }

}
