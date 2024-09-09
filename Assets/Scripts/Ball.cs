using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] GameObject ball;
    
    void Start()
    {
        ball.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        ball.SetActive(true);
    }
}
