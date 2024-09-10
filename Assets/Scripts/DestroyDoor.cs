using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyDoor : MonoBehaviour
{
    [SerializeField] GameObject D;
    [SerializeField] GameObject M;
    [SerializeField] Timer timer;
    void OnTriggerEnter(Collider obj)
    {
        D.SetActive(false);
        M.SetActive(true);

    
    }

}
