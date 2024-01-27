using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public GameObject inventorySlotPrefab;
    public static InventoryManager Instance { get; private set; }
    // Reference to the InventoryItem prefab
    public GameObject inventoryItemPrefab;

    public Transform inventoryLayout;
    public Sprite sprite;
    public string nameOfItem;


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        Instance = this;
    }
    public void InstantiateItemInSlot(Sprite sprite, string itemName, ItemType item)
    {
        // Instantiate a new InventorySlot
        GameObject newSlot = Instantiate(inventorySlotPrefab, Vector3.zero, Quaternion.identity);

        // Optionally, you can set the instantiated slot as a child of a specific parent in your inventory layout
        newSlot.transform.SetParent(inventoryLayout, false);

        // Instantiate a new InventoryItem
        GameObject newItem = Instantiate(inventoryItemPrefab, Vector3.zero, Quaternion.identity);

        // Set the sprite and name on the InventoryItem
        InventoryItem itemScript = newItem.GetComponent<InventoryItem>();
        if (itemScript != null)
        {
            itemScript.SetItemInfo(sprite, itemName, item);
        }

        // Set the instantiated item as a child of the inventory slot
        newItem.transform.SetParent(newSlot.transform, false);
    }
    public void SwapSlots(InventorySlot slot1, InventorySlot slot2)
    {
        Vector2 tempPosition = slot1.transform.position;
        slot1.transform.position = slot2.transform.position;
        slot2.transform.position = tempPosition;
    }

    public void ResetSlotPosition(InventorySlot slot)
    {
        // slot.ResetPosition();
    }



}