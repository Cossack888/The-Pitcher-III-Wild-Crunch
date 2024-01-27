using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    public Item CurrentItem;
    public Sprite sprite;
    public Image image;

    private Canvas canvas; // Reference to the canvas component
    private Vector2 originalPosition;

    private void Start()
    {
        image = GetComponent<Image>();
        canvas = GetComponentInParent<Canvas>();

    }

    public void OnDrag(PointerEventData eventData)
    {
        // Ensure that the dragged item is rendered on top of other UI elements
        canvas.sortingOrder = 1;
        if (transform.childCount > 0)
            transform.GetChild(0).transform.position = eventData.position;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (CurrentItem != null)
        {
            originalPosition = transform.position;
            PickUpItem();
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        // Reset the canvas sorting order when the item is dropped
        canvas.sortingOrder = 0;
        DropItem(eventData);
    }

    void PickUpItem()
    {
        MovingObjects.Instance.SetItemSlot(this);
        MovingObjects.Instance.Properties(GetComponent<ItemInformation>());
        image.sprite = null;
    }

    void DropItem(PointerEventData eventData)
    {
        // Check if the object is over another ItemSlot
        var results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData, results);

        // Find the first ItemSlot in the results
        foreach (var result in results)
        {
            var itemSlot = result.gameObject.GetComponent<ItemSlot>();
            if (itemSlot != null)
            {
                // Make the dragged object a child of the ItemSlot
                //MovingObjects.Instance.ResetItemSlot();
                transform.SetParent(itemSlot.transform);

                // Optionally, you can add some logic when the object becomes a child of the ItemSlot
                return; // Exit the method to prevent returning to the original position
            }
        }

        // If the object is not dropped onto an ItemSlot, return it to the original position
        transform.position = originalPosition;
    }
}
