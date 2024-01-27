using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MovingObjects : MonoBehaviour
{
    public static MovingObjects Instance { get; private set; }
    public Item newItem;
    public ItemSlot Slot;
    public Image Img;
    [SerializeField] Sprite defaultSprite;
    public int ItemAmount;
    ItemInformation info;


    private void Start()
    {
        Img = GetComponentInChildren<Image>();
    }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        Instance = this;
    }
    public void SetItemSlot(ItemSlot itemSlot)
    {
        Slot = itemSlot;
    }
    public ItemSlot GetItemSlot()
    {
        return Slot;
    }

    public void Properties(ItemInformation information)
    {
        info = information;
        Img.sprite = info.sprite;
        newItem = info.item;
        ItemAmount = info.amount;
    }
    public Sprite RetrieveSprite()
    {
        return Img.sprite;
    }
    public void ClearDataCache()
    {
        Img.sprite = defaultSprite;
        newItem = null;
        ItemAmount = 0;
    }
    public void ReturnToDefault()
    {
        if (Slot)
        {
            Slot.image.sprite = Img.sprite;
            Slot.CurrentItem = newItem;
            Slot.GetComponentInChildren<TMP_Text>().text = ItemAmount.ToString();
        }
    }
    public void DecreaseAmount(int amount)
    {
        ItemAmount -= amount;
    }
}
