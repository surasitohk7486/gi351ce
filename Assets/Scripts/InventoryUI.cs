using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI chickText;
    void Start()
    {
        chickText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateChickText(PlayerInventory playerInventory)
    {
        chickText.text = playerInventory.NumberOfChick.ToString();
    }
}
