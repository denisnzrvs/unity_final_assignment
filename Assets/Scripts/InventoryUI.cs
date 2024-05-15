using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI sugarText;
    void Start()
    {
        sugarText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateSugarText(PlayerInventory playerInventory)
    {
        sugarText.text = playerInventory.sugarPoints.ToString() + "/100";
    }
}