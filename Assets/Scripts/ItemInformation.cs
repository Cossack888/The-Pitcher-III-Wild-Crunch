using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInformation : MonoBehaviour
{

    public int amount;
    public float value;
    public Sprite sprite;
    public Sprite defaultSprite;
    public Item item;

    private void Start()
    {
        UpdateInformation();
    }
    private void Update()
    {
        //UpdateInformation();
    }
    public void ClearInformation()
    {
        amount = 0;
        value = 0;
        sprite = defaultSprite;
        item = null;
    }
    public void UpdateInformation()
    {
        if (gameObject.GetComponent<ItemSlot>().CurrentItem)
        {
            sprite = gameObject.GetComponent<ItemSlot>().CurrentItem.sprite;
            item = gameObject.GetComponent<ItemSlot>().CurrentItem;
        }
        else
        {
            ClearInformation();
        }
    }

}
