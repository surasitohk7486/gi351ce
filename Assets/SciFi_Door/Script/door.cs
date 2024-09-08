using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

public class door : MonoBehaviour
{
    GameObject thedoor;
    
    void OnTriggerEnter(Collider obj)
    {
        thedoor = GameObject.FindWithTag("SF_Door");
        thedoor.GetComponent<Animation>().Play("open");

        
    }
}