using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    [SerializeField]
    public int ckCL { get; private set; }
    public int NumberOfChick { get; private set; }

    public UnityEvent<PlayerInventory> OnChickCollected;
    public void ChickCollected()
    {
        NumberOfChick++;
        OnChickCollected.Invoke(this);
    }

    [SerializeField] GameObject[] doorCL;
    [SerializeField] GameObject[] DestroyDoor;

    int kN = -1;

    public UnityEvent<PlayerInventory> OnKeyCollected;

    private void Start()
    {
        foreach (var D in doorCL)
        {
            D.SetActive(false);
        }

        foreach (var D in DestroyDoor)
        {
            D.SetActive(false);
        }

        DestroyDoor[0].SetActive(true);

    }
    public void ckCol()
    {
        ckCL++;
        OnKeyCollected.Invoke(this);
    }

    public void KeyCL()
    {
        kN++;
        doorCL[kN].SetActive(true);
    }

}
