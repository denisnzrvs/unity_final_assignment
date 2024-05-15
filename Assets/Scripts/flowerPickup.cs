using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flowerPickup : MonoBehaviour
{
    public FlowerData flowerData;
    private PlayerInventory playerInventory;
    private fadingCoroutine fadingScript;

    void Start()
    {
        fadingScript = FindObjectOfType<fadingCoroutine>(); // Find the fadingCoroutine instance in the scene
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null && flowerData != null)
        {
            playerInventory.AddSugar(flowerData.sugarPoints);

            // Check if player's inventory has 10 or more sugar points
            if (playerInventory.sugarPoints >= 100)
            {
                // Call FadeOut method if conditions are met
                if (fadingScript != null)
                {
                    fadingScript.FadeOut();
                }
                else
                {
                    Debug.LogWarning("fadingCoroutine instance not found.");
                }
            }

            Destroy(gameObject);
        }
    }
}
