using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour, IDropHandler
{
    public Item CurrentItem;
    public Image image;
    public TMP_Text itemNameText;

    private void Start()
    {
        image = GetComponent<Image>();
    }

    public void OnDrop(PointerEventData eventData)
    {
        InventoryItem draggedItem = eventData.pointerDrag.GetComponent<InventoryItem>();

        if (draggedItem != null)
        {

            // Optionally, you can add logic here to check if the drop is valid
            // For example, check if the slot already contains an item, or implement stacking rules.
            Debug.Log(draggedItem.name);
            // Set the parent of the dragged item to this slot
            draggedItem.transform.SetParent(transform, false);
            draggedItem.transform.position = transform.position;
        }

    }
    public void SetItemInfo(Sprite sprite, string itemName)
    {
        image.sprite = sprite;
        itemNameText.text = itemName;
    }
}