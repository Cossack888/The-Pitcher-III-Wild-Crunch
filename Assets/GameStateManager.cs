using Ink.Parsed;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    DialogueManager manager;
    public List<ItemType> items;
    private void Start()
    {
        items = new List<ItemType>();
        manager = FindObjectOfType<DialogueManager>();
        ResetInvertory();
        StartCoroutine(Wait(2));
    }

    public void ResetInvertory()
    {
        /* foreach (var item in GameObject.FindGameObjectsWithTag("Slot"))
         {
             Destroy(item.gameObject);
         }*/
        if (items.Count > 0)
        {
            foreach (ItemType itemType in items)
            {
                if (!items.Contains(itemType))
                    InventoryManager.Instance.InstantiateItemInSlot(itemType);
            }

            manager.CheckGlobalVariableStatus();

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

    public void AddItemToList(ItemType type)
    {
        items.Add(type);
    }
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    private IEnumerator Wait(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        manager = FindObjectOfType<DialogueManager>();
        ResetInvertory();
        DestroyAllObjects();
        DestroyAllConvos();
        StartCoroutine(Wait(waitTime));
    }
}
