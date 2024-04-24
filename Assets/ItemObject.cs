using UnityEngine;

public class ItemObject : MonoBehaviour
{
    public InventoryItemData referenceItem;
    private bool isEPressed = false;

    public void OnHandlePickupItem(GameObject obj)
    {
        InventorySystem.current.Add(referenceItem);
        Destroy(obj);

    }

    void Update()
    {
        Debug.Log(referenceItem.displayName);
        Vector3 cameraPosition = Camera.main.transform.position;
        Vector3 cameraDirection = Camera.main.transform.forward;

        RaycastHit hit;

        if (Physics.Raycast(cameraPosition, cameraDirection, out hit))
        {
            GameObject objectLookedAt = hit.collider.gameObject;

            Debug.Log("Player is looking at: " + objectLookedAt.name);

            // Check if the E key is pressed and if it's not already being processed
            if (Input.GetKeyDown(KeyCode.E) && !isEPressed)
            {
                Debug.Log("Item picked up (E is pressed)");
                // Set the flag to indicate that the E key is being processed
                isEPressed = true;
                // Call the item pickup method
                OnHandlePickupItem(objectLookedAt);
            }
        }
        else
        {
            // Reset the flag if the player is not looking at any object
            isEPressed = false;
        }
    }
}