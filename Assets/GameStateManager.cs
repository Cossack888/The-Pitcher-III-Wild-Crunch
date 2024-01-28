using Ink.Parsed;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public List<ItemType> items;
    private void Start()
    {
        ResetInvertory();

    }

    public void ResetInvertory()
    {
        foreach (var item in GameObject.FindGameObjectsWithTag("Slot"))
        {
            Destroy(item.gameObject);
        }
        foreach (ItemType itemType in items)
        {
            InventoryManager.Instance.InstantiateItemInSlot(itemType);
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            ResetInvertory();
        }
    }

    public void AddItemToList(ItemType type)
    {
        items.Add(type);
    }
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

}
