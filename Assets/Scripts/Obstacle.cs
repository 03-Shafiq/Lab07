﻿﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//This script manages the behavior of individual obstacle
public class Obstacle : MonoBehaviour
{
    [SerializeField] private float Speed = 3;
  

    void Update()
    {
        if (transform.position.x <= -8)
        {
            Destroy(gameObject);
          
        }
        
        else
            transform.Translate(Vector3.right * Time.deltaTime * -Speed);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
          
            Destroy(collision.gameObject);
            SceneManager.LoadScene("Gameover");

        }
    }
}
