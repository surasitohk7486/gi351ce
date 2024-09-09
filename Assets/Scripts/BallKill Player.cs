using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallKillPlayer : MonoBehaviour
{
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
        }
    }


}
