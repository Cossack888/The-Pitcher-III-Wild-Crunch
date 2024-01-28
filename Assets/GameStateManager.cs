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

    public void DestroyAllObjects()
    {
        foreach (var item in GameObject.FindObjectsOfType<ItemCollect>())
        {
            if (items.Contains(item.type))
            {
                Destroy(item.gameObject);
            }
        }
    }

    public void DestroyAllConvos()
    {
        foreach (var item in GameObject.FindObjectsOfType<ConvoTrigger>())
        {
            if (items.Contains(item.itemType) || items.Contains(item.itemType1))
            {
                item.enabled = false;
            }
        }
    }



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            ResetInvertory();
            DestroyAllObjects();
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
