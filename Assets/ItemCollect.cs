using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEditor.Progress;

public class ItemCollect : MonoBehaviour
{
    public ItemType type;
    GameStateManager manager;
    Outline outline;
    bool inRange;
    private void Start()
    {
        manager = GameObject.FindObjectOfType<GameStateManager>();
        outline = GetComponent<Outline>();



    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            inRange = true;
            outline.OutlineColor = Color.green;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            inRange = false;
            outline.OutlineColor = Color.white;
        }
    }

    private void Update()
    {
        if (inRange)
        {
            if (Input.GetMouseButtonDown(0))
            {
                manager.AddItemToList(type);
                this.enabled = false;
                InventoryManager.Instance.InstantiateItemInSlot(type);
            }

        }

    }
}
