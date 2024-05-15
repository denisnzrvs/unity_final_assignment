using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flowerPickup : MonoBehaviour
{

    public FlowerData flowerData;

    private void OnTriggerEnter(Collider other)
    {

        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null && flowerData != null && playerInventory.sugarPoints < 100)
        {
            playerInventory.AddSugar(flowerData.sugarPoints);
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("Enough sugar has been collected.");
        }
    }
}
