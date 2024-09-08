using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int keyCL { get; private set; }

    public UnityEvent<PlayerInventory> OnKeyCollected;

    public void KeyCol()
    {
        keyCL++;
        OnKeyCollected.Invoke(this);
    }
}
