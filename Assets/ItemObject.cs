using UnityEngine;

public class ItemObject : MonoBehaviour
{
    public InventoryItemData referenceItem;

    public void OnHandlePickupItem()
    {
        InventorySystem.current.Add(referenceItem);
        Destroy(gameObject);
        Debug.Log(InventorySystem.current.inventory);
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

            if (Input.GetKeyDown(KeyCode.E))
            {
                OnHandlePickupItem();
            }
        }
    }
}