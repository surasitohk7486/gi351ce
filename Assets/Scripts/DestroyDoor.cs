using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDoor : MonoBehaviour
{
    [SerializeField] GameObject D;
    [SerializeField] GameObject M;
    void OnTriggerEnter(Collider obj)
    {
        D.SetActive(false);
        M.SetActive(true);
    }

}
