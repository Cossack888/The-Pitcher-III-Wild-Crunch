using Ink.Parsed;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public GameObject inventorySlotPrefab;
    public static InventoryManager Instance { get; private set; }
    // Reference to the InventoryItem prefab
    public GameObject inventoryItemPrefab;

    public Transform inventoryLayout;
    public Transform inventoryLayout1;
    public Transform inventoryLayout2;
    public Transform inventoryLayout3;
    public Sprite sprite;
    public string nameOfItem;
    public List<InventoryItem> slots;
    public ItemType[] itemTypes;
    public int type = 0;
    public int invGroup;
    public GameObject[] invGroups;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        Instance = this;
    }


    public void nextInvGroup()
    {
        if (invGroup < invGroups.Length)
        {
            invGroup++;
            foreach (GameObject inv in invGroups)
            {
                inv.SetActive(false);
            }
            invGroups[invGroup].SetActive(true);
        }
    }
    public void previousInvGroup()
    {
        if (invGroup > 0)
        {
            invGroup--;
            foreach (GameObject inv in invGroups)
            {
                inv.SetActive(false);
            }
            invGroups[invGroup].SetActive(true);
        }
    }

    public void InstantiateItemInSlot(ItemType item)
    {



        // Instantiate a new InventorySlot
        GameObject newSlot = Instantiate(inventorySlotPrefab, Vector3.zero, Quaternion.identity);

        // Optionally, you can set the instantiated slot as a child of a specific parent in your inventory layout
        if (slots.Count >= 0 && slots.Count < 14)
        {
            newSlot.transform.SetParent(inventoryLayout, false);
        }
        if (slots.Count >= 15 && slots.Count < 30)
        {
            newSlot.transform.SetParent(inventoryLayout1, false);
        }
        if (slots.Count >= 31 && slots.Count < 45)
        {
            newSlot.transform.SetParent(inventoryLayout2, false);
        }
        if (slots.Count >= 46)
        {
            newSlot.transform.SetParent(inventoryLayout3, false);
        }

        // Instantiate a new InventoryItem
        GameObject newItem = Instantiate(inventoryItemPrefab, Vector3.zero, Quaternion.identity);

        // Set the sprite and name on the InventoryItem
        InventoryItem itemScript = newItem.GetComponent<InventoryItem>();
        if (itemScript != null)
        {
            itemScript.SetItemInfo(item);
            slots.Add(itemScript);
        }


        // Set the instantiated item as a child of the inventory slot
        newItem.transform.SetParent(newSlot.transform, false);


    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (type < itemTypes.Length - 1)
            {
                type++;
                InstantiateItemInSlot(itemTypes[type]);
            }

        }
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