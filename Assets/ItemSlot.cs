using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    public Item CurrentItem;
    public Sprite sprite;
    public Image image;

    private void Start()
    {
        image = GetComponent<Image>();
    }
    public void OnDrag(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (CurrentItem != null)
        {
            PickUpItem();
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
    void PickUpItem()
    {
        MovingObjects.Instance.SetItemSlot(this);

    }

}
