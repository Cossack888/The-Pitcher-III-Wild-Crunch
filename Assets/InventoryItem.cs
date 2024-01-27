using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventoryItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private Vector2 originalPosition;
    Canvas canvas;
    public Sprite sprite;
    public TMP_Text text;
    public Image img;


    private void Start()
    {
        img = GetComponent<Image>();
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        originalPosition = rectTransform.anchoredPosition;
        canvas = GetComponentInParent<Canvas>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = false; // Disable raycasts for the item while dragging
        canvas.sortingOrder = 1;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / GetComponentInParent<Canvas>().scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true; // Enable raycasts for the item after dragging ends
        canvas.sortingOrder = 0;
        // Check if the object is dropped onto another InventorySlot
        var results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData, results);

        bool droppedOnSlot = false;

        // Find the first InventorySlot in the results
        foreach (var result in results)
        {
            var inventorySlot = result.gameObject.GetComponent<InventorySlot>();
            if (inventorySlot != null)
            {
                droppedOnSlot = true;
                // Optionally, you can add logic here to check if the drop is valid
                // For example, check if the slot already contains an item, or implement stacking rules.

                // Set the parent of the dragged item to the inventory slot
                rectTransform.SetParent(inventorySlot.transform, false);
                break;
            }
        }

        // If the object is not dropped onto an InventorySlot or the drop is not valid, return it to the original position
        if (!droppedOnSlot)
        {
            rectTransform.anchoredPosition = originalPosition;
        }
    }
    public void SetItemInfo(Sprite sprite, string itemName)
    {
        this.sprite = sprite;
        text.text = itemName;
        img.sprite = sprite;
    }
}